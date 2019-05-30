using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AbsolventskaApp.UserControls;
using System.Security;

namespace AbsolventskaApp
{
    public partial class Form1 : Form
    {
        Manager manager = Manager.GetInstance();
        static Form1 instance;

        public Form1()
        {
            InitializeComponent();

            instance = this;
            manager.AddOtherUCs(this);
            manager.AddMenuButtonsToList(this);
            manager.AddPanelsToList(this);
            manager.AddExAnswers();

            manager.FillLists(this);
            manager.SetUcPositions();

            if (Environment.GetEnvironmentVariable("Tunga", EnvironmentVariableTarget.User) == null) manager.GetOtherUCList()[1].Controls.Find("btnOwn", true).FirstOrDefault().Enabled = false;
        }

        public static Form1 GetInstance()
        {
            return instance;
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
