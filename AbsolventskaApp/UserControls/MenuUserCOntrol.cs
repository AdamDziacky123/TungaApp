using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsolventskaApp.UserControls
{
    public partial class MenuUserControl : UserControl
    {
        Manager manager = Manager.GetInstance();

        public MenuUserControl()
        {
            InitializeComponent();
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            manager.SetPath_files(@"C:\Users\Adam\source\repos\GitHub\TungaEditorGitRepo\Absolventska\bin\Debug\Tunga Files\Numbers");
            manager.SetPath_words(@"C:\Users\Adam\source\repos\GitHub\TungaEditorGitRepo\Absolventska\bin\Debug\Tunga Files\Numbers\Words.txt");
            Start();
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            manager.SetPath_files(@"C:\Users\Adam\source\repos\GitHub\TungaEditorGitRepo\Absolventska\bin\Debug\Tunga Files\Animals");
            manager.SetPath_words(@"C:\Users\Adam\source\repos\GitHub\TungaEditorGitRepo\Absolventska\bin\Debug\Tunga Files\Animals\Words.txt");
            Start();
        }

        private void btnWut_Click(object sender, EventArgs e) //to be continued
        {

        }

        private void btnOwn_Click(object sender, EventArgs e)
        {
            manager.SetPath_files(@"C:\Users\Adam\source\repos\GitHub\TungaEditorGitRepo\Absolventska\bin\Debug\Tunga Files");
            manager.SetPath_words(@"C:\Users\Adam\source\repos\GitHub\TungaEditorGitRepo\Absolventska\bin\Debug\Tunga Files\Words.txt");
            Start();
        }

        private void Start()
        {
            manager.AssignTaskNum();
            manager.HideOtherTasks();
            manager.LastUcBTNRemove();

            manager.AssignPic(0);
            manager.BringTaskToFront(0);
            manager.SetPanels(0);
        }
    }
}
