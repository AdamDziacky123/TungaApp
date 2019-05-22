using System;
using System.Windows.Forms;
using System.Speech.Synthesis;


namespace AbsolventskaApp.UserControls
{

    public partial class SettingsUserControl : UserControl
    {
        Manager manager = Manager.GetInstance();

        public SettingsUserControl()
        {
            InitializeComponent();
            lblPath.Text = manager.GetPath_files();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            manager.speakerVolume = trackBar1.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //manager.speakerGender = (VoiceGender)comboBox1.ValueMember;
        }
    }
}
