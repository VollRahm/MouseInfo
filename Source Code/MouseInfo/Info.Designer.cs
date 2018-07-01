namespace MouseInfo
{
    partial class Info
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.lClick = new System.Windows.Forms.Label();
            this.MouseWheel = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.rClick = new System.Windows.Forms.Label();
            this.autostart = new System.Windows.Forms.CheckBox();
            this.Minimize = new System.Windows.Forms.Button();
            this.SystemTrayIco = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.infoBtn = new System.Windows.Forms.Button();
            this.positionText = new System.Windows.Forms.Label();
            this.positionTimer = new System.Windows.Forms.Timer(this.components);
            this.cpsTimer = new System.Windows.Forms.Timer(this.components);
            this.cpsLabel = new System.Windows.Forms.Label();
            this.overlaySwitch = new System.Windows.Forms.CheckBox();
            this.distanceLbl = new System.Windows.Forms.Label();
            this.DistanceTimer = new System.Windows.Forms.Timer(this.components);
            this.calibratebtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkForCal = new System.Windows.Forms.Timer(this.components);
            this.SystemTrayIco.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lClick
            // 
            this.lClick.AutoSize = true;
            this.lClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClick.Location = new System.Drawing.Point(25, 16);
            this.lClick.Name = "lClick";
            this.lClick.Size = new System.Drawing.Size(80, 16);
            this.lClick.TabIndex = 0;
            this.lClick.Text = "Left Klicks: 0";
            // 
            // MouseWheel
            // 
            this.MouseWheel.AutoSize = true;
            this.MouseWheel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MouseWheel.Location = new System.Drawing.Point(25, 53);
            this.MouseWheel.Name = "MouseWheel";
            this.MouseWheel.Size = new System.Drawing.Size(140, 16);
            this.MouseWheel.TabIndex = 1;
            this.MouseWheel.Text = "Mouse Wheel Ticks: 0";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(246, 37);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 2;
            this.reset.Text = "Reset All";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // rClick
            // 
            this.rClick.AutoSize = true;
            this.rClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rClick.Location = new System.Drawing.Point(25, 37);
            this.rClick.Name = "rClick";
            this.rClick.Size = new System.Drawing.Size(90, 16);
            this.rClick.TabIndex = 1;
            this.rClick.Text = "Right Klicks: 0";
            // 
            // autostart
            // 
            this.autostart.AutoSize = true;
            this.autostart.Location = new System.Drawing.Point(68, 174);
            this.autostart.Name = "autostart";
            this.autostart.Size = new System.Drawing.Size(68, 17);
            this.autostart.TabIndex = 3;
            this.autostart.Text = "Autostart";
            this.autostart.UseVisualStyleBackColor = true;
            this.autostart.CheckedChanged += new System.EventHandler(this.autostart_CheckedChanged);
            // 
            // Minimize
            // 
            this.Minimize.Location = new System.Drawing.Point(221, 199);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(75, 23);
            this.Minimize.TabIndex = 4;
            this.Minimize.Text = "Hide";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // SystemTrayIco
            // 
            this.SystemTrayIco.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.donateToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.SystemTrayIco.Name = "SystemTrayIco";
            this.SystemTrayIco.Size = new System.Drawing.Size(113, 70);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.donateToolStripMenuItem.Text = "Donate";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SystemTray
            // 
            this.SystemTray.ContextMenuStrip = this.SystemTrayIco;
            this.SystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemTray.Icon")));
            this.SystemTray.Text = "Mouse Info";
            this.SystemTray.Visible = true;
            // 
            // infoBtn
            // 
            this.infoBtn.Location = new System.Drawing.Point(68, 199);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(75, 23);
            this.infoBtn.TabIndex = 6;
            this.infoBtn.Text = "About";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // positionText
            // 
            this.positionText.AutoSize = true;
            this.positionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionText.Location = new System.Drawing.Point(6, 34);
            this.positionText.Name = "positionText";
            this.positionText.Size = new System.Drawing.Size(109, 15);
            this.positionText.TabIndex = 7;
            this.positionText.Text = "Postion: X= 0; Y= 0";
            // 
            // positionTimer
            // 
            this.positionTimer.Interval = 35;
            this.positionTimer.Tick += new System.EventHandler(this.positionTimer_Tick);
            // 
            // cpsTimer
            // 
            this.cpsTimer.Interval = 1000;
            this.cpsTimer.Tick += new System.EventHandler(this.cpsTimer_Tick);
            // 
            // cpsLabel
            // 
            this.cpsLabel.AutoSize = true;
            this.cpsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpsLabel.Location = new System.Drawing.Point(6, 18);
            this.cpsLabel.Name = "cpsLabel";
            this.cpsLabel.Size = new System.Drawing.Size(48, 16);
            this.cpsLabel.TabIndex = 8;
            this.cpsLabel.Text = "CPS: 0";
            // 
            // overlaySwitch
            // 
            this.overlaySwitch.AutoSize = true;
            this.overlaySwitch.Location = new System.Drawing.Point(68, 150);
            this.overlaySwitch.Name = "overlaySwitch";
            this.overlaySwitch.Size = new System.Drawing.Size(86, 17);
            this.overlaySwitch.TabIndex = 9;
            this.overlaySwitch.Text = "CPS Overlay";
            this.overlaySwitch.UseVisualStyleBackColor = true;
            this.overlaySwitch.CheckedChanged += new System.EventHandler(this.overlaySwitch_CheckedChanged);
            // 
            // distanceLbl
            // 
            this.distanceLbl.AutoSize = true;
            this.distanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLbl.Location = new System.Drawing.Point(3, 92);
            this.distanceLbl.Name = "distanceLbl";
            this.distanceLbl.Size = new System.Drawing.Size(64, 16);
            this.distanceLbl.TabIndex = 10;
            this.distanceLbl.Text = "Distance:";
            // 
            // DistanceTimer
            // 
            this.DistanceTimer.Enabled = true;
            this.DistanceTimer.Interval = 130;
            this.DistanceTimer.Tick += new System.EventHandler(this.DistanceTimer_Tick_1);
            // 
            // calibratebtn
            // 
            this.calibratebtn.Location = new System.Drawing.Point(210, 89);
            this.calibratebtn.Name = "calibratebtn";
            this.calibratebtn.Size = new System.Drawing.Size(111, 23);
            this.calibratebtn.TabIndex = 11;
            this.calibratebtn.Text = "Calibrate Distance";
            this.calibratebtn.UseVisualStyleBackColor = true;
            this.calibratebtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lClick);
            this.groupBox1.Controls.Add(this.rClick);
            this.groupBox1.Controls.Add(this.MouseWheel);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 73);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Button Counter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.positionText);
            this.groupBox2.Controls.Add(this.cpsLabel);
            this.groupBox2.Location = new System.Drawing.Point(160, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 59);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Live Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // checkForCal
            // 
            this.checkForCal.Tick += new System.EventHandler(this.checkForCal_Tick);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(333, 243);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.calibratebtn);
            this.Controls.Add(this.distanceLbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.overlaySwitch);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.autostart);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Info";
            this.Text = "Mouse Info";
            this.TopMost = true;
            this.SystemTrayIco.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lClick;
        private System.Windows.Forms.Label MouseWheel;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label rClick;
        private System.Windows.Forms.CheckBox autostart;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.ContextMenuStrip SystemTrayIco;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon SystemTray;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Label positionText;
		private System.Windows.Forms.Timer positionTimer;
		private System.Windows.Forms.Timer cpsTimer;
		private System.Windows.Forms.Label cpsLabel;
		private System.Windows.Forms.CheckBox overlaySwitch;
		private System.Windows.Forms.Label distanceLbl;
		private System.Windows.Forms.Timer DistanceTimer;
		private System.Windows.Forms.Button calibratebtn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		public  System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer checkForCal;
	}
}

