﻿namespace AbsolventskaApp.UserControls
{
    partial class MenuUserControl
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
            this.btnNumbers = new System.Windows.Forms.Button();
            this.btnAnimals = new System.Windows.Forms.Button();
            this.btnWut = new System.Windows.Forms.Button();
            this.btnOwn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 45F);
            this.label1.Location = new System.Drawing.Point(486, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 90);
            this.label1.TabIndex = 23;
            this.label1.Text = "Menu";
            // 
            // btnNumbers
            // 
            this.btnNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.btnNumbers.FlatAppearance.BorderSize = 0;
            this.btnNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumbers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))));
            this.btnNumbers.Location = new System.Drawing.Point(454, 321);
            this.btnNumbers.Name = "btnNumbers";
            this.btnNumbers.Size = new System.Drawing.Size(313, 57);
            this.btnNumbers.TabIndex = 31;
            this.btnNumbers.Text = "Numbers";
            this.btnNumbers.UseVisualStyleBackColor = false;
            this.btnNumbers.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // btnAnimals
            // 
            this.btnAnimals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.btnAnimals.FlatAppearance.BorderSize = 0;
            this.btnAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimals.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnimals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))));
            this.btnAnimals.Location = new System.Drawing.Point(454, 409);
            this.btnAnimals.Name = "btnAnimals";
            this.btnAnimals.Size = new System.Drawing.Size(313, 57);
            this.btnAnimals.TabIndex = 32;
            this.btnAnimals.Text = "Animals";
            this.btnAnimals.UseVisualStyleBackColor = false;
            this.btnAnimals.Click += new System.EventHandler(this.btnAnimals_Click);
            // 
            // btnWut
            // 
            this.btnWut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.btnWut.FlatAppearance.BorderSize = 0;
            this.btnWut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))));
            this.btnWut.Location = new System.Drawing.Point(454, 495);
            this.btnWut.Name = "btnWut";
            this.btnWut.Size = new System.Drawing.Size(313, 57);
            this.btnWut.TabIndex = 33;
            this.btnWut.Text = "???";
            this.btnWut.UseVisualStyleBackColor = false;
            this.btnWut.Click += new System.EventHandler(this.btnWut_Click);
            // 
            // btnOwn
            // 
            this.btnOwn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.btnOwn.FlatAppearance.BorderSize = 0;
            this.btnOwn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOwn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOwn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(210)))), ((int)(((byte)(226)))));
            this.btnOwn.Location = new System.Drawing.Point(454, 582);
            this.btnOwn.Name = "btnOwn";
            this.btnOwn.Size = new System.Drawing.Size(313, 57);
            this.btnOwn.TabIndex = 34;
            this.btnOwn.Text = "Own";
            this.btnOwn.UseVisualStyleBackColor = false;
            this.btnOwn.Click += new System.EventHandler(this.btnOwn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(310, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 3);
            this.panel1.TabIndex = 35;
            // 
            // MenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOwn);
            this.Controls.Add(this.btnWut);
            this.Controls.Add(this.btnAnimals);
            this.Controls.Add(this.btnNumbers);
            this.Controls.Add(this.label1);
            this.Name = "MenuUserControl";
            this.Size = new System.Drawing.Size(1300, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNumbers;
        private System.Windows.Forms.Button btnAnimals;
        private System.Windows.Forms.Button btnWut;
        private System.Windows.Forms.Button btnOwn;
        private System.Windows.Forms.Panel panel1;
    }
}
