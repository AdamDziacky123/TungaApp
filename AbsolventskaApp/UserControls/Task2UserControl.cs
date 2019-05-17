using System;
using System.Windows.Forms;

namespace AbsolventskaApp.UserControls
{
    public partial class Task2UserControl : UserControl //: MyUserControl
    {
        int index = Manager.GetInstance().index;
        Manager manager = Manager.GetInstance();

        public Task2UserControl()
        {
            InitializeComponent();
            index = 1;
        }

        private void Task2UserControl_Load(object sender, EventArgs e)
        {
            this.Location = manager.taskPosition;
        }

        private void TBAnswer2_Click(object sender, EventArgs e)
        {
            TBAnswer2.Text = string.Empty;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            manager.Speak(manager.GetWord(this.index));
        }

        private void btnNext_Click_1(object sender, EventArgs e)
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
            manager.CheckAnswer(TBAnswer2, index);
        }
    }
}
