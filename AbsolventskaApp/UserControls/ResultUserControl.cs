using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsolventskaApp.UserControls
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
            manager.OtherUCList[0].BringToFront();
            manager.OtherUCList[0].Visible = true;
            manager.ShowButtons(true);
            manager.SetPanels(0,false);
        }
    }
}
