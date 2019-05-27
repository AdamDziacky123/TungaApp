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
    public partial class MenuUserControl : UserControl
    {
        Manager manager = Manager.GetInstance();

        public MenuUserControl()
        {
            InitializeComponent();
        }

        #region btn_Click

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            manager.SetNumBool();
            Start();
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            manager.SetAnimBool();
            Start();
        }

        private void btnOwn_Click(object sender, EventArgs e)
        {
            manager.SetOwnBool();
            Start();
        }

        private void btnColours_Click(object sender, EventArgs e)
        {
            manager.SetColourBool();
            Start();
        }

        private void btnNumbers100_Click(object sender, EventArgs e)
        {
            manager.SetNum100Bool();
            Start();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            manager.SetFoodBool();
            Start();
        }

        private void btnClothing_Click(object sender, EventArgs e)
        {
            manager.SetClothingBool();
            Start();
        }

        #endregion

        private void Start()
        {
            manager.AssignTaskNum();
            manager.AnswersReset();

            manager.ShowButtons(false);
            manager.AssignPic(0);
            manager.BringControlToFront(0, true);
            manager.SetPanels(0, true);
        }
    }
}
