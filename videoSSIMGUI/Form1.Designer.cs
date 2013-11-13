namespace videoSSIMGUI
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ssim_video_cat = new System.Windows.Forms.TabPage();
            this.txtXmlFile = new System.Windows.Forms.TextBox();
            this.btnFileXml = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label36 = new System.Windows.Forms.Label();
            this.ColorTxt = new System.Windows.Forms.TextBox();
            this.flcolor = new System.Windows.Forms.Button();
            this.checkBoxWhiteSSIM = new System.Windows.Forms.CheckBox();
            this.label35 = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.original = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OrigTxt = new System.Windows.Forms.TextBox();
            this.DecTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkTemp = new System.Windows.Forms.CheckBox();
            this.florig = new System.Windows.Forms.Button();
            this.heightTxt = new System.Windows.Forms.ComboBox();
            this.fldec = new System.Windows.Forms.Button();
            this.widthTxt = new System.Windows.Forms.ComboBox();
            this.btnNextTab = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label34 = new System.Windows.Forms.Label();
            this.txtXmlOut = new System.Windows.Forms.TextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnVectors = new System.Windows.Forms.Button();
            this.btnExcelMotion = new System.Windows.Forms.Button();
            this.excel2matlab = new System.Windows.Forms.TabPage();
            this.btnGenMotionExcel = new System.Windows.Forms.Button();
            this.txtExcelMVfiles = new System.Windows.Forms.TextBox();
            this.btnExcelMVFiles = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.txtMatlabScript = new System.Windows.Forms.TextBox();
            this.btnMatlabScr = new System.Windows.Forms.Button();
            this.encoder = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtErr = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnQPEncoding = new System.Windows.Forms.Button();
            this.txtQPBSlice = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtQPPSlice = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtQPISlice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txtStepBitrate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtEndBitrate = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnBitrateEncoding = new System.Windows.Forms.Button();
            this.txtStartBitrate = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtFrameRate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFrames = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboHeight = new System.Windows.Forms.ComboBox();
            this.comboWidth = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listBoxEncodingScenarios = new System.Windows.Forms.ListBox();
            this.btnAddEncodingScenario = new System.Windows.Forms.Button();
            this.btnFileEncoder = new System.Windows.Forms.Button();
            this.txtEncoderFile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOrigFile = new System.Windows.Forms.Button();
            this.txtOrigFile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.yuv_color_converter = new System.Windows.Forms.TabPage();
            this.comboBoxPattern = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxH = new System.Windows.Forms.ComboBox();
            this.comboBoxW = new System.Windows.Forms.ComboBox();
            this.flOrigYUV = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOrigYUV = new System.Windows.Forms.TextBox();
            this.temporal_evaluation = new System.Windows.Forms.TabPage();
            this.checkedFoldersQP = new System.Windows.Forms.CheckedListBox();
            this.btnFindQps = new System.Windows.Forms.Button();
            this.flroot = new System.Windows.Forms.Button();
            this.txtRoot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTempCur = new System.Windows.Forms.Button();
            this.openFileDialogEnc = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogXml = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogExcel = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.ssim_video_cat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.excel2matlab.SuspendLayout();
            this.encoder.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.yuv_color_converter.SuspendLayout();
            this.temporal_evaluation.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ssim_video_cat);
            this.tabControl1.Controls.Add(this.excel2matlab);
            this.tabControl1.Controls.Add(this.encoder);
            this.tabControl1.Controls.Add(this.yuv_color_converter);
            this.tabControl1.Controls.Add(this.temporal_evaluation);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 632);
            this.tabControl1.TabIndex = 13;
            // 
            // ssim_video_cat
            // 
            this.ssim_video_cat.Controls.Add(this.txtXmlFile);
            this.ssim_video_cat.Controls.Add(this.btnFileXml);
            this.ssim_video_cat.Controls.Add(this.label33);
            this.ssim_video_cat.Controls.Add(this.splitContainer1);
            this.ssim_video_cat.Location = new System.Drawing.Point(4, 22);
            this.ssim_video_cat.Name = "ssim_video_cat";
            this.ssim_video_cat.Padding = new System.Windows.Forms.Padding(3);
            this.ssim_video_cat.Size = new System.Drawing.Size(958, 606);
            this.ssim_video_cat.TabIndex = 0;
            this.ssim_video_cat.Text = "SSIM & Video Categorization metrics";
            this.ssim_video_cat.UseVisualStyleBackColor = true;
            this.ssim_video_cat.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtXmlFile
            // 
            this.txtXmlFile.Location = new System.Drawing.Point(551, 82);
            this.txtXmlFile.Name = "txtXmlFile";
            this.txtXmlFile.Size = new System.Drawing.Size(213, 20);
            this.txtXmlFile.TabIndex = 28;
            // 
            // btnFileXml
            // 
            this.btnFileXml.Location = new System.Drawing.Point(770, 82);
            this.btnFileXml.Name = "btnFileXml";
            this.btnFileXml.Size = new System.Drawing.Size(33, 23);
            this.btnFileXml.TabIndex = 29;
            this.btnFileXml.Text = "...";
            this.btnFileXml.UseVisualStyleBackColor = true;
            this.btnFileXml.Click += new System.EventHandler(this.btnFileXml_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(521, 87);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(24, 13);
            this.label33.TabIndex = 31;
            this.label33.Text = "Xml";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(6, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label36);
            this.splitContainer1.Panel1.Controls.Add(this.ColorTxt);
            this.splitContainer1.Panel1.Controls.Add(this.flcolor);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxWhiteSSIM);
            this.splitContainer1.Panel1.Controls.Add(this.label35);
            this.splitContainer1.Panel1.Controls.Add(this.zedGraphControl1);
            this.splitContainer1.Panel1.Controls.Add(this.original);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.OrigTxt);
            this.splitContainer1.Panel1.Controls.Add(this.DecTxt);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnGraph);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.chkTemp);
            this.splitContainer1.Panel1.Controls.Add(this.florig);
            this.splitContainer1.Panel1.Controls.Add(this.heightTxt);
            this.splitContainer1.Panel1.Controls.Add(this.fldec);
            this.splitContainer1.Panel1.Controls.Add(this.widthTxt);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnNextTab);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel2.Controls.Add(this.label34);
            this.splitContainer1.Panel2.Controls.Add(this.txtXmlOut);
            this.splitContainer1.Panel2.Controls.Add(this.btnClearLog);
            this.splitContainer1.Panel2.Controls.Add(this.btnVectors);
            this.splitContainer1.Panel2.Controls.Add(this.btnExcelMotion);
            this.splitContainer1.Size = new System.Drawing.Size(941, 600);
            this.splitContainer1.SplitterDistance = 485;
            this.splitContainer1.TabIndex = 34;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(216, 64);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(61, 13);
            this.label36.TabIndex = 29;
            this.label36.Text = "Color Video";
            // 
            // ColorTxt
            // 
            this.ColorTxt.Location = new System.Drawing.Point(283, 60);
            this.ColorTxt.Name = "ColorTxt";
            this.ColorTxt.Size = new System.Drawing.Size(100, 20);
            this.ColorTxt.TabIndex = 28;
            // 
            // flcolor
            // 
            this.flcolor.Location = new System.Drawing.Point(389, 58);
            this.flcolor.Name = "flcolor";
            this.flcolor.Size = new System.Drawing.Size(33, 23);
            this.flcolor.TabIndex = 30;
            this.flcolor.Text = "...";
            this.flcolor.UseVisualStyleBackColor = true;
            this.flcolor.Click += new System.EventHandler(this.flcolor_Click);
            // 
            // checkBoxWhiteSSIM
            // 
            this.checkBoxWhiteSSIM.AutoSize = true;
            this.checkBoxWhiteSSIM.Location = new System.Drawing.Point(171, 150);
            this.checkBoxWhiteSSIM.Name = "checkBoxWhiteSSIM";
            this.checkBoxWhiteSSIM.Size = new System.Drawing.Size(183, 17);
            this.checkBoxWhiteSSIM.TabIndex = 27;
            this.checkBoxWhiteSSIM.Text = "Generate SSIM with color pattern";
            this.checkBoxWhiteSSIM.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.DarkGray;
            this.label35.Location = new System.Drawing.Point(38, 19);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(326, 26);
            this.label35.TabIndex = 1;
            this.label35.Text = "SSIM Metric and Categorization";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(7, 215);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(465, 382);
            this.zedGraphControl1.TabIndex = 26;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // original
            // 
            this.original.AutoSize = true;
            this.original.Location = new System.Drawing.Point(17, 61);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(42, 13);
            this.original.TabIndex = 15;
            this.original.Text = "Original";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "width";
            // 
            // OrigTxt
            // 
            this.OrigTxt.Location = new System.Drawing.Point(65, 58);
            this.OrigTxt.Name = "OrigTxt";
            this.OrigTxt.Size = new System.Drawing.Size(100, 20);
            this.OrigTxt.TabIndex = 13;
            // 
            // DecTxt
            // 
            this.DecTxt.Location = new System.Drawing.Point(65, 82);
            this.DecTxt.Name = "DecTxt";
            this.DecTxt.Size = new System.Drawing.Size(100, 20);
            this.DecTxt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Decoded";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Compute SSIM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(141, 182);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(75, 23);
            this.btnGraph.TabIndex = 25;
            this.btnGraph.Text = "Graph";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "height";
            // 
            // chkTemp
            // 
            this.chkTemp.AutoSize = true;
            this.chkTemp.Location = new System.Drawing.Point(171, 129);
            this.chkTemp.Name = "chkTemp";
            this.chkTemp.Size = new System.Drawing.Size(140, 17);
            this.chkTemp.TabIndex = 24;
            this.chkTemp.Text = "Temporal Categorization";
            this.chkTemp.UseVisualStyleBackColor = true;
            // 
            // florig
            // 
            this.florig.Location = new System.Drawing.Point(171, 58);
            this.florig.Name = "florig";
            this.florig.Size = new System.Drawing.Size(33, 23);
            this.florig.TabIndex = 20;
            this.florig.Text = "...";
            this.florig.UseVisualStyleBackColor = true;
            this.florig.Click += new System.EventHandler(this.florig_Click);
            // 
            // heightTxt
            // 
            this.heightTxt.FormattingEnabled = true;
            this.heightTxt.Items.AddRange(new object[] {
            "1080\t",
            "832",
            "720",
            "480",
            "240",
            "288",
            "144"});
            this.heightTxt.Location = new System.Drawing.Point(65, 131);
            this.heightTxt.Name = "heightTxt";
            this.heightTxt.Size = new System.Drawing.Size(100, 21);
            this.heightTxt.TabIndex = 23;
            // 
            // fldec
            // 
            this.fldec.Location = new System.Drawing.Point(171, 85);
            this.fldec.Name = "fldec";
            this.fldec.Size = new System.Drawing.Size(33, 23);
            this.fldec.TabIndex = 21;
            this.fldec.Text = "...";
            this.fldec.UseVisualStyleBackColor = true;
            this.fldec.Click += new System.EventHandler(this.fldec_Click);
            // 
            // widthTxt
            // 
            this.widthTxt.FormattingEnabled = true;
            this.widthTxt.Items.AddRange(new object[] {
            "1920",
            "1280",
            "832",
            "640",
            "480",
            "416",
            "352",
            "176"});
            this.widthTxt.Location = new System.Drawing.Point(65, 105);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(100, 21);
            this.widthTxt.TabIndex = 22;
            // 
            // btnNextTab
            // 
            this.btnNextTab.Location = new System.Drawing.Point(350, 21);
            this.btnNextTab.Name = "btnNextTab";
            this.btnNextTab.Size = new System.Drawing.Size(75, 23);
            this.btnNextTab.TabIndex = 34;
            this.btnNextTab.Text = ">>";
            this.btnNextTab.UseVisualStyleBackColor = true;
            this.btnNextTab.Click += new System.EventHandler(this.btnNextTab_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 154);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(146, 23);
            this.progressBar1.TabIndex = 31;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.DarkGray;
            this.label34.Location = new System.Drawing.Point(29, 19);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(301, 26);
            this.label34.TabIndex = 0;
            this.label34.Text = "Motion Vector Categorization";
            // 
            // txtXmlOut
            // 
            this.txtXmlOut.Location = new System.Drawing.Point(24, 182);
            this.txtXmlOut.Multiline = true;
            this.txtXmlOut.Name = "txtXmlOut";
            this.txtXmlOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXmlOut.Size = new System.Drawing.Size(399, 415);
            this.txtXmlOut.TabIndex = 30;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(295, 125);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(128, 23);
            this.btnClearLog.TabIndex = 33;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnVectors
            // 
            this.btnVectors.Location = new System.Drawing.Point(27, 125);
            this.btnVectors.Name = "btnVectors";
            this.btnVectors.Size = new System.Drawing.Size(128, 23);
            this.btnVectors.TabIndex = 27;
            this.btnVectors.Text = "Write to Memory";
            this.btnVectors.UseVisualStyleBackColor = true;
            this.btnVectors.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExcelMotion
            // 
            this.btnExcelMotion.Enabled = false;
            this.btnExcelMotion.Location = new System.Drawing.Point(161, 125);
            this.btnExcelMotion.Name = "btnExcelMotion";
            this.btnExcelMotion.Size = new System.Drawing.Size(128, 23);
            this.btnExcelMotion.TabIndex = 32;
            this.btnExcelMotion.Text = "Export Excel";
            this.btnExcelMotion.UseVisualStyleBackColor = true;
            this.btnExcelMotion.Click += new System.EventHandler(this.btnExcelMotion_Click);
            // 
            // excel2matlab
            // 
            this.excel2matlab.Controls.Add(this.btnGenMotionExcel);
            this.excel2matlab.Controls.Add(this.txtExcelMVfiles);
            this.excel2matlab.Controls.Add(this.btnExcelMVFiles);
            this.excel2matlab.Controls.Add(this.label37);
            this.excel2matlab.Controls.Add(this.txtMatlabScript);
            this.excel2matlab.Controls.Add(this.btnMatlabScr);
            this.excel2matlab.Location = new System.Drawing.Point(4, 22);
            this.excel2matlab.Name = "excel2matlab";
            this.excel2matlab.Size = new System.Drawing.Size(958, 606);
            this.excel2matlab.TabIndex = 4;
            this.excel2matlab.Text = "MV Excels to Excel or MATlab";
            this.excel2matlab.UseVisualStyleBackColor = true;
            // 
            // btnGenMotionExcel
            // 
            this.btnGenMotionExcel.Location = new System.Drawing.Point(198, 133);
            this.btnGenMotionExcel.Name = "btnGenMotionExcel";
            this.btnGenMotionExcel.Size = new System.Drawing.Size(150, 23);
            this.btnGenMotionExcel.TabIndex = 38;
            this.btnGenMotionExcel.Text = "Generate Excel File";
            this.btnGenMotionExcel.UseVisualStyleBackColor = true;
            this.btnGenMotionExcel.Click += new System.EventHandler(this.btnGenMotionExcel_Click);
            // 
            // txtExcelMVfiles
            // 
            this.txtExcelMVfiles.Location = new System.Drawing.Point(102, 44);
            this.txtExcelMVfiles.Multiline = true;
            this.txtExcelMVfiles.Name = "txtExcelMVfiles";
            this.txtExcelMVfiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExcelMVfiles.Size = new System.Drawing.Size(213, 83);
            this.txtExcelMVfiles.TabIndex = 34;
            // 
            // btnExcelMVFiles
            // 
            this.btnExcelMVFiles.Location = new System.Drawing.Point(321, 44);
            this.btnExcelMVFiles.Name = "btnExcelMVFiles";
            this.btnExcelMVFiles.Size = new System.Drawing.Size(33, 23);
            this.btnExcelMVFiles.TabIndex = 35;
            this.btnExcelMVFiles.Text = "...";
            this.btnExcelMVFiles.UseVisualStyleBackColor = true;
            this.btnExcelMVFiles.Click += new System.EventHandler(this.btnExcelMVFiles_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(39, 47);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(57, 13);
            this.label37.TabIndex = 37;
            this.label37.Text = "Excel Files";
            // 
            // txtMatlabScript
            // 
            this.txtMatlabScript.Location = new System.Drawing.Point(42, 162);
            this.txtMatlabScript.Multiline = true;
            this.txtMatlabScript.Name = "txtMatlabScript";
            this.txtMatlabScript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMatlabScript.Size = new System.Drawing.Size(312, 295);
            this.txtMatlabScript.TabIndex = 36;
            // 
            // btnMatlabScr
            // 
            this.btnMatlabScr.Location = new System.Drawing.Point(42, 133);
            this.btnMatlabScr.Name = "btnMatlabScr";
            this.btnMatlabScr.Size = new System.Drawing.Size(150, 23);
            this.btnMatlabScr.TabIndex = 33;
            this.btnMatlabScr.Text = "Generate Matlab Script";
            this.btnMatlabScr.UseVisualStyleBackColor = true;
            this.btnMatlabScr.Click += new System.EventHandler(this.btnMatlabScr_Click);
            // 
            // encoder
            // 
            this.encoder.Controls.Add(this.label31);
            this.encoder.Controls.Add(this.label30);
            this.encoder.Controls.Add(this.txtErr);
            this.encoder.Controls.Add(this.btnEncode);
            this.encoder.Controls.Add(this.tabControl2);
            this.encoder.Controls.Add(this.txtFrameRate);
            this.encoder.Controls.Add(this.label14);
            this.encoder.Controls.Add(this.txtFrames);
            this.encoder.Controls.Add(this.label13);
            this.encoder.Controls.Add(this.comboHeight);
            this.encoder.Controls.Add(this.comboWidth);
            this.encoder.Controls.Add(this.label11);
            this.encoder.Controls.Add(this.label12);
            this.encoder.Controls.Add(this.listBoxEncodingScenarios);
            this.encoder.Controls.Add(this.btnAddEncodingScenario);
            this.encoder.Controls.Add(this.btnFileEncoder);
            this.encoder.Controls.Add(this.txtEncoderFile);
            this.encoder.Controls.Add(this.label10);
            this.encoder.Controls.Add(this.btnOrigFile);
            this.encoder.Controls.Add(this.txtOrigFile);
            this.encoder.Controls.Add(this.label7);
            this.encoder.Location = new System.Drawing.Point(4, 22);
            this.encoder.Name = "encoder";
            this.encoder.Size = new System.Drawing.Size(958, 606);
            this.encoder.TabIndex = 3;
            this.encoder.Text = "Encoder";
            this.encoder.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(392, 167);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(88, 13);
            this.label31.TabIndex = 64;
            this.label31.Text = "Bitrate Encoding:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(407, 145);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(73, 13);
            this.label30.TabIndex = 63;
            this.label30.Text = "QP Encoding:";
            // 
            // txtErr
            // 
            this.txtErr.AutoSize = true;
            this.txtErr.ForeColor = System.Drawing.Color.Red;
            this.txtErr.Location = new System.Drawing.Point(7, 494);
            this.txtErr.Name = "txtErr";
            this.txtErr.Size = new System.Drawing.Size(29, 13);
            this.txtErr.TabIndex = 42;
            this.txtErr.Text = "Error";
            // 
            // btnEncode
            // 
            this.btnEncode.Enabled = false;
            this.btnEncode.Location = new System.Drawing.Point(395, 429);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(97, 62);
            this.btnEncode.TabIndex = 41;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(6, 123);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(378, 173);
            this.tabControl2.TabIndex = 40;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label29);
            this.tabPage5.Controls.Add(this.label28);
            this.tabPage5.Controls.Add(this.label27);
            this.tabPage5.Controls.Add(this.textBox15);
            this.tabPage5.Controls.Add(this.label25);
            this.tabPage5.Controls.Add(this.textBox16);
            this.tabPage5.Controls.Add(this.label26);
            this.tabPage5.Controls.Add(this.textBox13);
            this.tabPage5.Controls.Add(this.label23);
            this.tabPage5.Controls.Add(this.textBox14);
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Controls.Add(this.textBox12);
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Controls.Add(this.textBox11);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.btnQPEncoding);
            this.tabPage5.Controls.Add(this.txtQPBSlice);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.txtQPPSlice);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.txtQPISlice);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(370, 147);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "QP";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(328, 88);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(31, 13);
            this.label29.TabIndex = 62;
            this.label29.Text = "times";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(329, 55);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(31, 13);
            this.label28.TabIndex = 61;
            this.label28.Text = "times";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(329, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(31, 13);
            this.label27.TabIndex = 60;
            this.label27.Text = "times";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(286, 85);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(36, 20);
            this.textBox15.TabIndex = 59;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(268, 88);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(12, 13);
            this.label25.TabIndex = 58;
            this.label25.Text = "x";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(229, 85);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(33, 20);
            this.textBox16.TabIndex = 57;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(185, 88);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(42, 13);
            this.label26.TabIndex = 56;
            this.label26.Text = "Step B:";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(285, 52);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(36, 20);
            this.textBox13.TabIndex = 55;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(267, 55);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(12, 13);
            this.label23.TabIndex = 54;
            this.label23.Text = "x";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(228, 52);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(33, 20);
            this.textBox14.TabIndex = 53;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(184, 55);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 13);
            this.label24.TabIndex = 52;
            this.label24.Text = "Step P:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(285, 17);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(36, 20);
            this.textBox12.TabIndex = 51;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(267, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(12, 13);
            this.label22.TabIndex = 50;
            this.label22.Text = "x";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(228, 17);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(33, 20);
            this.textBox11.TabIndex = 49;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(184, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "Step I:";
            // 
            // btnQPEncoding
            // 
            this.btnQPEncoding.Location = new System.Drawing.Point(78, 118);
            this.btnQPEncoding.Name = "btnQPEncoding";
            this.btnQPEncoding.Size = new System.Drawing.Size(146, 23);
            this.btnQPEncoding.TabIndex = 47;
            this.btnQPEncoding.Text = "QP Encoding";
            this.btnQPEncoding.UseVisualStyleBackColor = true;
            this.btnQPEncoding.Click += new System.EventHandler(this.btnQPEncoding_Click);
            // 
            // txtQPBSlice
            // 
            this.txtQPBSlice.Location = new System.Drawing.Point(78, 83);
            this.txtQPBSlice.Name = "txtQPBSlice";
            this.txtQPBSlice.Size = new System.Drawing.Size(100, 20);
            this.txtQPBSlice.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "QP B-Slice:";
            // 
            // txtQPPSlice
            // 
            this.txtQPPSlice.Location = new System.Drawing.Point(78, 50);
            this.txtQPPSlice.Name = "txtQPPSlice";
            this.txtQPPSlice.Size = new System.Drawing.Size(100, 20);
            this.txtQPPSlice.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "QP P-Slice:";
            // 
            // txtQPISlice
            // 
            this.txtQPISlice.Location = new System.Drawing.Point(78, 17);
            this.txtQPISlice.Name = "txtQPISlice";
            this.txtQPISlice.Size = new System.Drawing.Size(100, 20);
            this.txtQPISlice.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "QP I-Slice:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txtStepBitrate);
            this.tabPage6.Controls.Add(this.label20);
            this.tabPage6.Controls.Add(this.txtEndBitrate);
            this.tabPage6.Controls.Add(this.label18);
            this.tabPage6.Controls.Add(this.btnBitrateEncoding);
            this.tabPage6.Controls.Add(this.txtStartBitrate);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(370, 147);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Bitrate";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txtStepBitrate
            // 
            this.txtStepBitrate.Location = new System.Drawing.Point(117, 72);
            this.txtStepBitrate.Name = "txtStepBitrate";
            this.txtStepBitrate.Size = new System.Drawing.Size(100, 20);
            this.txtStepBitrate.TabIndex = 51;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = "Step Bitrate in Mbps:";
            // 
            // txtEndBitrate
            // 
            this.txtEndBitrate.Location = new System.Drawing.Point(117, 46);
            this.txtEndBitrate.Name = "txtEndBitrate";
            this.txtEndBitrate.Size = new System.Drawing.Size(100, 20);
            this.txtEndBitrate.TabIndex = 49;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "End Bitrate in Mbps:";
            // 
            // btnBitrateEncoding
            // 
            this.btnBitrateEncoding.Location = new System.Drawing.Point(117, 98);
            this.btnBitrateEncoding.Name = "btnBitrateEncoding";
            this.btnBitrateEncoding.Size = new System.Drawing.Size(100, 43);
            this.btnBitrateEncoding.TabIndex = 47;
            this.btnBitrateEncoding.Text = "Bitrate Encoding";
            this.btnBitrateEncoding.UseVisualStyleBackColor = true;
            this.btnBitrateEncoding.Click += new System.EventHandler(this.btnBitrateEncoding_Click);
            // 
            // txtStartBitrate
            // 
            this.txtStartBitrate.Location = new System.Drawing.Point(117, 12);
            this.txtStartBitrate.Name = "txtStartBitrate";
            this.txtStartBitrate.Size = new System.Drawing.Size(100, 20);
            this.txtStartBitrate.TabIndex = 46;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "Start Bitrate in Mbps:";
            // 
            // txtFrameRate
            // 
            this.txtFrameRate.Location = new System.Drawing.Point(275, 95);
            this.txtFrameRate.Name = "txtFrameRate";
            this.txtFrameRate.Size = new System.Drawing.Size(100, 20);
            this.txtFrameRate.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(203, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Frame Rate:";
            // 
            // txtFrames
            // 
            this.txtFrames.Location = new System.Drawing.Point(75, 97);
            this.txtFrames.Name = "txtFrames";
            this.txtFrames.Size = new System.Drawing.Size(100, 20);
            this.txtFrames.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Frames:";
            // 
            // comboHeight
            // 
            this.comboHeight.FormattingEnabled = true;
            this.comboHeight.Items.AddRange(new object[] {
            "1080\t",
            "832",
            "720",
            "480",
            "240",
            "288",
            "144"});
            this.comboHeight.Location = new System.Drawing.Point(284, 36);
            this.comboHeight.Name = "comboHeight";
            this.comboHeight.Size = new System.Drawing.Size(100, 21);
            this.comboHeight.TabIndex = 35;
            // 
            // comboWidth
            // 
            this.comboWidth.FormattingEnabled = true;
            this.comboWidth.Items.AddRange(new object[] {
            "1920",
            "1280",
            "832",
            "640",
            "480",
            "416",
            "352",
            "176"});
            this.comboWidth.Location = new System.Drawing.Point(284, 10);
            this.comboWidth.Name = "comboWidth";
            this.comboWidth.Size = new System.Drawing.Size(100, 21);
            this.comboWidth.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "height";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(232, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "width";
            // 
            // listBoxEncodingScenarios
            // 
            this.listBoxEncodingScenarios.FormattingEnabled = true;
            this.listBoxEncodingScenarios.Location = new System.Drawing.Point(6, 331);
            this.listBoxEncodingScenarios.Name = "listBoxEncodingScenarios";
            this.listBoxEncodingScenarios.ScrollAlwaysVisible = true;
            this.listBoxEncodingScenarios.Size = new System.Drawing.Size(383, 160);
            this.listBoxEncodingScenarios.TabIndex = 31;
            // 
            // btnAddEncodingScenario
            // 
            this.btnAddEncodingScenario.Enabled = false;
            this.btnAddEncodingScenario.Location = new System.Drawing.Point(6, 302);
            this.btnAddEncodingScenario.Name = "btnAddEncodingScenario";
            this.btnAddEncodingScenario.Size = new System.Drawing.Size(134, 23);
            this.btnAddEncodingScenario.TabIndex = 30;
            this.btnAddEncodingScenario.Text = "Add Encoding Scenario";
            this.btnAddEncodingScenario.UseVisualStyleBackColor = true;
            this.btnAddEncodingScenario.Click += new System.EventHandler(this.btnAddEncodingScenario_Click);
            // 
            // btnFileEncoder
            // 
            this.btnFileEncoder.Location = new System.Drawing.Point(181, 47);
            this.btnFileEncoder.Name = "btnFileEncoder";
            this.btnFileEncoder.Size = new System.Drawing.Size(33, 23);
            this.btnFileEncoder.TabIndex = 27;
            this.btnFileEncoder.Text = "...";
            this.btnFileEncoder.UseVisualStyleBackColor = true;
            this.btnFileEncoder.Click += new System.EventHandler(this.btnFileEncoder_Click);
            // 
            // txtEncoderFile
            // 
            this.txtEncoderFile.Location = new System.Drawing.Point(75, 47);
            this.txtEncoderFile.Name = "txtEncoderFile";
            this.txtEncoderFile.Size = new System.Drawing.Size(100, 20);
            this.txtEncoderFile.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Encoder:";
            // 
            // btnOrigFile
            // 
            this.btnOrigFile.Location = new System.Drawing.Point(181, 13);
            this.btnOrigFile.Name = "btnOrigFile";
            this.btnOrigFile.Size = new System.Drawing.Size(33, 23);
            this.btnOrigFile.TabIndex = 24;
            this.btnOrigFile.Text = "...";
            this.btnOrigFile.UseVisualStyleBackColor = true;
            this.btnOrigFile.Click += new System.EventHandler(this.btnOrigFile_Click);
            // 
            // txtOrigFile
            // 
            this.txtOrigFile.Location = new System.Drawing.Point(75, 13);
            this.txtOrigFile.Name = "txtOrigFile";
            this.txtOrigFile.Size = new System.Drawing.Size(100, 20);
            this.txtOrigFile.TabIndex = 23;
            this.txtOrigFile.TextChanged += new System.EventHandler(this.txtOrigFile_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Original File:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // yuv_color_converter
            // 
            this.yuv_color_converter.Controls.Add(this.comboBoxPattern);
            this.yuv_color_converter.Controls.Add(this.label9);
            this.yuv_color_converter.Controls.Add(this.comboBoxH);
            this.yuv_color_converter.Controls.Add(this.comboBoxW);
            this.yuv_color_converter.Controls.Add(this.flOrigYUV);
            this.yuv_color_converter.Controls.Add(this.label5);
            this.yuv_color_converter.Controls.Add(this.btnConvert);
            this.yuv_color_converter.Controls.Add(this.label6);
            this.yuv_color_converter.Controls.Add(this.label8);
            this.yuv_color_converter.Controls.Add(this.txtOrigYUV);
            this.yuv_color_converter.Location = new System.Drawing.Point(4, 22);
            this.yuv_color_converter.Name = "yuv_color_converter";
            this.yuv_color_converter.Size = new System.Drawing.Size(958, 606);
            this.yuv_color_converter.TabIndex = 2;
            this.yuv_color_converter.Text = "YUV Color Conversion";
            this.yuv_color_converter.UseVisualStyleBackColor = true;
            // 
            // comboBoxPattern
            // 
            this.comboBoxPattern.FormattingEnabled = true;
            this.comboBoxPattern.Items.AddRange(new object[] {
            "white",
            "black",
            "grey"});
            this.comboBoxPattern.Location = new System.Drawing.Point(85, 101);
            this.comboBoxPattern.Name = "comboBoxPattern";
            this.comboBoxPattern.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPattern.TabIndex = 36;
            this.comboBoxPattern.Text = "white";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Pattern";
            // 
            // comboBoxH
            // 
            this.comboBoxH.FormattingEnabled = true;
            this.comboBoxH.Items.AddRange(new object[] {
            "1080\t",
            "720",
            "480",
            "240",
            "288",
            "144"});
            this.comboBoxH.Location = new System.Drawing.Point(85, 76);
            this.comboBoxH.Name = "comboBoxH";
            this.comboBoxH.Size = new System.Drawing.Size(100, 21);
            this.comboBoxH.TabIndex = 34;
            // 
            // comboBoxW
            // 
            this.comboBoxW.FormattingEnabled = true;
            this.comboBoxW.Items.AddRange(new object[] {
            "1920",
            "1280",
            "640",
            "416",
            "352",
            "176"});
            this.comboBoxW.Location = new System.Drawing.Point(85, 50);
            this.comboBoxW.Name = "comboBoxW";
            this.comboBoxW.Size = new System.Drawing.Size(100, 21);
            this.comboBoxW.TabIndex = 33;
            // 
            // flOrigYUV
            // 
            this.flOrigYUV.Location = new System.Drawing.Point(191, 15);
            this.flOrigYUV.Name = "flOrigYUV";
            this.flOrigYUV.Size = new System.Drawing.Size(33, 23);
            this.flOrigYUV.TabIndex = 31;
            this.flOrigYUV.Text = "...";
            this.flOrigYUV.UseVisualStyleBackColor = true;
            this.flOrigYUV.Click += new System.EventHandler(this.florig_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "height";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(85, 144);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 29;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "width";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "YUV";
            // 
            // txtOrigYUV
            // 
            this.txtOrigYUV.Location = new System.Drawing.Point(85, 17);
            this.txtOrigYUV.Name = "txtOrigYUV";
            this.txtOrigYUV.Size = new System.Drawing.Size(100, 20);
            this.txtOrigYUV.TabIndex = 24;
            // 
            // temporal_evaluation
            // 
            this.temporal_evaluation.Controls.Add(this.checkedFoldersQP);
            this.temporal_evaluation.Controls.Add(this.btnFindQps);
            this.temporal_evaluation.Controls.Add(this.flroot);
            this.temporal_evaluation.Controls.Add(this.txtRoot);
            this.temporal_evaluation.Controls.Add(this.label4);
            this.temporal_evaluation.Controls.Add(this.btnTempCur);
            this.temporal_evaluation.Location = new System.Drawing.Point(4, 22);
            this.temporal_evaluation.Name = "temporal_evaluation";
            this.temporal_evaluation.Padding = new System.Windows.Forms.Padding(3);
            this.temporal_evaluation.Size = new System.Drawing.Size(958, 606);
            this.temporal_evaluation.TabIndex = 1;
            this.temporal_evaluation.Text = "Temporal Evalution";
            this.temporal_evaluation.UseVisualStyleBackColor = true;
            // 
            // checkedFoldersQP
            // 
            this.checkedFoldersQP.FormattingEnabled = true;
            this.checkedFoldersQP.HorizontalScrollbar = true;
            this.checkedFoldersQP.Location = new System.Drawing.Point(40, 87);
            this.checkedFoldersQP.Name = "checkedFoldersQP";
            this.checkedFoldersQP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedFoldersQP.Size = new System.Drawing.Size(319, 139);
            this.checkedFoldersQP.TabIndex = 24;
            this.checkedFoldersQP.SelectedIndexChanged += new System.EventHandler(this.checkedFoldersQP_SelectedIndexChanged);
            // 
            // btnFindQps
            // 
            this.btnFindQps.Location = new System.Drawing.Point(173, 46);
            this.btnFindQps.Name = "btnFindQps";
            this.btnFindQps.Size = new System.Drawing.Size(75, 27);
            this.btnFindQps.TabIndex = 22;
            this.btnFindQps.Text = "Find QPs";
            this.btnFindQps.UseVisualStyleBackColor = true;
            this.btnFindQps.Click += new System.EventHandler(this.btnFindQps_Click);
            // 
            // flroot
            // 
            this.flroot.Location = new System.Drawing.Point(215, 17);
            this.flroot.Name = "flroot";
            this.flroot.Size = new System.Drawing.Size(33, 23);
            this.flroot.TabIndex = 21;
            this.flroot.Text = "...";
            this.flroot.UseVisualStyleBackColor = true;
            this.flroot.Click += new System.EventHandler(this.flroot_Click);
            // 
            // txtRoot
            // 
            this.txtRoot.Location = new System.Drawing.Point(109, 17);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.Size = new System.Drawing.Size(100, 20);
            this.txtRoot.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Root Folder:";
            // 
            // btnTempCur
            // 
            this.btnTempCur.Location = new System.Drawing.Point(40, 257);
            this.btnTempCur.Name = "btnTempCur";
            this.btnTempCur.Size = new System.Drawing.Size(75, 42);
            this.btnTempCur.TabIndex = 0;
            this.btnTempCur.Text = "Calculate Videos";
            this.btnTempCur.UseVisualStyleBackColor = true;
            this.btnTempCur.Click += new System.EventHandler(this.btnTempCur_Click);
            // 
            // openFileDialogEnc
            // 
            this.openFileDialogEnc.FileName = "openFileDialogEnc";
            // 
            // openFileDialogXml
            // 
            this.openFileDialogXml.FileName = "openFileDialogXml";
            // 
            // openFileDialogExcel
            // 
            this.openFileDialogExcel.FileName = "openFileDialogExcel";
            this.openFileDialogExcel.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(987, 668);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "MN LAB Video Tools";
            this.tabControl1.ResumeLayout(false);
            this.ssim_video_cat.ResumeLayout(false);
            this.ssim_video_cat.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.excel2matlab.ResumeLayout(false);
            this.excel2matlab.PerformLayout();
            this.encoder.ResumeLayout(false);
            this.encoder.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.yuv_color_converter.ResumeLayout(false);
            this.yuv_color_converter.PerformLayout();
            this.temporal_evaluation.ResumeLayout(false);
            this.temporal_evaluation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ssim_video_cat;
        private System.Windows.Forms.ComboBox heightTxt;
        private System.Windows.Forms.ComboBox widthTxt;
        private System.Windows.Forms.Button fldec;
        private System.Windows.Forms.Button florig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label original;
        private System.Windows.Forms.TextBox DecTxt;
        private System.Windows.Forms.TextBox OrigTxt;
        private System.Windows.Forms.TabPage temporal_evaluation;
        private System.Windows.Forms.Button btnTempCur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button flroot;
        private System.Windows.Forms.TextBox txtRoot;
        private System.Windows.Forms.Button btnFindQps;
        private System.Windows.Forms.CheckedListBox checkedFoldersQP;
        private System.Windows.Forms.TabPage yuv_color_converter;
        private System.Windows.Forms.ComboBox comboBoxH;
        private System.Windows.Forms.ComboBox comboBoxW;
        private System.Windows.Forms.Button flOrigYUV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOrigYUV;
        private System.Windows.Forms.ComboBox comboBoxPattern;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkTemp;
        private System.Windows.Forms.Button btnGraph;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TabPage encoder;
        private System.Windows.Forms.ComboBox comboHeight;
        private System.Windows.Forms.ComboBox comboWidth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBoxEncodingScenarios;
        private System.Windows.Forms.Button btnAddEncodingScenario;
        private System.Windows.Forms.Button btnFileEncoder;
        private System.Windows.Forms.TextBox txtEncoderFile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOrigFile;
        private System.Windows.Forms.TextBox txtOrigFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtErr;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnQPEncoding;
        private System.Windows.Forms.TextBox txtQPBSlice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtQPPSlice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtQPISlice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txtStepBitrate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtEndBitrate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnBitrateEncoding;
        private System.Windows.Forms.TextBox txtStartBitrate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtFrameRate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFrames;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.OpenFileDialog openFileDialogEnc;
        private System.Windows.Forms.Button btnVectors;
        private System.Windows.Forms.Button btnFileXml;
        private System.Windows.Forms.TextBox txtXmlFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogXml;
        private System.Windows.Forms.TextBox txtXmlOut;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btnExcelMotion;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.CheckBox checkBoxWhiteSSIM;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox ColorTxt;
        private System.Windows.Forms.Button flcolor;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabPage excel2matlab;
        private System.Windows.Forms.Button btnNextTab;
        private System.Windows.Forms.TextBox txtExcelMVfiles;
        private System.Windows.Forms.Button btnExcelMVFiles;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtMatlabScript;
        private System.Windows.Forms.Button btnMatlabScr;
        private System.Windows.Forms.OpenFileDialog openFileDialogExcel;
        private System.Windows.Forms.Button btnGenMotionExcel;
    }
}

