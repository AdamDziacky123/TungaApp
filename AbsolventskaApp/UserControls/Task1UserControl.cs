using System;
using System.Windows.Forms;

namespace AbsolventskaApp.UserControls
{
    public partial class Task1UserControl : UserControl
    {
        int index = Manager.GetInstance().index;
        Manager manager = Manager.GetInstance();

        public Task1UserControl()
        {
            index = 0;
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            manager.Speak(manager.GetWord(this.index));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            manager.AssignPic(index + 1);
            manager.BringTaskToFront(index + 1);
            manager.SetPanels(index + 1);
            manager.index++;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            manager.CheckAnswer(TBAnswer1, index);
        }

    }
}
