using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Security;

namespace AbsolventskaApp
{
    public class Manager
    {
        #region Variables
        protected string fileName;
        public int index;
        protected string path_files = @"C:\Users\Adam\source\repos\GitHub\TungaEditorGitRepo\Absolventska\bin\Debug\Tunga Files";
        protected string path_words = @"C:\Users\Adam\source\repos\GitHub\TungaEditorGitRepo\Absolventska\bin\Debug\Tunga Files\Words.txt";
        protected SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        protected List<UserControl> TaskUCList = new List<UserControl>();
        private List<TextBox> TBAnswersList = new List<TextBox>();
        private List<PictureBox> PBsList = new List<PictureBox>();
        private List<Panel> panelsList = new List<Panel>();
        private List<Button> buttonsList = new List<Button>(); //on the left
        public List<UserControl> OtherUCList = new List<UserControl>();
        private bool renull;
        public Point taskPosition = new Point(390, 80);
        private int numOfTasks;
        private int numOfCorrect = 0;
        static Manager instance = new Manager();

        // From Sharepoint
        //private List<string> wordsList = new List<string>();
        //private IEnumerable<Image> imagesEnum;
        //private List<File> imagesList = new List<File>();
        //private List<System.IO.Stream> imagesStreamsList = new List<System.IO.Stream>();
        #endregion

        #region PathMethods

        public void SetPath_files(string newPathFiles)
        {
            path_files = newPathFiles;
        }

        public void SetPath_words(string newPathWords)
        {
            path_words = newPathWords;
        }

        public string GetPath_files()
        {
            return path_files;
        }

        public string GetPath_words()
        {
            return path_words;
        }

        #endregion

        #region GetMethods
        public static Manager GetInstance()
        {
            return instance;
        }

        public List<UserControl> GetUCList()
        {
            return TaskUCList;
        }

        public List<Button> GetButtonsList()
        {
            return buttonsList;
        }
        #endregion

        #region AddToList Functions
        private void AddToAnswers(Form1 form)
        {
            for (int i = 0; i < form.Controls.Count; i++)
            {
                if (form.Controls.Find(string.Format("TBAnswer{0}", i), true).FirstOrDefault() != null)
                {
                    TBAnswersList.Add((TextBox)form.Controls.Find(string.Format("TBAnswer{0}", i), true).FirstOrDefault());
                }
            }
        }

        private void AddToPBs(Form1 form)
        {
            for (int i = 0; i < form.Controls.Count; i++)
            {
                if (form.Controls.Find(string.Format("pictureBox{0}", i), true).FirstOrDefault() != null)
                {
                    PBsList.Add((PictureBox)form.Controls.Find(string.Format("pictureBox{0}", i), true).FirstOrDefault());
                }
            }
        }

        private void AddPanelsToList(Form1 form)
        {
            panelsList.Add(form.Controls.Find("sidePanel", true).FirstOrDefault() as Panel);
            panelsList.Add(form.Controls.Find("pnlLogo", true).FirstOrDefault() as Panel);
        }

        private void AddButtonsToList(Form1 form)
        {
            for (int i = 0; i < 21; i++)
            {
                if (form.Controls.Find(string.Format("BTNTask{0}",i), true).FirstOrDefault() != null)
                {
                    buttonsList.Add(form.Controls.Find(string.Format("BTNTask{0}", i), true).FirstOrDefault() as Button);
                }
            }
        }

        private void AddTasks(Form1 form) //Adding and ordering all task user controls
        {
            List<UserControl> random = new List<UserControl>();

            int q = 1; //name index

            foreach (Control c in form.Controls)
            {
                if (c.Name.Contains("task") && c is UserControl)
                {
                    random.Add((UserControl)c);
                    c.Location = taskPosition;
                }
            }

            for (int i = 0; i <= random.Count; i++) //ordering by index / number
            {
                if (renull) { i = 0; renull = false; }
                if (q <= random.Count)
                {
                    if (random[i].Name.Contains(string.Format("task{0}", q)))
                    {
                        TaskUCList.Add(random[i]);
                        renull = true;
                        q++;
                    }
                }
                else i += random.Count;
            }
        }

        private void AddOtherUCs(Form1 form) // Adding other User Controls ( menu, settings.. )
        {
            if (form.Controls.Find("assessUserControl1", true).FirstOrDefault() != null)
            {
                OtherUCList.Add(form.Controls.Find("assessUserControl1", true).FirstOrDefault() as UserControl);
            }

            if (form.Controls.Find("resultUserControl1", true).FirstOrDefault() != null)
            {
                OtherUCList.Add(form.Controls.Find("resultUserControl1", true).FirstOrDefault() as UserControl);
            }

            if (form.Controls.Find("menuUserControl1", true).FirstOrDefault() != null)
            {
                OtherUCList.Add(form.Controls.Find("menuUserControl1", true).FirstOrDefault() as UserControl);
            }
        }

        public void FillLists(Form1 form) //Calls all to List functions
        {
            AddToAnswers(form);
            AddToPBs(form);
            AddTasks(form);
            AddOtherUCs(form);
            AddButtonsToList(form);
            AddPanelsToList(form);
        }
        #endregion

        #region UIFunctions
        public void HideOtherTasks() //Removes remaining tasks from lists
        {
            foreach (Button btn in buttonsList)
            {
                btn.Visible = false;
            }

            TaskUCList.RemoveRange(numOfTasks, TaskUCList.Count - numOfTasks);
            PBsList.RemoveRange(numOfTasks, PBsList.Count - numOfTasks);
            TBAnswersList.RemoveRange(numOfTasks, TBAnswersList.Count - numOfTasks);
            buttonsList.RemoveRange(numOfTasks, buttonsList.Count - numOfTasks);

            foreach (Button btn in buttonsList)
            {
                btn.Visible = true;
            }
        }

        public void SetPanels(int indexControl) //UI buttons + panels setting
        {
            foreach (Button btn in buttonsList)
            {
                btn.Enabled = false;
            }

            buttonsList[indexControl].Enabled = true;
            panelsList[0].Height = buttonsList[indexControl].Height;
            panelsList[0].Top = buttonsList[indexControl].Top;
            panelsList[0].BringToFront();
            panelsList[1].BringToFront();
        }

        public void BringTaskToFront(int index) 
        {
            foreach (Control c in TaskUCList) //Hiding other Tasks
            {
                c.Visible = false;
            }

            TaskUCList[index].Visible = true;
            TaskUCList[index].Enabled = true;
            TaskUCList[index].BringToFront();
        }
        #endregion

        #region OtherFunctions

        public void SetUcPositions() //Sets up TaskUserControl location + calls TBAnswerOnClick()
        {
            int tmp = 1;

            foreach (UserControl UC in TaskUCList)
            {
                UC.Location = taskPosition;
                UC.Controls.Find(string.Format("TBAnswer{0}", tmp), true).FirstOrDefault().Click += new EventHandler(TBAnswerOnClick);
                tmp++;
            }

            foreach (UserControl UC in OtherUCList)
            {
                UC.Location = taskPosition;
            }
        }

        private void TBAnswerOnClick(object sender, EventArgs e) // hides text from Answer textbox
        {
            TextBox TB = sender as TextBox;
            TB.Text = string.Empty;
        } 

        public void LastUcBTNRemove()  // change buttons in Assess UC 
        {
            TaskUCList[numOfTasks-1].Controls.Find("btnNext", true).FirstOrDefault().Visible = false;
            /*OtherUCList[0].Controls.Find("btnContinue", true).FirstOrDefault().Visible = false;
            OtherUCList[0].Controls.Find("btnConfirm", true).FirstOrDefault().Visible = true;*/
    }

        public void AssignTaskNum() //Finds out how many tasks From the file
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(path_words))
            {
                numOfTasks = int.Parse(reader.ReadLine());
            }
        }

        public void AssignPic(int index) 
        {
            if (GetWord(index) != null && GetWord(index).Length > 0)
            {
                PBsList[index].Image = Image.FromFile(string.Format(path_files + "/{0}.jpg", GetWord(index)));
            }

            else MessageBox.Show("Error during image loading occured.");
        }

        public void CheckAnswer(TextBox answer, int currentIndex) 
        {
            if (answer.Text == GetWord(currentIndex))
            {
                numOfCorrect++;

                OtherUCList[0].Location = new Point(350,150);
                OtherUCList[0].Controls.Find("LblAnswerGood", true).FirstOrDefault().Visible = true;
                OtherUCList[0].Controls.Find("LblAnswerWrong", true).FirstOrDefault().Visible = false;
                OtherUCList[0].BringToFront();
                OtherUCList[0].Visible = true;

                //BringTaskToFront(currentIndex);
                TaskUCList[currentIndex].Visible = false;
                TaskUCList[currentIndex].Controls.Find("btnConfirm", true).FirstOrDefault().Enabled = false;
            }

            else
            {
                OtherUCList[0].Location = new Point(350, 150);
                OtherUCList[0].Controls.Find("LblAnswerGood", true).FirstOrDefault().Visible = false;
                OtherUCList[0].Controls.Find("LblAnswerWrong", true).FirstOrDefault().Visible = true;
                OtherUCList[0].BringToFront();
                OtherUCList[0].Visible = true;

                //BringTaskToFront(currentIndex);
                TaskUCList[currentIndex].Visible = false;
                TaskUCList[currentIndex].Controls.Find("btnConfirm", true).FirstOrDefault().Enabled = false;
            }
        }

        public void Speak(string input) //Reads the answer !!! finish settings for changing voice
        {
            //synthesizer.Voice.Gender = VoiceGender.Female;
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
            synthesizer.Volume = 100;
            synthesizer.Rate = -2;
            synthesizer.Speak(input);
        }

        public string GetWord(int index) // Gets file name / right answer from the file
        {
            string output = string.Empty;

            using (System.IO.StreamReader reader = new System.IO.StreamReader(path_words))
            {
                reader.ReadLine(); //Avoiding Number of Tasks

                for (int i = 0; i <= index; i++)
                {
                    output = reader.ReadLine();
                }
            }
            
            if (output.Length > 0) return output;
            else return null;
        }

        #endregion

        #region Sharepoint
        /*public void FindFiles(string userName, SecureString securePassword)
{
    string siteUrl = "https://vzdelavameprebuducnost.sharepoint.com/sites/Private";
    string libraryName = "Documents";
    SharePointOnlineCredentials credentials;

    credentials = new SharePointOnlineCredentials(userName, securePassword);

    using (ClientContext ctx = new ClientContext(siteUrl))
    {
        Web myWeb = ctx.Web;
        List myLibrary = myWeb.Lists.GetByTitle(libraryName);
        FileInformation fileInfo;

        ctx.Credentials = credentials;
        ctx.Load(myLibrary.RootFolder.Files);

        ctx.ExecuteQuery();

        List<File> SPFiles = myLibrary.RootFolder.Files.ToList();

        foreach (File f in SPFiles)
        {
            //MessageBox.Show(f.Name);
            if (!f.Name.Contains("Words"))
            {
                imagesList.Add(f); // NOT sorted

                fileInfo = File.OpenBinaryDirect(ctx, (string)f.ServerRelativeUrl);
                imagesStreamsList.Add(fileInfo.Stream); //stucks here.. why? 
            }

            else
            {
                Words = f;
                fileInfo = File.OpenBinaryDirect(ctx, (string)Words.ServerRelativeUrl);

                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileInfo.Stream))
                {

                    for (int i = 0; i < 10; i++)
                    {
                        wordsList.Add(reader.ReadLine());
                    }
                }
            }

        }

        ctx.ExecuteQuery();
    }
}*/
        #endregion
    }
}
