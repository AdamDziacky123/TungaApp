namespace TungaApp.UserControls
{
    partial class Task19UserControl
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.TBAnswer19 = new System.Windows.Forms.TextBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))));
            this.btnNext.Location = new System.Drawing.Point(1126, 379);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 50);
            this.btnNext.TabIndex = 77;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))));
            this.btnConfirm.Location = new System.Drawing.Point(191, 752);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(125, 50);
            this.btnConfirm.TabIndex = 76;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 45F);
            this.label1.Location = new System.Drawing.Point(445, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 90);
            this.label1.TabIndex = 75;
            this.label1.Text = "Task 19";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))));
            this.btnPlay.Location = new System.Drawing.Point(866, 752);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(125, 50);
            this.btnPlay.TabIndex = 74;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // TBAnswer19
            // 
            this.TBAnswer19.BackColor = System.Drawing.Color.Silver;
            this.TBAnswer19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBAnswer19.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.TBAnswer19.Location = new System.Drawing.Point(441, 690);
            this.TBAnswer19.Name = "TBAnswer19";
            this.TBAnswer19.Size = new System.Drawing.Size(300, 37);
            this.TBAnswer19.TabIndex = 73;
            this.TBAnswer19.Text = "Type in the answer";
            this.TBAnswer19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox19
            // 
            this.pictureBox19.ImageLocation = "";
            this.pictureBox19.Location = new System.Drawing.Point(191, 154);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(800, 500);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox19.TabIndex = 72;
            this.pictureBox19.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(290, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 3);
            this.panel1.TabIndex = 78;
            // 
            // Task19UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.TBAnswer19);
            this.Controls.Add(this.pictureBox19);
            this.Name = "Task19UserControl";
            this.Size = new System.Drawing.Size(1300, 900);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox TBAnswer19;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.Panel panel1;
    }
}
