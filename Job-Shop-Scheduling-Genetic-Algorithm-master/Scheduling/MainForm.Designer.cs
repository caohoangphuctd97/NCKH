namespace Scheduling
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnHideRes = new System.Windows.Forms.Button();
            this.btnHideBoxes = new System.Windows.Forms.Button();
            this.nmudmac = new System.Windows.Forms.NumericUpDown();
            this.nmudproc = new System.Windows.Forms.NumericUpDown();
            this.nmudjob = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrepare = new System.Windows.Forms.Button();
            this.btnClearBoxes = new System.Windows.Forms.Button();
            this.resPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRandom = new System.Windows.Forms.Button();
            this.popnmud = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.mutnmud = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupnmud = new System.Windows.Forms.NumericUpDown();
            this.lblSpan = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblIdleTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.namelabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBestTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.nmudMinTime = new System.Windows.Forms.NumericUpDown();
            this.cbCOTypes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRefresh = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMutTypes = new System.Windows.Forms.ComboBox();
            this.cbSelTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSampleData = new System.Windows.Forms.Button();
            this.lblWorkingTime = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnExportXml = new System.Windows.Forms.Button();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nmudmac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudproc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudjob)).BeginInit();
            this.resPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popnmud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutnmud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupnmud)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudMinTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.CausesValidation = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.Color.Green;
            this.btnStart.Location = new System.Drawing.Point(16, 175);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 46);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "RUN";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(124, 175);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 44);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnHideRes
            // 
            this.btnHideRes.Location = new System.Drawing.Point(19, 428);
            this.btnHideRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHideRes.Name = "btnHideRes";
            this.btnHideRes.Size = new System.Drawing.Size(100, 44);
            this.btnHideRes.TabIndex = 4;
            this.btnHideRes.Text = ">>";
            this.btnHideRes.UseVisualStyleBackColor = true;
            // 
            // btnHideBoxes
            // 
            this.btnHideBoxes.Location = new System.Drawing.Point(16, 230);
            this.btnHideBoxes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHideBoxes.Name = "btnHideBoxes";
            this.btnHideBoxes.Size = new System.Drawing.Size(100, 44);
            this.btnHideBoxes.TabIndex = 4;
            this.btnHideBoxes.Text = ">>";
            this.btnHideBoxes.UseVisualStyleBackColor = true;
            // 
            // nmudmac
            // 
            this.nmudmac.Location = new System.Drawing.Point(92, 102);
            this.nmudmac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmudmac.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nmudmac.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudmac.Name = "nmudmac";
            this.nmudmac.Size = new System.Drawing.Size(63, 22);
            this.nmudmac.TabIndex = 5;
            this.nmudmac.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nmudproc
            // 
            this.nmudproc.Location = new System.Drawing.Point(92, 70);
            this.nmudproc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmudproc.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nmudproc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudproc.Name = "nmudproc";
            this.nmudproc.Size = new System.Drawing.Size(63, 22);
            this.nmudproc.TabIndex = 5;
            this.nmudproc.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nmudjob
            // 
            this.nmudjob.Location = new System.Drawing.Point(92, 37);
            this.nmudjob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmudjob.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nmudjob.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudjob.Name = "nmudjob";
            this.nmudjob.Size = new System.Drawing.Size(63, 22);
            this.nmudjob.TabIndex = 5;
            this.nmudjob.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Job:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Process:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Machine:";
            // 
            // btnPrepare
            // 
            this.btnPrepare.Location = new System.Drawing.Point(161, 33);
            this.btnPrepare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrepare.Name = "btnPrepare";
            this.btnPrepare.Size = new System.Drawing.Size(100, 32);
            this.btnPrepare.TabIndex = 4;
            this.btnPrepare.Text = "Create";
            this.btnPrepare.UseVisualStyleBackColor = true;
            // 
            // btnClearBoxes
            // 
            this.btnClearBoxes.Location = new System.Drawing.Point(161, 100);
            this.btnClearBoxes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearBoxes.Name = "btnClearBoxes";
            this.btnClearBoxes.Size = new System.Drawing.Size(100, 30);
            this.btnClearBoxes.TabIndex = 4;
            this.btnClearBoxes.Text = "Clear";
            this.btnClearBoxes.UseVisualStyleBackColor = true;
            // 
            // resPanel
            // 
            this.resPanel.BackColor = System.Drawing.Color.Transparent;
            this.resPanel.Controls.Add(this.panel1);
            this.resPanel.Location = new System.Drawing.Point(144, 428);
            this.resPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resPanel.Name = "resPanel";
            this.resPanel.Size = new System.Drawing.Size(853, 185);
            this.resPanel.TabIndex = 7;
            this.resPanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 176);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(161, 66);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(100, 32);
            this.btnRandom.TabIndex = 4;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // popnmud
            // 
            this.popnmud.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.popnmud.Location = new System.Drawing.Point(141, 21);
            this.popnmud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.popnmud.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.popnmud.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.popnmud.Name = "popnmud";
            this.popnmud.Size = new System.Drawing.Size(100, 22);
            this.popnmud.TabIndex = 8;
            this.popnmud.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mutation(%):";
            // 
            // mutnmud
            // 
            this.mutnmud.Location = new System.Drawing.Point(141, 57);
            this.mutnmud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mutnmud.Name = "mutnmud";
            this.mutnmud.Size = new System.Drawing.Size(100, 22);
            this.mutnmud.TabIndex = 8;
            this.mutnmud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Group Size:";
            // 
            // groupnmud
            // 
            this.groupnmud.Location = new System.Drawing.Point(141, 89);
            this.groupnmud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupnmud.Name = "groupnmud";
            this.groupnmud.Size = new System.Drawing.Size(100, 22);
            this.groupnmud.TabIndex = 8;
            this.groupnmud.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblSpan
            // 
            this.lblSpan.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblSpan.Name = "lblSpan";
            this.lblSpan.Size = new System.Drawing.Size(4, 20);
            // 
            // lblIdleTime
            // 
            this.lblIdleTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblIdleTime.Name = "lblIdleTime";
            this.lblIdleTime.Size = new System.Drawing.Size(4, 20);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.namelabel1,
            this.lblSpan,
            this.toolStripStatusLabel3,
            this.lblIdleTime,
            this.toolStripStatusLabel1,
            this.lblProgress,
            this.toolStripStatusLabel2,
            this.lblBestTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 662);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1065, 25);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // namelabel1
            // 
            this.namelabel1.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.namelabel1.Name = "namelabel1";
            this.namelabel1.Size = new System.Drawing.Size(79, 20);
            this.namelabel1.Text = "Makespan:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(111, 20);
            this.toolStripStatusLabel3.Text = "Total Idle Time:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 20);
            this.toolStripStatusLabel1.Text = "Progress:";
            // 
            // lblProgress
            // 
            this.lblProgress.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(4, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 20);
            this.toolStripStatusLabel2.Text = "Best found at:";
            // 
            // lblBestTime
            // 
            this.lblBestTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblBestTime.Name = "lblBestTime";
            this.lblBestTime.Size = new System.Drawing.Size(4, 20);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(284, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Min. Time(%):";
            // 
            // nmudMinTime
            // 
            this.nmudMinTime.Location = new System.Drawing.Point(408, 18);
            this.nmudMinTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmudMinTime.Name = "nmudMinTime";
            this.nmudMinTime.Size = new System.Drawing.Size(100, 22);
            this.nmudMinTime.TabIndex = 8;
            // 
            // cbCOTypes
            // 
            this.cbCOTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCOTypes.FormattingEnabled = true;
            this.cbCOTypes.Items.AddRange(new object[] {
            "Single Point",
            "Two-Point",
            "Uniform",
            "Ordered"});
            this.cbCOTypes.Location = new System.Drawing.Point(408, 119);
            this.cbCOTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCOTypes.Name = "cbCOTypes";
            this.cbCOTypes.Size = new System.Drawing.Size(160, 24);
            this.cbCOTypes.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Crossing Over:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRefresh);
            this.groupBox1.Controls.Add(this.groupnmud);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbMutTypes);
            this.groupBox1.Controls.Add(this.cbSelTypes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbCOTypes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nmudMinTime);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.popnmud);
            this.groupBox1.Controls.Add(this.mutnmud);
            this.groupBox1.Location = new System.Drawing.Point(303, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(747, 161);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // chkRefresh
            // 
            this.chkRefresh.AutoSize = true;
            this.chkRefresh.Location = new System.Drawing.Point(35, 124);
            this.chkRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRefresh.Name = "chkRefresh";
            this.chkRefresh.Size = new System.Drawing.Size(151, 21);
            this.chkRefresh.TabIndex = 13;
            this.chkRefresh.Text = "Refresh Population";
            this.chkRefresh.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Mutation Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 55);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Selection Type:";
            // 
            // cbMutTypes
            // 
            this.cbMutTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMutTypes.FormattingEnabled = true;
            this.cbMutTypes.Items.AddRange(new object[] {
            "Exchange Values",
            "Change Value",
            "Slip Block",
            "Replacement"});
            this.cbMutTypes.Location = new System.Drawing.Point(408, 85);
            this.cbMutTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMutTypes.Name = "cbMutTypes";
            this.cbMutTypes.Size = new System.Drawing.Size(160, 24);
            this.cbMutTypes.TabIndex = 10;
            // 
            // cbSelTypes
            // 
            this.cbSelTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelTypes.FormattingEnabled = true;
            this.cbSelTypes.Items.AddRange(new object[] {
            "Tournament",
            "Roulette Wheel"});
            this.cbSelTypes.Location = new System.Drawing.Point(408, 52);
            this.cbSelTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSelTypes.Name = "cbSelTypes";
            this.cbSelTypes.Size = new System.Drawing.Size(160, 24);
            this.cbSelTypes.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Population:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRandom);
            this.groupBox2.Controls.Add(this.btnPrepare);
            this.groupBox2.Controls.Add(this.btnClearBoxes);
            this.groupBox2.Controls.Add(this.nmudmac);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nmudproc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nmudjob);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(277, 161);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Data Table";
            // 
            // btnSampleData
            // 
            this.btnSampleData.Location = new System.Drawing.Point(275, 175);
            this.btnSampleData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSampleData.Name = "btnSampleData";
            this.btnSampleData.Size = new System.Drawing.Size(100, 46);
            this.btnSampleData.TabIndex = 14;
            this.btnSampleData.Text = "Sample Data";
            this.btnSampleData.UseVisualStyleBackColor = true;
            // 
            // lblWorkingTime
            // 
            this.lblWorkingTime.AutoSize = true;
            this.lblWorkingTime.Location = new System.Drawing.Point(5, 638);
            this.lblWorkingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkingTime.Name = "lblWorkingTime";
            this.lblWorkingTime.Size = new System.Drawing.Size(0, 17);
            this.lblWorkingTime.TabIndex = 15;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(383, 175);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(107, 44);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "GAMS Model";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnExportXml
            // 
            this.btnExportXml.Location = new System.Drawing.Point(497, 175);
            this.btnExportXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportXml.Name = "btnExportXml";
            this.btnExportXml.Size = new System.Drawing.Size(107, 44);
            this.btnExportXml.TabIndex = 16;
            this.btnExportXml.Text = "Export as XML";
            this.btnExportXml.UseVisualStyleBackColor = true;
            // 
            // btnLoadXml
            // 
            this.btnLoadXml.Location = new System.Drawing.Point(612, 176);
            this.btnLoadXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(107, 44);
            this.btnLoadXml.TabIndex = 16;
            this.btnLoadXml.Text = "Import XML";
            this.btnLoadXml.UseVisualStyleBackColor = true;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(727, 176);
            this.btnSelectPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(45, 43);
            this.btnSelectPath.TabIndex = 17;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(780, 186);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 22);
            this.textBox1.TabIndex = 18;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 687);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.btnLoadXml);
            this.Controls.Add(this.btnExportXml);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblWorkingTime);
            this.Controls.Add(this.btnSampleData);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.resPanel);
            this.Controls.Add(this.btnHideRes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHideBoxes);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "GA ";
            ((System.ComponentModel.ISupportInitialize)(this.nmudmac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudproc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudjob)).EndInit();
            this.resPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popnmud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutnmud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupnmud)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudMinTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnHideRes;
        private System.Windows.Forms.Button btnHideBoxes;
        private System.Windows.Forms.NumericUpDown nmudmac;
        private System.Windows.Forms.NumericUpDown nmudproc;
        private System.Windows.Forms.NumericUpDown nmudjob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrepare;
        private System.Windows.Forms.Button btnClearBoxes;
        private System.Windows.Forms.Panel resPanel;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.NumericUpDown popnmud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown mutnmud;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown groupnmud;
        private System.Windows.Forms.ToolStripStatusLabel lblSpan;
        private System.Windows.Forms.ToolStripStatusLabel lblIdleTime;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel namelabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmudMinTime;
        private System.Windows.Forms.ComboBox cbCOTypes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblProgress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSelTypes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMutTypes;
        private System.Windows.Forms.Button btnSampleData;
        private System.Windows.Forms.ToolStripStatusLabel lblBestTime;
        private System.Windows.Forms.Label lblWorkingTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chkRefresh;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btnExportXml;
        private System.Windows.Forms.Button btnLoadXml;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

