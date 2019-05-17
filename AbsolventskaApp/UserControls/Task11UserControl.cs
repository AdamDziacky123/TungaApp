using System;
using System.Windows.Forms;

namespace AbsolventskaApp.UserControls
{
    public partial class Task11UserControl : UserControl //: MyUserControl
    {
        int index = Manager.GetInstance().index;
        Manager manager = Manager.GetInstance();

        public Task11UserControl()
        {
            InitializeComponent();
            index = 10;
        }

        private void Task11UserControl_Load(object sender, EventArgs e)
        {
            //manager.AssignPic(index);
            this.Location = manager.taskPosition;
            //this.Visible = true;
        }

        private void TBAnswer1_Click(object sender, EventArgs e)
        {
            TBAnswer11.Text = string.Empty;
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

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            //manager.AddToAnswers((Form1)Form1.ActiveForm);
            manager.CheckAnswer(TBAnswer11, index);
        }
    }
}
