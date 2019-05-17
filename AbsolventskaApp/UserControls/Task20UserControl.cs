using System;
using System.Windows.Forms;

namespace AbsolventskaApp.UserControls
{
    public partial class Task20UserControl : UserControl //: MyUserControl
    {
        int index = Manager.GetInstance().index;
        Manager manager = Manager.GetInstance();

        public Task20UserControl()
        {
            InitializeComponent();
            index = 19;
        }

        private void Task20UserControl_Load(object sender, EventArgs e)
        {
            //manager.AssignPic(index);
            this.Location = manager.taskPosition;
            //this.Visible = true;
        }

        private void TBAnswer1_Click(object sender, EventArgs e)
        {
            TBAnswer20.Text = string.Empty;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            manager.Speak(manager.GetWord(this.index));
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //manager.AddToAnswers((Form1)Form1.ActiveForm);
            manager.CheckAnswer(TBAnswer20, index);
        }

    }
}
