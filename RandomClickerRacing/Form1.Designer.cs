namespace RandomClickerRacing
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
            this.beginbtn = new System.Windows.Forms.Button();
            this.racebtn = new System.Windows.Forms.Button();
            this.playerTrack1 = new System.Windows.Forms.TextBox();
            this.playerTrack2 = new System.Windows.Forms.TextBox();
            this.playerTrack3 = new System.Windows.Forms.TextBox();
            this.playerTrack4 = new System.Windows.Forms.TextBox();
            this.playerTrack5 = new System.Windows.Forms.TextBox();
            this.cpuTrack1 = new System.Windows.Forms.TextBox();
            this.cpuTrack2 = new System.Windows.Forms.TextBox();
            this.cpuTrack3 = new System.Windows.Forms.TextBox();
            this.cpuTrack5 = new System.Windows.Forms.TextBox();
            this.cpuTrack4 = new System.Windows.Forms.TextBox();
            this.cpuLbl = new System.Windows.Forms.Label();
            this.playerlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // beginbtn
            // 
            this.beginbtn.Location = new System.Drawing.Point(96, 157);
            this.beginbtn.Name = "beginbtn";
            this.beginbtn.Size = new System.Drawing.Size(75, 23);
            this.beginbtn.TabIndex = 0;
            this.beginbtn.Text = "Begin";
            this.beginbtn.UseVisualStyleBackColor = true;
            this.beginbtn.Click += new System.EventHandler(this.beginbtn_Click);
            // 
            // racebtn
            // 
            this.racebtn.Location = new System.Drawing.Point(96, 186);
            this.racebtn.Name = "racebtn";
            this.racebtn.Size = new System.Drawing.Size(75, 23);
            this.racebtn.TabIndex = 1;
            this.racebtn.Text = "Race!";
            this.racebtn.UseVisualStyleBackColor = true;
            this.racebtn.Visible = false;
            this.racebtn.Click += new System.EventHandler(this.racebtn_Click);
            // 
            // playerTrack1
            // 
            this.playerTrack1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.playerTrack1.Location = new System.Drawing.Point(68, 122);
            this.playerTrack1.Name = "playerTrack1";
            this.playerTrack1.Size = new System.Drawing.Size(22, 20);
            this.playerTrack1.TabIndex = 2;
            this.playerTrack1.Visible = false;
            // 
            // playerTrack2
            // 
            this.playerTrack2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.playerTrack2.Location = new System.Drawing.Point(96, 122);
            this.playerTrack2.Name = "playerTrack2";
            this.playerTrack2.Size = new System.Drawing.Size(22, 20);
            this.playerTrack2.TabIndex = 3;
            this.playerTrack2.Visible = false;
            // 
            // playerTrack3
            // 
            this.playerTrack3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.playerTrack3.Location = new System.Drawing.Point(124, 122);
            this.playerTrack3.Name = "playerTrack3";
            this.playerTrack3.Size = new System.Drawing.Size(22, 20);
            this.playerTrack3.TabIndex = 4;
            this.playerTrack3.Visible = false;
            // 
            // playerTrack4
            // 
            this.playerTrack4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.playerTrack4.Location = new System.Drawing.Point(152, 122);
            this.playerTrack4.Name = "playerTrack4";
            this.playerTrack4.Size = new System.Drawing.Size(22, 20);
            this.playerTrack4.TabIndex = 5;
            this.playerTrack4.Visible = false;
            // 
            // playerTrack5
            // 
            this.playerTrack5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.playerTrack5.Enabled = false;
            this.playerTrack5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.playerTrack5.Location = new System.Drawing.Point(180, 122);
            this.playerTrack5.Name = "playerTrack5";
            this.playerTrack5.Size = new System.Drawing.Size(22, 20);
            this.playerTrack5.TabIndex = 6;
            this.playerTrack5.Visible = false;
            // 
            // cpuTrack1
            // 
            this.cpuTrack1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cpuTrack1.Location = new System.Drawing.Point(68, 96);
            this.cpuTrack1.Name = "cpuTrack1";
            this.cpuTrack1.Size = new System.Drawing.Size(22, 20);
            this.cpuTrack1.TabIndex = 7;
            this.cpuTrack1.Visible = false;
            // 
            // cpuTrack2
            // 
            this.cpuTrack2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cpuTrack2.Location = new System.Drawing.Point(96, 96);
            this.cpuTrack2.Name = "cpuTrack2";
            this.cpuTrack2.Size = new System.Drawing.Size(22, 20);
            this.cpuTrack2.TabIndex = 8;
            this.cpuTrack2.Visible = false;
            // 
            // cpuTrack3
            // 
            this.cpuTrack3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cpuTrack3.Location = new System.Drawing.Point(124, 96);
            this.cpuTrack3.Name = "cpuTrack3";
            this.cpuTrack3.Size = new System.Drawing.Size(22, 20);
            this.cpuTrack3.TabIndex = 9;
            this.cpuTrack3.Visible = false;
            // 
            // cpuTrack5
            // 
            this.cpuTrack5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cpuTrack5.Location = new System.Drawing.Point(180, 96);
            this.cpuTrack5.Name = "cpuTrack5";
            this.cpuTrack5.Size = new System.Drawing.Size(22, 20);
            this.cpuTrack5.TabIndex = 10;
            this.cpuTrack5.Visible = false;
            // 
            // cpuTrack4
            // 
            this.cpuTrack4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cpuTrack4.Location = new System.Drawing.Point(152, 96);
            this.cpuTrack4.Name = "cpuTrack4";
            this.cpuTrack4.Size = new System.Drawing.Size(22, 20);
            this.cpuTrack4.TabIndex = 11;
            this.cpuTrack4.Visible = false;
            // 
            // cpuLbl
            // 
            this.cpuLbl.AutoSize = true;
            this.cpuLbl.Location = new System.Drawing.Point(27, 96);
            this.cpuLbl.Name = "cpuLbl";
            this.cpuLbl.Size = new System.Drawing.Size(29, 13);
            this.cpuLbl.TabIndex = 12;
            this.cpuLbl.Text = "CPU";
            // 
            // playerlbl
            // 
            this.playerlbl.AutoSize = true;
            this.playerlbl.Location = new System.Drawing.Point(27, 125);
            this.playerlbl.Name = "playerlbl";
            this.playerlbl.Size = new System.Drawing.Size(36, 13);
            this.playerlbl.TabIndex = 13;
            this.playerlbl.Text = "Player";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.playerlbl);
            this.Controls.Add(this.cpuLbl);
            this.Controls.Add(this.cpuTrack4);
            this.Controls.Add(this.cpuTrack5);
            this.Controls.Add(this.cpuTrack3);
            this.Controls.Add(this.cpuTrack2);
            this.Controls.Add(this.cpuTrack1);
            this.Controls.Add(this.playerTrack5);
            this.Controls.Add(this.playerTrack4);
            this.Controls.Add(this.playerTrack3);
            this.Controls.Add(this.playerTrack2);
            this.Controls.Add(this.playerTrack1);
            this.Controls.Add(this.racebtn);
            this.Controls.Add(this.beginbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beginbtn;
        private System.Windows.Forms.Button racebtn;
        private System.Windows.Forms.TextBox playerTrack1;
        private System.Windows.Forms.TextBox playerTrack2;
        private System.Windows.Forms.TextBox playerTrack3;
        private System.Windows.Forms.TextBox playerTrack4;
        private System.Windows.Forms.TextBox playerTrack5;
        private System.Windows.Forms.TextBox cpuTrack1;
        private System.Windows.Forms.TextBox cpuTrack2;
        private System.Windows.Forms.TextBox cpuTrack3;
        private System.Windows.Forms.TextBox cpuTrack5;
        private System.Windows.Forms.TextBox cpuTrack4;
        private System.Windows.Forms.Label cpuLbl;
        private System.Windows.Forms.Label playerlbl;
    }
}

