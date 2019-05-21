namespace AbsolventskaApp.UserControls
{
    partial class AssessUserControl
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
            this.LblAnswerGood = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.LBLAnswerWrong = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAnswerGood
            // 
            this.LblAnswerGood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAnswerGood.AutoSize = true;
            this.LblAnswerGood.Font = new System.Drawing.Font("Century Gothic", 45F);
            this.LblAnswerGood.Location = new System.Drawing.Point(436, 154);
            this.LblAnswerGood.Name = "LblAnswerGood";
            this.LblAnswerGood.Size = new System.Drawing.Size(430, 90);
            this.LblAnswerGood.TabIndex = 0;
            this.LblAnswerGood.Text = "Well Done!";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))));
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnContinue.ForeColor = System.Drawing.Color.Black;
            this.btnContinue.Location = new System.Drawing.Point(548, 470);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(200, 50);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.BTNContinue_Click);
            // 
            // LBLAnswerWrong
            // 
            this.LBLAnswerWrong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLAnswerWrong.AutoSize = true;
            this.LBLAnswerWrong.Font = new System.Drawing.Font("Century Gothic", 45F);
            this.LBLAnswerWrong.Location = new System.Drawing.Point(360, 153);
            this.LBLAnswerWrong.Name = "LBLAnswerWrong";
            this.LBLAnswerWrong.Size = new System.Drawing.Size(579, 90);
            this.LBLAnswerWrong.TabIndex = 2;
            this.LBLAnswerWrong.Text = "Wrong Answer!";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(491, 441);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(314, 108);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // AssessUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.LBLAnswerWrong);
            this.Controls.Add(this.LblAnswerGood);
            this.Controls.Add(this.btnConfirm);
            this.Name = "AssessUserControl";
            this.Size = new System.Drawing.Size(1300, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnswerGood;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label LBLAnswerWrong;
        private System.Windows.Forms.Button btnConfirm;
    }
}
