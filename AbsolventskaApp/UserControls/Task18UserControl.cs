using System;
using System.Windows.Forms;

namespace TungaApp.UserControls
{
    public partial class Task18UserControl : UserControl
    {
        int index = Manager.GetInstance().index;
        Manager manager = Manager.GetInstance();

        public Task18UserControl()
        {
            InitializeComponent();
            index = 17;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            manager.Speak(manager.GetWord(this.index));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            manager.AssignPic(index + 1);
            manager.BringControlToFront(index + 1, true);
            manager.SetPanels(index + 1, true);
            manager.index++;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            manager.CheckAnswer(TBAnswer18, index);
        }

    }
}
