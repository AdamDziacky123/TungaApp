﻿using System;
using System.Windows.Forms;
using System.Speech.Synthesis;


namespace AbsolventskaApp.UserControls 
{

    public partial class SettingsUserControl : UserControl
    {
        Manager manager = Manager.GetInstance(); // Changing path option is here because not every PC will have an editor

        public SettingsUserControl()
        {
            InitializeComponent();

            lblPath.Text = manager.GetPath_files();
            comboBox1.Text = "Female";
        }

        private void barVolume_Scroll(object sender, EventArgs e) //Volume
        {
            manager.speakerVolume = BarVolume.Value;
        }

        private void BarRate_Scroll(object sender, EventArgs e)
        {
            manager.speakerRate = BarRate.Value;
        } //Rate

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //VoiceGender
        {
            if (comboBox1.SelectedItem.ToString() == "Male") manager.speakerGender = VoiceGender.Male;
            else manager.speakerGender = VoiceGender.Female;
        }

        private void btnChangePath_Click(object sender, EventArgs e) //Changing default path
        {
            string oldPath = lblPath.Text;

            MessageBox.Show("To function properly, be sure this path is the same as editors path. Otherwise, some problems might occur.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            using (FolderBrowserDialog OFD = new FolderBrowserDialog())
            {
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    lblPath.Text = OFD.SelectedPath;
                }

                if (lblPath.Text.Length > 0) //saving new path
                {
                    if (lblPath.Text != oldPath)
                    {
                        manager.SetPath_files(lblPath.Text);
                        manager.SetPath_words(lblPath.Text + @"\Words.txt");
                        MessageBox.Show("Path changed successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else MessageBox.Show("Keeping the old path.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else MessageBox.Show("Please, insert a path.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}
