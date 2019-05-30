using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsolventskaApp
{
    public partial class StartUserControl : UserControl// : MyUserControl
    {
        Manager manager = Manager.GetInstance();

        public StartUserControl()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //manager.otherUCList[1].BringToFront();
            manager.otherUCList[1].Visible = true;
            manager.BringControlToFront(1, false);
            manager.SetPanels(1, false);
        }
    }
}
