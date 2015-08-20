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
        string filepath = "C:\\Users\\CPP\\Desktop\\Test\\";        //use C:\\Users\\KCURRIE\\Desktop\\Test\\ on desktop
        string filename;
        int lastRow1 = 1;
        int lastRow2 = 1;
        int extraColumns = 1;       //How many additional data columns there are after data from sensors

        //Communication variables
        ConcurrentQueue<int> serialQueue1 = new ConcurrentQueue<int>();
        ConcurrentQueue<int> serialQueue2 = new ConcurrentQueue<int>();
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
 
        //Chart Variables
        int maxChartVal = 100000;       //Bug in chart library: ensure values less than or greater than these min/max values
        int minChartVal = -100000;
        int graphSeconds = 120;         //Number of seconds to view on graph, removes earliest graph points as we go
        int numSeries = 2;              //Number of data series on our graphs: internal and external means 2
        int dataErrorValue = 0;       //If incoming data is this value it is an error
              
        /////////////////////////////////
        public MainForm()
        {
            InitializeComponent();
           
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
                graphSeconds = Convert.ToInt16(txtGraphSeconds.Text);
            }
            catch (Exception Ex)
            {//do nothing, leave as default
            }

            if(txtGraphSeconds.Text == "")
                MessageBox.Show(string.Format("Graph at {0} second intervals default", graphSeconds));
            
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
                        if (data == dataErrorValue)             //Filter data: if = error value, reuse last value for that key
                        {
                            errorCount++;              //Count how many errors are in this packetcurrentData[key] = data;            //Put data in its respective key
                        }
                        else if (errorCount == 0)               //Else If this data is ok, check all other data in packet has been ok  
                        {
                            currentData[key] = data;            //Put data in its respective key
                        }
                        //If any other data values have errors, use last value for that key and don't update error count (do nothing)
                        MySheet.Cells[lastRow1, j] = currentData[key];   //Put data in excel sheet
                        j++;    //Update current row in excel sheet
                    }                    
                    serialQueue1.TryDequeue(out data);  //Remove exit byte
                    MySheet.Cells[lastRow1, j] = errorCount;    //Save error count
                    MySheet.Cells[lastRow1,1] = DateTime.Now;   //Fix time

                    //Display data text
                    txtHumidityInternal.Text = currentData["Humidity"].ToString();
                    txtTempInternal.Text = currentData["Temp_h"].ToString();
                    txtPressureInternal.Text = currentData["Pressure"].ToString();
                    
                    //Plot data on charts
                    plotData(0);    //Plot data in series 0, internal                     
                }
            }
            
            while (serialQueue2.Count > 2)
            {
                data = 0;
                errorCount = 0;
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
                        if (data == dataErrorValue)                          //Filter data: if = errorvalue, reuse last value for that key
                        {
                            errorCount++;              //Count how many errors are in this packetcurrentData[key] = data;            //Put data in its respective key
                        }
                        else if (errorCount == 0)               //Else If this data is ok, check all other data in packet has been ok  
                        {
                            currentData[key] = data;            //Put data in its respective key
                        }
                        //If any other data values have errors, use last value for that key and don't update error count (do nothing)
                        MySheet.Cells[lastRow2, j] = currentData[key];   //Put data in excel sheet
                        j++;    //Update current row in excel sheet
                    }
                    
                    serialQueue2.TryDequeue(out data);  //Remove exit byte
                    MySheet.Cells[lastRow2, j] = errorCount;    //Save error count
                    MySheet.Cells[lastRow2, currentData.Count()+1 + extraColumns] = DateTime.Now;   //Fix time

                    //Display data text
                    txtHumidityExternal.Text = currentData["Humidity"].ToString();
                    txtTempExternal.Text = currentData["Temp_h"].ToString();
                    txtPressureExternal.Text = currentData["Pressure"].ToString();
                    
                    //Plot data on charts
                    plotData(1);    //Plot data in series 1, External


                     
                }
             
            }
        
        }

        private void plotData(int series)
        {
            //If over the end data point count remove points from the beginning of graph
            if (chartHumidity.Series[series].Points.Count > graphSeconds)
            {
                //for (int i = 0; i < numSeries; i++) { chartHumidity.Series[i].Points.RemoveAt(0); }
                chartHumidity.Series[series].Points.RemoveAt(0);
            }
            if (chartTemp.Series[series].Points.Count > graphSeconds)
            {
                //for (int i = 0; i < numSeries; i++) { chartTemp.Series[i].Points.RemoveAt(0); }
                chartTemp.Series[series].Points.RemoveAt(0);
            }
            if (chartPressure.Series[series].Points.Count > graphSeconds)
            {
                //for (int i = 0; i < numSeries; i++) { chartPressure.Series[i].Points.RemoveAt(0); }
                chartPressure.Series[series].Points.RemoveAt(0);
            }
                          
            //Try to graph and display values. Use filter fxn to ensure no chart errors and big red chart X's
            //http://stackoverflow.com/questions/17210257/microsoft-chart-control-redraw-chart-after-failure-red-cross
            try
            {
                chartHumidity.Series[series].Points.AddY(filteredChartData("Humidity"));
                chartTemp.Series[series].Points.AddY(filteredChartData("Temp_h"));
                chartPressure.Series[series].Points.AddY(filteredChartData("Pressure"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chart plot error");
            }

            //Try to update axis scales
            try
            {
                chartHumidity.ResetAutoValues();
                chartTemp.ResetAutoValues();
                chartPressure.ResetAutoValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reset Auto Values Error");
            }
        }

        private int filteredChartData(string key)       //Ensures values to chart are within limits of chart
        {
            if (currentData[key] < minChartVal)
                return minChartVal;
            else if (currentData[key] > maxChartVal)
                return maxChartVal;
            else
                return currentData[key];
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

                filename = dateTimeBox.Text + " - " + filename;

                MyBook.SaveAs(filepath + filename + ".xlsx");

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
                MyBook.SaveAs(filepath + filename + ".xlsx");
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




    }
}



