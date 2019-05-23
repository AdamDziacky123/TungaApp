namespace AbsolventskaApp.UserControls
{
    partial class SettingsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblSpeaker = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BarVolume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BarRate = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnChangePath = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarRate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.BackColor = System.Drawing.Color.Silver;
            this.lblSettings.Font = new System.Drawing.Font("Century Gothic", 45F);
            this.lblSettings.Location = new System.Drawing.Point(471, 26);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(315, 90);
            this.lblSettings.TabIndex = 24;
            this.lblSettings.Text = "Settings";
            // 
            // lblSpeaker
            // 
            this.lblSpeaker.AutoSize = true;
            this.lblSpeaker.Font = new System.Drawing.Font("Century Gothic", 22F);
            this.lblSpeaker.Location = new System.Drawing.Point(146, 304);
            this.lblSpeaker.Name = "lblSpeaker";
            this.lblSpeaker.Size = new System.Drawing.Size(186, 44);
            this.lblSpeaker.TabIndex = 25;
            this.lblSpeaker.Text = "Speaker :";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Silver;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(892, 313);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 31);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Tag = "";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BarVolume
            // 
            this.BarVolume.Location = new System.Drawing.Point(847, 382);
            this.BarVolume.Maximum = 100;
            this.BarVolume.Name = "BarVolume";
            this.BarVolume.Size = new System.Drawing.Size(218, 56);
            this.BarVolume.TabIndex = 27;
            this.BarVolume.Value = 50;
            this.BarVolume.Scroll += new System.EventHandler(this.barVolume_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label1.Location = new System.Drawing.Point(506, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 28;
            this.label1.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label2.Location = new System.Drawing.Point(506, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 33);
            this.label2.TabIndex = 29;
            this.label2.Text = "Volume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label3.Location = new System.Drawing.Point(506, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 33);
            this.label3.TabIndex = 30;
            this.label3.Text = "Rate";
            // 
            // BarRate
            // 
            this.BarRate.Location = new System.Drawing.Point(847, 444);
            this.BarRate.Minimum = -10;
            this.BarRate.Name = "BarRate";
            this.BarRate.Size = new System.Drawing.Size(218, 56);
            this.BarRate.TabIndex = 31;
            this.BarRate.Value = -3;
            this.BarRate.Scroll += new System.EventHandler(this.BarRate_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21F);
            this.label4.Location = new System.Drawing.Point(146, 559);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 42);
            this.label4.TabIndex = 32;
            this.label4.Text = "Path to Files :";
            // 
            // lblPath
            // 
            this.lblPath.AutoEllipsis = true;
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblPath.Location = new System.Drawing.Point(507, 569);
            this.lblPath.MaximumSize = new System.Drawing.Size(600, 22);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(80, 22);
            this.lblPath.TabIndex = 33;
            this.lblPath.Text = "label5";
            // 
            // btnChangePath
            // 
            this.btnChangePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.btnChangePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePath.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChangePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))));
            this.btnChangePath.Location = new System.Drawing.Point(176, 643);
            this.btnChangePath.Name = "btnChangePath";
            this.btnChangePath.Size = new System.Drawing.Size(173, 58);
            this.btnChangePath.TabIndex = 34;
            this.btnChangePath.Text = "Change Path";
            this.btnChangePath.UseVisualStyleBackColor = false;
            this.btnChangePath.Click += new System.EventHandler(this.btnChangePath_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(328, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 3);
            this.panel1.TabIndex = 36;
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChangePath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BarRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarVolume);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSpeaker);
            this.Controls.Add(this.lblSettings);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(1300, 900);
            ((System.ComponentModel.ISupportInitialize)(this.BarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblSpeaker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar BarVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar BarRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnChangePath;
        private System.Windows.Forms.Panel panel1;
    }
}
