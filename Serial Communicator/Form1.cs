using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Media;
//using PISDK;
//using PISDKCommon;
using Excel=Microsoft.Office.Interop.Excel;
using MetroFramework.Forms;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;



namespace Serial_Comm
{

    public enum MetroColorStyle
    {
        Default,
        Black,
        White,
        Silver,
        Blue,
        Green,
        Lime,
        Teal,
        Orange,
        Brown,
        Pink,
        Magenta,
        Purple,
        Red,
        Yellow
    }

    public partial class MainForm : MetroForm
    {
        //Excel variables
        private static Excel.Workbook MyBook = null;
        private static Excel.Application MyApp = null;
        private static Excel.Worksheet MySheet = null;
        object misValue = System.Reflection.Missing.Value;
        string filename;
        int lastRow1 = 1;
        int lastRow2 = 1;
        int extraColumns = 1;       //How many additional data columns there are after data from sensors

        //Communication variables
        ConcurrentQueue<int> serialQueue1 = new ConcurrentQueue<int>();
        ConcurrentQueue<int> serialQueue2 = new ConcurrentQueue<int>();
        //private string[] commandList = { "Error", "1", "2", "3", "4", "5", "6", "7", "8", "9", "Encoder" };
        Dictionary<string, int> currentData = new Dictionary<string,int>{
            {"Time", 0},
            {"Humidity", 0},
            {"Temp_h", 0}, 
            {"Temp_p", 0}, 
            {"Pressure", 0}, 
            {"DewPT", 0}, 
            {"Battery", 11}, 
            {"Conversion",0},
        };
        int packetCount1 = 0;
        int packetCount2 = 0;
        int startByte = 255;
        int errorCount = 0;
        public int numberOfDataPoints1 = 0;
        public int numberOfDataPoints2 = 0;    
        
        /*
        double humidity = 0; // [%]
        double temp_p = 0; // [temperature from humidity sensor - Fahrenheit]
        double temp_h = 0;  //[temperature from humidity sensor - Celsius]
        double pressure = 0;
        double dewpt; // [dewpoint C] 
        double batt_lvl = 11.8; //[analog value from 0 to 1023]
     * */

        /*
        int commandByte, dataByte1, dataByte2, exitByte;
        double currentRPM, currentFrequency;
        int currentDirection;
        
        
        //Variables for recording position
        const int numberOfPointsToRecord = 2000;
        string[] positionData = new string[numberOfPointsToRecord];
        int positionDataIterator = 0;
        int previousPosition = 0;
        bool recordPosition = false;    //true when we want to record the position data
        */


        
        /////////////////////////////////
        public MainForm()
        {
            InitializeComponent();
            //this.StyleManager = this.msmMain; msmMain is the name of stylemanager;


            DataTable _table = new DataTable();
            _table.ReadXml(@"C:\Users\KCURRIE\Desktop\Breather-Experiment\Winforms-modernui-master\winforms-modernui-master\MetroFramework.Demo\Data\Books.xml");
            //metroGrid1.DataSource = _table;

            //metroGrid1.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
          /*  metroGrid1.AllowUserToAddRows = false;

            private Components.MetroStyleManager metroStyleManager;
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit(); */
        }

        private void ComPortUpdate()
        {
            cmbComPort1.Items.Clear();
            cmbComPort2.Items.Clear();
            string[] comPortArray = System.IO.Ports.SerialPort.GetPortNames().ToArray();
            Array.Reverse(comPortArray);
            cmbComPort1.Items.AddRange(comPortArray);

            if (cmbComPort1.Items.Count != 0)
                cmbComPort1.SelectedIndex = 0;
            else
                cmbComPort1.Text = "No Ports Found!";
                        
            cmbComPort2.Items.AddRange(comPortArray);
            if (cmbComPort2.Items.Count != 0)
                cmbComPort2.SelectedIndex = 0;
            else
                cmbComPort2.Text = "No Ports Found!";
            /*
            //Check if combo port used by other arduino
            if( btnConnect1.Text =="Disconnect")
            {
                cmbComPort2.Items.Remove(cmbComPort1.SelectedItem.ToString());
            }
            if (btnConnect2.Text == "Disconnect")
            {
                cmbComPort1.Items.Remove(cmbComPort2.SelectedItem.ToString());
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblIncomingDataRate1.Visible = false;
            lblIncomingDataRate2.Visible = false;
            chkShowResponse1.Checked = true;
            chkShowResponse2.Checked = true;
            ComPortUpdate();

            chartHumidity.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chartTemp.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chartPressure.ChartAreas[0].AxisY.IsStartedFromZero = false;
        }

        private void cmbComPort1_DropDown(object sender, EventArgs e)
        {
            //ComPortUpdate();
            cmbComPort1.Items.Clear();
            
            string[] comPortArray = System.IO.Ports.SerialPort.GetPortNames().ToArray();
            Array.Reverse(comPortArray);
            cmbComPort1.Items.AddRange(comPortArray);

            if (cmbComPort1.Items.Count != 0)
                cmbComPort1.SelectedIndex = 0;
            else
                cmbComPort1.Text = "No Ports Found!";
            //Check if combo port used by other arduino
            
            if (btnConnect2.Text == "Disconnect")
            {
                cmbComPort1.Items.Remove(cmbComPort2.SelectedItem.ToString());
            }
            
        }

        private void cmbComPort2_DropDown(object sender, EventArgs e)
        {
            //ComPortUpdate();
            
            cmbComPort2.Items.Clear();
            string[] comPortArray = System.IO.Ports.SerialPort.GetPortNames().ToArray();
            Array.Reverse(comPortArray);
            

            cmbComPort2.Items.AddRange(comPortArray);
            if (cmbComPort2.Items.Count != 0)
                cmbComPort2.SelectedIndex = 0;
            else
                cmbComPort2.Text = "No Ports Found!";

            //Check if combo port used by other arduino
            if (btnConnect1.Text == "Disconnect")
            {
                cmbComPort2.Items.Remove(cmbComPort1.SelectedItem.ToString());
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect1.Text == "Connect")
            {
                if (cmbComPort1.Items.Count > 0)
                {
                    try
                    {
                        serialPort1.BaudRate = Convert.ToInt16(txtBaudRate1.Text);
                        serialPort1.PortName = cmbComPort1.SelectedItem.ToString();
                        serialPort1.Open();
                        btnConnect1.Text = "Disconnect";
                        timer1.Enabled = true;
                        lblIncomingDataRate1.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    btnConnect1.Text = "Connect";
                    timer1.Enabled = false;
                    lblIncomingDataRate1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnConnect2_Click(object sender, EventArgs e)
        {
            if (btnConnect2.Text == "Connect")
            {
                if (cmbComPort2.Items.Count > 0)
                {
                    try
                    {
                        serialPort2.BaudRate = Convert.ToInt16(txtBaudRate2.Text);
                        serialPort2.PortName = cmbComPort2.SelectedItem.ToString();
                        serialPort2.Open();
                        btnConnect2.Text = "Disconnect";
                        timer1.Enabled = true;
                        lblIncomingDataRate2.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                try
                {
                    serialPort2.Close();
                    btnConnect2.Text = "Connect";
                    timer1.Enabled = false;
                    lblIncomingDataRate2.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void btnStartExperiment_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("start\r");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            try
            {
                if (serialPort2.IsOpen)
                {
                    serialPort2.Write("start\r");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            tmrData.Enabled = true;         //Start reading data
            startExcel();
            
            //Clear old data from serial queue so that experiment starts at this time
            int data;
            while (serialQueue1.TryDequeue(out data)) ; //keep dequeueing, do nothing with data
            while (serialQueue2.TryDequeue(out data)) ; //keep dequeueing, do nothing with data

        }

        private void startExcel()
        {
            //Initialize Excel file for storage
            MyApp = new Excel.Application();
            MyApp.Visible = false;

            try
            {          
                MyBook = MyApp.Workbooks.Add(misValue);
                MySheet = (Excel.Worksheet)MyBook.Worksheets.get_Item(1);
            }
                catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            //Format excel sheet
            MySheet.Cells[1, 1] = "Internal";
            MySheet.Cells[1, currentData.Count()+1 + extraColumns] = "External";
            MySheet.Cells[2, 1] = "Notes:";
            
            int i = 1;
            foreach(var entry in currentData)
            {
                string k = entry.Key;
                MySheet.Cells[3, i] = k;
                i++;
            }
            MySheet.Cells[3, i] = "Error";
            i++;
            foreach (var entry in currentData)
            {
                string k = entry.Key;
                MySheet.Cells[3, i] = k;
                i++;
            }
            MySheet.Cells[3, i] = "Error";
            i++;

            //Setup row indexes
            lastRow1 = MySheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
            lastRow2 = MySheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (serialPort1.IsOpen && serialPort1.BytesToRead != 0)
            {
                int currentByte = serialPort1.ReadByte();
                numberOfDataPoints1++;
                if (chkShowResponse1.Checked)
                    this.BeginInvoke(new EventHandler(delegate
                    {
                        txtRawSerial1.AppendText(currentByte.ToString() + ", ");
                    }));
                serialQueue1.Enqueue(currentByte);   //Add byte to the queue of data
            }
        }

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort2.IsOpen && serialPort2.BytesToRead != 0)
            {
                int currentByte = serialPort2.ReadByte();
                numberOfDataPoints2++;
                if (chkShowResponse2.Checked)
                    this.BeginInvoke(new EventHandler(delegate
                    {
                        txtRawSerial2.AppendText(currentByte.ToString() + ", ");
                    }));
                serialQueue2.Enqueue(currentByte);   //Add byte to the queue of data
            }

        }

        private void tmrData_Tick(object sender, EventArgs e)
        {
            int data;

             //output number of bytes to read from buffer and number of bytes in queue
            if (serialPort1.IsOpen == true)
                txtBytesToRead.Text = serialPort1.BytesToRead.ToString();
            txtBytesInQueue.Text = serialQueue1.Count.ToString();

            while (serialQueue1.Count > 2)
            {
                data = 0;
                errorCount = 0;
                serialQueue1.TryDequeue(out data);
                if (data == startByte)
                {
                    packetCount1++;
                    txtPackets.Text = packetCount1.ToString();

                    //Dequeue data packet into current data dictionary
                    //and add data to excel sheet
                    lastRow1 += 1;
                    int j = 1;
                    List<string> keys = new List<string>(currentData.Keys);
                    foreach (var key in keys)
                    {
                        serialQueue1.TryDequeue(out data);      //Remove data from queue
                        if (data != 0)                          //Filter data: if =0, reuse last value for that key
                        {
                            currentData[key] = data;            //Put data in its respective key
                        }
                        else
                        {
                           errorCount++;              //Count how many errors are in this packet
                        }
                        MySheet.Cells[lastRow1, j] = currentData[key];   //Put data in excel sheet
                        j++;    //Update current row in excel sheet
                    }
                    //Remove exit byte
                    serialQueue1.TryDequeue(out data);
                    //Save error count
                    MySheet.Cells[lastRow1, j] = errorCount;
                    //Fix time
                    MySheet.Cells[lastRow1,1] = DateTime.Now;
                    


                    //Plot data on charts
                    plotData(0);    //Plot data in series 0, internal

                    //Display data text
                    txtHumidityInternal.Text = currentData["Humidity"].ToString();
                    txtTempInternal.Text = currentData["Temp_h"].ToString();
                    txtPressureInternal.Text = currentData["Pressure"].ToString();

                    
                     chartPressure.ChartAreas[0].RecalculateAxesScale();
                     
                }
            }
            
            while (serialQueue2.Count > 2)
            {  
                serialQueue2.TryDequeue(out data);
                if (data == startByte)
                {
                    packetCount2++;
                    txtPackets2.Text = packetCount2.ToString();

                    //Dequeue data packet into current data dictionary
                    //and add data to excel sheet
                    lastRow2 += 1;
                    int j = currentData.Count()+1 + extraColumns;    //start putting data in excel sheet after columns used by first sensor set
                    List<string> keys = new List<string>(currentData.Keys);
                    foreach (var key in keys)
                    {
                        serialQueue2.TryDequeue(out data);      //Remove data from queue                     
                        if (data != 0)                          //Filter data: if =0, reuse last value for that key
                        {
                            currentData[key] = data;            //Put data in its respective key
                        }
                        else
                        {
                            errorCount++;              //Count how many errors are in this packet
                        }
                        MySheet.Cells[lastRow2, j] = currentData[key];   //Put data in excel sheet
                        j++;    //Update current row in excel sheet
                    }
                    //Remove exit byte
                    serialQueue2.TryDequeue(out data);
                    //Save error count
                    MySheet.Cells[lastRow2, j] = errorCount;
                    //Fix time
                    MySheet.Cells[lastRow2, currentData.Count()+1 + extraColumns] = DateTime.Now;

                    
                    //Plot data on charts
                    plotData(1);    //Plot data in series 1, External

                    //Display data text
                    txtHumidityExternal.Text = currentData["Humidity"].ToString();
                    txtTempExternal.Text = currentData["Temp_h"].ToString();
                    txtPressureExternal.Text = currentData["Pressure"].ToString(); 
                }
             
            }
        
        }

        private void plotData(int series)
        {
            //If over the end data point count remove points from the beginning of graph
            if (chartHumidity.Series[series].Points.Count > 150)
            {
                for (int i = 0; i < 1; i++) { chartHumidity.Series[i].Points.RemoveAt(0); }
            }
            if (chartTemp.Series[series].Points.Count > 150)
            {
                for (int i = 0; i < 1; i++) { chartTemp.Series[i].Points.RemoveAt(0); }
            }
            if (chartPressure.Series[series].Points.Count > 150)
            {
                for (int i = 0; i < 1; i++) { chartPressure.Series[i].Points.RemoveAt(0); }
            }

            //graph and display values
            chartHumidity.Series[series].Points.AddY(currentData["Humidity"]);
            chartTemp.Series[series].Points.AddY(currentData["Temp_h"]);
            chartPressure.Series[series].Points.AddY(currentData["Pressure"]);

            chartHumidity.ResetAutoValues();
            chartTemp.ResetAutoValues();
            chartPressure.ResetAutoValues();

            /*
            chartPressure.ChartAreas[0].RecalculateAxesScale();

            // Enable scale breaks.
            chartPressure.ChartAreas[0].AxisY.ScaleBreakStyle.Enabled = true;

            // Show scale break if more than 25% of the chart is empty space.
            chartPressure.ChartAreas[0].AxisY.ScaleBreakStyle.CollapsibleSpaceThreshold = 25;

            // Set the line width of the scale break.
            chartPressure.ChartAreas[0].AxisY.ScaleBreakStyle.LineWidth = 2;

            // Set the color of the scale break.
            chartPressure.ChartAreas[0].AxisY.ScaleBreakStyle.LineColor = Color.Red;

            // If all data points are significantly far from zero, the chart will calculate the scale minimum value.
            chartPressure.ChartAreas[0].AxisY.ScaleBreakStyle.StartFromZero = StartFromZero.No;

            // Set the spacing gap between the lines of the scale break (as a percentage of the Y-axis).
            chartPressure.ChartAreas[0].AxisY.ScaleBreakStyle.Spacing = 2;

             * */
        }

        private void btnSaveData_Click_1(object sender, EventArgs e)
        {
            filename = txtFileName.Text;
            if (filename == "")
                MessageBox.Show("Enter a File Name");
            else
            {
                tmrData.Enabled = false;
             
                MySheet.Cells[2, 2] = txtNotes.Text;        //Add notes to sheet    
                MySheet.Range[MySheet.Cells[2, 2], MySheet.Cells[2, 9]].Merge();    //Merge cells used for note   
                MySheet.Columns.AutoFit();
               // MySheet.Rows.AutoFit();

                filename = dateTimeBox.Text + " - " + filename;
                MyBook.SaveAs("C:\\Users\\KCURRIE\\Desktop\\Test\\" + filename + ".xlsx");
                
                MyBook.Close(0);
                MyApp.Quit();
                releaseObject(MySheet);
                releaseObject(MyBook);
                releaseObject(MyApp);
                
                MessageBox.Show("Excel File Saved");
            }
        }


        private void btnSaveOnly_Click(object sender, EventArgs e)
        {
           
            filename = txtFileName.Text;
            if (filename == "")
                MessageBox.Show("Enter a File Name");
            else
            {
                filename = dateTimeBox.Text + " - " + filename;
                MyBook.SaveAs("C:\\Users\\KCURRIE\\Desktop\\Test\\" + filename + ".xlsx");
                MessageBox.Show("Excel File Saved");
            }
          
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void genericTextBoxEventHandler(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;
            short parseResult;
            if (Int16.TryParse((currentTextBox.Text), out parseResult))
            {
                if (parseResult > 255)
                    parseResult = 255;
                if (parseResult <= 0)
                    parseResult = 0;
                currentTextBox.Text = parseResult.ToString();
            }
            else
                currentTextBox.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblIncomingDataRate1.Text = "Incoming data rate = " + numberOfDataPoints1.ToString() + " bytes per second";
            numberOfDataPoints1 = 0;
            lblIncomingDataRate2.Text = "Incoming data rate = " + numberOfDataPoints2.ToString() + " bytes per second";
            numberOfDataPoints2 = 0;
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            txtRawSerial1.Clear();
        }

        private void btnClearHistory2_Click(object sender, EventArgs e)
        {
            txtRawSerial2.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
            if (serialPort2.IsOpen == true)
            {
                serialPort2.Close();
            }

            tmrData.Enabled = false;
            try
            { 
                MyBook.Close(0);
                MyApp.Quit();

                releaseObject(MySheet);
                releaseObject(MyBook);
                releaseObject(MyApp);
                MessageBox.Show("Excel closed without saving");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No excel sheet open");
            }
           
            

        }

        private void metroTileSwitch_Click(object sender, EventArgs e)
        {
            var m = new Random();
            int next = m.Next(0, 13);

            //MetroStyleManager mt = new MetroStyleManager();
            //metroStyleManager.Style = (MetroColorStyle)next;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            //metroStyleManager.Theme = metroStyleManager.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
        }






    }
}




/////////////////////////
//txtPIData.Items.Clear();

//PISDK.PIPoint myPoint = myServer.PIPoints["cppctl21"];

//////////////////////////






//string fileName = "C:\\Users\\KCURRIE\\Desktop\\Test\\Openme4.xlsx";
//xlWorkBook.SaveAs("csharp.net-informations.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);


            

            /*
Excel.Worksheet sheet = workbook.ActiveSheet;
Excel.Range rng = (Excel.Range) sheet.get_Range(sheet.Cells[1, 1], sheet.Cells[3,3]);
Where range is one cell:

Excel.Worksheet sheet = workbook.ActiveSheet;
Excel.Range rng = (Excel.Range) sheet.Cells[1, 1];
            */

            //myWorkbook.SaveAs(@"C:/pape.xltx", missing, missing, missing, missing, missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, missing, missing, missing, missing, missing);



//System.IO.File.WriteAllLines("C:\\Users\\KCURRIE\\Desktop\\Test\\test.txt", positionData);

//string fileName = "C:\\Users\\KCURRIE\\Desktop\\Test\\Openme2.xlsx";
//MyBook = MyApp.Workbooks.Open(fileName);
//MyBook = MyApp.NewWorkbook.Add(fileName);




/*
private void btnPositionCommand_Click(object sender, EventArgs e)
{
    byte[] TxBytes = new Byte[5];
    UInt16 dataToSend = 0;

    //Convert textbox input to int to send
    //dataToSend = Convert.ToUInt16(txtSetPosition.Text);

    //Make sure the target position is greater than 0
    if (dataToSend < 0)
        dataToSend = 0;

    try
    {
        if (serialPort1.IsOpen)
        {
            TxBytes[0] = Convert.ToByte(255);
            serialPort1.Write(TxBytes, 0, 1);

            TxBytes[1] = Convert.ToByte(6);
            serialPort1.Write(TxBytes, 1, 1);

            TxBytes[2] = Convert.ToByte(((dataToSend >> 8) & 0xFF));
            serialPort1.Write(TxBytes, 2, 1);

            TxBytes[3] = Convert.ToByte((dataToSend & 0xFF));
            serialPort1.Write(TxBytes, 3, 1);

            TxBytes[4] = Convert.ToByte(0);
            serialPort1.Write(TxBytes, 4, 1);
        }
    }
    catch (Exception Ex)
    {
        MessageBox.Show(Ex.Message);
    }

    //Start Recording Data
    recordPosition = true;
    positionDataIterator = 0;
}

*/


//Write data to excel
/*
lastRow += 1;
int j = 0;
List<string> keys2 = new List<string>(currentData.Keys);
foreach (var key in keys2)
{
    MySheet.Cells[lastRow, j] = currentData[key];
    j++;
}
*/
//MySheet.Cells[lastRow, 4] = "blah4";
//int rowIndex = 5; int columnIndex = 2;
//MySheet.Cells[rowIndex, columnIndex] = "alekjrej";



/*
serialQueue1.TryDequeue(out commandByte); txtCommandByte.Text = commandByte.ToString();
//txtCommand.Text = commandList[commandByte].ToString();
serialQueue1.TryDequeue(out dataByte1); 
serialQueue1.TryDequeue(out dataByte2); 
serialQueue1.TryDequeue(out exitByte); txtExit.Text = exitByte.ToString();

//Deal with exit byte
if (exitByte != 0)        //exitbyte was used
{
    if (exitByte == 1)
        dataByte1 = 255;
    if (exitByte == 2)
        dataByte2 = 255;
    if (exitByte == 3)
    {
        dataByte1 = 255;
        dataByte2 = 255;
    }
}
txtInputByte1.Text = dataByte1.ToString();
txtInputByte2.Text = dataByte2.ToString();

//Check what command was input
if (commandByte == 10 || commandByte == 11)    //Command 10 for encoder stuff
{
    //Update currentDirection
    if (commandByte == 10)
        currentDirection = 1;
    else
        currentDirection = 2;

    //Update the positionData array if we're doing position command
    if (recordPosition)
    {
        if (positionDataIterator < numberOfPointsToRecord)
        {
            countsToAdd = Convert.ToInt16(dataByte1) * 256 + Convert.ToInt16(dataByte2);
                                
            if (currentDirection == 1)
            {
                positionData[positionDataIterator] = Convert.ToString(previousPosition + countsToAdd);
                previousPosition += countsToAdd;
            }
            else if (currentDirection == 2)
            {
                positionData[positionDataIterator] = Convert.ToString(previousPosition - countsToAdd);
                previousPosition -= countsToAdd;
            }

            positionDataIterator++;
        }
        else
        {
            recordPosition = false;
        }
    }
                        


    //Decode data from bytes to an int - comes in as counts
    //int currentRPM;
    if(commandByte == 10)
        currentRPM = (Convert.ToDouble(dataByte1) * 256 + Convert.ToDouble(dataByte2)) * 60 / 400 * 24000000/8 / 65535;
    else
        currentRPM = -1 * (Convert.ToDouble(dataByte1) * 256 + Convert.ToDouble(dataByte2)) * 60 / 400 * 24000000 / 8 / 65535;

                        
    //If over the end data point count remove points from the beginning of graph
    if (chartFreq.Series[0].Points.Count > 150)
    {
        for (int i = 0; i < 1; i++) { chartFreq.Series[i].Points.RemoveAt(0); }
    }
    if (chartRPM.Series[0].Points.Count > 150)
    {
        for (int i = 0; i < 1; i++) { chartRPM.Series[i].Points.RemoveAt(0); }
    }

    //graph and display values
    chartRPM.Series[0].Points.AddY(currentRPM);
    currentFrequency = currentRPM /( 60.0);
    chartFreq.Series[0].Points.AddY(currentFrequency);
    txtRPM.Text = currentRPM.ToString();
    txtFreq.Text = currentFrequency.ToString();

    if (currentDirection == 1)
        txtDirection.Text = "Forward";
    else
        txtDirection.Text = "Reverse";

                       
    //reset graph axes
    chartRPM.ResetAutoValues();
    chartFreq.ResetAutoValues();
}
                    
 * /
 * /*
avgCount++;
maxCount++;

if (avgCount >= 100)
{
    txtAvgX.Text = (sum[0] / 100).ToString("F3"); sum[0] -= avg100QueueX.Dequeue();
}
*/
