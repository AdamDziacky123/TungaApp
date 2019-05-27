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
    public partial class AssessUserControl : UserControl
    {
        Manager manager = Manager.GetInstance();

        public AssessUserControl()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e) //to next task
        {
            Visible = false;
            manager.BringControlToFront(manager.index, true);
            lblCorrectAnswer.Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = false;
            btnContinue.Visible = true;
            this.Visible = false;
            lblCorrectAnswer.Visible = false;

            manager.otherUCList[4].BringToFront();
            manager.otherUCList[4].Visible = true;
            manager.ShowResult();
        } // to result UC 
    }
}
