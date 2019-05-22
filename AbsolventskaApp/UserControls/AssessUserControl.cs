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
    public partial class AssessUserControl : UserControl // vsetky uc na zaciatku - visible = false; bring Task to front after clicking continue
    {
        Manager manager = Manager.GetInstance();

        public AssessUserControl()
        {
            InitializeComponent();
        }

        private void BTNContinue_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manager.BringControlToFront(manager.index, true);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = false;
            btnContinue.Visible = true;
            this.Visible = false;

            manager.OtherUCList[4].BringToFront();
            manager.OtherUCList[4].Visible = true;
            manager.ShowResult();
        }
    }
}
