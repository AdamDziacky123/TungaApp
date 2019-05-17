using System;
using System.Windows.Forms;

namespace AbsolventskaApp.UserControls
{
    public partial class Task6UserControl : UserControl //: MyUserControl
    {
        int index = Manager.GetInstance().index;
        Manager manager = Manager.GetInstance();

        public Task6UserControl()
        {
            InitializeComponent();
            index = 5;
        }

        private void Task6UserControl_Load(object sender, EventArgs e)
        {
            //manager.AssignPic(index);
            this.Location = manager.taskPosition;
        }

        private void TBAnswer6_Click(object sender, EventArgs e)
        {
            TBAnswer6.Text = string.Empty;
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
            manager.CheckAnswer(TBAnswer6, index);
        }
    }
}
