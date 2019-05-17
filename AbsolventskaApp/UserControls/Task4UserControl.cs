using System;
using System.Windows.Forms;

namespace AbsolventskaApp.UserControls
{
    public partial class Task4UserControl : UserControl //: MyUserControl
    {
        int index = Manager.GetInstance().index;
        Manager manager = Manager.GetInstance();

        public Task4UserControl()
        {
            InitializeComponent();
            index = 3;
        }

        private void Task4UserControl_Load(object sender, EventArgs e)
        {
            //manager.AssignPic(index);
            this.Location = manager.taskPosition;
        }

        private void TBAnswer4_Click(object sender, EventArgs e)
        {
            TBAnswer4.Text = string.Empty;
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
            manager.CheckAnswer(TBAnswer4, index);
        }
    }
}
