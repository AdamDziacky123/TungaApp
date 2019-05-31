using System;
using System.Windows.Forms;

namespace TungaApp
{
    public partial class StartUserControl : UserControl
    {
        Manager manager = Manager.GetInstance();

        public StartUserControl()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manager.otherUCList[1].Visible = true;
            manager.BringControlToFront(1, false);
            manager.SetPanels(1, false);
        }
    }
}
