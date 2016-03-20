namespace WIFIGUIDemo
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdDisconnect = new System.Windows.Forms.Button();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.lbPort = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblwantedangle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btngetheading = new System.Windows.Forms.Button();
            this.btnturn = new System.Windows.Forms.Button();
            this.txtturnangle = new System.Windows.Forms.TextBox();
            this.lblangle = new System.Windows.Forms.Label();
            this.MagCalStop = new System.Windows.Forms.Button();
            this.MagCalStart = new System.Windows.Forms.Button();
            this.checkMag = new System.Windows.Forms.CheckBox();
            this.AngleLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblmotorspeed = new System.Windows.Forms.Label();
            this.scrlspeed = new System.Windows.Forms.HScrollBar();
            this.btnstopmotors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnforward = new System.Windows.Forms.Button();
            this.txtgodistance = new System.Windows.Forms.TextBox();
            this.btngodistance = new System.Windows.Forms.Button();
            this.btnsetnorth = new System.Windows.Forms.Button();
            this.btngetmotorpos = new System.Windows.Forms.Button();
            this.lblrightmotorpos = new System.Windows.Forms.Label();
            this.lblloftmotorpos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSwitch2Stat = new System.Windows.Forms.CheckBox();
            this.chkSwitch1Stat = new System.Windows.Forms.CheckBox();
            this.chkGreenStat = new System.Windows.Forms.CheckBox();
            this.chkRedStat = new System.Windows.Forms.CheckBox();
            this.txtCounter = new System.Windows.Forms.TextBox();
            this.chkRed = new System.Windows.Forms.CheckBox();
            this.chkGreen = new System.Windows.Forms.CheckBox();
            this.cmdSwitchLedStatus = new System.Windows.Forms.Button();
            this.cmdGetCount = new System.Windows.Forms.Button();
            this.cmdSetLEDs = new System.Windows.Forms.Button();
            this.tmrmotorpos = new System.Windows.Forms.Timer(this.components);
            this.Rotation = new System.Windows.Forms.TabControl();
            this.tabVortex = new System.Windows.Forms.TabPage();
            this.btnorientexitvortex = new System.Windows.Forms.Button();
            this.btnexitvortex = new System.Windows.Forms.Button();
            this.btnentervortex = new System.Windows.Forms.Button();
            this.btnorientvortexon = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtReset = new System.Windows.Forms.Button();
            this.chartStop = new System.Windows.Forms.Button();
            this.chartStart = new System.Windows.Forms.Button();
            this.tabTeeter = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbllengthHval2 = new System.Windows.Forms.Label();
            this.lbllengthHval = new System.Windows.Forms.Label();
            this.lbllengthCval = new System.Windows.Forms.Label();
            this.lbllengthAval = new System.Windows.Forms.Label();
            this.lblangleMval = new System.Windows.Forms.Label();
            this.lbllengthA = new System.Windows.Forms.Label();
            this.lblangleM = new System.Windows.Forms.Label();
            this.lbllengthC = new System.Windows.Forms.Label();
            this.lnllengthH = new System.Windows.Forms.Label();
            this.lbllengthF = new System.Windows.Forms.Label();
            this.lbllengthFval = new System.Windows.Forms.Label();
            this.btncalcteeter = new System.Windows.Forms.Button();
            this.txtdeclineangle = new System.Windows.Forms.TextBox();
            this.txtinclineangle = new System.Windows.Forms.TextBox();
            this.btnstoredeclineangle = new System.Windows.Forms.Button();
            this.btnstoreinclneangle = new System.Windows.Forms.Button();
            this.chkaccel = new System.Windows.Forms.CheckBox();
            this.lblAccelyG = new System.Windows.Forms.Label();
            this.lblAccelxG = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.LblAccelY = new System.Windows.Forms.Label();
            this.LblAccelX = new System.Windows.Forms.Label();
            this.btnorientteeter = new System.Windows.Forms.Button();
            this.tabearthquake = new System.Windows.Forms.TabPage();
            this.btnselsafterearthquake = new System.Windows.Forms.Button();
            this.btnexitearthquake = new System.Windows.Forms.Button();
            this.btnenterearthquake = new System.Windows.Forms.Button();
            this.btnorientearthquake = new System.Windows.Forms.Button();
            this.btnclearsamples = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbletimercycles = new System.Windows.Forms.Label();
            this.chkesampling = new System.Windows.Forms.CheckBox();
            this.lblearthsamplestaken = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btndumptofile = new System.Windows.Forms.Button();
            this.btnearthquakestop = new System.Windows.Forms.Button();
            this.btnearthquakestart = new System.Windows.Forms.Button();
            this.tablights = new System.Windows.Forms.TabPage();
            this.LightDrawBtn = new System.Windows.Forms.Button();
            this.lightPnl = new System.Windows.Forms.Panel();
            this.lightdTxt = new System.Windows.Forms.TextBox();
            this.lightPathBtn = new System.Windows.Forms.Button();
            this.tabmorse = new System.Windows.Forms.TabPage();
            this.tabtesting = new System.Windows.Forms.TabPage();
            this.lblnorthbearing = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txttestselsb = new System.Windows.Forms.TextBox();
            this.txttestselsc = new System.Windows.Forms.TextBox();
            this.txttestselsd = new System.Windows.Forms.TextBox();
            this.txttestselsa = new System.Windows.Forms.TextBox();
            this.btntestcircle = new System.Windows.Forms.Button();
            this.lblmagzmax = new System.Windows.Forms.Label();
            this.lblmagymax = new System.Windows.Forms.Label();
            this.lblmagxmax = new System.Windows.Forms.Label();
            this.lblmagzmin = new System.Windows.Forms.Label();
            this.lblmagymin = new System.Windows.Forms.Label();
            this.lblmagxmin = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnorientsouth = new System.Windows.Forms.Button();
            this.btnorienteast = new System.Windows.Forms.Button();
            this.btnorientwest = new System.Windows.Forms.Button();
            this.btnorientnorth = new System.Windows.Forms.Button();
            this.btnspin = new System.Windows.Forms.Button();
            this.lblselsb = new System.Windows.Forms.Label();
            this.lblselsc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblselsd = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblselsa = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Turning = new System.Windows.Forms.TabPage();
            this.tmrangle = new System.Windows.Forms.Timer(this.components);
            this.lightTimer = new System.Windows.Forms.Timer(this.components);
            this.extBtn = new System.Windows.Forms.Button();
            this.tmrearthquake = new System.Windows.Forms.Timer(this.components);
            this.btngetsels = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblcoordX = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblcoordY = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picRover = new System.Windows.Forms.PictureBox();
            this.picmorseaproach = new System.Windows.Forms.PictureBox();
            this.picvortex = new System.Windows.Forms.PictureBox();
            this.picearthquake = new System.Windows.Forms.PictureBox();
            this.picimage = new System.Windows.Forms.PictureBox();
            this.pictteeteraproach = new System.Windows.Forms.PictureBox();
            this.picteeter = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.chrtTmr = new System.Windows.Forms.Timer(this.components);
            this.btncalculatepath = new System.Windows.Forms.Button();
            this.txtxwanted = new System.Windows.Forms.TextBox();
            this.txtywanted = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txttravelangle = new System.Windows.Forms.TextBox();
            this.txttraveldistance = new System.Windows.Forms.TextBox();
            this.btnturntravel = new System.Windows.Forms.Button();
            this.btntravelgo = new System.Windows.Forms.Button();
            this.tmraccelerometer = new System.Windows.Forms.Timer(this.components);
            this.chkturning = new System.Windows.Forms.CheckBox();
            this.chktravelling = new System.Windows.Forms.CheckBox();
            this.teeterTmr = new System.Windows.Forms.Timer(this.components);
            this.stopPth = new System.Windows.Forms.Button();
            this.lighttxt2 = new System.Windows.Forms.TextBox();
            this.spinslbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Rotation.SuspendLayout();
            this.tabVortex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabTeeter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabearthquake.SuspendLayout();
            this.tablights.SuspendLayout();
            this.tabtesting.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmorseaproach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvortex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picearthquake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictteeteraproach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picteeter)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdDisconnect);
            this.groupBox1.Controls.Add(this.cmdConnect);
            this.groupBox1.Controls.Add(this.lbPort);
            this.groupBox1.Controls.Add(this.lblIPAddress);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtIPAddress);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // cmdDisconnect
            // 
            this.cmdDisconnect.Location = new System.Drawing.Point(15, 82);
            this.cmdDisconnect.Name = "cmdDisconnect";
            this.cmdDisconnect.Size = new System.Drawing.Size(75, 23);
            this.cmdDisconnect.TabIndex = 5;
            this.cmdDisconnect.Text = "Disconnect";
            this.cmdDisconnect.UseVisualStyleBackColor = true;
            this.cmdDisconnect.Click += new System.EventHandler(this.cmdDisconnect_Click);
            // 
            // cmdConnect
            // 
            this.cmdConnect.Enabled = false;
            this.cmdConnect.Location = new System.Drawing.Point(138, 82);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(75, 23);
            this.cmdConnect.TabIndex = 4;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(12, 57);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(60, 13);
            this.lbPort.TabIndex = 3;
            this.lbPort.Text = "Server Port";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(12, 31);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(92, 13);
            this.lblIPAddress.TabIndex = 2;
            this.lblIPAddress.Text = "Server IP Address";
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(113, 54);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 1;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Enabled = false;
            this.txtIPAddress.Location = new System.Drawing.Point(113, 28);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(100, 20);
            this.txtIPAddress.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblwantedangle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btngetheading);
            this.groupBox2.Controls.Add(this.btnturn);
            this.groupBox2.Controls.Add(this.txtturnangle);
            this.groupBox2.Controls.Add(this.lblangle);
            this.groupBox2.Controls.Add(this.MagCalStop);
            this.groupBox2.Controls.Add(this.MagCalStart);
            this.groupBox2.Controls.Add(this.checkMag);
            this.groupBox2.Controls.Add(this.AngleLabel);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lblmotorspeed);
            this.groupBox2.Controls.Add(this.scrlspeed);
            this.groupBox2.Controls.Add(this.btnstopmotors);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnforward);
            this.groupBox2.Controls.Add(this.txtgodistance);
            this.groupBox2.Controls.Add(this.btngodistance);
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 374);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navigation";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblwantedangle
            // 
            this.lblwantedangle.AutoSize = true;
            this.lblwantedangle.Location = new System.Drawing.Point(177, 179);
            this.lblwantedangle.Name = "lblwantedangle";
            this.lblwantedangle.Size = new System.Drawing.Size(13, 13);
            this.lblwantedangle.TabIndex = 35;
            this.lblwantedangle.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Wanted Angle:";
            // 
            // btngetheading
            // 
            this.btngetheading.Location = new System.Drawing.Point(15, 211);
            this.btngetheading.Name = "btngetheading";
            this.btngetheading.Size = new System.Drawing.Size(75, 23);
            this.btngetheading.TabIndex = 33;
            this.btngetheading.Text = "Get heading";
            this.btngetheading.UseVisualStyleBackColor = true;
            this.btngetheading.Click += new System.EventHandler(this.btngetheading_Click);
            // 
            // btnturn
            // 
            this.btnturn.Location = new System.Drawing.Point(104, 287);
            this.btnturn.Name = "btnturn";
            this.btnturn.Size = new System.Drawing.Size(100, 21);
            this.btnturn.TabIndex = 32;
            this.btnturn.Text = "Turn Angle";
            this.btnturn.UseVisualStyleBackColor = true;
            this.btnturn.Click += new System.EventHandler(this.btnturn_Click);
            // 
            // txtturnangle
            // 
            this.txtturnangle.Location = new System.Drawing.Point(9, 287);
            this.txtturnangle.Name = "txtturnangle";
            this.txtturnangle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtturnangle.Size = new System.Drawing.Size(89, 20);
            this.txtturnangle.TabIndex = 31;
            // 
            // lblangle
            // 
            this.lblangle.AutoSize = true;
            this.lblangle.Location = new System.Drawing.Point(61, 179);
            this.lblangle.Name = "lblangle";
            this.lblangle.Size = new System.Drawing.Size(13, 13);
            this.lblangle.TabIndex = 29;
            this.lblangle.Text = "0";
            // 
            // MagCalStop
            // 
            this.MagCalStop.Location = new System.Drawing.Point(113, 245);
            this.MagCalStop.Name = "MagCalStop";
            this.MagCalStop.Size = new System.Drawing.Size(100, 23);
            this.MagCalStop.TabIndex = 28;
            this.MagCalStop.Text = "Stop Calibration";
            this.MagCalStop.UseVisualStyleBackColor = true;
            this.MagCalStop.Click += new System.EventHandler(this.MagCalStop_Click);
            // 
            // MagCalStart
            // 
            this.MagCalStart.Location = new System.Drawing.Point(113, 211);
            this.MagCalStart.Name = "MagCalStart";
            this.MagCalStart.Size = new System.Drawing.Size(100, 23);
            this.MagCalStart.TabIndex = 27;
            this.MagCalStart.Text = "Start Calibration";
            this.MagCalStart.UseVisualStyleBackColor = true;
            this.MagCalStart.Click += new System.EventHandler(this.MagCalStart_Click);
            // 
            // checkMag
            // 
            this.checkMag.AutoSize = true;
            this.checkMag.Location = new System.Drawing.Point(15, 338);
            this.checkMag.Name = "checkMag";
            this.checkMag.Size = new System.Drawing.Size(77, 17);
            this.checkMag.TabIndex = 26;
            this.checkMag.Text = "checkMag";
            this.checkMag.UseVisualStyleBackColor = true;
            this.checkMag.CheckedChanged += new System.EventHandler(this.checkMag_CheckedChanged);
            // 
            // AngleLabel
            // 
            this.AngleLabel.AutoSize = true;
            this.AngleLabel.Location = new System.Drawing.Point(12, 179);
            this.AngleLabel.Name = "AngleLabel";
            this.AngleLabel.Size = new System.Drawing.Size(37, 13);
            this.AngleLabel.TabIndex = 25;
            this.AngleLabel.Text = "Angle:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 21);
            this.button1.TabIndex = 23;
            this.button1.Text = "Backward";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblmotorspeed
            // 
            this.lblmotorspeed.AutoSize = true;
            this.lblmotorspeed.Location = new System.Drawing.Point(215, 85);
            this.lblmotorspeed.Name = "lblmotorspeed";
            this.lblmotorspeed.Size = new System.Drawing.Size(0, 13);
            this.lblmotorspeed.TabIndex = 22;
            // 
            // scrlspeed
            // 
            this.scrlspeed.Location = new System.Drawing.Point(9, 81);
            this.scrlspeed.Maximum = 127;
            this.scrlspeed.Minimum = 25;
            this.scrlspeed.Name = "scrlspeed";
            this.scrlspeed.Size = new System.Drawing.Size(184, 17);
            this.scrlspeed.TabIndex = 12;
            this.scrlspeed.Value = 40;
            this.scrlspeed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlspeed_Scroll);
            // 
            // btnstopmotors
            // 
            this.btnstopmotors.Location = new System.Drawing.Point(59, 136);
            this.btnstopmotors.Name = "btnstopmotors";
            this.btnstopmotors.Size = new System.Drawing.Size(100, 21);
            this.btnstopmotors.TabIndex = 21;
            this.btnstopmotors.Text = "Stop!";
            this.btnstopmotors.UseVisualStyleBackColor = true;
            this.btnstopmotors.Click += new System.EventHandler(this.btnstopmotors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Motor Speed";
            // 
            // btnforward
            // 
            this.btnforward.Location = new System.Drawing.Point(9, 109);
            this.btnforward.Name = "btnforward";
            this.btnforward.Size = new System.Drawing.Size(100, 21);
            this.btnforward.TabIndex = 15;
            this.btnforward.Text = "Forward";
            this.btnforward.UseVisualStyleBackColor = true;
            this.btnforward.Click += new System.EventHandler(this.btnsetspeed_Click);
            // 
            // txtgodistance
            // 
            this.txtgodistance.Location = new System.Drawing.Point(15, 31);
            this.txtgodistance.Name = "txtgodistance";
            this.txtgodistance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtgodistance.Size = new System.Drawing.Size(89, 20);
            this.txtgodistance.TabIndex = 12;
            // 
            // btngodistance
            // 
            this.btngodistance.Location = new System.Drawing.Point(115, 30);
            this.btngodistance.Name = "btngodistance";
            this.btngodistance.Size = new System.Drawing.Size(100, 21);
            this.btngodistance.TabIndex = 12;
            this.btngodistance.Text = "Go Distance(mm)";
            this.btngodistance.UseVisualStyleBackColor = true;
            this.btngodistance.Click += new System.EventHandler(this.btngodistance_Click);
            // 
            // btnsetnorth
            // 
            this.btnsetnorth.Location = new System.Drawing.Point(356, 79);
            this.btnsetnorth.Name = "btnsetnorth";
            this.btnsetnorth.Size = new System.Drawing.Size(75, 23);
            this.btnsetnorth.TabIndex = 30;
            this.btnsetnorth.Text = "Set North";
            this.btnsetnorth.UseVisualStyleBackColor = true;
            this.btnsetnorth.Click += new System.EventHandler(this.btnsetnorth_Click);
            // 
            // btngetmotorpos
            // 
            this.btngetmotorpos.Location = new System.Drawing.Point(115, 334);
            this.btngetmotorpos.Name = "btngetmotorpos";
            this.btngetmotorpos.Size = new System.Drawing.Size(100, 21);
            this.btngetmotorpos.TabIndex = 20;
            this.btngetmotorpos.Text = "Get Pos";
            this.btngetmotorpos.UseVisualStyleBackColor = true;
            this.btngetmotorpos.Click += new System.EventHandler(this.btngetmotorpos_Click);
            // 
            // lblrightmotorpos
            // 
            this.lblrightmotorpos.AutoSize = true;
            this.lblrightmotorpos.Location = new System.Drawing.Point(91, 338);
            this.lblrightmotorpos.Name = "lblrightmotorpos";
            this.lblrightmotorpos.Size = new System.Drawing.Size(13, 13);
            this.lblrightmotorpos.TabIndex = 19;
            this.lblrightmotorpos.Text = "0";
            // 
            // lblloftmotorpos
            // 
            this.lblloftmotorpos.AutoSize = true;
            this.lblloftmotorpos.Location = new System.Drawing.Point(91, 315);
            this.lblloftmotorpos.Name = "lblloftmotorpos";
            this.lblloftmotorpos.Size = new System.Drawing.Size(13, 13);
            this.lblloftmotorpos.TabIndex = 18;
            this.lblloftmotorpos.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Right Motor Pos.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Left Motor Pos.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkSwitch2Stat);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.chkSwitch1Stat);
            this.groupBox3.Controls.Add(this.lblloftmotorpos);
            this.groupBox3.Controls.Add(this.chkGreenStat);
            this.groupBox3.Controls.Add(this.btngetmotorpos);
            this.groupBox3.Controls.Add(this.chkRedStat);
            this.groupBox3.Controls.Add(this.lblrightmotorpos);
            this.groupBox3.Controls.Add(this.txtCounter);
            this.groupBox3.Controls.Add(this.chkRed);
            this.groupBox3.Controls.Add(this.chkGreen);
            this.groupBox3.Controls.Add(this.cmdSwitchLedStatus);
            this.groupBox3.Controls.Add(this.cmdGetCount);
            this.groupBox3.Controls.Add(this.cmdSetLEDs);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 374);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Commands";
            // 
            // chkSwitch2Stat
            // 
            this.chkSwitch2Stat.AutoSize = true;
            this.chkSwitch2Stat.Enabled = false;
            this.chkSwitch2Stat.Location = new System.Drawing.Point(133, 243);
            this.chkSwitch2Stat.Name = "chkSwitch2Stat";
            this.chkSwitch2Stat.Size = new System.Drawing.Size(67, 17);
            this.chkSwitch2Stat.TabIndex = 11;
            this.chkSwitch2Stat.Text = "Switch 2";
            this.chkSwitch2Stat.UseVisualStyleBackColor = true;
            // 
            // chkSwitch1Stat
            // 
            this.chkSwitch1Stat.AutoSize = true;
            this.chkSwitch1Stat.Enabled = false;
            this.chkSwitch1Stat.Location = new System.Drawing.Point(28, 243);
            this.chkSwitch1Stat.Name = "chkSwitch1Stat";
            this.chkSwitch1Stat.Size = new System.Drawing.Size(67, 17);
            this.chkSwitch1Stat.TabIndex = 10;
            this.chkSwitch1Stat.Text = "Switch 1";
            this.chkSwitch1Stat.UseVisualStyleBackColor = true;
            // 
            // chkGreenStat
            // 
            this.chkGreenStat.AutoSize = true;
            this.chkGreenStat.Enabled = false;
            this.chkGreenStat.Location = new System.Drawing.Point(133, 219);
            this.chkGreenStat.Name = "chkGreenStat";
            this.chkGreenStat.Size = new System.Drawing.Size(79, 17);
            this.chkGreenStat.TabIndex = 9;
            this.chkGreenStat.Text = "Green LED";
            this.chkGreenStat.UseVisualStyleBackColor = true;
            // 
            // chkRedStat
            // 
            this.chkRedStat.AutoSize = true;
            this.chkRedStat.Enabled = false;
            this.chkRedStat.Location = new System.Drawing.Point(28, 219);
            this.chkRedStat.Name = "chkRedStat";
            this.chkRedStat.Size = new System.Drawing.Size(70, 17);
            this.chkRedStat.TabIndex = 8;
            this.chkRedStat.Text = "Red LED";
            this.chkRedStat.UseVisualStyleBackColor = true;
            // 
            // txtCounter
            // 
            this.txtCounter.Location = new System.Drawing.Point(15, 99);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.Size = new System.Drawing.Size(89, 20);
            this.txtCounter.TabIndex = 7;
            // 
            // chkRed
            // 
            this.chkRed.AutoSize = true;
            this.chkRed.Location = new System.Drawing.Point(133, 24);
            this.chkRed.Name = "chkRed";
            this.chkRed.Size = new System.Drawing.Size(70, 17);
            this.chkRed.TabIndex = 5;
            this.chkRed.Text = "Red LED";
            this.chkRed.UseVisualStyleBackColor = true;
            // 
            // chkGreen
            // 
            this.chkGreen.AutoSize = true;
            this.chkGreen.Location = new System.Drawing.Point(15, 24);
            this.chkGreen.Name = "chkGreen";
            this.chkGreen.Size = new System.Drawing.Size(79, 17);
            this.chkGreen.TabIndex = 4;
            this.chkGreen.Text = "Green LED";
            this.chkGreen.UseVisualStyleBackColor = true;
            // 
            // cmdSwitchLedStatus
            // 
            this.cmdSwitchLedStatus.Location = new System.Drawing.Point(62, 266);
            this.cmdSwitchLedStatus.Name = "cmdSwitchLedStatus";
            this.cmdSwitchLedStatus.Size = new System.Drawing.Size(100, 21);
            this.cmdSwitchLedStatus.TabIndex = 3;
            this.cmdSwitchLedStatus.Text = "Get Status";
            this.cmdSwitchLedStatus.UseVisualStyleBackColor = true;
            this.cmdSwitchLedStatus.Click += new System.EventHandler(this.cmdSwitchLedStatus_Click);
            // 
            // cmdGetCount
            // 
            this.cmdGetCount.Location = new System.Drawing.Point(113, 99);
            this.cmdGetCount.Name = "cmdGetCount";
            this.cmdGetCount.Size = new System.Drawing.Size(100, 21);
            this.cmdGetCount.TabIndex = 1;
            this.cmdGetCount.Text = "Counter";
            this.cmdGetCount.UseVisualStyleBackColor = true;
            this.cmdGetCount.Click += new System.EventHandler(this.cmdGetCount_Click);
            // 
            // cmdSetLEDs
            // 
            this.cmdSetLEDs.Location = new System.Drawing.Point(15, 47);
            this.cmdSetLEDs.Name = "cmdSetLEDs";
            this.cmdSetLEDs.Size = new System.Drawing.Size(198, 23);
            this.cmdSetLEDs.TabIndex = 0;
            this.cmdSetLEDs.Text = "Set LEDs";
            this.cmdSetLEDs.UseVisualStyleBackColor = true;
            this.cmdSetLEDs.Click += new System.EventHandler(this.cmdSetLEDs_Click);
            // 
            // tmrmotorpos
            // 
            this.tmrmotorpos.Enabled = true;
            this.tmrmotorpos.Interval = 50;
            this.tmrmotorpos.Tick += new System.EventHandler(this.tmrmotorpos_Tick);
            // 
            // Rotation
            // 
            this.Rotation.Controls.Add(this.tabVortex);
            this.Rotation.Controls.Add(this.tabTeeter);
            this.Rotation.Controls.Add(this.tabearthquake);
            this.Rotation.Controls.Add(this.tablights);
            this.Rotation.Controls.Add(this.tabmorse);
            this.Rotation.Controls.Add(this.tabtesting);
            this.Rotation.Controls.Add(this.Turning);
            this.Rotation.Location = new System.Drawing.Point(253, 17);
            this.Rotation.Name = "Rotation";
            this.Rotation.SelectedIndex = 0;
            this.Rotation.Size = new System.Drawing.Size(495, 493);
            this.Rotation.TabIndex = 12;
            // 
            // tabVortex
            // 
            this.tabVortex.Controls.Add(this.spinslbl);
            this.tabVortex.Controls.Add(this.btnorientexitvortex);
            this.tabVortex.Controls.Add(this.btnexitvortex);
            this.tabVortex.Controls.Add(this.btnentervortex);
            this.tabVortex.Controls.Add(this.btnorientvortexon);
            this.tabVortex.Controls.Add(this.chart1);
            this.tabVortex.Controls.Add(this.chrtReset);
            this.tabVortex.Controls.Add(this.chartStop);
            this.tabVortex.Controls.Add(this.chartStart);
            this.tabVortex.Location = new System.Drawing.Point(4, 22);
            this.tabVortex.Name = "tabVortex";
            this.tabVortex.Padding = new System.Windows.Forms.Padding(3);
            this.tabVortex.Size = new System.Drawing.Size(487, 467);
            this.tabVortex.TabIndex = 0;
            this.tabVortex.Text = "Spiral Vortex";
            this.tabVortex.UseVisualStyleBackColor = true;
            // 
            // btnorientexitvortex
            // 
            this.btnorientexitvortex.Location = new System.Drawing.Point(348, 371);
            this.btnorientexitvortex.Name = "btnorientexitvortex";
            this.btnorientexitvortex.Size = new System.Drawing.Size(100, 21);
            this.btnorientexitvortex.TabIndex = 60;
            this.btnorientexitvortex.Text = "Orient to exit";
            this.btnorientexitvortex.UseVisualStyleBackColor = true;
            this.btnorientexitvortex.Click += new System.EventHandler(this.btnorientexitvortex_Click);
            // 
            // btnexitvortex
            // 
            this.btnexitvortex.Location = new System.Drawing.Point(348, 400);
            this.btnexitvortex.Name = "btnexitvortex";
            this.btnexitvortex.Size = new System.Drawing.Size(100, 21);
            this.btnexitvortex.TabIndex = 59;
            this.btnexitvortex.Text = "Drive down";
            this.btnexitvortex.UseVisualStyleBackColor = true;
            this.btnexitvortex.Click += new System.EventHandler(this.btnexitvortex_Click);
            // 
            // btnentervortex
            // 
            this.btnentervortex.Location = new System.Drawing.Point(39, 400);
            this.btnentervortex.Name = "btnentervortex";
            this.btnentervortex.Size = new System.Drawing.Size(100, 21);
            this.btnentervortex.TabIndex = 58;
            this.btnentervortex.Text = "Drive up";
            this.btnentervortex.UseVisualStyleBackColor = true;
            this.btnentervortex.Click += new System.EventHandler(this.btnentervortex_Click);
            // 
            // btnorientvortexon
            // 
            this.btnorientvortexon.Location = new System.Drawing.Point(39, 373);
            this.btnorientvortexon.Name = "btnorientvortexon";
            this.btnorientvortexon.Size = new System.Drawing.Size(100, 21);
            this.btnorientvortexon.TabIndex = 57;
            this.btnorientvortexon.Text = "Orient to ramp";
            this.btnorientvortexon.UseVisualStyleBackColor = true;
            this.btnorientvortexon.Click += new System.EventHandler(this.btnorientvortexon_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart1.BackColor = System.Drawing.SystemColors.Window;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea2.AxisX.Title = "Time";
            chartArea2.AxisY.ScaleView.Zoomable = false;
            chartArea2.AxisY.Title = "Mag amp";
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorY.IsUserEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Angle";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(475, 347);
            this.chart1.SuppressExceptions = true;
            this.chart1.TabIndex = 56;
            this.chart1.Text = "Rotation Graph";
            // 
            // chrtReset
            // 
            this.chrtReset.Location = new System.Drawing.Point(253, 371);
            this.chrtReset.Name = "chrtReset";
            this.chrtReset.Size = new System.Drawing.Size(75, 23);
            this.chrtReset.TabIndex = 35;
            this.chrtReset.Text = "Reset";
            this.chrtReset.UseVisualStyleBackColor = true;
            this.chrtReset.Click += new System.EventHandler(this.chrtReset_Click);
            // 
            // chartStop
            // 
            this.chartStop.Location = new System.Drawing.Point(172, 400);
            this.chartStop.Name = "chartStop";
            this.chartStop.Size = new System.Drawing.Size(75, 23);
            this.chartStop.TabIndex = 33;
            this.chartStop.Text = "Stop";
            this.chartStop.UseVisualStyleBackColor = true;
            this.chartStop.Click += new System.EventHandler(this.btnstopvortex_Click);
            // 
            // chartStart
            // 
            this.chartStart.Location = new System.Drawing.Point(172, 371);
            this.chartStart.Name = "chartStart";
            this.chartStart.Size = new System.Drawing.Size(75, 23);
            this.chartStart.TabIndex = 28;
            this.chartStart.Text = "Start";
            this.chartStart.UseVisualStyleBackColor = true;
            this.chartStart.Click += new System.EventHandler(this.bntstartvortex_Click);
            // 
            // tabTeeter
            // 
            this.tabTeeter.Controls.Add(this.button2);
            this.tabTeeter.Controls.Add(this.pictureBox1);
            this.tabTeeter.Controls.Add(this.lbllengthHval2);
            this.tabTeeter.Controls.Add(this.lbllengthHval);
            this.tabTeeter.Controls.Add(this.lbllengthCval);
            this.tabTeeter.Controls.Add(this.lbllengthAval);
            this.tabTeeter.Controls.Add(this.lblangleMval);
            this.tabTeeter.Controls.Add(this.lbllengthA);
            this.tabTeeter.Controls.Add(this.lblangleM);
            this.tabTeeter.Controls.Add(this.lbllengthC);
            this.tabTeeter.Controls.Add(this.lnllengthH);
            this.tabTeeter.Controls.Add(this.lbllengthF);
            this.tabTeeter.Controls.Add(this.lbllengthFval);
            this.tabTeeter.Controls.Add(this.btncalcteeter);
            this.tabTeeter.Controls.Add(this.txtdeclineangle);
            this.tabTeeter.Controls.Add(this.txtinclineangle);
            this.tabTeeter.Controls.Add(this.btnstoredeclineangle);
            this.tabTeeter.Controls.Add(this.btnstoreinclneangle);
            this.tabTeeter.Controls.Add(this.chkaccel);
            this.tabTeeter.Controls.Add(this.lblAccelyG);
            this.tabTeeter.Controls.Add(this.lblAccelxG);
            this.tabTeeter.Controls.Add(this.label28);
            this.tabTeeter.Controls.Add(this.label30);
            this.tabTeeter.Controls.Add(this.LblAccelY);
            this.tabTeeter.Controls.Add(this.LblAccelX);
            this.tabTeeter.Controls.Add(this.btnorientteeter);
            this.tabTeeter.Location = new System.Drawing.Point(4, 22);
            this.tabTeeter.Name = "tabTeeter";
            this.tabTeeter.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeeter.Size = new System.Drawing.Size(487, 467);
            this.tabTeeter.TabIndex = 1;
            this.tabTeeter.Text = "Teeter Board";
            this.tabTeeter.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 90;
            this.button2.Text = "Start ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(79, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 113);
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // lbllengthHval2
            // 
            this.lbllengthHval2.AutoSize = true;
            this.lbllengthHval2.Location = new System.Drawing.Point(395, 255);
            this.lbllengthHval2.Name = "lbllengthHval2";
            this.lbllengthHval2.Size = new System.Drawing.Size(13, 13);
            this.lbllengthHval2.TabIndex = 88;
            this.lbllengthHval2.Text = "0";
            // 
            // lbllengthHval
            // 
            this.lbllengthHval.AutoSize = true;
            this.lbllengthHval.Location = new System.Drawing.Point(395, 233);
            this.lbllengthHval.Name = "lbllengthHval";
            this.lbllengthHval.Size = new System.Drawing.Size(13, 13);
            this.lbllengthHval.TabIndex = 87;
            this.lbllengthHval.Text = "0";
            // 
            // lbllengthCval
            // 
            this.lbllengthCval.AutoSize = true;
            this.lbllengthCval.Location = new System.Drawing.Point(395, 206);
            this.lbllengthCval.Name = "lbllengthCval";
            this.lbllengthCval.Size = new System.Drawing.Size(13, 13);
            this.lbllengthCval.TabIndex = 86;
            this.lbllengthCval.Text = "0";
            // 
            // lbllengthAval
            // 
            this.lbllengthAval.AutoSize = true;
            this.lbllengthAval.Location = new System.Drawing.Point(395, 182);
            this.lbllengthAval.Name = "lbllengthAval";
            this.lbllengthAval.Size = new System.Drawing.Size(13, 13);
            this.lbllengthAval.TabIndex = 85;
            this.lbllengthAval.Text = "0";
            // 
            // lblangleMval
            // 
            this.lblangleMval.AutoSize = true;
            this.lblangleMval.Location = new System.Drawing.Point(145, 210);
            this.lblangleMval.Name = "lblangleMval";
            this.lblangleMval.Size = new System.Drawing.Size(13, 13);
            this.lblangleMval.TabIndex = 84;
            this.lblangleMval.Text = "0";
            // 
            // lbllengthA
            // 
            this.lbllengthA.AutoSize = true;
            this.lbllengthA.Location = new System.Drawing.Point(336, 182);
            this.lbllengthA.Name = "lbllengthA";
            this.lbllengthA.Size = new System.Drawing.Size(53, 13);
            this.lbllengthA.TabIndex = 83;
            this.lbllengthA.Text = "Length A:";
            // 
            // lblangleM
            // 
            this.lblangleM.AutoSize = true;
            this.lblangleM.Location = new System.Drawing.Point(87, 210);
            this.lblangleM.Name = "lblangleM";
            this.lblangleM.Size = new System.Drawing.Size(49, 13);
            this.lblangleM.TabIndex = 82;
            this.lblangleM.Text = "Angle M:";
            // 
            // lbllengthC
            // 
            this.lbllengthC.AutoSize = true;
            this.lbllengthC.Location = new System.Drawing.Point(336, 206);
            this.lbllengthC.Name = "lbllengthC";
            this.lbllengthC.Size = new System.Drawing.Size(53, 13);
            this.lbllengthC.TabIndex = 79;
            this.lbllengthC.Text = "Length C:";
            // 
            // lnllengthH
            // 
            this.lnllengthH.AutoSize = true;
            this.lnllengthH.Location = new System.Drawing.Point(335, 233);
            this.lnllengthH.Name = "lnllengthH";
            this.lnllengthH.Size = new System.Drawing.Size(54, 13);
            this.lnllengthH.TabIndex = 78;
            this.lnllengthH.Text = "Length H:";
            // 
            // lbllengthF
            // 
            this.lbllengthF.AutoSize = true;
            this.lbllengthF.Location = new System.Drawing.Point(87, 182);
            this.lbllengthF.Name = "lbllengthF";
            this.lbllengthF.Size = new System.Drawing.Size(52, 13);
            this.lbllengthF.TabIndex = 77;
            this.lbllengthF.Text = "Length F:";
            // 
            // lbllengthFval
            // 
            this.lbllengthFval.AutoSize = true;
            this.lbllengthFval.Location = new System.Drawing.Point(145, 182);
            this.lbllengthFval.Name = "lbllengthFval";
            this.lbllengthFval.Size = new System.Drawing.Size(13, 13);
            this.lbllengthFval.TabIndex = 36;
            this.lbllengthFval.Text = "0";
            // 
            // btncalcteeter
            // 
            this.btncalcteeter.Location = new System.Drawing.Point(253, 127);
            this.btncalcteeter.Name = "btncalcteeter";
            this.btncalcteeter.Size = new System.Drawing.Size(100, 21);
            this.btncalcteeter.TabIndex = 70;
            this.btncalcteeter.Text = "Calculate lengths";
            this.btncalcteeter.UseVisualStyleBackColor = true;
            this.btncalcteeter.Click += new System.EventHandler(this.btncalcteeter_Click);
            // 
            // txtdeclineangle
            // 
            this.txtdeclineangle.Location = new System.Drawing.Point(373, 78);
            this.txtdeclineangle.Name = "txtdeclineangle";
            this.txtdeclineangle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtdeclineangle.Size = new System.Drawing.Size(89, 20);
            this.txtdeclineangle.TabIndex = 69;
            // 
            // txtinclineangle
            // 
            this.txtinclineangle.Location = new System.Drawing.Point(373, 46);
            this.txtinclineangle.Name = "txtinclineangle";
            this.txtinclineangle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtinclineangle.Size = new System.Drawing.Size(89, 20);
            this.txtinclineangle.TabIndex = 36;
            // 
            // btnstoredeclineangle
            // 
            this.btnstoredeclineangle.Location = new System.Drawing.Point(253, 78);
            this.btnstoredeclineangle.Name = "btnstoredeclineangle";
            this.btnstoredeclineangle.Size = new System.Drawing.Size(100, 21);
            this.btnstoredeclineangle.TabIndex = 68;
            this.btnstoredeclineangle.Text = "Store Decline";
            this.btnstoredeclineangle.UseVisualStyleBackColor = true;
            this.btnstoredeclineangle.Click += new System.EventHandler(this.btnstoredeclineangle_Click);
            // 
            // btnstoreinclneangle
            // 
            this.btnstoreinclneangle.Location = new System.Drawing.Point(253, 46);
            this.btnstoreinclneangle.Name = "btnstoreinclneangle";
            this.btnstoreinclneangle.Size = new System.Drawing.Size(100, 21);
            this.btnstoreinclneangle.TabIndex = 36;
            this.btnstoreinclneangle.Text = "Store incline";
            this.btnstoreinclneangle.UseVisualStyleBackColor = true;
            this.btnstoreinclneangle.Click += new System.EventHandler(this.btnstoreinclneangle_Click);
            // 
            // chkaccel
            // 
            this.chkaccel.AutoSize = true;
            this.chkaccel.Location = new System.Drawing.Point(39, 49);
            this.chkaccel.Name = "chkaccel";
            this.chkaccel.Size = new System.Drawing.Size(61, 17);
            this.chkaccel.TabIndex = 67;
            this.chkaccel.Text = "Sample";
            this.chkaccel.UseVisualStyleBackColor = true;
            // 
            // lblAccelyG
            // 
            this.lblAccelyG.AutoSize = true;
            this.lblAccelyG.Location = new System.Drawing.Point(175, 101);
            this.lblAccelyG.Name = "lblAccelyG";
            this.lblAccelyG.Size = new System.Drawing.Size(28, 13);
            this.lblAccelyG.TabIndex = 66;
            this.lblAccelyG.Text = "Yaw";
            // 
            // lblAccelxG
            // 
            this.lblAccelxG.AutoSize = true;
            this.lblAccelxG.Location = new System.Drawing.Point(175, 78);
            this.lblAccelxG.Name = "lblAccelxG";
            this.lblAccelxG.Size = new System.Drawing.Size(31, 13);
            this.lblAccelxG.TabIndex = 65;
            this.lblAccelxG.Text = "Pitch";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(36, 101);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(17, 13);
            this.label28.TabIndex = 64;
            this.label28.Text = "Y:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(36, 78);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(17, 13);
            this.label30.TabIndex = 62;
            this.label30.Text = "X:";
            // 
            // LblAccelY
            // 
            this.LblAccelY.AutoSize = true;
            this.LblAccelY.Location = new System.Drawing.Point(59, 101);
            this.LblAccelY.Name = "LblAccelY";
            this.LblAccelY.Size = new System.Drawing.Size(85, 13);
            this.LblAccelY.TabIndex = 60;
            this.LblAccelY.Text = "Accelerometer Y";
            // 
            // LblAccelX
            // 
            this.LblAccelX.AutoSize = true;
            this.LblAccelX.Location = new System.Drawing.Point(59, 78);
            this.LblAccelX.Name = "LblAccelX";
            this.LblAccelX.Size = new System.Drawing.Size(85, 13);
            this.LblAccelX.TabIndex = 59;
            this.LblAccelX.Text = "Accelerometer X";
            // 
            // btnorientteeter
            // 
            this.btnorientteeter.Location = new System.Drawing.Point(44, 384);
            this.btnorientteeter.Name = "btnorientteeter";
            this.btnorientteeter.Size = new System.Drawing.Size(100, 21);
            this.btnorientteeter.TabIndex = 58;
            this.btnorientteeter.Text = "Orient to Teeter";
            this.btnorientteeter.UseVisualStyleBackColor = true;
            this.btnorientteeter.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // tabearthquake
            // 
            this.tabearthquake.Controls.Add(this.btnselsafterearthquake);
            this.tabearthquake.Controls.Add(this.btnexitearthquake);
            this.tabearthquake.Controls.Add(this.btnenterearthquake);
            this.tabearthquake.Controls.Add(this.btnorientearthquake);
            this.tabearthquake.Controls.Add(this.btnclearsamples);
            this.tabearthquake.Controls.Add(this.label8);
            this.tabearthquake.Controls.Add(this.lbletimercycles);
            this.tabearthquake.Controls.Add(this.chkesampling);
            this.tabearthquake.Controls.Add(this.lblearthsamplestaken);
            this.tabearthquake.Controls.Add(this.label5);
            this.tabearthquake.Controls.Add(this.label4);
            this.tabearthquake.Controls.Add(this.btndumptofile);
            this.tabearthquake.Controls.Add(this.btnearthquakestop);
            this.tabearthquake.Controls.Add(this.btnearthquakestart);
            this.tabearthquake.Location = new System.Drawing.Point(4, 22);
            this.tabearthquake.Name = "tabearthquake";
            this.tabearthquake.Padding = new System.Windows.Forms.Padding(3);
            this.tabearthquake.Size = new System.Drawing.Size(487, 467);
            this.tabearthquake.TabIndex = 2;
            this.tabearthquake.Text = "Earthquake";
            this.tabearthquake.UseVisualStyleBackColor = true;
            // 
            // btnselsafterearthquake
            // 
            this.btnselsafterearthquake.Location = new System.Drawing.Point(180, 321);
            this.btnselsafterearthquake.Name = "btnselsafterearthquake";
            this.btnselsafterearthquake.Size = new System.Drawing.Size(100, 21);
            this.btnselsafterearthquake.TabIndex = 56;
            this.btnselsafterearthquake.Text = "Get location";
            this.btnselsafterearthquake.UseVisualStyleBackColor = true;
            this.btnselsafterearthquake.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnexitearthquake
            // 
            this.btnexitearthquake.Location = new System.Drawing.Point(180, 279);
            this.btnexitearthquake.Name = "btnexitearthquake";
            this.btnexitearthquake.Size = new System.Drawing.Size(100, 21);
            this.btnexitearthquake.TabIndex = 42;
            this.btnexitearthquake.Text = "Drive down";
            this.btnexitearthquake.UseVisualStyleBackColor = true;
            this.btnexitearthquake.Click += new System.EventHandler(this.btnexitearthquake_Click);
            // 
            // btnenterearthquake
            // 
            this.btnenterearthquake.Location = new System.Drawing.Point(180, 107);
            this.btnenterearthquake.Name = "btnenterearthquake";
            this.btnenterearthquake.Size = new System.Drawing.Size(100, 21);
            this.btnenterearthquake.TabIndex = 41;
            this.btnenterearthquake.Text = "Drive up";
            this.btnenterearthquake.UseVisualStyleBackColor = true;
            this.btnenterearthquake.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnorientearthquake
            // 
            this.btnorientearthquake.Location = new System.Drawing.Point(180, 70);
            this.btnorientearthquake.Name = "btnorientearthquake";
            this.btnorientearthquake.Size = new System.Drawing.Size(100, 21);
            this.btnorientearthquake.TabIndex = 40;
            this.btnorientearthquake.Text = "Orient to ramp";
            this.btnorientearthquake.UseVisualStyleBackColor = true;
            this.btnorientearthquake.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnclearsamples
            // 
            this.btnclearsamples.Location = new System.Drawing.Point(310, 176);
            this.btnclearsamples.Name = "btnclearsamples";
            this.btnclearsamples.Size = new System.Drawing.Size(100, 21);
            this.btnclearsamples.TabIndex = 39;
            this.btnclearsamples.Text = "Clear array";
            this.btnclearsamples.UseVisualStyleBackColor = true;
            this.btnclearsamples.Click += new System.EventHandler(this.btnclearsamples_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Timer cycles";
            // 
            // lbletimercycles
            // 
            this.lbletimercycles.AutoSize = true;
            this.lbletimercycles.Location = new System.Drawing.Point(457, 439);
            this.lbletimercycles.Name = "lbletimercycles";
            this.lbletimercycles.Size = new System.Drawing.Size(13, 13);
            this.lbletimercycles.TabIndex = 37;
            this.lbletimercycles.Text = "0";
            // 
            // chkesampling
            // 
            this.chkesampling.AutoSize = true;
            this.chkesampling.Enabled = false;
            this.chkesampling.Location = new System.Drawing.Point(216, 179);
            this.chkesampling.Name = "chkesampling";
            this.chkesampling.Size = new System.Drawing.Size(72, 17);
            this.chkesampling.TabIndex = 36;
            this.chkesampling.Text = "Sampling ";
            this.chkesampling.UseVisualStyleBackColor = true;
            // 
            // lblearthsamplestaken
            // 
            this.lblearthsamplestaken.AutoSize = true;
            this.lblearthsamplestaken.Location = new System.Drawing.Point(166, 179);
            this.lblearthsamplestaken.Name = "lblearthsamplestaken";
            this.lblearthsamplestaken.Size = new System.Drawing.Size(13, 13);
            this.lblearthsamplestaken.TabIndex = 36;
            this.lblearthsamplestaken.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Samples taken:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Sampling";
            // 
            // btndumptofile
            // 
            this.btndumptofile.Location = new System.Drawing.Point(180, 231);
            this.btndumptofile.Name = "btndumptofile";
            this.btndumptofile.Size = new System.Drawing.Size(100, 21);
            this.btndumptofile.TabIndex = 33;
            this.btndumptofile.Text = "Dump to file";
            this.btndumptofile.UseVisualStyleBackColor = true;
            this.btndumptofile.Click += new System.EventHandler(this.btndumptofile_Click);
            // 
            // btnearthquakestop
            // 
            this.btnearthquakestop.Location = new System.Drawing.Point(180, 144);
            this.btnearthquakestop.Name = "btnearthquakestop";
            this.btnearthquakestop.Size = new System.Drawing.Size(100, 21);
            this.btnearthquakestop.TabIndex = 34;
            this.btnearthquakestop.Text = "Stop";
            this.btnearthquakestop.UseVisualStyleBackColor = true;
            this.btnearthquakestop.Click += new System.EventHandler(this.btnearthquakestop_Click);
            // 
            // btnearthquakestart
            // 
            this.btnearthquakestart.Location = new System.Drawing.Point(74, 144);
            this.btnearthquakestart.Name = "btnearthquakestart";
            this.btnearthquakestart.Size = new System.Drawing.Size(100, 21);
            this.btnearthquakestart.TabIndex = 33;
            this.btnearthquakestart.Text = "Start  ";
            this.btnearthquakestart.UseVisualStyleBackColor = true;
            this.btnearthquakestart.Click += new System.EventHandler(this.btnearthquakestart_Click);
            // 
            // tablights
            // 
            this.tablights.Controls.Add(this.lighttxt2);
            this.tablights.Controls.Add(this.stopPth);
            this.tablights.Controls.Add(this.LightDrawBtn);
            this.tablights.Controls.Add(this.lightPnl);
            this.tablights.Controls.Add(this.lightdTxt);
            this.tablights.Controls.Add(this.lightPathBtn);
            this.tablights.Location = new System.Drawing.Point(4, 22);
            this.tablights.Name = "tablights";
            this.tablights.Padding = new System.Windows.Forms.Padding(3);
            this.tablights.Size = new System.Drawing.Size(487, 467);
            this.tablights.TabIndex = 3;
            this.tablights.Text = "Light Phenominom";
            this.tablights.UseVisualStyleBackColor = true;
            this.tablights.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // LightDrawBtn
            // 
            this.LightDrawBtn.Location = new System.Drawing.Point(6, 438);
            this.LightDrawBtn.Name = "LightDrawBtn";
            this.LightDrawBtn.Size = new System.Drawing.Size(27, 23);
            this.LightDrawBtn.TabIndex = 3;
            this.LightDrawBtn.Text = "DRAW PATH";
            this.LightDrawBtn.UseVisualStyleBackColor = true;
            this.LightDrawBtn.Click += new System.EventHandler(this.LightDrawBtn_Click);
            // 
            // lightPnl
            // 
            this.lightPnl.Location = new System.Drawing.Point(35, 34);
            this.lightPnl.Name = "lightPnl";
            this.lightPnl.Size = new System.Drawing.Size(421, 427);
            this.lightPnl.TabIndex = 2;
            // 
            // lightdTxt
            // 
            this.lightdTxt.Location = new System.Drawing.Point(23, 8);
            this.lightdTxt.Name = "lightdTxt";
            this.lightdTxt.Size = new System.Drawing.Size(52, 20);
            this.lightdTxt.TabIndex = 1;
            this.lightdTxt.Text = "Sensor1";
            // 
            // lightPathBtn
            // 
            this.lightPathBtn.Location = new System.Drawing.Point(152, 6);
            this.lightPathBtn.Name = "lightPathBtn";
            this.lightPathBtn.Size = new System.Drawing.Size(75, 23);
            this.lightPathBtn.TabIndex = 0;
            this.lightPathBtn.Text = "start path";
            this.lightPathBtn.UseVisualStyleBackColor = true;
            this.lightPathBtn.Click += new System.EventHandler(this.lightPathBtn_Click);
            // 
            // tabmorse
            // 
            this.tabmorse.Location = new System.Drawing.Point(4, 22);
            this.tabmorse.Name = "tabmorse";
            this.tabmorse.Padding = new System.Windows.Forms.Padding(3);
            this.tabmorse.Size = new System.Drawing.Size(487, 467);
            this.tabmorse.TabIndex = 4;
            this.tabmorse.Text = "Morse Code";
            this.tabmorse.UseVisualStyleBackColor = true;
            // 
            // tabtesting
            // 
            this.tabtesting.Controls.Add(this.lblnorthbearing);
            this.tabtesting.Controls.Add(this.label24);
            this.tabtesting.Controls.Add(this.txttestselsb);
            this.tabtesting.Controls.Add(this.txttestselsc);
            this.tabtesting.Controls.Add(this.txttestselsd);
            this.tabtesting.Controls.Add(this.txttestselsa);
            this.tabtesting.Controls.Add(this.btntestcircle);
            this.tabtesting.Controls.Add(this.btnsetnorth);
            this.tabtesting.Controls.Add(this.lblmagzmax);
            this.tabtesting.Controls.Add(this.lblmagymax);
            this.tabtesting.Controls.Add(this.lblmagxmax);
            this.tabtesting.Controls.Add(this.lblmagzmin);
            this.tabtesting.Controls.Add(this.lblmagymin);
            this.tabtesting.Controls.Add(this.lblmagxmin);
            this.tabtesting.Controls.Add(this.label19);
            this.tabtesting.Controls.Add(this.label18);
            this.tabtesting.Controls.Add(this.label17);
            this.tabtesting.Controls.Add(this.label16);
            this.tabtesting.Controls.Add(this.label15);
            this.tabtesting.Controls.Add(this.btnorientsouth);
            this.tabtesting.Controls.Add(this.btnorienteast);
            this.tabtesting.Controls.Add(this.btnorientwest);
            this.tabtesting.Controls.Add(this.btnorientnorth);
            this.tabtesting.Controls.Add(this.btnspin);
            this.tabtesting.Controls.Add(this.lblselsb);
            this.tabtesting.Controls.Add(this.groupBox3);
            this.tabtesting.Controls.Add(this.lblselsc);
            this.tabtesting.Controls.Add(this.label7);
            this.tabtesting.Controls.Add(this.lblselsd);
            this.tabtesting.Controls.Add(this.label9);
            this.tabtesting.Controls.Add(this.lblselsa);
            this.tabtesting.Controls.Add(this.label10);
            this.tabtesting.Controls.Add(this.label12);
            this.tabtesting.Controls.Add(this.label11);
            this.tabtesting.Location = new System.Drawing.Point(4, 22);
            this.tabtesting.Name = "tabtesting";
            this.tabtesting.Padding = new System.Windows.Forms.Padding(3);
            this.tabtesting.Size = new System.Drawing.Size(487, 467);
            this.tabtesting.TabIndex = 5;
            this.tabtesting.Text = "Testing";
            this.tabtesting.UseVisualStyleBackColor = true;
            // 
            // lblnorthbearing
            // 
            this.lblnorthbearing.AutoSize = true;
            this.lblnorthbearing.Location = new System.Drawing.Point(433, 108);
            this.lblnorthbearing.Name = "lblnorthbearing";
            this.lblnorthbearing.Size = new System.Drawing.Size(13, 13);
            this.lblnorthbearing.TabIndex = 69;
            this.lblnorthbearing.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(353, 105);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 13);
            this.label24.TabIndex = 68;
            this.label24.Text = "North bearing:";
            // 
            // txttestselsb
            // 
            this.txttestselsb.Location = new System.Drawing.Point(261, 393);
            this.txttestselsb.Name = "txttestselsb";
            this.txttestselsb.Size = new System.Drawing.Size(89, 20);
            this.txttestselsb.TabIndex = 67;
            // 
            // txttestselsc
            // 
            this.txttestselsc.Location = new System.Drawing.Point(261, 417);
            this.txttestselsc.Name = "txttestselsc";
            this.txttestselsc.Size = new System.Drawing.Size(89, 20);
            this.txttestselsc.TabIndex = 66;
            // 
            // txttestselsd
            // 
            this.txttestselsd.Location = new System.Drawing.Point(261, 441);
            this.txttestselsd.Name = "txttestselsd";
            this.txttestselsd.Size = new System.Drawing.Size(89, 20);
            this.txttestselsd.TabIndex = 65;
            // 
            // txttestselsa
            // 
            this.txttestselsa.Location = new System.Drawing.Point(261, 370);
            this.txttestselsa.Name = "txttestselsa";
            this.txttestselsa.Size = new System.Drawing.Size(89, 20);
            this.txttestselsa.TabIndex = 21;
            // 
            // btntestcircle
            // 
            this.btntestcircle.Location = new System.Drawing.Point(255, 343);
            this.btntestcircle.Name = "btntestcircle";
            this.btntestcircle.Size = new System.Drawing.Size(100, 21);
            this.btntestcircle.TabIndex = 64;
            this.btntestcircle.Text = "Test circles";
            this.btntestcircle.UseVisualStyleBackColor = true;
            this.btntestcircle.Click += new System.EventHandler(this.btntestcircle_Click);
            // 
            // lblmagzmax
            // 
            this.lblmagzmax.AutoSize = true;
            this.lblmagzmax.Location = new System.Drawing.Point(151, 436);
            this.lblmagzmax.Name = "lblmagzmax";
            this.lblmagzmax.Size = new System.Drawing.Size(13, 13);
            this.lblmagzmax.TabIndex = 63;
            this.lblmagzmax.Text = "0";
            // 
            // lblmagymax
            // 
            this.lblmagymax.AutoSize = true;
            this.lblmagymax.Location = new System.Drawing.Point(151, 417);
            this.lblmagymax.Name = "lblmagymax";
            this.lblmagymax.Size = new System.Drawing.Size(13, 13);
            this.lblmagymax.TabIndex = 62;
            this.lblmagymax.Text = "0";
            this.lblmagymax.Click += new System.EventHandler(this.label24_Click);
            // 
            // lblmagxmax
            // 
            this.lblmagxmax.AutoSize = true;
            this.lblmagxmax.Location = new System.Drawing.Point(151, 399);
            this.lblmagxmax.Name = "lblmagxmax";
            this.lblmagxmax.Size = new System.Drawing.Size(13, 13);
            this.lblmagxmax.TabIndex = 61;
            this.lblmagxmax.Text = "0";
            // 
            // lblmagzmin
            // 
            this.lblmagzmin.AutoSize = true;
            this.lblmagzmin.Location = new System.Drawing.Point(110, 435);
            this.lblmagzmin.Name = "lblmagzmin";
            this.lblmagzmin.Size = new System.Drawing.Size(13, 13);
            this.lblmagzmin.TabIndex = 60;
            this.lblmagzmin.Text = "0";
            // 
            // lblmagymin
            // 
            this.lblmagymin.AutoSize = true;
            this.lblmagymin.Location = new System.Drawing.Point(110, 417);
            this.lblmagymin.Name = "lblmagymin";
            this.lblmagymin.Size = new System.Drawing.Size(13, 13);
            this.lblmagymin.TabIndex = 59;
            this.lblmagymin.Text = "0";
            // 
            // lblmagxmin
            // 
            this.lblmagxmin.AutoSize = true;
            this.lblmagxmin.Location = new System.Drawing.Point(110, 399);
            this.lblmagxmin.Name = "lblmagxmin";
            this.lblmagxmin.Size = new System.Drawing.Size(13, 13);
            this.lblmagxmin.TabIndex = 58;
            this.lblmagxmin.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(87, 400);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 13);
            this.label19.TabIndex = 57;
            this.label19.Text = "X:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(87, 417);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 13);
            this.label18.TabIndex = 56;
            this.label18.Text = "Y:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(87, 435);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 13);
            this.label17.TabIndex = 55;
            this.label17.Text = "Z:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 387);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "Mag Min/Max:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(247, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "Turn to face:";
            // 
            // btnorientsouth
            // 
            this.btnorientsouth.Location = new System.Drawing.Point(305, 182);
            this.btnorientsouth.Name = "btnorientsouth";
            this.btnorientsouth.Size = new System.Drawing.Size(100, 21);
            this.btnorientsouth.TabIndex = 25;
            this.btnorientsouth.Text = "South";
            this.btnorientsouth.UseVisualStyleBackColor = true;
            this.btnorientsouth.Click += new System.EventHandler(this.btnorientsouth_Click);
            // 
            // btnorienteast
            // 
            this.btnorienteast.Location = new System.Drawing.Point(356, 155);
            this.btnorienteast.Name = "btnorienteast";
            this.btnorienteast.Size = new System.Drawing.Size(100, 21);
            this.btnorienteast.TabIndex = 24;
            this.btnorienteast.Text = "East";
            this.btnorienteast.UseVisualStyleBackColor = true;
            this.btnorienteast.Click += new System.EventHandler(this.btnorienteast_Click);
            // 
            // btnorientwest
            // 
            this.btnorientwest.Location = new System.Drawing.Point(250, 155);
            this.btnorientwest.Name = "btnorientwest";
            this.btnorientwest.Size = new System.Drawing.Size(100, 21);
            this.btnorientwest.TabIndex = 23;
            this.btnorientwest.Text = "West";
            this.btnorientwest.UseVisualStyleBackColor = true;
            this.btnorientwest.Click += new System.EventHandler(this.btnorientwest_Click);
            // 
            // btnorientnorth
            // 
            this.btnorientnorth.Location = new System.Drawing.Point(305, 127);
            this.btnorientnorth.Name = "btnorientnorth";
            this.btnorientnorth.Size = new System.Drawing.Size(100, 21);
            this.btnorientnorth.TabIndex = 22;
            this.btnorientnorth.Text = "North";
            this.btnorientnorth.UseVisualStyleBackColor = true;
            this.btnorientnorth.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnspin
            // 
            this.btnspin.Location = new System.Drawing.Point(255, 26);
            this.btnspin.Name = "btnspin";
            this.btnspin.Size = new System.Drawing.Size(100, 21);
            this.btnspin.TabIndex = 21;
            this.btnspin.Text = "Spin";
            this.btnspin.UseVisualStyleBackColor = true;
            this.btnspin.Click += new System.EventHandler(this.btnspin_Click);
            // 
            // lblselsb
            // 
            this.lblselsb.AutoSize = true;
            this.lblselsb.Location = new System.Drawing.Point(449, 399);
            this.lblselsb.Name = "lblselsb";
            this.lblselsb.Size = new System.Drawing.Size(13, 13);
            this.lblselsb.TabIndex = 48;
            this.lblselsb.Text = "0";
            // 
            // lblselsc
            // 
            this.lblselsc.AutoSize = true;
            this.lblselsc.Location = new System.Drawing.Point(449, 417);
            this.lblselsc.Name = "lblselsc";
            this.lblselsc.Size = new System.Drawing.Size(13, 13);
            this.lblselsc.TabIndex = 47;
            this.lblselsc.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "SELS Ouputs";
            // 
            // lblselsd
            // 
            this.lblselsd.AutoSize = true;
            this.lblselsd.Location = new System.Drawing.Point(449, 441);
            this.lblselsd.Name = "lblselsd";
            this.lblselsd.Size = new System.Drawing.Size(13, 13);
            this.lblselsd.TabIndex = 46;
            this.lblselsd.Text = "0";
            this.lblselsd.Click += new System.EventHandler(this.lblselsd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(426, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "A:";
            // 
            // lblselsa
            // 
            this.lblselsa.AutoSize = true;
            this.lblselsa.Location = new System.Drawing.Point(449, 377);
            this.lblselsa.Name = "lblselsa";
            this.lblselsa.Size = new System.Drawing.Size(13, 13);
            this.lblselsa.TabIndex = 45;
            this.lblselsa.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "D:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(426, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "B:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(426, 417);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "C:";
            // 
            // Turning
            // 
            this.Turning.Location = new System.Drawing.Point(4, 22);
            this.Turning.Name = "Turning";
            this.Turning.Padding = new System.Windows.Forms.Padding(3);
            this.Turning.Size = new System.Drawing.Size(487, 467);
            this.Turning.TabIndex = 6;
            this.Turning.Text = "Turning";
            this.Turning.UseVisualStyleBackColor = true;
            // 
            // tmrangle
            // 
            this.tmrangle.Tick += new System.EventHandler(this.tmrMag_Tick);
            // 
            // lightTimer
            // 
            this.lightTimer.Tick += new System.EventHandler(this.lightTimer_Tick);
            // 
            // extBtn
            // 
            this.extBtn.Location = new System.Drawing.Point(992, 484);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(75, 23);
            this.extBtn.TabIndex = 13;
            this.extBtn.Text = "EXIT";
            this.extBtn.UseVisualStyleBackColor = true;
            this.extBtn.Click += new System.EventHandler(this.extBtn_Click);
            // 
            // tmrearthquake
            // 
            this.tmrearthquake.Interval = 500;
            this.tmrearthquake.Tick += new System.EventHandler(this.tmrearthquake_Tick);
            // 
            // btngetsels
            // 
            this.btngetsels.Location = new System.Drawing.Point(1070, 43);
            this.btngetsels.Name = "btngetsels";
            this.btngetsels.Size = new System.Drawing.Size(100, 21);
            this.btngetsels.TabIndex = 40;
            this.btngetsels.Text = "Get location";
            this.btngetsels.UseVisualStyleBackColor = true;
            this.btngetsels.Click += new System.EventHandler(this.btngetsels_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1080, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Location X: ";
            // 
            // lblcoordX
            // 
            this.lblcoordX.AutoSize = true;
            this.lblcoordX.Location = new System.Drawing.Point(1150, 73);
            this.lblcoordX.Name = "lblcoordX";
            this.lblcoordX.Size = new System.Drawing.Size(13, 13);
            this.lblcoordX.TabIndex = 50;
            this.lblcoordX.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1080, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Location Y:";
            // 
            // lblcoordY
            // 
            this.lblcoordY.AutoSize = true;
            this.lblcoordY.Location = new System.Drawing.Point(1150, 92);
            this.lblcoordY.Name = "lblcoordY";
            this.lblcoordY.Size = new System.Drawing.Size(13, 13);
            this.lblcoordY.TabIndex = 52;
            this.lblcoordY.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.picRover);
            this.panel1.Controls.Add(this.picmorseaproach);
            this.panel1.Controls.Add(this.picvortex);
            this.panel1.Controls.Add(this.picearthquake);
            this.panel1.Controls.Add(this.picimage);
            this.panel1.Controls.Add(this.pictteeteraproach);
            this.panel1.Controls.Add(this.picteeter);
            this.panel1.Location = new System.Drawing.Point(764, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 53;
            // 
            // picRover
            // 
            this.picRover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picRover.BackColor = System.Drawing.Color.Fuchsia;
            this.picRover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRover.BackgroundImage")));
            this.picRover.Location = new System.Drawing.Point(-5, -5);
            this.picRover.Margin = new System.Windows.Forms.Padding(0);
            this.picRover.Name = "picRover";
            this.picRover.Size = new System.Drawing.Size(10, 10);
            this.picRover.TabIndex = 0;
            this.picRover.TabStop = false;
            // 
            // picmorseaproach
            // 
            this.picmorseaproach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picmorseaproach.BackColor = System.Drawing.Color.Black;
            this.picmorseaproach.Location = new System.Drawing.Point(215, 25);
            this.picmorseaproach.Margin = new System.Windows.Forms.Padding(0);
            this.picmorseaproach.Name = "picmorseaproach";
            this.picmorseaproach.Size = new System.Drawing.Size(10, 10);
            this.picmorseaproach.TabIndex = 6;
            this.picmorseaproach.TabStop = false;
            this.picmorseaproach.Click += new System.EventHandler(this.picmorseaproach_Click);
            // 
            // picvortex
            // 
            this.picvortex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picvortex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.picvortex.Location = new System.Drawing.Point(222, 100);
            this.picvortex.Margin = new System.Windows.Forms.Padding(0);
            this.picvortex.Name = "picvortex";
            this.picvortex.Size = new System.Drawing.Size(10, 10);
            this.picvortex.TabIndex = 5;
            this.picvortex.TabStop = false;
            this.picvortex.Click += new System.EventHandler(this.picvortex_Click);
            // 
            // picearthquake
            // 
            this.picearthquake.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picearthquake.BackColor = System.Drawing.Color.Yellow;
            this.picearthquake.Location = new System.Drawing.Point(188, 200);
            this.picearthquake.Margin = new System.Windows.Forms.Padding(0);
            this.picearthquake.Name = "picearthquake";
            this.picearthquake.Size = new System.Drawing.Size(10, 10);
            this.picearthquake.TabIndex = 4;
            this.picearthquake.TabStop = false;
            this.picearthquake.Click += new System.EventHandler(this.picearthquake_Click);
            // 
            // picimage
            // 
            this.picimage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picimage.BackColor = System.Drawing.Color.Blue;
            this.picimage.Location = new System.Drawing.Point(105, 155);
            this.picimage.Margin = new System.Windows.Forms.Padding(0);
            this.picimage.Name = "picimage";
            this.picimage.Size = new System.Drawing.Size(10, 10);
            this.picimage.TabIndex = 3;
            this.picimage.TabStop = false;
            this.picimage.Click += new System.EventHandler(this.picimage_Click);
            // 
            // pictteeteraproach
            // 
            this.pictteeteraproach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictteeteraproach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictteeteraproach.Location = new System.Drawing.Point(55, 235);
            this.pictteeteraproach.Margin = new System.Windows.Forms.Padding(0);
            this.pictteeteraproach.Name = "pictteeteraproach";
            this.pictteeteraproach.Size = new System.Drawing.Size(10, 10);
            this.pictteeteraproach.TabIndex = 2;
            this.pictteeteraproach.TabStop = false;
            this.pictteeteraproach.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picteeter
            // 
            this.picteeter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picteeter.BackColor = System.Drawing.Color.Red;
            this.picteeter.Location = new System.Drawing.Point(55, 175);
            this.picteeter.Margin = new System.Windows.Forms.Padding(0);
            this.picteeter.Name = "picteeter";
            this.picteeter.Size = new System.Drawing.Size(10, 10);
            this.picteeter.TabIndex = 1;
            this.picteeter.TabStop = false;
            this.picteeter.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(761, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "B";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1053, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 13);
            this.label21.TabIndex = 54;
            this.label21.Text = "D";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(761, 342);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 22;
            this.label22.Text = "C";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1054, 342);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 13);
            this.label23.TabIndex = 55;
            this.label23.Text = "A";
            // 
            // chrtTmr
            // 
            this.chrtTmr.Tick += new System.EventHandler(this.chrtTmr_Tick);
            // 
            // btncalculatepath
            // 
            this.btncalculatepath.Location = new System.Drawing.Point(822, 450);
            this.btncalculatepath.Name = "btncalculatepath";
            this.btncalculatepath.Size = new System.Drawing.Size(89, 21);
            this.btncalculatepath.TabIndex = 56;
            this.btncalculatepath.Text = "Get Path";
            this.btncalculatepath.UseVisualStyleBackColor = true;
            this.btncalculatepath.Click += new System.EventHandler(this.btncalculatepath_Click);
            // 
            // txtxwanted
            // 
            this.txtxwanted.Location = new System.Drawing.Point(822, 398);
            this.txtxwanted.Name = "txtxwanted";
            this.txtxwanted.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtxwanted.Size = new System.Drawing.Size(89, 20);
            this.txtxwanted.TabIndex = 36;
            this.txtxwanted.Text = "0";
            // 
            // txtywanted
            // 
            this.txtywanted.Location = new System.Drawing.Point(822, 424);
            this.txtywanted.Name = "txtywanted";
            this.txtywanted.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtywanted.Size = new System.Drawing.Size(89, 20);
            this.txtywanted.TabIndex = 57;
            this.txtywanted.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(755, 405);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 13);
            this.label25.TabIndex = 58;
            this.label25.Text = "Location X: ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(755, 430);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(61, 13);
            this.label26.TabIndex = 59;
            this.label26.Text = "Location Y:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(786, 381);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(51, 13);
            this.label27.TabIndex = 60;
            this.label27.Text = "Drive To;";
            // 
            // txttravelangle
            // 
            this.txttravelangle.Location = new System.Drawing.Point(942, 398);
            this.txttravelangle.Name = "txttravelangle";
            this.txttravelangle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttravelangle.Size = new System.Drawing.Size(89, 20);
            this.txttravelangle.TabIndex = 36;
            this.txttravelangle.Text = "0";
            // 
            // txttraveldistance
            // 
            this.txttraveldistance.Location = new System.Drawing.Point(942, 424);
            this.txttraveldistance.Name = "txttraveldistance";
            this.txttraveldistance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttraveldistance.Size = new System.Drawing.Size(89, 20);
            this.txttraveldistance.TabIndex = 61;
            this.txttraveldistance.Text = "0";
            // 
            // btnturntravel
            // 
            this.btnturntravel.Location = new System.Drawing.Point(1041, 397);
            this.btnturntravel.Name = "btnturntravel";
            this.btnturntravel.Size = new System.Drawing.Size(100, 21);
            this.btnturntravel.TabIndex = 36;
            this.btnturntravel.Text = "Turn";
            this.btnturntravel.UseVisualStyleBackColor = true;
            this.btnturntravel.Click += new System.EventHandler(this.btnturntravel_Click);
            // 
            // btntravelgo
            // 
            this.btntravelgo.Location = new System.Drawing.Point(1041, 423);
            this.btntravelgo.Name = "btntravelgo";
            this.btntravelgo.Size = new System.Drawing.Size(100, 21);
            this.btntravelgo.TabIndex = 36;
            this.btntravelgo.Text = "Go";
            this.btntravelgo.UseVisualStyleBackColor = true;
            this.btntravelgo.Click += new System.EventHandler(this.btntravelgo_Click);
            // 
            // tmraccelerometer
            // 
            this.tmraccelerometer.Enabled = true;
            this.tmraccelerometer.Tick += new System.EventHandler(this.tmraccelerometer_Tick);
            // 
            // chkturning
            // 
            this.chkturning.AutoSize = true;
            this.chkturning.Location = new System.Drawing.Point(789, 12);
            this.chkturning.Name = "chkturning";
            this.chkturning.Size = new System.Drawing.Size(62, 17);
            this.chkturning.TabIndex = 62;
            this.chkturning.Text = "Turning";
            this.chkturning.UseVisualStyleBackColor = true;
            // 
            // chktravelling
            // 
            this.chktravelling.AutoSize = true;
            this.chktravelling.Location = new System.Drawing.Point(872, 12);
            this.chktravelling.Name = "chktravelling";
            this.chktravelling.Size = new System.Drawing.Size(72, 17);
            this.chktravelling.TabIndex = 63;
            this.chktravelling.Text = "Travelling";
            this.chktravelling.UseVisualStyleBackColor = true;
            // 
            // teeterTmr
            // 
            this.teeterTmr.Tick += new System.EventHandler(this.teeterTmr_Tick);
            // 
            // stopPth
            // 
            this.stopPth.Location = new System.Drawing.Point(248, 6);
            this.stopPth.Name = "stopPth";
            this.stopPth.Size = new System.Drawing.Size(75, 23);
            this.stopPth.TabIndex = 4;
            this.stopPth.Text = "Stop";
            this.stopPth.UseVisualStyleBackColor = true;
            this.stopPth.Click += new System.EventHandler(this.stopPth_Click);
            // 
            // lighttxt2
            // 
            this.lighttxt2.Location = new System.Drawing.Point(82, 7);
            this.lighttxt2.Name = "lighttxt2";
            this.lighttxt2.Size = new System.Drawing.Size(64, 20);
            this.lighttxt2.TabIndex = 5;
            this.lighttxt2.Text = "Sensor2";
            // 
            // spinslbl
            // 
            this.spinslbl.AutoSize = true;
            this.spinslbl.Location = new System.Drawing.Point(56, 339);
            this.spinslbl.Name = "spinslbl";
            this.spinslbl.Size = new System.Drawing.Size(31, 13);
            this.spinslbl.TabIndex = 61;
            this.spinslbl.Text = "spins";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 532);
            this.Controls.Add(this.chktravelling);
            this.Controls.Add(this.chkturning);
            this.Controls.Add(this.btntravelgo);
            this.Controls.Add(this.btnturntravel);
            this.Controls.Add(this.txttraveldistance);
            this.Controls.Add(this.txttravelangle);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtywanted);
            this.Controls.Add(this.txtxwanted);
            this.Controls.Add(this.btncalculatepath);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblcoordY);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblcoordX);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btngetsels);
            this.Controls.Add(this.extBtn);
            this.Controls.Add(this.Rotation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Rover GUI";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Rotation.ResumeLayout(false);
            this.tabVortex.ResumeLayout(false);
            this.tabVortex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabTeeter.ResumeLayout(false);
            this.tabTeeter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabearthquake.ResumeLayout(false);
            this.tabearthquake.PerformLayout();
            this.tablights.ResumeLayout(false);
            this.tablights.PerformLayout();
            this.tabtesting.ResumeLayout(false);
            this.tabtesting.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmorseaproach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvortex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picearthquake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictteeteraproach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picteeter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Button cmdDisconnect;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdSwitchLedStatus;
        private System.Windows.Forms.Button cmdGetCount;
        private System.Windows.Forms.Button cmdSetLEDs;
        private System.Windows.Forms.CheckBox chkRed;
        private System.Windows.Forms.CheckBox chkGreen;
        private System.Windows.Forms.TextBox txtCounter;
        private System.Windows.Forms.CheckBox chkSwitch2Stat;
        private System.Windows.Forms.CheckBox chkSwitch1Stat;
        private System.Windows.Forms.CheckBox chkGreenStat;
        private System.Windows.Forms.CheckBox chkRedStat;
        private System.Windows.Forms.TextBox txtgodistance;
        private System.Windows.Forms.Button btngodistance;
        private System.Windows.Forms.Button btnforward;
        private System.Windows.Forms.Label lblrightmotorpos;
        private System.Windows.Forms.Label lblloftmotorpos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngetmotorpos;
        private System.Windows.Forms.Button btnstopmotors;
        private System.Windows.Forms.HScrollBar scrlspeed;
        private System.Windows.Forms.Timer tmrmotorpos;
        private System.Windows.Forms.Label lblmotorspeed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl Rotation;
        private System.Windows.Forms.TabPage tabVortex;
        private System.Windows.Forms.TabPage tabTeeter;
        private System.Windows.Forms.TabPage tabearthquake;
        private System.Windows.Forms.TabPage tablights;
        private System.Windows.Forms.TabPage tabmorse;
        private System.Windows.Forms.TabPage tabtesting;
        private System.Windows.Forms.TabPage Turning;
        private System.Windows.Forms.CheckBox checkMag;
        private System.Windows.Forms.Button MagCalStop;
        private System.Windows.Forms.Button MagCalStart;
        private System.Windows.Forms.Label lblangle;
        private System.Windows.Forms.Timer tmrangle;
        private System.Windows.Forms.Button btnsetnorth;
        private System.Windows.Forms.Button btnturn;
        private System.Windows.Forms.TextBox txtturnangle;
        private System.Windows.Forms.Button chartStop;
        private System.Windows.Forms.Button chartStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndumptofile;
        private System.Windows.Forms.Button btnearthquakestop;
        private System.Windows.Forms.Button btnearthquakestart;
        private System.Windows.Forms.Label lblearthsamplestaken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btngetheading;
        private System.Windows.Forms.Label lblwantedangle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AngleLabel;
        private System.Windows.Forms.Button btnspin;
        private System.Windows.Forms.Button btnorientsouth;
        private System.Windows.Forms.Button btnorienteast;
        private System.Windows.Forms.Button btnorientwest;
        private System.Windows.Forms.Button btnorientnorth;
        private System.Windows.Forms.Button lightPathBtn;
        private System.Windows.Forms.Timer lightTimer;
        private System.Windows.Forms.TextBox lightdTxt;
        private System.Windows.Forms.Button extBtn;
        private System.Windows.Forms.Panel lightPnl;
        private System.Windows.Forms.Button LightDrawBtn;
        private System.Windows.Forms.Timer tmrearthquake;
        private System.Windows.Forms.CheckBox chkesampling;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbletimercycles;
        private System.Windows.Forms.Button btnclearsamples;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblselsa;
        private System.Windows.Forms.Label lblselsd;
        private System.Windows.Forms.Label lblselsc;
        private System.Windows.Forms.Label lblselsb;
        private System.Windows.Forms.Button btngetsels;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblcoordX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblcoordY;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblmagzmax;
        private System.Windows.Forms.Label lblmagymax;
        private System.Windows.Forms.Label lblmagxmax;
        private System.Windows.Forms.Label lblmagzmin;
        private System.Windows.Forms.Label lblmagymin;
        private System.Windows.Forms.Label lblmagxmin;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox picRover;
        private System.Windows.Forms.Button btntestcircle;
        private System.Windows.Forms.TextBox txttestselsb;
        private System.Windows.Forms.TextBox txttestselsc;
        private System.Windows.Forms.TextBox txttestselsd;
        private System.Windows.Forms.TextBox txttestselsa;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblnorthbearing;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button chrtReset;
        private System.Windows.Forms.Timer chrtTmr;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnselsafterearthquake;
        private System.Windows.Forms.Button btnexitearthquake;
        private System.Windows.Forms.Button btnenterearthquake;
        private System.Windows.Forms.Button btnorientearthquake;
        private System.Windows.Forms.Button btnorientexitvortex;
        private System.Windows.Forms.Button btnexitvortex;
        private System.Windows.Forms.Button btnentervortex;
        private System.Windows.Forms.Button btnorientvortexon;
        private System.Windows.Forms.Button btnorientteeter;
        private System.Windows.Forms.Button btncalculatepath;
        private System.Windows.Forms.TextBox txtxwanted;
        private System.Windows.Forms.TextBox txtywanted;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txttravelangle;
        private System.Windows.Forms.TextBox txttraveldistance;
        private System.Windows.Forms.Button btnturntravel;
        private System.Windows.Forms.Button btntravelgo;
        private System.Windows.Forms.CheckBox chkaccel;
        private System.Windows.Forms.Label lblAccelyG;
        private System.Windows.Forms.Label lblAccelxG;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label LblAccelY;
        private System.Windows.Forms.Label LblAccelX;
        private System.Windows.Forms.Timer tmraccelerometer;
        private System.Windows.Forms.TextBox txtdeclineangle;
        private System.Windows.Forms.TextBox txtinclineangle;
        private System.Windows.Forms.Button btnstoredeclineangle;
        private System.Windows.Forms.Button btnstoreinclneangle;
        private System.Windows.Forms.Label lbllengthHval;
        private System.Windows.Forms.Label lbllengthCval;
        private System.Windows.Forms.Label lbllengthAval;
        private System.Windows.Forms.Label lblangleMval;
        private System.Windows.Forms.Label lbllengthA;
        private System.Windows.Forms.Label lblangleM;
        private System.Windows.Forms.Label lbllengthC;
        private System.Windows.Forms.Label lnllengthH;
        private System.Windows.Forms.Label lbllengthF;
        private System.Windows.Forms.Label lbllengthFval;
        private System.Windows.Forms.Button btncalcteeter;
        private System.Windows.Forms.Label lbllengthHval2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkturning;
        private System.Windows.Forms.CheckBox chktravelling;
        private System.Windows.Forms.PictureBox picvortex;
        private System.Windows.Forms.PictureBox picearthquake;
        private System.Windows.Forms.PictureBox picimage;
        private System.Windows.Forms.PictureBox pictteeteraproach;
        private System.Windows.Forms.PictureBox picteeter;
        private System.Windows.Forms.PictureBox picmorseaproach;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer teeterTmr;
        private System.Windows.Forms.Button stopPth;
        private System.Windows.Forms.TextBox lighttxt2;
        private System.Windows.Forms.Label spinslbl;
    }
}

