using System;
using System.Windows.Forms;

namespace AbsolventskaApp.UserControls
{
    public partial class Task5UserControl : UserControl //: MyUserControl
    {
        int index = Manager.GetInstance().index;
        Manager manager = Manager.GetInstance();

        public Task5UserControl()
        {
            InitializeComponent();
            index = 4;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            manager.Speak(manager.GetWord(this.index));
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            manager.AssignPic(index + 1);
            manager.BringControlToFront(index + 1, true);
            manager.SetPanels(index + 1, true);
            manager.index++;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            //manager.AddToAnswers((Form1)Form1.ActiveForm);
            manager.CheckAnswer(TBAnswer5, index);
        }
    }
}
