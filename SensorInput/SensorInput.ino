/* 
 SensorInput
 By: Katelyn Currie
 Cariboo Pulp and Paper
 Date: June 2, 2015
 Modifications to original weather shield code for breather humidity testing experiment. 
 
 Removed all use of wind speeds, wind direction, rain and GPS sensors as these are not used in the experiment.
 
 Settings: Must use USBtinyISP and correct COM port
 */

#include <Wire.h> //I2C needed for sensors
#include "MPL3115A2.h" //Pressure sensor
#include "HTU21D.h" //Humidity sensor

MPL3115A2 myPressure; //Create an instance of the pressure sensor
HTU21D myHumidity; //Create an instance of the humidity sensor

//Hardware pin definitions
//-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
// digital I/O pins
const byte STAT1 = 7;
const byte STAT2 = 8;

// analog I/O pins
const byte REFERENCE_3V3 = A3;
const byte BATT = A2;
//-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

//Global Variables
//-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
long lastSecond; //The millis counter to see when a second rolls by
int seconds = 0;
int minutes = 0;
int hours = 0;
int days = 0;

double conversion = 1;
double humidity = 0; // [%]
double temp_p = 0; // [temperature from humidity sensor - Fahrenheit]
double temp_h = 0;  //[temperature from humidity sensor - Celsius]
//double baromin = 30.03;// [barom in] - It's hard to calculate baromin locally, do this in the agent
double pressure = 0;
double dewpt; // [dewpoint C] 

double batt_lvl = 11.8; //[analog value from 0 to 1023]

volatile boolean runExperiment = true;
String inputString = "";          //For incoming data
boolean stringComplete = false;   //shows if incoming data is complete

//-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

void setup()
{
  Serial.begin(9600);
  Serial.println("Weather Shield Example");
  inputString.reserve(200);  //reserve 200 bytes for the input string

  pinMode(STAT1, OUTPUT); //Status LED Blue
  pinMode(STAT2, OUTPUT); //Status LED Green
  
  pinMode(REFERENCE_3V3, INPUT);

  //Configure the pressure sensor
  myPressure.begin(); // Get sensor online
  myPressure.setModeBarometer(); // Measure pressure in Pascals from 20 to 110 kPa
  myPressure.setOversampleRate(7); // Set Oversample to the recommended 128
  myPressure.enableEventFlags(); // Enable all three pressure and temp event flags 

  //Configure the humidity sensor
  myHumidity.begin();

  seconds = 0;
  lastSecond = millis();

  // turn on interrupts
  interrupts();

  Serial.println("Weather Shield online!");
}

///////////////////////////////////////////////////////////////////////

void loop()
{
  //Take commands/info from Serial
  if(stringComplete)
  {
    if(inputString == "start")
    {
      Serial.println("Experiment starting!");
      runExperiment = true;
    }
    else
      Serial.println("I got it");
    inputString = "";
    stringComplete = false;
  }
  
  //Check to see if experiment should be running or reset
  if(runExperiment == true)
  {
    //Keep track of which minute it is
    if(millis() - lastSecond >= 1000)
    {
      digitalWrite(STAT1, HIGH); //Blink stat LED
      
      lastSecond += 1000;  
      if(++seconds > 59)
      {
        seconds = 0;
        if(++minutes > 59) 
        {  
          minutes = 0;
          if(++hours > 23)
          {
            hours = 0;
            days++;
          }
        }
      }
  
      //printWeather(); //Report all readings every second
      writeData();      //Sends data over serial every second
      digitalWrite(STAT1, LOW); //Turn off stat LED
    }
  }
  //If experiment not running, track seconds
  else if(millis() - lastSecond >= 1000)
  {
    lastSecond += 1000;
  }
  delayMicroseconds(100000);
}

//Checks for incoming RX data. Runs between loops
void serialEvent()
{
  while (Serial.available())
  {
    char inChar = (char)Serial.read();  //get the new byte
    Serial.print(inChar);  //display user's input to them
    if(inChar == 13)    //if incoming character is a carriage return (enter) we reached the input end
    {
      stringComplete = true;
      Serial.print('\n');
    }
    else
      inputString += inChar;  //add new bite to string
  }
}

//////////////////////////////////////////////////////////////

//Calculates each of the variables that wunderground is expecting
void calcWeather()
{
  //Calc humidity and temp
  humidity = myHumidity.readHumidity();
  temp_h = myHumidity.readTemperature();  

  //Calc pressure and temp
  pressure = myPressure.readPressure();
  temp_p = (myPressure.readTempF() - 32)*5/9;

  //Calc dewptf
  dewpt = dewPoint(temp_h, humidity);

  //Calc battery level
  batt_lvl = get_battery_level();
}

// dewPoint function NOAA: http://playground.arduino.cc/main/DHT11Lib
// reference (1) : http://wahiduddin.net/calc/density_algorithms.htm
// reference (2) : http://www.colorado.edu/geography/weather_station/Geog_site/about.htm
double dewPoint(double celsius, double humidity)
{
      	// (1) Saturation Vapor Pressure = ESGG(T)
      	double RATIO = 373.15 / (273.15 + celsius);
      	double RHS = -7.90298 * (RATIO - 1);
      	RHS += 5.02808 * log10(RATIO);
      	RHS += -1.3816e-7 * (pow(10, (11.344 * (1 - 1/RATIO ))) - 1) ;
      	RHS += 8.1328e-3 * (pow(10, (-3.49149 * (RATIO - 1))) - 1) ;
      	RHS += log10(1013.246);
      
        // factor -3 is to adjust units - Vapor Pressure SVP * humidity
      	double VP = pow(10, RHS - 3) * humidity;
      
        // (2) DEWPOINT = F(Vapor Pressure)
      	double T = log(VP/0.61078);   // temp var
      	return (241.88 * T) / (17.558 - T);
}

// delta max = 0.6544 wrt dewPoint()
// 6.9 x faster than dewPoint()
// reference: http://en.wikipedia.org/wiki/Dew_point
double dewPointFast(double celsius, double humidity)
{
	double a = 17.271;
	double b = 237.7;
	double temp = (a * celsius) / (b + celsius) + log(humidity*0.01);
	double Td = (b * temp) / (a - temp);
	return Td;
}

//Returns the voltage of the raw pin based on the 3.3V rail
//This allows us to ignore what VCC might be (an Arduino plugged into USB has VCC of 4.5 to 5.2V)
//Battery level is connected to the RAW pin on Arduino and is fed through two 5% resistors:
//3.9K on the high side (R1), and 1K on the low side (R2)
double get_battery_level()
{
  double operatingVoltage = analogRead(REFERENCE_3V3);

  double rawVoltage = analogRead(BATT);
  
  operatingVoltage = 3.30 / operatingVoltage; //The reference voltage is 3.3V
  
  rawVoltage = operatingVoltage * rawVoltage; //Convert the 0 to 1023 int to actual voltage on BATT pin
  
  rawVoltage *= 4.90; //(3.9k+1k)/1k - multiple BATT voltage by the voltage divider to get actual system voltage
  
  return(rawVoltage);
  
  /*
    //*************** READING BATTERY VOLTAGE *********************
  //turn MOSFET ON and read voltage, should give a valid reading
  pinMode(A3, OUTPUT);
  digitalWrite(A3, LOW);
  Serial.print("  BATT: ");
  Serial.println(analogRead(A7));
  pinMode(A3, INPUT); //put A3 in HI-Z mode (to allow mosfet gate pullup to turn it OFF)
  //*************** READING BATTERY VOLTAGE *********************
  */
}

//Print the time in HH:MM:SS to the serial port
void serialPrintTime()
{
  if(days>0)
  {
    Serial.print(days);
    Serial.print(":");
  }
  
  if(hours<10)  
    Serial.print("0");
  Serial.print(hours);
  Serial.print(":");
  
  if(minutes<10)
    Serial.print("0");
  Serial.print(minutes);
  Serial.print(":");
  
  if(seconds<10)
    Serial.print("0");
  Serial.println(seconds);    //newline printed after seconds
}

//Prints the various variables directly to the port
//I don't like the way this function is written but Arduino doesn't support doubles under sprintf
void printWeather()
{
  calcWeather(); //Go calc all the various sensors

  Serial.println();
  Serial.print(", Time=");
  serialPrintTime();
  Serial.print("humidity=");
  Serial.print(humidity, 1);
  Serial.print(", temp humidity=");
  Serial.print(temp_h, 1);
  Serial.print(", temp pressure=");
  Serial.print(temp_p, 1);
  Serial.print(", pressure=");
  Serial.print(pressure, 2);
  Serial.print(", dewpoint=");
  Serial.print(dewpt, 1);
  Serial.print(", batt_lvl=");
  Serial.print(batt_lvl, 2);
  Serial.print(",");
  Serial.println("#");
}

//Writes a data packet to the serial port
void writeData()
{
  calcWeather();
  
  Serial.write(255);  //send start byte
  Serial.write(10);  //placeholder for time
  Serial.write((int)(humidity*conversion));
  Serial.write((int)(temp_h*conversion));
  Serial.write((int)(temp_p*conversion));
  Serial.write((int)(pressure*conversion));
  Serial.write((int)(dewpt*conversion));
  Serial.write((int)(batt_lvl*conversion));
  Serial.write((int)conversion);
}
