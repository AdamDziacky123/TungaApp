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
            manager.OtherUCList[1].BringToFront();
            manager.OtherUCList[1].Visible = true;
            manager.SetPanels(1, false);
        }

        private void StartUserControl_Load(object sender, EventArgs e)
        {
            this.Location = manager.taskPosition;
        }
    }
}
