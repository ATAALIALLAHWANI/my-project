namespace WindowsFormsApp10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.currentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textLevel = new System.Windows.Forms.TextBox();
            this.textTime = new System.Windows.Forms.TextBox();
            this.textscor = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picturepom = new System.Windows.Forms.PictureBox();
            this.picturstar = new System.Windows.Forms.PictureBox();
            this.investigator = new System.Windows.Forms.PictureBox();
            this.pictureTime = new System.Windows.Forms.PictureBox();
            this.pictureOrange = new System.Windows.Forms.PictureBox();
            this.pictureApple = new System.Windows.Forms.PictureBox();
            this.picturbanana = new System.Windows.Forms.PictureBox();
            this.picturefic = new System.Windows.Forms.PictureBox();
            this.timerFruits = new System.Windows.Forms.Timer(this.components);
            this.timerTrop = new System.Windows.Forms.Timer(this.components);
            this.timerReward = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturepom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturstar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureApple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturbanana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturefic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(142, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 48);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.endToolStripMenuItem});
            this.gameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(105, 44);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(153, 44);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.Size = new System.Drawing.Size(153, 44);
            this.endToolStripMenuItem.Text = "End";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.currentToolStripMenuItem});
            this.profileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(128, 44);
            this.profileToolStripMenuItem.Text = "Current";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(189, 44);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // currentToolStripMenuItem
            // 
            this.currentToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            this.currentToolStripMenuItem.Size = new System.Drawing.Size(189, 44);
            this.currentToolStripMenuItem.Text = "current";
            this.currentToolStripMenuItem.Click += new System.EventHandler(this.currentToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticsToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(117, 44);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(210, 44);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(210, 44);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(77, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "            Fruit Collector             ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.textLevel);
            this.panel1.Controls.Add(this.textTime);
            this.panel1.Controls.Add(this.textscor);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Location = new System.Drawing.Point(142, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 112);
            this.panel1.TabIndex = 3;
            // 
            // textLevel
            // 
            this.textLevel.Enabled = false;
            this.textLevel.Location = new System.Drawing.Point(21, 65);
            this.textLevel.Multiline = true;
            this.textLevel.Name = "textLevel";
            this.textLevel.Size = new System.Drawing.Size(107, 32);
            this.textLevel.TabIndex = 3;
            // 
            // textTime
            // 
            this.textTime.Enabled = false;
            this.textTime.Location = new System.Drawing.Point(328, 14);
            this.textTime.Multiline = true;
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(107, 32);
            this.textTime.TabIndex = 2;
            // 
            // textscor
            // 
            this.textscor.Enabled = false;
            this.textscor.Location = new System.Drawing.Point(177, 14);
            this.textscor.Multiline = true;
            this.textscor.Name = "textscor";
            this.textscor.Size = new System.Drawing.Size(107, 32);
            this.textscor.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.Enabled = false;
            this.textName.Location = new System.Drawing.Point(21, 14);
            this.textName.Multiline = true;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(107, 32);
            this.textName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picturepom);
            this.groupBox1.Controls.Add(this.picturstar);
            this.groupBox1.Controls.Add(this.investigator);
            this.groupBox1.Controls.Add(this.pictureTime);
            this.groupBox1.Controls.Add(this.pictureOrange);
            this.groupBox1.Controls.Add(this.pictureApple);
            this.groupBox1.Controls.Add(this.picturbanana);
            this.groupBox1.Controls.Add(this.picturefic);
            this.groupBox1.Location = new System.Drawing.Point(189, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 258);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // picturepom
            // 
            this.picturepom.Image = ((System.Drawing.Image)(resources.GetObject("picturepom.Image")));
            this.picturepom.Location = new System.Drawing.Point(314, 10);
            this.picturepom.Name = "picturepom";
            this.picturepom.Size = new System.Drawing.Size(56, 49);
            this.picturepom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturepom.TabIndex = 7;
            this.picturepom.TabStop = false;
            this.picturepom.Visible = false;
            // 
            // picturstar
            // 
            this.picturstar.Image = ((System.Drawing.Image)(resources.GetObject("picturstar.Image")));
            this.picturstar.Location = new System.Drawing.Point(252, 10);
            this.picturstar.Name = "picturstar";
            this.picturstar.Size = new System.Drawing.Size(56, 49);
            this.picturstar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturstar.TabIndex = 6;
            this.picturstar.TabStop = false;
            this.picturstar.Visible = false;
            // 
            // investigator
            // 
            this.investigator.Image = ((System.Drawing.Image)(resources.GetObject("investigator.Image")));
            this.investigator.Location = new System.Drawing.Point(163, 179);
            this.investigator.Name = "investigator";
            this.investigator.Size = new System.Drawing.Size(74, 61);
            this.investigator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.investigator.TabIndex = 5;
            this.investigator.TabStop = false;
            // 
            // pictureTime
            // 
            this.pictureTime.Image = ((System.Drawing.Image)(resources.GetObject("pictureTime.Image")));
            this.pictureTime.Location = new System.Drawing.Point(163, 74);
            this.pictureTime.Name = "pictureTime";
            this.pictureTime.Size = new System.Drawing.Size(56, 49);
            this.pictureTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTime.TabIndex = 4;
            this.pictureTime.TabStop = false;
            this.pictureTime.Visible = false;
            // 
            // pictureOrange
            // 
            this.pictureOrange.Image = ((System.Drawing.Image)(resources.GetObject("pictureOrange.Image")));
            this.pictureOrange.Location = new System.Drawing.Point(163, 10);
            this.pictureOrange.Name = "pictureOrange";
            this.pictureOrange.Size = new System.Drawing.Size(56, 44);
            this.pictureOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOrange.TabIndex = 2;
            this.pictureOrange.TabStop = false;
            // 
            // pictureApple
            // 
            this.pictureApple.Image = ((System.Drawing.Image)(resources.GetObject("pictureApple.Image")));
            this.pictureApple.Location = new System.Drawing.Point(252, 74);
            this.pictureApple.Name = "pictureApple";
            this.pictureApple.Size = new System.Drawing.Size(56, 49);
            this.pictureApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureApple.TabIndex = 3;
            this.pictureApple.TabStop = false;
            // 
            // picturbanana
            // 
            this.picturbanana.Image = ((System.Drawing.Image)(resources.GetObject("picturbanana.Image")));
            this.picturbanana.Location = new System.Drawing.Point(57, 74);
            this.picturbanana.Name = "picturbanana";
            this.picturbanana.Size = new System.Drawing.Size(56, 49);
            this.picturbanana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturbanana.TabIndex = 1;
            this.picturbanana.TabStop = false;
            // 
            // picturefic
            // 
            this.picturefic.Image = ((System.Drawing.Image)(resources.GetObject("picturefic.Image")));
            this.picturefic.Location = new System.Drawing.Point(57, 10);
            this.picturefic.Name = "picturefic";
            this.picturefic.Size = new System.Drawing.Size(56, 49);
            this.picturefic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturefic.TabIndex = 0;
            this.picturefic.TabStop = false;
            this.picturefic.Visible = false;
            // 
            // timerFruits
            // 
            this.timerFruits.Enabled = true;
            this.timerFruits.Tick += new System.EventHandler(this.timerFruits_Tick_1);
            // 
            // timerTrop
            // 
            this.timerTrop.Enabled = true;
            this.timerTrop.Tick += new System.EventHandler(this.timerTrop_Tick_1);
            // 
            // timerReward
            // 
            this.timerReward.Enabled = true;
            this.timerReward.Tick += new System.EventHandler(this.timerReward_Tick_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(209)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(814, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturepom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturstar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureApple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturbanana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturefic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem currentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textLevel;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.TextBox textscor;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerFruits;
        private System.Windows.Forms.Timer timerTrop;
        private System.Windows.Forms.Timer timerReward;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picturepom;
        private System.Windows.Forms.PictureBox picturstar;
        private System.Windows.Forms.PictureBox investigator;
        private System.Windows.Forms.PictureBox pictureTime;
        private System.Windows.Forms.PictureBox pictureApple;
        private System.Windows.Forms.PictureBox pictureOrange;
        private System.Windows.Forms.PictureBox picturbanana;
        private System.Windows.Forms.PictureBox picturefic;
    }
}

