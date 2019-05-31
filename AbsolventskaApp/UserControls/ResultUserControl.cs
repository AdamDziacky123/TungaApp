using System;
using System.Windows.Forms;

namespace TungaApp.UserControls
{
    public partial class ResultUserControl : UserControl
    {
        Manager manager = Manager.GetInstance(); 

        public ResultUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bring Start to front
            Visible = false;
            manager.BringControlToFront(0, false);
            manager.ShowButtons(true);
            manager.SetPanels(0,false);
            manager.NewGame();
        }
    }
}
