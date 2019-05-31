namespace TungaApp.UserControls
{
    partial class ResultUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultPercent = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label1.Location = new System.Drawing.Point(318, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your result is :";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lblResult.Location = new System.Drawing.Point(601, 334);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(135, 49);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            // 
            // lblResultPercent
            // 
            this.lblResultPercent.AutoSize = true;
            this.lblResultPercent.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lblResultPercent.Location = new System.Drawing.Point(820, 334);
            this.lblResultPercent.Name = "lblResultPercent";
            this.lblResultPercent.Size = new System.Drawing.Size(141, 49);
            this.lblResultPercent.TabIndex = 2;
            this.lblResultPercent.Text = "0.,00%";
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnFinish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))));
            this.btnFinish.Location = new System.Drawing.Point(484, 459);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(303, 72);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "Finish Exercise";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblResultPercent);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Name = "ResultUserControl";
            this.Size = new System.Drawing.Size(1300, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultPercent;
        private System.Windows.Forms.Button btnFinish;
    }
}
