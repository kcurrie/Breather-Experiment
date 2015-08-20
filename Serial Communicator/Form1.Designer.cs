namespace Serial_Comm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.cmbComPort1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtBaudRate1 = new System.Windows.Forms.ToolStripTextBox();
            this.btnConnect1 = new System.Windows.Forms.ToolStripButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chkShowResponse1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblIncomingDataRate1 = new System.Windows.Forms.Label();
            this.tmrData = new System.Windows.Forms.Timer(this.components);
            this.lblBytesInQueue = new System.Windows.Forms.Label();
            this.lblBytesToRead = new System.Windows.Forms.Label();
            this.txtBytesInQueue = new System.Windows.Forms.TextBox();
            this.txtBytesToRead = new System.Windows.Forms.TextBox();
            this.txtRawSerial1 = new System.Windows.Forms.TextBox();
            this.chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHumidity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClearHistory1 = new System.Windows.Forms.Button();
            this.txtPackets = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cmbComPort2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtBaudRate2 = new System.Windows.Forms.ToolStripTextBox();
            this.btnConnect2 = new System.Windows.Forms.ToolStripButton();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.txtPackets2 = new System.Windows.Forms.TextBox();
            this.btnClearHistory2 = new System.Windows.Forms.Button();
            this.chkShowResponse2 = new System.Windows.Forms.CheckBox();
            this.lblIncomingDataRate2 = new System.Windows.Forms.Label();
            this.txtRawSerial2 = new System.Windows.Forms.TextBox();
            this.dateTimeBox = new MetroFramework.Controls.MetroDateTime();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.txtNotes = new MetroFramework.Controls.MetroTextBox();
            this.btnSaveOnly = new MetroFramework.Controls.MetroButton();
            this.btnSaveData = new MetroFramework.Controls.MetroButton();
            this.btnStartExperiment = new MetroFramework.Controls.MetroButton();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.txtFileName = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.chartPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroLabel30 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.txtTempInternal = new MetroFramework.Controls.MetroTextBox();
            this.txtPressureInternal = new MetroFramework.Controls.MetroTextBox();
            this.txtHumidityExternal = new MetroFramework.Controls.MetroTextBox();
            this.txtTempExternal = new MetroFramework.Controls.MetroTextBox();
            this.txtPressureExternal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel28 = new MetroFramework.Controls.MetroLabel();
            this.txtHumidityInternal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.bntVideoSource = new System.Windows.Forms.Button();
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.bntVideoFormat = new System.Windows.Forms.Button();
            this.imgCapture = new System.Windows.Forms.PictureBox();
            this.bntSave = new System.Windows.Forms.Button();
            this.bntStart = new System.Windows.Forms.Button();
            this.bntCapture = new System.Windows.Forms.Button();
            this.bntStop = new System.Windows.Forms.Button();
            this.bntContinue = new System.Windows.Forms.Button();
            this.metroTabPage8 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtGraphSeconds = new MetroFramework.Controls.MetroTextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHumidity)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPage6.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressure)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).BeginInit();
            this.metroTabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4,
            this.cmbComPort1,
            this.toolStripLabel1,
            this.txtBaudRate1,
            this.btnConnect1});
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(842, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel4.Text = "Internal Sensor:";
            // 
            // cmbComPort1
            // 
            this.cmbComPort1.Name = "cmbComPort1";
            this.cmbComPort1.Size = new System.Drawing.Size(120, 25);
            this.cmbComPort1.DropDown += new System.EventHandler(this.cmbComPort1_DropDown);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel1.Text = "Baud Rate:";
            // 
            // txtBaudRate1
            // 
            this.txtBaudRate1.Name = "txtBaudRate1";
            this.txtBaudRate1.Size = new System.Drawing.Size(70, 25);
            this.txtBaudRate1.Text = "9600";
            // 
            // btnConnect1
            // 
            this.btnConnect1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConnect1.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect1.Image")));
            this.btnConnect1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect1.Name = "btnConnect1";
            this.btnConnect1.Size = new System.Drawing.Size(56, 22);
            this.btnConnect1.Text = "Connect";
            this.btnConnect1.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // chkShowResponse1
            // 
            this.chkShowResponse1.AutoSize = true;
            this.chkShowResponse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowResponse1.Location = new System.Drawing.Point(10, 38);
            this.chkShowResponse1.Name = "chkShowResponse1";
            this.chkShowResponse1.Size = new System.Drawing.Size(220, 24);
            this.chkShowResponse1.TabIndex = 2;
            this.chkShowResponse1.Text = "Response from Com Port 1";
            this.chkShowResponse1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblIncomingDataRate1
            // 
            this.lblIncomingDataRate1.AutoSize = true;
            this.lblIncomingDataRate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomingDataRate1.Location = new System.Drawing.Point(6, 238);
            this.lblIncomingDataRate1.Name = "lblIncomingDataRate1";
            this.lblIncomingDataRate1.Size = new System.Drawing.Size(303, 20);
            this.lblIncomingDataRate1.TabIndex = 1;
            this.lblIncomingDataRate1.Text = "Incoming Data Rate = 0 bytes per second";
            // 
            // tmrData
            // 
            this.tmrData.Tick += new System.EventHandler(this.tmrData_Tick);
            // 
            // lblBytesInQueue
            // 
            this.lblBytesInQueue.AutoSize = true;
            this.lblBytesInQueue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBytesInQueue.Location = new System.Drawing.Point(116, 308);
            this.lblBytesInQueue.Name = "lblBytesInQueue";
            this.lblBytesInQueue.Size = new System.Drawing.Size(42, 15);
            this.lblBytesInQueue.TabIndex = 29;
            this.lblBytesInQueue.Text = "Queue";
            // 
            // lblBytesToRead
            // 
            this.lblBytesToRead.AutoSize = true;
            this.lblBytesToRead.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBytesToRead.Location = new System.Drawing.Point(116, 278);
            this.lblBytesToRead.Name = "lblBytesToRead";
            this.lblBytesToRead.Size = new System.Drawing.Size(56, 15);
            this.lblBytesToRead.TabIndex = 28;
            this.lblBytesToRead.Text = "Buffer ";
            // 
            // txtBytesInQueue
            // 
            this.txtBytesInQueue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBytesInQueue.Location = new System.Drawing.Point(10, 305);
            this.txtBytesInQueue.Name = "txtBytesInQueue";
            this.txtBytesInQueue.ReadOnly = true;
            this.txtBytesInQueue.Size = new System.Drawing.Size(100, 23);
            this.txtBytesInQueue.TabIndex = 27;
            // 
            // txtBytesToRead
            // 
            this.txtBytesToRead.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBytesToRead.Location = new System.Drawing.Point(10, 275);
            this.txtBytesToRead.Name = "txtBytesToRead";
            this.txtBytesToRead.ReadOnly = true;
            this.txtBytesToRead.Size = new System.Drawing.Size(100, 23);
            this.txtBytesToRead.TabIndex = 26;
            // 
            // txtRawSerial1
            // 
            this.txtRawSerial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRawSerial1.Location = new System.Drawing.Point(10, 76);
            this.txtRawSerial1.Multiline = true;
            this.txtRawSerial1.Name = "txtRawSerial1";
            this.txtRawSerial1.Size = new System.Drawing.Size(335, 159);
            this.txtRawSerial1.TabIndex = 4;
            // 
            // chartTemp
            // 
            this.chartTemp.BorderlineColor = System.Drawing.Color.DeepSkyBlue;
            this.chartTemp.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea7.AxisX.Title = "Time [s]";
            chartArea7.AxisY.IsStartedFromZero = false;
            chartArea7.AxisY.Title = "Celsius";
            chartArea7.Name = "ChartArea1";
            this.chartTemp.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartTemp.Legends.Add(legend7);
            this.chartTemp.Location = new System.Drawing.Point(346, 188);
            this.chartTemp.Name = "chartTemp";
            series13.BorderWidth = 3;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Internal";
            series14.BorderWidth = 3;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.Name = "External";
            this.chartTemp.Series.Add(series13);
            this.chartTemp.Series.Add(series14);
            this.chartTemp.Size = new System.Drawing.Size(488, 174);
            this.chartTemp.TabIndex = 52;
            this.chartTemp.Text = "chartFreq";
            title7.Name = "Title1";
            title7.Text = "Temperature";
            this.chartTemp.Titles.Add(title7);
            // 
            // chartHumidity
            // 
            this.chartHumidity.BorderlineColor = System.Drawing.Color.DeepSkyBlue;
            this.chartHumidity.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea8.AxisX.Title = "Time [s]";
            chartArea8.AxisY.Title = "%RH";
            chartArea8.Name = "ChartArea1";
            chartArea8.ShadowColor = System.Drawing.Color.White;
            this.chartHumidity.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartHumidity.Legends.Add(legend8);
            this.chartHumidity.Location = new System.Drawing.Point(346, 8);
            this.chartHumidity.Name = "chartHumidity";
            series15.BorderWidth = 3;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "Internal";
            series16.BorderWidth = 3;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.Name = "External";
            this.chartHumidity.Series.Add(series15);
            this.chartHumidity.Series.Add(series16);
            this.chartHumidity.Size = new System.Drawing.Size(488, 174);
            this.chartHumidity.TabIndex = 53;
            this.chartHumidity.Text = "Humidity";
            title8.Name = "Humidity";
            title8.Text = "Humidity";
            this.chartHumidity.Titles.Add(title8);
            // 
            // btnClearHistory1
            // 
            this.btnClearHistory1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearHistory1.Location = new System.Drawing.Point(236, 30);
            this.btnClearHistory1.Name = "btnClearHistory1";
            this.btnClearHistory1.Size = new System.Drawing.Size(120, 39);
            this.btnClearHistory1.TabIndex = 59;
            this.btnClearHistory1.Text = "Clear History";
            this.btnClearHistory1.UseVisualStyleBackColor = true;
            this.btnClearHistory1.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // txtPackets
            // 
            this.txtPackets.Location = new System.Drawing.Point(10, 12);
            this.txtPackets.Name = "txtPackets";
            this.txtPackets.Size = new System.Drawing.Size(100, 20);
            this.txtPackets.TabIndex = 75;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.cmbComPort2,
            this.toolStripLabel2,
            this.txtBaudRate2,
            this.btnConnect2});
            this.toolStrip2.Location = new System.Drawing.Point(20, 85);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(842, 25);
            this.toolStrip2.TabIndex = 76;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(89, 22);
            this.toolStripLabel3.Text = "External Sensor:";
            // 
            // cmbComPort2
            // 
            this.cmbComPort2.Name = "cmbComPort2";
            this.cmbComPort2.Size = new System.Drawing.Size(120, 25);
            this.cmbComPort2.DropDown += new System.EventHandler(this.cmbComPort2_DropDown);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel2.Text = "Baud Rate:";
            // 
            // txtBaudRate2
            // 
            this.txtBaudRate2.Name = "txtBaudRate2";
            this.txtBaudRate2.Size = new System.Drawing.Size(70, 25);
            this.txtBaudRate2.Text = "9600";
            // 
            // btnConnect2
            // 
            this.btnConnect2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConnect2.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect2.Image")));
            this.btnConnect2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect2.Name = "btnConnect2";
            this.btnConnect2.Size = new System.Drawing.Size(56, 22);
            this.btnConnect2.Text = "Connect";
            this.btnConnect2.Click += new System.EventHandler(this.btnConnect2_Click);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // txtPackets2
            // 
            this.txtPackets2.Location = new System.Drawing.Point(379, 13);
            this.txtPackets2.Name = "txtPackets2";
            this.txtPackets2.Size = new System.Drawing.Size(100, 20);
            this.txtPackets2.TabIndex = 81;
            // 
            // btnClearHistory2
            // 
            this.btnClearHistory2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearHistory2.Location = new System.Drawing.Point(612, 31);
            this.btnClearHistory2.Name = "btnClearHistory2";
            this.btnClearHistory2.Size = new System.Drawing.Size(120, 39);
            this.btnClearHistory2.TabIndex = 80;
            this.btnClearHistory2.Text = "Clear History";
            this.btnClearHistory2.UseVisualStyleBackColor = true;
            this.btnClearHistory2.Click += new System.EventHandler(this.btnClearHistory2_Click);
            // 
            // chkShowResponse2
            // 
            this.chkShowResponse2.AutoSize = true;
            this.chkShowResponse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowResponse2.Location = new System.Drawing.Point(379, 39);
            this.chkShowResponse2.Name = "chkShowResponse2";
            this.chkShowResponse2.Size = new System.Drawing.Size(220, 24);
            this.chkShowResponse2.TabIndex = 78;
            this.chkShowResponse2.Text = "Response from Com Port 2";
            this.chkShowResponse2.UseVisualStyleBackColor = true;
            // 
            // lblIncomingDataRate2
            // 
            this.lblIncomingDataRate2.AutoSize = true;
            this.lblIncomingDataRate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomingDataRate2.Location = new System.Drawing.Point(380, 238);
            this.lblIncomingDataRate2.Name = "lblIncomingDataRate2";
            this.lblIncomingDataRate2.Size = new System.Drawing.Size(303, 20);
            this.lblIncomingDataRate2.TabIndex = 77;
            this.lblIncomingDataRate2.Text = "Incoming Data Rate = 0 bytes per second";
            // 
            // txtRawSerial2
            // 
            this.txtRawSerial2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRawSerial2.Location = new System.Drawing.Point(379, 76);
            this.txtRawSerial2.Multiline = true;
            this.txtRawSerial2.Name = "txtRawSerial2";
            this.txtRawSerial2.Size = new System.Drawing.Size(335, 159);
            this.txtRawSerial2.TabIndex = 79;
            // 
            // dateTimeBox
            // 
            this.dateTimeBox.Location = new System.Drawing.Point(87, 20);
            this.dateTimeBox.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeBox.Name = "dateTimeBox";
            this.dateTimeBox.Size = new System.Drawing.Size(200, 29);
            this.dateTimeBox.TabIndex = 98;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage6);
            this.metroTabControl2.Controls.Add(this.metroTabPage5);
            this.metroTabControl2.Controls.Add(this.metroTabPage3);
            this.metroTabControl2.Controls.Add(this.metroTabPage8);
            this.metroTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl2.Location = new System.Drawing.Point(20, 110);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(842, 586);
            this.metroTabControl2.TabIndex = 100;
            this.metroTabControl2.UseSelectable = true;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.Controls.Add(this.txtGraphSeconds);
            this.metroTabPage6.Controls.Add(this.metroLabel1);
            this.metroTabPage6.Controls.Add(this.txtNotes);
            this.metroTabPage6.Controls.Add(this.btnSaveOnly);
            this.metroTabPage6.Controls.Add(this.btnSaveData);
            this.metroTabPage6.Controls.Add(this.btnStartExperiment);
            this.metroTabPage6.Controls.Add(this.metroLabel25);
            this.metroTabPage6.Controls.Add(this.metroLabel24);
            this.metroTabPage6.Controls.Add(this.metroLabel23);
            this.metroTabPage6.Controls.Add(this.txtFileName);
            this.metroTabPage6.Controls.Add(this.dateTimeBox);
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.HorizontalScrollbarSize = 10;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(834, 544);
            this.metroTabPage6.TabIndex = 5;
            this.metroTabPage6.Text = "Setup";
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.VerticalScrollbarSize = 10;
            // 
            // txtNotes
            // 
            this.txtNotes.Lines = new string[0];
            this.txtNotes.Location = new System.Drawing.Point(87, 88);
            this.txtNotes.MaxLength = 32767;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(324, 91);
            this.txtNotes.TabIndex = 109;
            this.txtNotes.UseSelectable = true;
            // 
            // btnSaveOnly
            // 
            this.btnSaveOnly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveOnly.Location = new System.Drawing.Point(177, 239);
            this.btnSaveOnly.Name = "btnSaveOnly";
            this.btnSaveOnly.Size = new System.Drawing.Size(127, 37);
            this.btnSaveOnly.TabIndex = 107;
            this.btnSaveOnly.Text = "Save";
            this.btnSaveOnly.UseSelectable = true;
            this.btnSaveOnly.Click += new System.EventHandler(this.btnSaveOnly_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Highlight = true;
            this.btnSaveData.Location = new System.Drawing.Point(347, 239);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(127, 37);
            this.btnSaveData.TabIndex = 106;
            this.btnSaveData.Text = "End Recording";
            this.btnSaveData.UseSelectable = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click_1);
            // 
            // btnStartExperiment
            // 
            this.btnStartExperiment.BackColor = System.Drawing.Color.DarkRed;
            this.btnStartExperiment.Highlight = true;
            this.btnStartExperiment.Location = new System.Drawing.Point(13, 239);
            this.btnStartExperiment.Name = "btnStartExperiment";
            this.btnStartExperiment.Size = new System.Drawing.Size(127, 37);
            this.btnStartExperiment.TabIndex = 105;
            this.btnStartExperiment.Text = "Start Recording";
            this.btnStartExperiment.UseSelectable = true;
            this.btnStartExperiment.Click += new System.EventHandler(this.btnStartExperiment_Click_1);
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Location = new System.Drawing.Point(13, 20);
            this.metroLabel25.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(36, 19);
            this.metroLabel25.TabIndex = 104;
            this.metroLabel25.Text = "Date";
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.Location = new System.Drawing.Point(13, 88);
            this.metroLabel24.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(43, 19);
            this.metroLabel24.TabIndex = 103;
            this.metroLabel24.Text = "Notes";
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Location = new System.Drawing.Point(12, 55);
            this.metroLabel23.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(69, 19);
            this.metroLabel23.TabIndex = 101;
            this.metroLabel23.Text = "File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.IconRight = true;
            this.txtFileName.Lines = new string[0];
            this.txtFileName.Location = new System.Drawing.Point(87, 55);
            this.txtFileName.MaxLength = 32767;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.PasswordChar = '\0';
            this.txtFileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFileName.SelectedText = "";
            this.txtFileName.Size = new System.Drawing.Size(324, 22);
            this.txtFileName.TabIndex = 100;
            this.txtFileName.UseSelectable = true;
            this.txtFileName.UseStyleColors = true;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.Controls.Add(this.chartPressure);
            this.metroTabPage5.Controls.Add(this.metroLabel30);
            this.metroTabPage5.Controls.Add(this.metroLabel29);
            this.metroTabPage5.Controls.Add(this.txtTempInternal);
            this.metroTabPage5.Controls.Add(this.txtPressureInternal);
            this.metroTabPage5.Controls.Add(this.txtHumidityExternal);
            this.metroTabPage5.Controls.Add(this.txtTempExternal);
            this.metroTabPage5.Controls.Add(this.txtPressureExternal);
            this.metroTabPage5.Controls.Add(this.metroLabel27);
            this.metroTabPage5.Controls.Add(this.metroLabel28);
            this.metroTabPage5.Controls.Add(this.txtHumidityInternal);
            this.metroTabPage5.Controls.Add(this.metroLabel26);
            this.metroTabPage5.Controls.Add(this.chartHumidity);
            this.metroTabPage5.Controls.Add(this.chartTemp);
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(834, 544);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "Experiment";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // chartPressure
            // 
            this.chartPressure.BorderlineColor = System.Drawing.Color.DeepSkyBlue;
            this.chartPressure.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea9.AxisX.Title = "Time [s]";
            chartArea9.AxisY.IsStartedFromZero = false;
            chartArea9.AxisY.Title = "kPa";
            chartArea9.Name = "ChartArea1";
            this.chartPressure.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartPressure.Legends.Add(legend9);
            this.chartPressure.Location = new System.Drawing.Point(346, 368);
            this.chartPressure.Name = "chartPressure";
            series17.BorderWidth = 3;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Legend = "Legend1";
            series17.Name = "Internal";
            series18.BorderWidth = 3;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Legend = "Legend1";
            series18.Name = "External";
            this.chartPressure.Series.Add(series17);
            this.chartPressure.Series.Add(series18);
            this.chartPressure.Size = new System.Drawing.Size(488, 174);
            this.chartPressure.TabIndex = 71;
            this.chartPressure.Text = "chartFreq";
            title9.Name = "Title1";
            title9.Text = "Pressure";
            this.chartPressure.Titles.Add(title9);
            // 
            // metroLabel30
            // 
            this.metroLabel30.AutoSize = true;
            this.metroLabel30.Location = new System.Drawing.Point(0, 252);
            this.metroLabel30.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel30.Name = "metroLabel30";
            this.metroLabel30.Size = new System.Drawing.Size(109, 19);
            this.metroLabel30.TabIndex = 70;
            this.metroLabel30.Text = "Temperature [C]:";
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Location = new System.Drawing.Point(0, 431);
            this.metroLabel29.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(94, 19);
            this.metroLabel29.TabIndex = 69;
            this.metroLabel29.Text = "Pressure [kPa]:";
            // 
            // txtTempInternal
            // 
            this.txtTempInternal.Enabled = false;
            this.txtTempInternal.Lines = new string[0];
            this.txtTempInternal.Location = new System.Drawing.Point(118, 252);
            this.txtTempInternal.MaxLength = 32767;
            this.txtTempInternal.Name = "txtTempInternal";
            this.txtTempInternal.PasswordChar = '\0';
            this.txtTempInternal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTempInternal.SelectedText = "";
            this.txtTempInternal.Size = new System.Drawing.Size(81, 22);
            this.txtTempInternal.TabIndex = 68;
            this.txtTempInternal.UseSelectable = true;
            // 
            // txtPressureInternal
            // 
            this.txtPressureInternal.Enabled = false;
            this.txtPressureInternal.Lines = new string[0];
            this.txtPressureInternal.Location = new System.Drawing.Point(118, 431);
            this.txtPressureInternal.MaxLength = 32767;
            this.txtPressureInternal.Name = "txtPressureInternal";
            this.txtPressureInternal.PasswordChar = '\0';
            this.txtPressureInternal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPressureInternal.SelectedText = "";
            this.txtPressureInternal.Size = new System.Drawing.Size(81, 22);
            this.txtPressureInternal.TabIndex = 67;
            this.txtPressureInternal.UseSelectable = true;
            // 
            // txtHumidityExternal
            // 
            this.txtHumidityExternal.Enabled = false;
            this.txtHumidityExternal.Lines = new string[0];
            this.txtHumidityExternal.Location = new System.Drawing.Point(228, 76);
            this.txtHumidityExternal.MaxLength = 32767;
            this.txtHumidityExternal.Name = "txtHumidityExternal";
            this.txtHumidityExternal.PasswordChar = '\0';
            this.txtHumidityExternal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHumidityExternal.SelectedText = "";
            this.txtHumidityExternal.Size = new System.Drawing.Size(81, 22);
            this.txtHumidityExternal.TabIndex = 66;
            this.txtHumidityExternal.UseSelectable = true;
            // 
            // txtTempExternal
            // 
            this.txtTempExternal.Enabled = false;
            this.txtTempExternal.Lines = new string[0];
            this.txtTempExternal.Location = new System.Drawing.Point(228, 252);
            this.txtTempExternal.MaxLength = 32767;
            this.txtTempExternal.Name = "txtTempExternal";
            this.txtTempExternal.PasswordChar = '\0';
            this.txtTempExternal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTempExternal.SelectedText = "";
            this.txtTempExternal.Size = new System.Drawing.Size(81, 22);
            this.txtTempExternal.TabIndex = 65;
            this.txtTempExternal.UseSelectable = true;
            // 
            // txtPressureExternal
            // 
            this.txtPressureExternal.Enabled = false;
            this.txtPressureExternal.Lines = new string[0];
            this.txtPressureExternal.Location = new System.Drawing.Point(228, 431);
            this.txtPressureExternal.MaxLength = 32767;
            this.txtPressureExternal.Name = "txtPressureExternal";
            this.txtPressureExternal.PasswordChar = '\0';
            this.txtPressureExternal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPressureExternal.SelectedText = "";
            this.txtPressureExternal.Size = new System.Drawing.Size(81, 22);
            this.txtPressureExternal.TabIndex = 64;
            this.txtPressureExternal.UseSelectable = true;
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel27.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel27.Location = new System.Drawing.Point(118, 20);
            this.metroLabel27.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(79, 25);
            this.metroLabel27.TabIndex = 61;
            this.metroLabel27.Text = "Internal";
            this.metroLabel27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel28
            // 
            this.metroLabel28.AutoSize = true;
            this.metroLabel28.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel28.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel28.Location = new System.Drawing.Point(228, 20);
            this.metroLabel28.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel28.Name = "metroLabel28";
            this.metroLabel28.Size = new System.Drawing.Size(82, 25);
            this.metroLabel28.TabIndex = 62;
            this.metroLabel28.Text = "External";
            this.metroLabel28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHumidityInternal
            // 
            this.txtHumidityInternal.Enabled = false;
            this.txtHumidityInternal.Lines = new string[0];
            this.txtHumidityInternal.Location = new System.Drawing.Point(118, 76);
            this.txtHumidityInternal.MaxLength = 32767;
            this.txtHumidityInternal.Name = "txtHumidityInternal";
            this.txtHumidityInternal.PasswordChar = '\0';
            this.txtHumidityInternal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHumidityInternal.SelectedText = "";
            this.txtHumidityInternal.Size = new System.Drawing.Size(81, 22);
            this.txtHumidityInternal.TabIndex = 60;
            this.txtHumidityInternal.UseSelectable = true;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(0, 76);
            this.metroLabel26.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(104, 19);
            this.metroLabel26.TabIndex = 59;
            this.metroLabel26.Text = "Humidity [%RH]:";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.bntVideoSource);
            this.metroTabPage3.Controls.Add(this.imgVideo);
            this.metroTabPage3.Controls.Add(this.bntVideoFormat);
            this.metroTabPage3.Controls.Add(this.imgCapture);
            this.metroTabPage3.Controls.Add(this.bntSave);
            this.metroTabPage3.Controls.Add(this.bntStart);
            this.metroTabPage3.Controls.Add(this.bntCapture);
            this.metroTabPage3.Controls.Add(this.bntStop);
            this.metroTabPage3.Controls.Add(this.bntContinue);
            this.metroTabPage3.HorizontalScrollbar = true;
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Padding = new System.Windows.Forms.Padding(25);
            this.metroTabPage3.Size = new System.Drawing.Size(834, 544);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Video && Pictures";
            this.metroTabPage3.VerticalScrollbar = true;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            this.metroTabPage3.Visible = false;
            // 
            // bntVideoSource
            // 
            this.bntVideoSource.Location = new System.Drawing.Point(101, 98);
            this.bntVideoSource.Name = "bntVideoSource";
            this.bntVideoSource.Size = new System.Drawing.Size(147, 23);
            this.bntVideoSource.TabIndex = 99;
            this.bntVideoSource.Text = "Video Source";
            this.bntVideoSource.UseVisualStyleBackColor = true;
            // 
            // imgVideo
            // 
            this.imgVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgVideo.Location = new System.Drawing.Point(101, 127);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(163, 138);
            this.imgVideo.TabIndex = 91;
            this.imgVideo.TabStop = false;
            // 
            // bntVideoFormat
            // 
            this.bntVideoFormat.Location = new System.Drawing.Point(101, 69);
            this.bntVideoFormat.Name = "bntVideoFormat";
            this.bntVideoFormat.Size = new System.Drawing.Size(147, 23);
            this.bntVideoFormat.TabIndex = 98;
            this.bntVideoFormat.Text = "Video Format";
            this.bntVideoFormat.UseVisualStyleBackColor = true;
            // 
            // imgCapture
            // 
            this.imgCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture.Location = new System.Drawing.Point(437, 127);
            this.imgCapture.Name = "imgCapture";
            this.imgCapture.Size = new System.Drawing.Size(163, 138);
            this.imgCapture.TabIndex = 92;
            this.imgCapture.TabStop = false;
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(521, 280);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(79, 23);
            this.bntSave.TabIndex = 97;
            this.bntSave.Text = "Save Image";
            this.bntSave.UseVisualStyleBackColor = true;
            // 
            // bntStart
            // 
            this.bntStart.Location = new System.Drawing.Point(112, 284);
            this.bntStart.Name = "bntStart";
            this.bntStart.Size = new System.Drawing.Size(41, 23);
            this.bntStart.TabIndex = 93;
            this.bntStart.Text = "Start";
            this.bntStart.UseVisualStyleBackColor = true;
            // 
            // bntCapture
            // 
            this.bntCapture.Location = new System.Drawing.Point(437, 280);
            this.bntCapture.Name = "bntCapture";
            this.bntCapture.Size = new System.Drawing.Size(85, 23);
            this.bntCapture.TabIndex = 96;
            this.bntCapture.Text = "Capture Image";
            this.bntCapture.UseVisualStyleBackColor = true;
            // 
            // bntStop
            // 
            this.bntStop.Location = new System.Drawing.Point(159, 284);
            this.bntStop.Name = "bntStop";
            this.bntStop.Size = new System.Drawing.Size(49, 23);
            this.bntStop.TabIndex = 94;
            this.bntStop.Text = "Stop";
            this.bntStop.UseVisualStyleBackColor = true;
            // 
            // bntContinue
            // 
            this.bntContinue.Location = new System.Drawing.Point(214, 284);
            this.bntContinue.Name = "bntContinue";
            this.bntContinue.Size = new System.Drawing.Size(61, 23);
            this.bntContinue.TabIndex = 95;
            this.bntContinue.Text = "Continue";
            this.bntContinue.UseVisualStyleBackColor = true;
            // 
            // metroTabPage8
            // 
            this.metroTabPage8.Controls.Add(this.txtRawSerial1);
            this.metroTabPage8.Controls.Add(this.chkShowResponse1);
            this.metroTabPage8.Controls.Add(this.btnClearHistory1);
            this.metroTabPage8.Controls.Add(this.txtPackets);
            this.metroTabPage8.Controls.Add(this.lblIncomingDataRate1);
            this.metroTabPage8.Controls.Add(this.txtRawSerial2);
            this.metroTabPage8.Controls.Add(this.lblIncomingDataRate2);
            this.metroTabPage8.Controls.Add(this.chkShowResponse2);
            this.metroTabPage8.Controls.Add(this.btnClearHistory2);
            this.metroTabPage8.Controls.Add(this.txtPackets2);
            this.metroTabPage8.Controls.Add(this.txtBytesToRead);
            this.metroTabPage8.Controls.Add(this.txtBytesInQueue);
            this.metroTabPage8.Controls.Add(this.lblBytesToRead);
            this.metroTabPage8.Controls.Add(this.lblBytesInQueue);
            this.metroTabPage8.HorizontalScrollbarBarColor = true;
            this.metroTabPage8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.HorizontalScrollbarSize = 10;
            this.metroTabPage8.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage8.Name = "metroTabPage8";
            this.metroTabPage8.Size = new System.Drawing.Size(834, 544);
            this.metroTabPage8.TabIndex = 9;
            this.metroTabPage8.Text = "Debug";
            this.metroTabPage8.VerticalScrollbarBarColor = true;
            this.metroTabPage8.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 193);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(182, 19);
            this.metroLabel1.TabIndex = 110;
            this.metroLabel1.Text = "Number of Seconds to Graph";
            // 
            // txtGraphSeconds
            // 
            this.txtGraphSeconds.IconRight = true;
            this.txtGraphSeconds.Lines = new string[0];
            this.txtGraphSeconds.Location = new System.Drawing.Point(203, 190);
            this.txtGraphSeconds.MaxLength = 32767;
            this.txtGraphSeconds.Name = "txtGraphSeconds";
            this.txtGraphSeconds.PasswordChar = '\0';
            this.txtGraphSeconds.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGraphSeconds.SelectedText = "";
            this.txtGraphSeconds.Size = new System.Drawing.Size(208, 22);
            this.txtGraphSeconds.TabIndex = 111;
            this.txtGraphSeconds.UseSelectable = true;
            this.txtGraphSeconds.UseStyleColors = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 716);
            this.Controls.Add(this.metroTabControl2);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Breather Test Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHumidity)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabPage6.ResumeLayout(false);
            this.metroTabPage6.PerformLayout();
            this.metroTabPage5.ResumeLayout(false);
            this.metroTabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressure)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).EndInit();
            this.metroTabPage8.ResumeLayout(false);
            this.metroTabPage8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cmbComPort1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtBaudRate1;
        private System.Windows.Forms.ToolStripButton btnConnect1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chkShowResponse1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblIncomingDataRate1;
        private System.Windows.Forms.Timer tmrData;
        private System.Windows.Forms.Label lblBytesInQueue;
        private System.Windows.Forms.Label lblBytesToRead;
        private System.Windows.Forms.TextBox txtBytesInQueue;
        private System.Windows.Forms.TextBox txtBytesToRead;
        private System.Windows.Forms.TextBox txtRawSerial1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHumidity;
        private System.Windows.Forms.Button btnClearHistory1;
        private System.Windows.Forms.TextBox txtPackets;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripComboBox cmbComPort2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtBaudRate2;
        private System.Windows.Forms.ToolStripButton btnConnect2;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.TextBox txtPackets2;
        private System.Windows.Forms.Button btnClearHistory2;
        private System.Windows.Forms.CheckBox chkShowResponse2;
        private System.Windows.Forms.Label lblIncomingDataRate2;
        private System.Windows.Forms.TextBox txtRawSerial2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private MetroFramework.Controls.MetroDateTime dateTimeBox;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroTabPage metroTabPage8;
        private MetroFramework.Controls.MetroButton btnSaveData;
        private MetroFramework.Controls.MetroButton btnStartExperiment;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroTextBox txtFileName;
        private MetroFramework.Controls.MetroButton btnSaveOnly;
        private MetroFramework.Controls.MetroTextBox txtNotes;
        private System.Windows.Forms.Button bntVideoSource;
        private System.Windows.Forms.PictureBox imgVideo;
        private System.Windows.Forms.Button bntVideoFormat;
        private System.Windows.Forms.PictureBox imgCapture;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.Button bntStart;
        private System.Windows.Forms.Button bntCapture;
        private System.Windows.Forms.Button bntStop;
        private System.Windows.Forms.Button bntContinue;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroLabel metroLabel28;
        private MetroFramework.Controls.MetroTextBox txtHumidityInternal;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroLabel metroLabel30;
        private MetroFramework.Controls.MetroLabel metroLabel29;
        private MetroFramework.Controls.MetroTextBox txtTempInternal;
        private MetroFramework.Controls.MetroTextBox txtPressureInternal;
        private MetroFramework.Controls.MetroTextBox txtHumidityExternal;
        private MetroFramework.Controls.MetroTextBox txtTempExternal;
        private MetroFramework.Controls.MetroTextBox txtPressureExternal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPressure;
        private MetroFramework.Controls.MetroTextBox txtGraphSeconds;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

