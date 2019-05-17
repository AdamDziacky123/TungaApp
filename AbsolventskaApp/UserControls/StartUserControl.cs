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
            manager.AssignPic(0);
            manager.BringTaskToFront(0);
            manager.SetPanels(0);
        }

        private void StartUserControl_Load(object sender, EventArgs e)
        {
            this.Location = manager.taskPosition;
        }
    }
}
