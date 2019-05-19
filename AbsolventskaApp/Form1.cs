using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbsolventskaApp.UserControls;
using System.Security;

namespace AbsolventskaApp //last task confirm button + menu + settings
{
    public partial class Form1 : Form
    {
        Manager manager = Manager.GetInstance();

        public Form1()
        {
            InitializeComponent();

            manager.FillLists(this);
            manager.AssignTaskNum();
            manager.HideOtherTasks();
            manager.LastUcBTNRemove();
            manager.SetUcPositions();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startUserControl1.BringToFront();

            foreach (UserControl c in manager.GetUCList())
            {
                c.Visible = false;
                c.Enabled = false;
            }

            foreach (Button btn in manager.GetButtonsList())
            {
                btn.Enabled = false;
                btn.Visible = true;
            }

            pnlLogo.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
