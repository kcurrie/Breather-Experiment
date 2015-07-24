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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton12 = new MetroFramework.Controls.MetroButton();
            this.metroButton11 = new MetroFramework.Controls.MetroButton();
            this.metroButton10 = new MetroFramework.Controls.MetroButton();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroRadioButton4 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton5 = new MetroFramework.Controls.MetroRadioButton();
            this.metroCheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox5 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroRadioButton6 = new MetroFramework.Controls.MetroRadioButton();
            this.metroCheckBox6 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLink4 = new MetroFramework.Controls.MetroLink();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTileSwitch = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime3 = new MetroFramework.Controls.MetroDateTime();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroToggle3 = new MetroFramework.Controls.MetroToggle();
            this.metroToggle2 = new MetroFramework.Controls.MetroToggle();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinner3 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressSpinner2 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroScrollBar1 = new MetroFramework.Controls.MetroScrollBar();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
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
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHumidity)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.metroTabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
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
            chartArea4.Name = "ChartArea1";
            this.chartTemp.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTemp.Legends.Add(legend4);
            this.chartTemp.Location = new System.Drawing.Point(346, 188);
            this.chartTemp.Name = "chartTemp";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Internal";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "External";
            this.chartTemp.Series.Add(series7);
            this.chartTemp.Series.Add(series8);
            this.chartTemp.Size = new System.Drawing.Size(488, 174);
            this.chartTemp.TabIndex = 52;
            this.chartTemp.Text = "chartFreq";
            title4.Name = "Title1";
            title4.Text = "Temperature";
            this.chartTemp.Titles.Add(title4);
            // 
            // chartHumidity
            // 
            this.chartHumidity.BorderlineColor = System.Drawing.Color.DeepSkyBlue;
            this.chartHumidity.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.Name = "ChartArea1";
            chartArea5.ShadowColor = System.Drawing.Color.White;
            this.chartHumidity.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartHumidity.Legends.Add(legend5);
            this.chartHumidity.Location = new System.Drawing.Point(346, 8);
            this.chartHumidity.Name = "chartHumidity";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Internal";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "External";
            this.chartHumidity.Series.Add(series9);
            this.chartHumidity.Series.Add(series10);
            this.chartHumidity.Size = new System.Drawing.Size(488, 174);
            this.chartHumidity.TabIndex = 53;
            this.chartHumidity.Text = "Humidity";
            title5.Name = "Humidity";
            title5.Text = "Humidity";
            this.chartHumidity.Titles.Add(title5);
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
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(87, 20);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(4, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 98;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage1);
            this.metroTabControl2.Controls.Add(this.metroTabPage2);
            this.metroTabControl2.Controls.Add(this.metroTabPage4);
            this.metroTabControl2.Controls.Add(this.metroTabPage7);
            this.metroTabControl2.Controls.Add(this.metroTabPage6);
            this.metroTabControl2.Controls.Add(this.metroTabPage5);
            this.metroTabControl2.Controls.Add(this.metroTabPage3);
            this.metroTabControl2.Controls.Add(this.metroTabPage8);
            this.metroTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl2.Location = new System.Drawing.Point(20, 110);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 7;
            this.metroTabControl2.Size = new System.Drawing.Size(842, 586);
            this.metroTabControl2.TabIndex = 100;
            this.metroTabControl2.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.AutoScroll = true;
            this.metroTabPage1.Controls.Add(this.metroButton12);
            this.metroTabPage1.Controls.Add(this.metroButton11);
            this.metroTabPage1.Controls.Add(this.metroButton10);
            this.metroTabPage1.Controls.Add(this.metroButton9);
            this.metroTabPage1.Controls.Add(this.metroButton8);
            this.metroTabPage1.Controls.Add(this.metroButton7);
            this.metroTabPage1.Controls.Add(this.metroButton6);
            this.metroTabPage1.Controls.Add(this.metroButton4);
            this.metroTabPage1.Controls.Add(this.metroRadioButton4);
            this.metroTabPage1.Controls.Add(this.metroRadioButton5);
            this.metroTabPage1.Controls.Add(this.metroCheckBox4);
            this.metroTabPage1.Controls.Add(this.metroCheckBox5);
            this.metroTabPage1.Controls.Add(this.metroLabel21);
            this.metroTabPage1.Controls.Add(this.metroLabel22);
            this.metroTabPage1.Controls.Add(this.metroRadioButton6);
            this.metroTabPage1.Controls.Add(this.metroCheckBox6);
            this.metroTabPage1.Controls.Add(this.metroLink4);
            this.metroTabPage1.Controls.Add(this.metroLink3);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.metroLink1);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.metroButton3);
            this.metroTabPage1.Controls.Add(this.metroButton2);
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.metroTileSwitch);
            this.metroTabPage1.Controls.Add(this.metroTile2);
            this.metroTabPage1.Controls.Add(this.metroTile1);
            this.metroTabPage1.HorizontalScrollbar = true;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Padding = new System.Windows.Forms.Padding(25);
            this.metroTabPage1.Size = new System.Drawing.Size(834, 544);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Tiles && Buttons";
            this.metroTabPage1.VerticalScrollbar = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroButton12
            // 
            this.metroButton12.Location = new System.Drawing.Point(253, 410);
            this.metroButton12.Name = "metroButton12";
            this.metroButton12.Size = new System.Drawing.Size(154, 42);
            this.metroButton12.TabIndex = 32;
            this.metroButton12.Text = "Default";
            this.metroButton12.UseSelectable = true;
            // 
            // metroButton11
            // 
            this.metroButton11.Location = new System.Drawing.Point(470, 296);
            this.metroButton11.Name = "metroButton11";
            this.metroButton11.Size = new System.Drawing.Size(154, 42);
            this.metroButton11.TabIndex = 31;
            this.metroButton11.Text = "Retry Cancel";
            this.metroButton11.UseSelectable = true;
            // 
            // metroButton10
            // 
            this.metroButton10.Location = new System.Drawing.Point(29, 350);
            this.metroButton10.Name = "metroButton10";
            this.metroButton10.Size = new System.Drawing.Size(154, 42);
            this.metroButton10.TabIndex = 30;
            this.metroButton10.Text = "Ok Cancel";
            this.metroButton10.UseSelectable = true;
            // 
            // metroButton9
            // 
            this.metroButton9.Location = new System.Drawing.Point(470, 350);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(154, 42);
            this.metroButton9.TabIndex = 29;
            this.metroButton9.Text = "Abort Retry Ignore";
            this.metroButton9.UseSelectable = true;
            // 
            // metroButton8
            // 
            this.metroButton8.Location = new System.Drawing.Point(253, 350);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(154, 42);
            this.metroButton8.TabIndex = 28;
            this.metroButton8.Text = "Yes No Cancel";
            this.metroButton8.UseSelectable = true;
            // 
            // metroButton7
            // 
            this.metroButton7.Location = new System.Drawing.Point(253, 296);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(154, 42);
            this.metroButton7.TabIndex = 27;
            this.metroButton7.Text = "Yes No";
            this.metroButton7.UseSelectable = true;
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(29, 296);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(154, 42);
            this.metroButton6.TabIndex = 26;
            this.metroButton6.Text = "Ok";
            this.metroButton6.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(232, 25);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(75, 23);
            this.metroButton4.TabIndex = 25;
            this.metroButton4.Text = "metroButton4";
            this.metroButton4.UseSelectable = true;
            // 
            // metroRadioButton4
            // 
            this.metroRadioButton4.AutoSize = true;
            this.metroRadioButton4.Enabled = false;
            this.metroRadioButton4.Location = new System.Drawing.Point(497, 261);
            this.metroRadioButton4.Name = "metroRadioButton4";
            this.metroRadioButton4.Size = new System.Drawing.Size(137, 15);
            this.metroRadioButton4.TabIndex = 23;
            this.metroRadioButton4.TabStop = true;
            this.metroRadioButton4.Text = "Disabled Radiobutton";
            this.metroRadioButton4.UseSelectable = true;
            // 
            // metroRadioButton5
            // 
            this.metroRadioButton5.AutoSize = true;
            this.metroRadioButton5.Location = new System.Drawing.Point(497, 240);
            this.metroRadioButton5.Name = "metroRadioButton5";
            this.metroRadioButton5.Size = new System.Drawing.Size(124, 15);
            this.metroRadioButton5.TabIndex = 22;
            this.metroRadioButton5.TabStop = true;
            this.metroRadioButton5.Text = "Styled Radiobutton";
            this.metroRadioButton5.UseSelectable = true;
            this.metroRadioButton5.UseStyleColors = true;
            // 
            // metroCheckBox4
            // 
            this.metroCheckBox4.AutoSize = true;
            this.metroCheckBox4.Enabled = false;
            this.metroCheckBox4.Location = new System.Drawing.Point(497, 154);
            this.metroCheckBox4.Name = "metroCheckBox4";
            this.metroCheckBox4.Size = new System.Drawing.Size(123, 15);
            this.metroCheckBox4.TabIndex = 21;
            this.metroCheckBox4.Text = "Disabled Checkbox";
            this.metroCheckBox4.UseSelectable = true;
            // 
            // metroCheckBox5
            // 
            this.metroCheckBox5.AutoSize = true;
            this.metroCheckBox5.Location = new System.Drawing.Point(497, 133);
            this.metroCheckBox5.Name = "metroCheckBox5";
            this.metroCheckBox5.Size = new System.Drawing.Size(110, 15);
            this.metroCheckBox5.TabIndex = 20;
            this.metroCheckBox5.Text = "Styled Checkbox";
            this.metroCheckBox5.UseSelectable = true;
            this.metroCheckBox5.UseStyleColors = true;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(497, 192);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(117, 19);
            this.metroLabel21.TabIndex = 19;
            this.metroLabel21.Text = "MetroRadioButton";
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Location = new System.Drawing.Point(512, 68);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(102, 19);
            this.metroLabel22.TabIndex = 18;
            this.metroLabel22.Text = "MetroCheckBox";
            // 
            // metroRadioButton6
            // 
            this.metroRadioButton6.AutoSize = true;
            this.metroRadioButton6.Location = new System.Drawing.Point(497, 219);
            this.metroRadioButton6.Name = "metroRadioButton6";
            this.metroRadioButton6.Size = new System.Drawing.Size(132, 15);
            this.metroRadioButton6.TabIndex = 17;
            this.metroRadioButton6.TabStop = true;
            this.metroRadioButton6.Text = "Normal Radiobutton";
            this.metroRadioButton6.UseSelectable = true;
            // 
            // metroCheckBox6
            // 
            this.metroCheckBox6.AutoSize = true;
            this.metroCheckBox6.Location = new System.Drawing.Point(497, 112);
            this.metroCheckBox6.Name = "metroCheckBox6";
            this.metroCheckBox6.Size = new System.Drawing.Size(118, 15);
            this.metroCheckBox6.TabIndex = 16;
            this.metroCheckBox6.Text = "Normal Checkbox";
            this.metroCheckBox6.UseSelectable = true;
            // 
            // metroLink4
            // 
            this.metroLink4.Enabled = false;
            this.metroLink4.Location = new System.Drawing.Point(369, 183);
            this.metroLink4.Name = "metroLink4";
            this.metroLink4.Size = new System.Drawing.Size(95, 23);
            this.metroLink4.TabIndex = 15;
            this.metroLink4.Text = "Disabled Link";
            this.metroLink4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink4.UseSelectable = true;
            // 
            // metroLink3
            // 
            this.metroLink3.Location = new System.Drawing.Point(369, 154);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(95, 23);
            this.metroLink3.TabIndex = 14;
            this.metroLink3.Text = "Styled Link";
            this.metroLink3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink3.UseSelectable = true;
            this.metroLink3.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(369, 103);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(67, 19);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "MetroLink";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(225, 65);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(83, 19);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "MetroButton";
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(369, 125);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(95, 23);
            this.metroLink1.TabIndex = 10;
            this.metroLink1.Text = "Normal Link";
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "MetroTile";
            // 
            // metroButton3
            // 
            this.metroButton3.Enabled = false;
            this.metroButton3.Location = new System.Drawing.Point(210, 189);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(127, 37);
            this.metroButton3.TabIndex = 7;
            this.metroButton3.Text = "Disabled Button";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(210, 146);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(127, 37);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Highlighted Button";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton1.Location = new System.Drawing.Point(210, 103);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(98, 24);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Normal Button";
            this.metroButton1.UseSelectable = true;
            // 
            // metroTileSwitch
            // 
            this.metroTileSwitch.ActiveControl = null;
            this.metroTileSwitch.Location = new System.Drawing.Point(29, 189);
            this.metroTileSwitch.Name = "metroTileSwitch";
            this.metroTileSwitch.Size = new System.Drawing.Size(166, 80);
            this.metroTileSwitch.TabIndex = 4;
            this.metroTileSwitch.Text = "Switch Style";
            this.metroTileSwitch.UseSelectable = true;
            this.metroTileSwitch.Click += new System.EventHandler(this.metroTileSwitch_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Enabled = false;
            this.metroTile2.Location = new System.Drawing.Point(115, 103);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(80, 80);
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Disabled";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(29, 103);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(80, 80);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Switch Theme";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroDateTime2);
            this.metroTabPage2.Controls.Add(this.metroLabel20);
            this.metroTabPage2.Controls.Add(this.metroDateTime3);
            this.metroTabPage2.Controls.Add(this.metroButton5);
            this.metroTabPage2.Controls.Add(this.metroComboBox2);
            this.metroTabPage2.Controls.Add(this.metroToggle3);
            this.metroTabPage2.Controls.Add(this.metroToggle2);
            this.metroTabPage2.Controls.Add(this.metroRadioButton3);
            this.metroTabPage2.Controls.Add(this.metroRadioButton2);
            this.metroTabPage2.Controls.Add(this.metroCheckBox3);
            this.metroTabPage2.Controls.Add(this.metroCheckBox2);
            this.metroTabPage2.Controls.Add(this.metroLabel19);
            this.metroTabPage2.Controls.Add(this.metroLabel18);
            this.metroTabPage2.Controls.Add(this.metroLabel17);
            this.metroTabPage2.Controls.Add(this.metroLabel16);
            this.metroTabPage2.Controls.Add(this.metroComboBox1);
            this.metroTabPage2.Controls.Add(this.metroRadioButton1);
            this.metroTabPage2.Controls.Add(this.metroToggle1);
            this.metroTabPage2.Controls.Add(this.metroCheckBox1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Padding = new System.Windows.Forms.Padding(25);
            this.metroTabPage2.Size = new System.Drawing.Size(834, 544);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Options";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Visible = false;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Enabled = false;
            this.metroDateTime2.Location = new System.Drawing.Point(201, 87);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(4, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(213, 29);
            this.metroDateTime2.TabIndex = 20;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(201, 25);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(101, 19);
            this.metroLabel20.TabIndex = 19;
            this.metroLabel20.Text = "MetroDateTime";
            // 
            // metroDateTime3
            // 
            this.metroDateTime3.Location = new System.Drawing.Point(201, 51);
            this.metroDateTime3.MinimumSize = new System.Drawing.Size(4, 29);
            this.metroDateTime3.Name = "metroDateTime3";
            this.metroDateTime3.Size = new System.Drawing.Size(213, 29);
            this.metroDateTime3.TabIndex = 18;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(453, 51);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(123, 29);
            this.metroButton5.TabIndex = 17;
            this.metroButton5.Text = "&Show Context Menu";
            this.metroButton5.UseSelectable = true;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.Enabled = false;
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "Normal Combobox"});
            this.metroComboBox2.Location = new System.Drawing.Point(201, 200);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(213, 29);
            this.metroComboBox2.TabIndex = 16;
            this.metroComboBox2.UseSelectable = true;
            // 
            // metroToggle3
            // 
            this.metroToggle3.AutoSize = true;
            this.metroToggle3.DisplayStatus = false;
            this.metroToggle3.Enabled = false;
            this.metroToggle3.Location = new System.Drawing.Point(483, 212);
            this.metroToggle3.Name = "metroToggle3";
            this.metroToggle3.Size = new System.Drawing.Size(50, 17);
            this.metroToggle3.TabIndex = 15;
            this.metroToggle3.Text = "Off";
            this.metroToggle3.UseSelectable = true;
            // 
            // metroToggle2
            // 
            this.metroToggle2.AutoSize = true;
            this.metroToggle2.DisplayStatus = false;
            this.metroToggle2.Location = new System.Drawing.Point(483, 189);
            this.metroToggle2.Name = "metroToggle2";
            this.metroToggle2.Size = new System.Drawing.Size(50, 17);
            this.metroToggle2.TabIndex = 14;
            this.metroToggle2.Text = "Off";
            this.metroToggle2.UseSelectable = true;
            this.metroToggle2.UseStyleColors = true;
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Enabled = false;
            this.metroRadioButton3.Location = new System.Drawing.Point(18, 202);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(137, 15);
            this.metroRadioButton3.TabIndex = 13;
            this.metroRadioButton3.TabStop = true;
            this.metroRadioButton3.Text = "Disabled Radiobutton";
            this.metroRadioButton3.UseSelectable = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(18, 181);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(124, 15);
            this.metroRadioButton2.TabIndex = 12;
            this.metroRadioButton2.TabStop = true;
            this.metroRadioButton2.Text = "Styled Radiobutton";
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.UseStyleColors = true;
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.Enabled = false;
            this.metroCheckBox3.Location = new System.Drawing.Point(18, 95);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(123, 15);
            this.metroCheckBox3.TabIndex = 11;
            this.metroCheckBox3.Text = "Disabled Checkbox";
            this.metroCheckBox3.UseSelectable = true;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(18, 74);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(110, 15);
            this.metroCheckBox2.TabIndex = 10;
            this.metroCheckBox2.Text = "Styled Checkbox";
            this.metroCheckBox2.UseSelectable = true;
            this.metroCheckBox2.UseStyleColors = true;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(453, 139);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(86, 19);
            this.metroLabel19.TabIndex = 9;
            this.metroLabel19.Text = "MetroToggle";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(18, 133);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(117, 19);
            this.metroLabel18.TabIndex = 8;
            this.metroLabel18.Text = "MetroRadioButton";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(201, 143);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(112, 19);
            this.metroLabel17.TabIndex = 7;
            this.metroLabel17.Text = "MetroComboBox";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(18, 25);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(102, 19);
            this.metroLabel16.TabIndex = 6;
            this.metroLabel16.Text = "MetroCheckBox";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Normal Combobox 1",
            "Normal Combobox 2",
            "Normal Combobox 3",
            "Normal Combobox 4"});
            this.metroComboBox1.Location = new System.Drawing.Point(201, 165);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.PromptText = "Prompted ComboBox";
            this.metroComboBox1.Size = new System.Drawing.Size(213, 29);
            this.metroComboBox1.TabIndex = 5;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(18, 160);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(132, 15);
            this.metroRadioButton1.TabIndex = 4;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "Normal Radiobutton";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(453, 166);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 3;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(18, 53);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(118, 15);
            this.metroCheckBox1.TabIndex = 2;
            this.metroCheckBox1.Text = "Normal Checkbox";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.metroLabel7);
            this.metroTabPage4.Controls.Add(this.metroProgressSpinner3);
            this.metroTabPage4.Controls.Add(this.metroProgressSpinner2);
            this.metroTabPage4.Controls.Add(this.metroLabel6);
            this.metroTabPage4.Controls.Add(this.metroLabel5);
            this.metroTabPage4.Controls.Add(this.metroProgressBar1);
            this.metroTabPage4.Controls.Add(this.metroLabel4);
            this.metroTabPage4.Controls.Add(this.metroScrollBar1);
            this.metroTabPage4.Controls.Add(this.metroTrackBar1);
            this.metroTabPage4.Controls.Add(this.metroProgressSpinner1);
            this.metroTabPage4.Controls.Add(this.metroProgressBar);
            this.metroTabPage4.Controls.Add(this.metroTextBox4);
            this.metroTabPage4.Controls.Add(this.metroTextBox3);
            this.metroTabPage4.Controls.Add(this.metroTextBox2);
            this.metroTabPage4.Controls.Add(this.metroLabel15);
            this.metroTabPage4.Controls.Add(this.metroLabel12);
            this.metroTabPage4.Controls.Add(this.metroLabel13);
            this.metroTabPage4.Controls.Add(this.metroLabel14);
            this.metroTabPage4.Controls.Add(this.metroLabel11);
            this.metroTabPage4.Controls.Add(this.metroLabel10);
            this.metroTabPage4.Controls.Add(this.metroLabel3);
            this.metroTabPage4.Controls.Add(this.metroTextBox1);
            this.metroTabPage4.Controls.Add(this.metroLabel2);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Padding = new System.Windows.Forms.Padding(25);
            this.metroTabPage4.Size = new System.Drawing.Size(834, 544);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Labels && Text";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            this.metroTabPage4.Visible = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(28, 387);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(97, 19);
            this.metroLabel7.TabIndex = 24;
            this.metroLabel7.Text = "MetroScrollBar";
            // 
            // metroProgressSpinner3
            // 
            this.metroProgressSpinner3.Location = new System.Drawing.Point(345, 346);
            this.metroProgressSpinner3.Maximum = 100;
            this.metroProgressSpinner3.Name = "metroProgressSpinner3";
            this.metroProgressSpinner3.Size = new System.Drawing.Size(23, 23);
            this.metroProgressSpinner3.TabIndex = 23;
            this.metroProgressSpinner3.UseSelectable = true;
            this.metroProgressSpinner3.Value = 50;
            // 
            // metroProgressSpinner2
            // 
            this.metroProgressSpinner2.Location = new System.Drawing.Point(316, 346);
            this.metroProgressSpinner2.Maximum = 100;
            this.metroProgressSpinner2.Name = "metroProgressSpinner2";
            this.metroProgressSpinner2.Size = new System.Drawing.Size(23, 23);
            this.metroProgressSpinner2.TabIndex = 22;
            this.metroProgressSpinner2.UseSelectable = true;
            this.metroProgressSpinner2.Value = 25;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(287, 324);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(140, 19);
            this.metroLabel6.TabIndex = 21;
            this.metroLabel6.Text = "MetroProgressSpinner";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(28, 324);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(96, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "MetroTrackBar";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar1.Location = new System.Drawing.Point(28, 276);
            this.metroProgressBar1.MinimumSize = new System.Drawing.Size(500, 23);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBar1.Size = new System.Drawing.Size(665, 23);
            this.metroProgressBar1.TabIndex = 19;
            this.metroProgressBar1.Value = 25;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 225);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(116, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "MetroProgressBar";
            // 
            // metroScrollBar1
            // 
            this.metroScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroScrollBar1.LargeChange = 10;
            this.metroScrollBar1.Location = new System.Drawing.Point(31, 409);
            this.metroScrollBar1.Maximum = 100;
            this.metroScrollBar1.Minimum = 0;
            this.metroScrollBar1.MinimumSize = new System.Drawing.Size(500, 23);
            this.metroScrollBar1.MouseWheelBarPartitions = 10;
            this.metroScrollBar1.Name = "metroScrollBar1";
            this.metroScrollBar1.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal;
            this.metroScrollBar1.ScrollbarSize = 23;
            this.metroScrollBar1.Size = new System.Drawing.Size(665, 23);
            this.metroScrollBar1.TabIndex = 17;
            this.metroScrollBar1.UseBarColor = true;
            this.metroScrollBar1.UseSelectable = true;
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(28, 346);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(237, 23);
            this.metroTrackBar1.TabIndex = 16;
            this.metroTrackBar1.Text = "metroTrackBar1";
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(287, 346);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(23, 23);
            this.metroProgressSpinner1.TabIndex = 15;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // metroProgressBar
            // 
            this.metroProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar.Enabled = false;
            this.metroProgressBar.Location = new System.Drawing.Point(28, 247);
            this.metroProgressBar.MinimumSize = new System.Drawing.Size(500, 23);
            this.metroProgressBar.Name = "metroProgressBar";
            this.metroProgressBar.Size = new System.Drawing.Size(665, 23);
            this.metroProgressBar.TabIndex = 14;
            this.metroProgressBar.Value = 25;
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.Enabled = false;
            this.metroTextBox4.Lines = new string[] {
        "Disabled Textbox"};
            this.metroTextBox4.Location = new System.Drawing.Point(342, 106);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.Size = new System.Drawing.Size(171, 22);
            this.metroTextBox4.TabIndex = 13;
            this.metroTextBox4.Text = "Disabled Textbox";
            this.metroTextBox4.UseSelectable = true;
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Lines = new string[] {
        "Multiline Textbox"};
            this.metroTextBox3.Location = new System.Drawing.Point(342, 134);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Multiline = true;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.Size = new System.Drawing.Size(171, 91);
            this.metroTextBox3.TabIndex = 12;
            this.metroTextBox3.Text = "Multiline Textbox";
            this.metroTextBox3.UseSelectable = true;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.IconRight = true;
            this.metroTextBox2.Lines = new string[] {
        "Styled Textbox"};
            this.metroTextBox2.Location = new System.Drawing.Point(342, 78);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.Size = new System.Drawing.Size(171, 22);
            this.metroTextBox2.TabIndex = 11;
            this.metroTextBox2.Text = "Styled Textbox";
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.UseStyleColors = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(342, 25);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(91, 19);
            this.metroLabel15.TabIndex = 10;
            this.metroLabel15.Text = "MetroTextBox";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Enabled = false;
            this.metroLabel12.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.metroLabel12.Location = new System.Drawing.Point(148, 100);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(157, 19);
            this.metroLabel12.TabIndex = 9;
            this.metroLabel12.Text = "Disabled Selectable Label";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.metroLabel13.Location = new System.Drawing.Point(148, 75);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(142, 19);
            this.metroLabel13.TabIndex = 8;
            this.metroLabel13.Text = "Styled Selectable Label";
            this.metroLabel13.UseStyleColors = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.metroLabel14.Location = new System.Drawing.Point(148, 50);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(152, 19);
            this.metroLabel14.TabIndex = 7;
            this.metroLabel14.Text = "Normal Selectable Label";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Enabled = false;
            this.metroLabel11.Location = new System.Drawing.Point(28, 100);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(94, 19);
            this.metroLabel11.TabIndex = 6;
            this.metroLabel11.Text = "Disabled Label";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(28, 75);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(79, 19);
            this.metroLabel10.TabIndex = 5;
            this.metroLabel10.Text = "Styled Label";
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(28, 50);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Normal Label";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTextBox1.Lines = new string[] {
        "Normal Textbox"};
            this.metroTextBox1.Location = new System.Drawing.Point(342, 50);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "With Placeholder support!";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(171, 22);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.Text = "Normal Textbox";
            this.metroTextBox1.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 25);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "MetroLabel";
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.Controls.Add(this.metroGrid1);
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.HorizontalScrollbarSize = 10;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.metroTabPage7.Size = new System.Drawing.Size(834, 544);
            this.metroTabPage7.TabIndex = 6;
            this.metroTabPage7.Text = "Grid";
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeight = 30;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.HighLightPercentage = 0.5F;
            this.metroGrid1.Location = new System.Drawing.Point(0, 5);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(834, 539);
            this.metroGrid1.TabIndex = 2;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.Controls.Add(this.txtNotes);
            this.metroTabPage6.Controls.Add(this.btnSaveOnly);
            this.metroTabPage6.Controls.Add(this.btnSaveData);
            this.metroTabPage6.Controls.Add(this.btnStartExperiment);
            this.metroTabPage6.Controls.Add(this.metroLabel25);
            this.metroTabPage6.Controls.Add(this.metroLabel24);
            this.metroTabPage6.Controls.Add(this.metroLabel23);
            this.metroTabPage6.Controls.Add(this.txtFileName);
            this.metroTabPage6.Controls.Add(this.metroDateTime1);
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
            chartArea6.Name = "ChartArea1";
            this.chartPressure.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartPressure.Legends.Add(legend6);
            this.chartPressure.Location = new System.Drawing.Point(346, 368);
            this.chartPressure.Name = "chartPressure";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Internal";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "External";
            this.chartPressure.Series.Add(series11);
            this.chartPressure.Series.Add(series12);
            this.chartPressure.Size = new System.Drawing.Size(488, 174);
            this.chartPressure.TabIndex = 71;
            this.chartPressure.Text = "chartFreq";
            title6.Name = "Title1";
            title6.Text = "Pressure";
            this.chartPressure.Titles.Add(title6);
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
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            this.metroTabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
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
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton4;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton5;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox5;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton6;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox6;
        private MetroFramework.Controls.MetroLink metroLink4;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTile metroTileSwitch;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroDateTime metroDateTime3;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroToggle metroToggle3;
        private MetroFramework.Controls.MetroToggle metroToggle2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroTabPage metroTabPage8;
        private MetroFramework.Controls.MetroButton btnSaveData;
        private MetroFramework.Controls.MetroButton btnStartExperiment;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroTextBox txtFileName;
        private MetroFramework.Controls.MetroButton metroButton12;
        private MetroFramework.Controls.MetroButton metroButton11;
        private MetroFramework.Controls.MetroButton metroButton10;
        private MetroFramework.Controls.MetroButton metroButton9;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton btnSaveOnly;
        private MetroFramework.Controls.MetroTextBox txtNotes;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner3;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar1;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar;
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
    }
}

