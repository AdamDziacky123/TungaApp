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
            Icon icon = Icon.ExtractAssociatedIcon(@"D:\Podklady\Absolventská\Logo\Icon.ico");
            this.Icon = icon;

            manager.FillLists(this);
            manager.SetUcPositions();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startUserControl1.BringToFront();

            foreach (UserControl c in manager.GetUCList())
            {
                c.Visible = false;
            }

            pnlLogo.BringToFront();
            pnlSideSmall.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            manager.SetPanels(0, false);
            manager.BringControlToFront(0,false);            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            manager.SetPanels(1, false);
            manager.BringControlToFront(1, false);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            manager.SetPanels(2, false);
            manager.BringControlToFront(2, false);
        }
    }
}
