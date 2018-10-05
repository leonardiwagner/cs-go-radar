namespace CsGoRadar
{
    partial class frmRadar
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
            this.btnRun = new System.Windows.Forms.Button();
            this.lblTop = new System.Windows.Forms.Label();
            this.trkTop = new System.Windows.Forms.TrackBar();
            this.lblLeft = new System.Windows.Forms.Label();
            this.trkLeft = new System.Windows.Forms.TrackBar();
            this.lblSpread = new System.Windows.Forms.Label();
            this.trkSpread = new System.Windows.Forms.TrackBar();
            this.lblDotSize = new System.Windows.Forms.Label();
            this.trkDotSize = new System.Windows.Forms.TrackBar();
            this.trkDotColor = new System.Windows.Forms.TrackBar();
            this.lblDotColor = new System.Windows.Forms.Label();
            this.chkDisplayTeam = new System.Windows.Forms.CheckBox();
            this.chkDisplayEnemies = new System.Windows.Forms.CheckBox();
            this.lblPreset = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chkStreched = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trkTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkDotSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkDotColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRun.Location = new System.Drawing.Point(280, 184);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(154, 37);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Start";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(12, 33);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(29, 13);
            this.lblTop.TabIndex = 1;
            this.lblTop.Text = "Top:";
            // 
            // trkTop
            // 
            this.trkTop.Location = new System.Drawing.Point(57, 33);
            this.trkTop.Name = "trkTop";
            this.trkTop.Size = new System.Drawing.Size(196, 45);
            this.trkTop.TabIndex = 2;
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(15, 91);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(28, 13);
            this.lblLeft.TabIndex = 3;
            this.lblLeft.Text = "Left:";
            // 
            // trkLeft
            // 
            this.trkLeft.Location = new System.Drawing.Point(57, 92);
            this.trkLeft.Name = "trkLeft";
            this.trkLeft.Size = new System.Drawing.Size(196, 45);
            this.trkLeft.TabIndex = 4;
            // 
            // lblSpread
            // 
            this.lblSpread.AutoSize = true;
            this.lblSpread.Location = new System.Drawing.Point(13, 143);
            this.lblSpread.Name = "lblSpread";
            this.lblSpread.Size = new System.Drawing.Size(44, 13);
            this.lblSpread.TabIndex = 5;
            this.lblSpread.Text = "Spread:";
            // 
            // trkSpread
            // 
            this.trkSpread.Location = new System.Drawing.Point(57, 143);
            this.trkSpread.Maximum = 40;
            this.trkSpread.Name = "trkSpread";
            this.trkSpread.Size = new System.Drawing.Size(196, 45);
            this.trkSpread.TabIndex = 6;
            // 
            // lblDotSize
            // 
            this.lblDotSize.AutoSize = true;
            this.lblDotSize.Location = new System.Drawing.Point(274, 40);
            this.lblDotSize.Name = "lblDotSize";
            this.lblDotSize.Size = new System.Drawing.Size(50, 13);
            this.lblDotSize.TabIndex = 7;
            this.lblDotSize.Text = "Dot Size:";
            // 
            // trkDotSize
            // 
            this.trkDotSize.Location = new System.Drawing.Point(330, 33);
            this.trkDotSize.Maximum = 5;
            this.trkDotSize.Name = "trkDotSize";
            this.trkDotSize.Size = new System.Drawing.Size(104, 45);
            this.trkDotSize.TabIndex = 8;
            // 
            // trkDotColor
            // 
            this.trkDotColor.Location = new System.Drawing.Point(330, 91);
            this.trkDotColor.Name = "trkDotColor";
            this.trkDotColor.Size = new System.Drawing.Size(104, 45);
            this.trkDotColor.TabIndex = 9;
            // 
            // lblDotColor
            // 
            this.lblDotColor.AutoSize = true;
            this.lblDotColor.Location = new System.Drawing.Point(277, 92);
            this.lblDotColor.Name = "lblDotColor";
            this.lblDotColor.Size = new System.Drawing.Size(54, 13);
            this.lblDotColor.TabIndex = 10;
            this.lblDotColor.Text = "Dot Color:";
            // 
            // chkDisplayTeam
            // 
            this.chkDisplayTeam.AutoSize = true;
            this.chkDisplayTeam.Location = new System.Drawing.Point(280, 130);
            this.chkDisplayTeam.Name = "chkDisplayTeam";
            this.chkDisplayTeam.Size = new System.Drawing.Size(90, 17);
            this.chkDisplayTeam.TabIndex = 11;
            this.chkDisplayTeam.Text = "Display Team";
            this.chkDisplayTeam.UseVisualStyleBackColor = true;
            // 
            // chkDisplayEnemies
            // 
            this.chkDisplayEnemies.AutoSize = true;
            this.chkDisplayEnemies.Checked = true;
            this.chkDisplayEnemies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplayEnemies.Location = new System.Drawing.Point(280, 153);
            this.chkDisplayEnemies.Name = "chkDisplayEnemies";
            this.chkDisplayEnemies.Size = new System.Drawing.Size(103, 17);
            this.chkDisplayEnemies.TabIndex = 12;
            this.chkDisplayEnemies.Text = "Display Enemies";
            this.chkDisplayEnemies.UseVisualStyleBackColor = true;
            // 
            // lblPreset
            // 
            this.lblPreset.AutoSize = true;
            this.lblPreset.Location = new System.Drawing.Point(16, 196);
            this.lblPreset.Name = "lblPreset";
            this.lblPreset.Size = new System.Drawing.Size(40, 13);
            this.lblPreset.TabIndex = 13;
            this.lblPreset.Text = "Preset:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(63, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "1024x768";
            // 
            // chkStreched
            // 
            this.chkStreched.AutoSize = true;
            this.chkStreched.Location = new System.Drawing.Point(181, 195);
            this.chkStreched.Name = "chkStreched";
            this.chkStreched.Size = new System.Drawing.Size(72, 17);
            this.chkStreched.TabIndex = 15;
            this.chkStreched.Text = "Stretched";
            this.chkStreched.UseVisualStyleBackColor = true;
            // 
            // frmRadar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 233);
            this.Controls.Add(this.chkStreched);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPreset);
            this.Controls.Add(this.chkDisplayEnemies);
            this.Controls.Add(this.chkDisplayTeam);
            this.Controls.Add(this.lblDotColor);
            this.Controls.Add(this.trkDotColor);
            this.Controls.Add(this.trkDotSize);
            this.Controls.Add(this.lblDotSize);
            this.Controls.Add(this.trkSpread);
            this.Controls.Add(this.lblSpread);
            this.Controls.Add(this.trkLeft);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.trkTop);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.btnRun);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRadar";
            this.Text = "Radar";
            ((System.ComponentModel.ISupportInitialize)(this.trkTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkDotSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkDotColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.TrackBar trkTop;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.TrackBar trkLeft;
        private System.Windows.Forms.Label lblSpread;
        private System.Windows.Forms.TrackBar trkSpread;
        private System.Windows.Forms.Label lblDotSize;
        private System.Windows.Forms.TrackBar trkDotSize;
        private System.Windows.Forms.TrackBar trkDotColor;
        private System.Windows.Forms.Label lblDotColor;
        private System.Windows.Forms.CheckBox chkDisplayTeam;
        private System.Windows.Forms.CheckBox chkDisplayEnemies;
        private System.Windows.Forms.Label lblPreset;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chkStreched;
    }
}

