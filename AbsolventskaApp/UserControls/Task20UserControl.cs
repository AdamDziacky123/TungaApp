using System;
using System.Windows.Forms;

namespace AbsolventskaApp.UserControls
{
    public partial class Task20UserControl : UserControl
    {
        int index = Manager.GetInstance().index;
        Manager manager = Manager.GetInstance();

        public Task20UserControl()
        {
            InitializeComponent();
            index = 19;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            manager.Speak(manager.GetWord(this.index));
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            manager.CheckAnswer(TBAnswer20, index);
        }

    }
}
