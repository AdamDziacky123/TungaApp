using System;
using System.Windows.Forms;

namespace AbsolventskaApp.UserControls
{
    public partial class Task10UserControl : UserControl //: MyUserControl
    {
        int index = Manager.GetInstance().index;
        Manager manager = Manager.GetInstance();

        public Task10UserControl()
        {
            InitializeComponent();
            index = 9;
        }

        private void TBAnswer10_Click(object sender, EventArgs e)
        {
            TBAnswer10.Text = string.Empty;
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
            //manager.AddToAnswers((Form1)Form1.ActiveForm);
            btnNext.Enabled = true;
            manager.CheckAnswer(TBAnswer10, index);
        }

    }
}
