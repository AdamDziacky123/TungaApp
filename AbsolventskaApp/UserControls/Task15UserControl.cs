using System;
using System.Windows.Forms;

namespace AbsolventskaApp.UserControls
{
    public partial class Task15UserControl : UserControl //: MyUserControl
    {
        int index = Manager.GetInstance().index;
        Manager manager = Manager.GetInstance();

        public Task15UserControl()
        {
            InitializeComponent();
            index = 14;
        }

        private void TBAnswer1_Click(object sender, EventArgs e)
        {
            TBAnswer15.Text = string.Empty;
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
            //manager.AddToAnswers((Form1)Form1.ActiveForm);
            manager.CheckAnswer(TBAnswer15, index);
        }

    }
}
