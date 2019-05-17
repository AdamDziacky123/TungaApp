using System;
using System.Windows.Forms;

namespace AbsolventskaApp.UserControls
{
    public partial class Task19UserControl : UserControl //: MyUserControl
    {
        int index = Manager.GetInstance().index;
        Manager manager = Manager.GetInstance();

        public Task19UserControl()
        {
            InitializeComponent();
            index = 18;
        }

        private void Task19UserControl_Load(object sender, EventArgs e)
        {
            //manager.AssignPic(index);
            this.Location = manager.taskPosition;
            //this.Visible = true;
        }

        private void TBAnswer1_Click(object sender, EventArgs e)
        {
            TBAnswer19.Text = string.Empty;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            manager.Speak(manager.GetWord(this.index));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //manager.AddTasks((Form1)Form1.ActiveForm);
            manager.AssignPic(index + 1);
            manager.BringTaskToFront(index + 1);
            manager.SetPanels(index + 1);
            manager.index++;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            //manager.AddToAnswers((Form1)Form1.ActiveForm);
            manager.CheckAnswer(TBAnswer19, index);
        }

    }
}
