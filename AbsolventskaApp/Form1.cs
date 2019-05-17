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

namespace AbsolventskaApp///////////////////////////////////////////////////////// turn off other ucs, disable the buttons on the side, create vyhodnotenie uc
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

        #region BTNTasks_Click

        private void BTNTask1_Click(object sender, EventArgs e) { manager.SetPanels(0); }
        private void BTNTask2_Click(object sender, EventArgs e) { manager.SetPanels(1); }
        private void BTNTask3_Click(object sender, EventArgs e) { manager.SetPanels(2); }
        private void BTNTask4_Click(object sender, EventArgs e) { manager.SetPanels(3); }
        private void BTNTask5_Click(object sender, EventArgs e) { manager.SetPanels(4); }
        private void BTNTask6_Click(object sender, EventArgs e) { manager.SetPanels(5); }
        private void BTNTask7_Click(object sender, EventArgs e) { manager.SetPanels(6); }
        private void BTNTask8_Click(object sender, EventArgs e) { manager.SetPanels(7); }
        private void BTNTask9_Click(object sender, EventArgs e) { manager.SetPanels(8); }
        private void BTNTask10_Click(object sender, EventArgs e) { manager.SetPanels(9); }
        private void BTNTask11_Click(object sender, EventArgs e) { manager.SetPanels(10); }
        private void BTNTask12_Click(object sender, EventArgs e) { manager.SetPanels(11); }
        private void BTNTask13_Click(object sender, EventArgs e) { manager.SetPanels(12); }
        private void BTNTask14_Click(object sender, EventArgs e) { manager.SetPanels(13); }
        private void BTNTask15_Click(object sender, EventArgs e) { manager.SetPanels(14); }
        private void BTNTask16_Click(object sender, EventArgs e) { manager.SetPanels(15); }
        private void BTNTask17_Click(object sender, EventArgs e) { manager.SetPanels(16); }
        private void BTNTask18_Click(object sender, EventArgs e) { manager.SetPanels(17); }
        private void BTNTask19_Click(object sender, EventArgs e) { manager.SetPanels(18); }
        private void BTNTask20_Click(object sender, EventArgs e) { manager.SetPanels(19); }

        #endregion

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
