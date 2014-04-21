namespace ReStar
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trvMachines = new System.Windows.Forms.TreeView();
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.tmrAdd = new System.Windows.Forms.Timer(this.components);
            this.rdoRestart = new System.Windows.Forms.RadioButton();
            this.rdoShutDown = new System.Windows.Forms.RadioButton();
            this.rdoAbort = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numTimer = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMinor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoPlanned = new System.Windows.Forms.RadioButton();
            this.rdoUnplanned = new System.Windows.Forms.RadioButton();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSend = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1068, 491);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1060, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Machines";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1054, 459);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1060, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Restart Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.trvMachines);
            this.splitContainer1.Size = new System.Drawing.Size(1054, 459);
            this.splitContainer1.SplitterDistance = 807;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoAbort);
            this.groupBox1.Controls.Add(this.rdoShutDown);
            this.groupBox1.Controls.Add(this.rdoRestart);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Options";
            // 
            // trvMachines
            // 
            this.trvMachines.CheckBoxes = true;
            this.trvMachines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvMachines.Location = new System.Drawing.Point(0, 0);
            this.trvMachines.Name = "trvMachines";
            this.trvMachines.Size = new System.Drawing.Size(243, 459);
            this.trvMachines.TabIndex = 0;
            // 
            // ofdMain
            // 
            this.ofdMain.Filter = "Text Files|*.txt|Comma Separated|*.csv";
            this.ofdMain.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdMain_FileOk);
            // 
            // tmrAdd
            // 
            this.tmrAdd.Interval = 500;
            this.tmrAdd.Tick += new System.EventHandler(this.tmrAdd_Tick);
            // 
            // rdoRestart
            // 
            this.rdoRestart.AutoSize = true;
            this.rdoRestart.Checked = true;
            this.rdoRestart.Location = new System.Drawing.Point(7, 20);
            this.rdoRestart.Name = "rdoRestart";
            this.rdoRestart.Size = new System.Drawing.Size(59, 17);
            this.rdoRestart.TabIndex = 0;
            this.rdoRestart.TabStop = true;
            this.rdoRestart.Text = "Restart";
            this.rdoRestart.UseVisualStyleBackColor = true;
            this.rdoRestart.CheckedChanged += new System.EventHandler(this.rdoRestart_CheckedChanged);
            // 
            // rdoShutDown
            // 
            this.rdoShutDown.AutoSize = true;
            this.rdoShutDown.Location = new System.Drawing.Point(7, 44);
            this.rdoShutDown.Name = "rdoShutDown";
            this.rdoShutDown.Size = new System.Drawing.Size(78, 17);
            this.rdoShutDown.TabIndex = 1;
            this.rdoShutDown.TabStop = true;
            this.rdoShutDown.Text = "Shut Down";
            this.rdoShutDown.UseVisualStyleBackColor = true;
            this.rdoShutDown.CheckedChanged += new System.EventHandler(this.rdoShutDown_CheckedChanged);
            // 
            // rdoAbort
            // 
            this.rdoAbort.AutoSize = true;
            this.rdoAbort.Location = new System.Drawing.Point(7, 68);
            this.rdoAbort.Name = "rdoAbort";
            this.rdoAbort.Size = new System.Drawing.Size(50, 17);
            this.rdoAbort.TabIndex = 2;
            this.rdoAbort.TabStop = true;
            this.rdoAbort.Text = "Abort";
            this.rdoAbort.UseVisualStyleBackColor = true;
            this.rdoAbort.CheckedChanged += new System.EventHandler(this.rdoAbort_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numTimer);
            this.groupBox2.Location = new System.Drawing.Point(5, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timer and Comments";
            // 
            // numTimer
            // 
            this.numTimer.Location = new System.Drawing.Point(7, 20);
            this.numTimer.Name = "numTimer";
            this.numTimer.Size = new System.Drawing.Size(78, 20);
            this.numTimer.TabIndex = 0;
            this.numTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTimer.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Timer ( in Seconds )";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 63);
            this.textBox1.MaxLength = 127;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 111);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comments ( Max. 127 characters )";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.rdoUnplanned);
            this.groupBox3.Controls.Add(this.rdoPlanned);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmbMinor);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbMajor);
            this.groupBox3.Location = new System.Drawing.Point(6, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(799, 152);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reason Codes";
            // 
            // cmbMajor
            // 
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Items.AddRange(new object[] {
            "Other ( 0 )",
            "Hardware ( 1 )",
            "Operating System ( 2 )",
            "Application ( 4 )",
            "System Failure ( 5 )",
            "Security Issue ( 5 )",
            "Network Loss ( 5 )"});
            this.cmbMajor.Location = new System.Drawing.Point(6, 19);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(166, 21);
            this.cmbMajor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Major Reason";
            // 
            // cmbMinor
            // 
            this.cmbMinor.FormattingEnabled = true;
            this.cmbMinor.Items.AddRange(new object[] {
            "Other ( 0 )",
            "Maintenance ( 1 )",
            "Installation ( 2 )",
            "Upgrade ( 3 )",
            "Reconfiguration ( 4 )",
            "Unresponsive ( 5 )",
            "Unstable ( 6 )",
            "Stop Error ( 15 )",
            "Service Pack ( 16 )",
            "Hot Fix ( 17 )",
            "Security Fix ( 18 )"});
            this.cmbMinor.Location = new System.Drawing.Point(6, 47);
            this.cmbMinor.Name = "cmbMinor";
            this.cmbMinor.Size = new System.Drawing.Size(166, 21);
            this.cmbMinor.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Minor Reason";
            // 
            // rdoPlanned
            // 
            this.rdoPlanned.AutoSize = true;
            this.rdoPlanned.Location = new System.Drawing.Point(9, 75);
            this.rdoPlanned.Name = "rdoPlanned";
            this.rdoPlanned.Size = new System.Drawing.Size(64, 17);
            this.rdoPlanned.TabIndex = 8;
            this.rdoPlanned.TabStop = true;
            this.rdoPlanned.Text = "Planned";
            this.rdoPlanned.UseVisualStyleBackColor = true;
            // 
            // rdoUnplanned
            // 
            this.rdoUnplanned.AutoSize = true;
            this.rdoUnplanned.Location = new System.Drawing.Point(9, 99);
            this.rdoUnplanned.Name = "rdoUnplanned";
            this.rdoUnplanned.Size = new System.Drawing.Size(77, 17);
            this.rdoUnplanned.TabIndex = 9;
            this.rdoUnplanned.TabStop = true;
            this.rdoUnplanned.Text = "Unplanned";
            this.rdoUnplanned.UseVisualStyleBackColor = true;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dumpSessionToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // dumpSessionToolStripMenuItem
            // 
            this.dumpSessionToolStripMenuItem.Name = "dumpSessionToolStripMenuItem";
            this.dumpSessionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dumpSessionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.dumpSessionToolStripMenuItem.Text = "Dump Session";
            this.dumpSessionToolStripMenuItem.Click += new System.EventHandler(this.dumpSessionToolStripMenuItem_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(9, 123);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 515);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "ReStar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdMain;
        private System.Windows.Forms.Timer tmrAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView trvMachines;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoUnplanned;
        private System.Windows.Forms.RadioButton rdoPlanned;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMinor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMajor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTimer;
        private System.Windows.Forms.RadioButton rdoAbort;
        private System.Windows.Forms.RadioButton rdoShutDown;
        private System.Windows.Forms.RadioButton rdoRestart;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumpSessionToolStripMenuItem;
        private System.Windows.Forms.Button btnSend;
    }
}

