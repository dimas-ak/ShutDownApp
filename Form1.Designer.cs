namespace ShutDownApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.durasi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.off_shutdown = new System.Windows.Forms.RadioButton();
            this.off_restart = new System.Windows.Forms.RadioButton();
            this.simpan = new System.Windows.Forms.Button();
            this.batal = new System.Windows.Forms.Button();
            this.keluar = new System.Windows.Forms.Button();
            this.progress_bar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.required_off = new System.Windows.Forms.Label();
            this.required_duration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // durasi
            // 
            this.durasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durasi.FormattingEnabled = true;
            this.durasi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.durasi.Items.AddRange(new object[] {
            "1 Menit",
            "2 Menit",
            "3 Menit",
            "4 Menit",
            "5 Menit",
            "10 Menit",
            "20 Menit",
            "30 Menit",
            "1 Jam",
            "1 Jam 30 Menit",
            "2 Jam",
            "2 Jam 30 Menit",
            "3 Jam"});
            this.durasi.Location = new System.Drawing.Point(12, 25);
            this.durasi.Name = "durasi";
            this.durasi.Size = new System.Drawing.Size(121, 21);
            this.durasi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Durasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shut Down/Restart";
            // 
            // off_shutdown
            // 
            this.off_shutdown.AutoSize = true;
            this.off_shutdown.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.off_shutdown.Location = new System.Drawing.Point(16, 76);
            this.off_shutdown.Name = "off_shutdown";
            this.off_shutdown.Size = new System.Drawing.Size(78, 17);
            this.off_shutdown.TabIndex = 5;
            this.off_shutdown.TabStop = true;
            this.off_shutdown.Text = "Shut Down";
            this.off_shutdown.UseVisualStyleBackColor = true;
            // 
            // off_restart
            // 
            this.off_restart.AutoSize = true;
            this.off_restart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.off_restart.Location = new System.Drawing.Point(16, 99);
            this.off_restart.Name = "off_restart";
            this.off_restart.Size = new System.Drawing.Size(59, 17);
            this.off_restart.TabIndex = 6;
            this.off_restart.TabStop = true;
            this.off_restart.Text = "Restart";
            this.off_restart.UseVisualStyleBackColor = true;
            // 
            // simpan
            // 
            this.simpan.Location = new System.Drawing.Point(23, 179);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(75, 23);
            this.simpan.TabIndex = 7;
            this.simpan.Text = "SIMPAN";
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // batal
            // 
            this.batal.Location = new System.Drawing.Point(104, 179);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(75, 23);
            this.batal.TabIndex = 8;
            this.batal.Text = "BATAL";
            this.batal.UseVisualStyleBackColor = true;
            this.batal.Click += new System.EventHandler(this.Batal_Click);
            // 
            // keluar
            // 
            this.keluar.BackColor = System.Drawing.Color.DarkRed;
            this.keluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.keluar.FlatAppearance.BorderSize = 0;
            this.keluar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.keluar.Location = new System.Drawing.Point(65, 212);
            this.keluar.Name = "keluar";
            this.keluar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.keluar.Size = new System.Drawing.Size(75, 23);
            this.keluar.TabIndex = 9;
            this.keluar.Text = "KELUAR";
            this.keluar.UseVisualStyleBackColor = false;
            this.keluar.Click += new System.EventHandler(this.Keluar_Click);
            // 
            // progress_bar
            // 
            this.progress_bar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progress_bar.ForeColor = System.Drawing.Color.DimGray;
            this.progress_bar.Location = new System.Drawing.Point(16, 148);
            this.progress_bar.Margin = new System.Windows.Forms.Padding(5);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(163, 23);
            this.progress_bar.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time :";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time.Location = new System.Drawing.Point(55, 132);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 13);
            this.time.TabIndex = 12;
            // 
            // required_off
            // 
            this.required_off.AutoSize = true;
            this.required_off.ForeColor = System.Drawing.Color.OrangeRed;
            this.required_off.Location = new System.Drawing.Point(122, 60);
            this.required_off.Name = "required_off";
            this.required_off.Size = new System.Drawing.Size(0, 13);
            this.required_off.TabIndex = 13;
            // 
            // required_duration
            // 
            this.required_duration.AutoSize = true;
            this.required_duration.ForeColor = System.Drawing.Color.OrangeRed;
            this.required_duration.Location = new System.Drawing.Point(55, 9);
            this.required_duration.Name = "required_duration";
            this.required_duration.Size = new System.Drawing.Size(0, 13);
            this.required_duration.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(191, 243);
            this.Controls.Add(this.required_duration);
            this.Controls.Add(this.required_off);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.batal);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.off_restart);
            this.Controls.Add(this.off_shutdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.durasi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Arjunane Log Off";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox durasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton off_shutdown;
        private System.Windows.Forms.RadioButton off_restart;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.Button batal;
        private System.Windows.Forms.Button keluar;
        private System.Windows.Forms.ProgressBar progress_bar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label required_off;
        private System.Windows.Forms.Label required_duration;
    }
}

