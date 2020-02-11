namespace GroundStation_Mahsa
{
    partial class GroundStation_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroundStation_Form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Port_ComboBox = new System.Windows.Forms.ComboBox();
            this.BaudRate_ComboBox = new System.Windows.Forms.ComboBox();
            this.ConnectionStatus_lbl = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Main_tab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Camera_groupBox = new System.Windows.Forms.GroupBox();
            this.PFD_groupBox = new System.Windows.Forms.GroupBox();
            this.pfdControl1 = new PrimaryFlightDisplay.PFDControl();
            this.GMap1 = new GMap.NET.WindowsForms.GMapControl();
            this.Graphs_tab = new System.Windows.Forms.TabPage();
            this.plotter = new GraphLib.PlotterDisplayEx();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new PrecisionTimer.Timer(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.GPSFixValue_lbl = new System.Windows.Forms.Label();
            this.GPSHDOP_lbl = new System.Windows.Forms.Label();
            this.GPSHDOPValue_lbl = new System.Windows.Forms.Label();
            this.GPSSTATS_lbl = new System.Windows.Forms.Label();
            this.GPSSTATSValue_lbl = new System.Windows.Forms.Label();
            this.ALTMSL_lbl = new System.Windows.Forms.Label();
            this.ALTMSLValue_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.GPSFix_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CONNECT_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Main_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PFD_groupBox.SuspendLayout();
            this.Graphs_tab.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.17095F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.98831F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.98831F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.98831F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.98831F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.887303F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.81658F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.17193F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ConnectionStatus_lbl, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.CONNECT_btn, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1271, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.Port_ComboBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BaudRate_ComboBox, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(767, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(127, 94);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Port_ComboBox
            // 
            this.Port_ComboBox.BackColor = System.Drawing.Color.RosyBrown;
            this.Port_ComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Port_ComboBox.FormattingEnabled = true;
            this.Port_ComboBox.Items.AddRange(new object[] {
            "COM3"});
            this.Port_ComboBox.Location = new System.Drawing.Point(3, 3);
            this.Port_ComboBox.Name = "Port_ComboBox";
            this.Port_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Port_ComboBox.TabIndex = 0;
            this.Port_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Port_ComboBox_SelectedIndexChanged);
            this.Port_ComboBox.SelectedValueChanged += new System.EventHandler(this.Port_ComboBox_SelectedValueChanged);
            // 
            // BaudRate_ComboBox
            // 
            this.BaudRate_ComboBox.BackColor = System.Drawing.Color.RosyBrown;
            this.BaudRate_ComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.BaudRate_ComboBox.FormattingEnabled = true;
            this.BaudRate_ComboBox.Location = new System.Drawing.Point(3, 50);
            this.BaudRate_ComboBox.Name = "BaudRate_ComboBox";
            this.BaudRate_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.BaudRate_ComboBox.TabIndex = 1;
            // 
            // ConnectionStatus_lbl
            // 
            this.ConnectionStatus_lbl.AutoSize = true;
            this.ConnectionStatus_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionStatus_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConnectionStatus_lbl.Location = new System.Drawing.Point(1143, 0);
            this.ConnectionStatus_lbl.Name = "ConnectionStatus_lbl";
            this.ConnectionStatus_lbl.Size = new System.Drawing.Size(125, 100);
            this.ConnectionStatus_lbl.TabIndex = 3;
            this.ConnectionStatus_lbl.Text = "Connection Status";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Main_tab);
            this.tabControl1.Controls.Add(this.Graphs_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1271, 586);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Main_tab
            // 
            this.Main_tab.BackColor = System.Drawing.Color.LightBlue;
            this.Main_tab.Controls.Add(this.splitContainer1);
            this.Main_tab.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Main_tab.Location = new System.Drawing.Point(4, 22);
            this.Main_tab.Name = "Main_tab";
            this.Main_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Main_tab.Size = new System.Drawing.Size(1263, 560);
            this.Main_tab.TabIndex = 0;
            this.Main_tab.Text = "Main";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Camera_groupBox);
            this.splitContainer1.Panel1.Controls.Add(this.PFD_groupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.splitContainer1.Panel2.Controls.Add(this.GMap1);
            this.splitContainer1.Size = new System.Drawing.Size(1257, 554);
            this.splitContainer1.SplitterDistance = 352;
            this.splitContainer1.TabIndex = 0;
            // 
            // Camera_groupBox
            // 
            this.Camera_groupBox.BackColor = System.Drawing.Color.RosyBrown;
            this.Camera_groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Camera_groupBox.Location = new System.Drawing.Point(0, 271);
            this.Camera_groupBox.Name = "Camera_groupBox";
            this.Camera_groupBox.Size = new System.Drawing.Size(352, 280);
            this.Camera_groupBox.TabIndex = 1;
            this.Camera_groupBox.TabStop = false;
            this.Camera_groupBox.Text = "Camera";
            // 
            // PFD_groupBox
            // 
            this.PFD_groupBox.BackColor = System.Drawing.Color.RosyBrown;
            this.PFD_groupBox.Controls.Add(this.pfdControl1);
            this.PFD_groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PFD_groupBox.Location = new System.Drawing.Point(0, 0);
            this.PFD_groupBox.Name = "PFD_groupBox";
            this.PFD_groupBox.Size = new System.Drawing.Size(352, 271);
            this.PFD_groupBox.TabIndex = 0;
            this.PFD_groupBox.TabStop = false;
            this.PFD_groupBox.Text = "PFD";
            // 
            // pfdControl1
            // 
            this.pfdControl1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pfdControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfdControl1.Location = new System.Drawing.Point(3, 16);
            this.pfdControl1.Name = "pfdControl1";
            this.pfdControl1.Size = new System.Drawing.Size(346, 252);
            this.pfdControl1.TabIndex = 0;
            // 
            // GMap1
            // 
            this.GMap1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GMap1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.GMap1.Bearing = 0F;
            this.GMap1.CanDragMap = true;
            this.GMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GMap1.GrayScaleMode = false;
            this.GMap1.LevelsKeepInMemmory = 5;
            this.GMap1.Location = new System.Drawing.Point(0, 0);
            this.GMap1.MarkersEnabled = true;
            this.GMap1.MaxZoom = 19;
            this.GMap1.MinZoom = 2;
            this.GMap1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GMap1.Name = "GMap1";
            this.GMap1.NegativeMode = false;
            this.GMap1.PolygonsEnabled = true;
            this.GMap1.RetryLoadTile = 0;
            this.GMap1.RoutesEnabled = true;
            this.GMap1.ShowTileGridLines = false;
            this.GMap1.Size = new System.Drawing.Size(901, 554);
            this.GMap1.TabIndex = 0;
            this.GMap1.Zoom = 2D;
            // 
            // Graphs_tab
            // 
            this.Graphs_tab.BackColor = System.Drawing.Color.LightBlue;
            this.Graphs_tab.Controls.Add(this.tableLayoutPanel4);
            this.Graphs_tab.Location = new System.Drawing.Point(4, 22);
            this.Graphs_tab.Name = "Graphs_tab";
            this.Graphs_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Graphs_tab.Size = new System.Drawing.Size(1263, 560);
            this.Graphs_tab.TabIndex = 1;
            this.Graphs_tab.Text = "Sensors & Graphs";
            // 
            // plotter
            // 
            this.plotter.BackColor = System.Drawing.Color.Transparent;
            this.plotter.BackgroundColorBot = System.Drawing.Color.White;
            this.plotter.BackgroundColorTop = System.Drawing.Color.White;
            this.plotter.DashedGridColor = System.Drawing.Color.DarkGray;
            this.plotter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotter.DoubleBuffering = false;
            this.plotter.Location = new System.Drawing.Point(3, 113);
            this.plotter.Name = "plotter";
            this.plotter.PlaySpeed = 0.5F;
            this.plotter.Size = new System.Drawing.Size(1251, 438);
            this.plotter.SolidGridColor = System.Drawing.Color.DarkGray;
            this.plotter.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.serialPort1_PinChanged);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Mode = PrecisionTimer.Mode.Periodic;
            this.timer2.Period = 1;
            this.timer2.Resolution = 1;
            this.timer2.SynchronizingObject = null;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.plotter, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1257, 554);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.RosyBrown;
            this.tableLayoutPanel3.ColumnCount = 10;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.GPSFixValue_lbl, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.GPSHDOP_lbl, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.GPSHDOPValue_lbl, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.GPSSTATS_lbl, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.GPSSTATSValue_lbl, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.ALTMSL_lbl, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.ALTMSLValue_lbl, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 9, 0);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label12, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label13, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label14, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label15, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.label16, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.label17, 6, 1);
            this.tableLayoutPanel3.Controls.Add(this.label18, 7, 1);
            this.tableLayoutPanel3.Controls.Add(this.label19, 8, 1);
            this.tableLayoutPanel3.Controls.Add(this.label20, 9, 1);
            this.tableLayoutPanel3.Controls.Add(this.label21, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label22, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label23, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label24, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.label25, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.label26, 5, 2);
            this.tableLayoutPanel3.Controls.Add(this.label27, 6, 2);
            this.tableLayoutPanel3.Controls.Add(this.label28, 7, 2);
            this.tableLayoutPanel3.Controls.Add(this.label29, 8, 2);
            this.tableLayoutPanel3.Controls.Add(this.label30, 9, 2);
            this.tableLayoutPanel3.Controls.Add(this.label31, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label32, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label33, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.label34, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.label35, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.label36, 5, 3);
            this.tableLayoutPanel3.Controls.Add(this.GPSFix_lbl, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1251, 104);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // GPSFixValue_lbl
            // 
            this.GPSFixValue_lbl.AutoSize = true;
            this.GPSFixValue_lbl.Location = new System.Drawing.Point(128, 0);
            this.GPSFixValue_lbl.Name = "GPSFixValue_lbl";
            this.GPSFixValue_lbl.Size = new System.Drawing.Size(34, 13);
            this.GPSFixValue_lbl.TabIndex = 1;
            this.GPSFixValue_lbl.Text = "Value";
            // 
            // GPSHDOP_lbl
            // 
            this.GPSHDOP_lbl.AutoSize = true;
            this.GPSHDOP_lbl.Location = new System.Drawing.Point(253, 0);
            this.GPSHDOP_lbl.Name = "GPSHDOP_lbl";
            this.GPSHDOP_lbl.Size = new System.Drawing.Size(75, 13);
            this.GPSHDOP_lbl.TabIndex = 2;
            this.GPSHDOP_lbl.Text = "GPS HDOP ( )";
            // 
            // GPSHDOPValue_lbl
            // 
            this.GPSHDOPValue_lbl.AutoSize = true;
            this.GPSHDOPValue_lbl.Location = new System.Drawing.Point(378, 0);
            this.GPSHDOPValue_lbl.Name = "GPSHDOPValue_lbl";
            this.GPSHDOPValue_lbl.Size = new System.Drawing.Size(34, 13);
            this.GPSHDOPValue_lbl.TabIndex = 3;
            this.GPSHDOPValue_lbl.Text = "Value";
            // 
            // GPSSTATS_lbl
            // 
            this.GPSSTATS_lbl.AutoSize = true;
            this.GPSSTATS_lbl.Location = new System.Drawing.Point(503, 0);
            this.GPSSTATS_lbl.Name = "GPSSTATS_lbl";
            this.GPSSTATS_lbl.Size = new System.Drawing.Size(82, 13);
            this.GPSSTATS_lbl.TabIndex = 4;
            this.GPSSTATS_lbl.Text = "GPS STATS (n)";
            // 
            // GPSSTATSValue_lbl
            // 
            this.GPSSTATSValue_lbl.AutoSize = true;
            this.GPSSTATSValue_lbl.Location = new System.Drawing.Point(628, 0);
            this.GPSSTATSValue_lbl.Name = "GPSSTATSValue_lbl";
            this.GPSSTATSValue_lbl.Size = new System.Drawing.Size(34, 13);
            this.GPSSTATSValue_lbl.TabIndex = 5;
            this.GPSSTATSValue_lbl.Text = "Value";
            // 
            // ALTMSL_lbl
            // 
            this.ALTMSL_lbl.AutoSize = true;
            this.ALTMSL_lbl.Location = new System.Drawing.Point(753, 0);
            this.ALTMSL_lbl.Name = "ALTMSL_lbl";
            this.ALTMSL_lbl.Size = new System.Drawing.Size(69, 13);
            this.ALTMSL_lbl.TabIndex = 6;
            this.ALTMSL_lbl.Text = "ALT MSL (m)";
            // 
            // ALTMSLValue_lbl
            // 
            this.ALTMSLValue_lbl.AutoSize = true;
            this.ALTMSLValue_lbl.Location = new System.Drawing.Point(878, 0);
            this.ALTMSLValue_lbl.Name = "ALTMSLValue_lbl";
            this.ALTMSLValue_lbl.Size = new System.Drawing.Size(34, 13);
            this.ALTMSLValue_lbl.TabIndex = 7;
            this.ALTMSLValue_lbl.Text = "Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1003, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "ALt REL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1128, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Battery";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(128, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Value";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(253, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Climb ( m/s )";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(378, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Value";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(503, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Current";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(628, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Value";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(753, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Pitch ( deg )";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(878, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Value";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1003, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Roll ( deg )";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1128, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "Value";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 52);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Yaw ( deg )";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(128, 52);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "Value";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(253, 52);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "Pressure";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(378, 52);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 13);
            this.label24.TabIndex = 23;
            this.label24.Text = "Value";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(503, 52);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 13);
            this.label25.TabIndex = 24;
            this.label25.Text = "Air Quality";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(628, 52);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 13);
            this.label26.TabIndex = 25;
            this.label26.Text = "Value";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(753, 52);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 13);
            this.label27.TabIndex = 26;
            this.label27.Text = "Humidity";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(878, 52);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(34, 13);
            this.label28.TabIndex = 27;
            this.label28.Text = "Value";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(1003, 52);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(22, 13);
            this.label29.TabIndex = 28;
            this.label29.Text = "UV";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(1128, 52);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(34, 13);
            this.label30.TabIndex = 29;
            this.label30.Text = "Value";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 78);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(67, 13);
            this.label31.TabIndex = 30;
            this.label31.Text = "Temperature";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(128, 78);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(34, 13);
            this.label32.TabIndex = 31;
            this.label32.Text = "Value";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(253, 78);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(94, 13);
            this.label33.TabIndex = 32;
            this.label33.Text = "Horizontal Velocity";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(378, 78);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(34, 13);
            this.label34.TabIndex = 33;
            this.label34.Text = "Value";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(503, 78);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(82, 13);
            this.label35.TabIndex = 34;
            this.label35.Text = "Vertical Velocity";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(628, 78);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(34, 13);
            this.label36.TabIndex = 35;
            this.label36.Text = "Value";
            // 
            // GPSFix_lbl
            // 
            this.GPSFix_lbl.AutoSize = true;
            this.GPSFix_lbl.Location = new System.Drawing.Point(3, 0);
            this.GPSFix_lbl.Name = "GPSFix_lbl";
            this.GPSFix_lbl.Size = new System.Drawing.Size(57, 13);
            this.GPSFix_lbl.TabIndex = 0;
            this.GPSFix_lbl.Text = "GPS Fix ( )";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GroundStation_Mahsa.Properties.Resources.Pluse;
            this.pictureBox1.InitialImage = global::GroundStation_Mahsa.Properties.Resources.Pluse;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CONNECT_btn
            // 
            this.CONNECT_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.CONNECT_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONNECT_btn.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CONNECT_btn.Image = ((System.Drawing.Image)(resources.GetObject("CONNECT_btn.Image")));
            this.CONNECT_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CONNECT_btn.Location = new System.Drawing.Point(602, 3);
            this.CONNECT_btn.Name = "CONNECT_btn";
            this.CONNECT_btn.Size = new System.Drawing.Size(159, 94);
            this.CONNECT_btn.TabIndex = 2;
            this.CONNECT_btn.Text = "CONNECT";
            this.CONNECT_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CONNECT_btn.UseVisualStyleBackColor = false;
            this.CONNECT_btn.Click += new System.EventHandler(this.CONNECT_btn_Click);
            // 
            // GroundStation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1271, 686);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GroundStation_Form";
            this.Text = "AUT∞SPACE Ground Station";
            this.Load += new System.EventHandler(this.GroundStation_Form_Load);
            this.Shown += new System.EventHandler(this.GroundStation_Form_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Main_tab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PFD_groupBox.ResumeLayout(false);
            this.Graphs_tab.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox Port_ComboBox;
        private System.Windows.Forms.ComboBox BaudRate_ComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CONNECT_btn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Graphs_tab;
        private System.Windows.Forms.TabPage Main_tab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox Camera_groupBox;
        private System.Windows.Forms.GroupBox PFD_groupBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label ConnectionStatus_lbl;
        private System.Windows.Forms.Timer timer1;
        public GMap.NET.WindowsForms.GMapControl GMap1;
        private PrimaryFlightDisplay.PFDControl pfdControl1;
        private GraphLib.PlotterDisplayEx plotter;
        private PrecisionTimer.Timer timer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label GPSFixValue_lbl;
        private System.Windows.Forms.Label GPSHDOP_lbl;
        private System.Windows.Forms.Label GPSHDOPValue_lbl;
        private System.Windows.Forms.Label GPSSTATS_lbl;
        private System.Windows.Forms.Label GPSSTATSValue_lbl;
        private System.Windows.Forms.Label ALTMSL_lbl;
        private System.Windows.Forms.Label ALTMSLValue_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label GPSFix_lbl;
    }
}

