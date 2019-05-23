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
using System.Globalization;

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
        private List<Button> taskButtonsList = new List<Button>(); //on the left
        private List<Button> menuButtonsList = new List<Button>();
        public List<UserControl> OtherUCList = new List<UserControl>();
        private bool renull;
        public Point taskPosition = new Point(390, 80);
        public int numOfTasks;
        public int numOfCorrect = 0;
        public int speakerVolume = 50;
        public int speakerRate = -3;
        public VoiceGender speakerGender = VoiceGender.Female;
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
            return taskButtonsList;
        }
        #endregion

        #region List Functions

        private void NewGame()
        {
            TaskUCList.Clear();
            TBAnswersList.Clear();
            PBsList.Clear();
            panelsList.Clear();
            taskButtonsList.Clear();
            menuButtonsList.Clear();
            OtherUCList.Clear();

            numOfCorrect = 0;
            index = 0;
        }

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
            panelsList.Add(form.Controls.Find("pnlSideSmall", true).FirstOrDefault() as Panel);
            panelsList.Add(form.Controls.Find("pnlLogo", true).FirstOrDefault() as Panel);
            panelsList.Add(form.Controls.Find("pnlSideLarge", true).FirstOrDefault() as Panel);
        }

        private void AddButtonsToList(Form1 form)
        {
            for (int i = 0; i < 21; i++)
            {
                if (form.Controls.Find(string.Format("BTNTask{0}",i), true).FirstOrDefault() != null)
                {
                    taskButtonsList.Add(form.Controls.Find(string.Format("BTNTask{0}", i), true).FirstOrDefault() as Button);
                }
            }

            foreach (Button btn in taskButtonsList) //hiding task buttons, for menu, settings..
            {
                btn.Enabled = false;
                btn.Visible = false;
            }

            menuButtonsList.Add(form.Controls.Find("btnWelcome", true).FirstOrDefault() as Button);
            menuButtonsList.Add(form.Controls.Find("btnMenu", true).FirstOrDefault() as Button);
            menuButtonsList.Add(form.Controls.Find("btnSettings", true).FirstOrDefault() as Button);
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
            if (form.Controls.Find("startUserControl1", true).FirstOrDefault() != null)
            {
                OtherUCList.Add(form.Controls.Find("startUserControl1", true).FirstOrDefault() as UserControl);
            }

            if (form.Controls.Find("menuUserControl1", true).FirstOrDefault() != null)
            {
                OtherUCList.Add(form.Controls.Find("menuUserControl1", true).FirstOrDefault() as UserControl);
            }

            if (form.Controls.Find("settingsUserControl1", true).FirstOrDefault() != null)
            {
                OtherUCList.Add(form.Controls.Find("settingsUserControl1", true).FirstOrDefault() as UserControl);
            }

            if (form.Controls.Find("assessUserControl1", true).FirstOrDefault() != null)
            {
                OtherUCList.Add(form.Controls.Find("assessUserControl1", true).FirstOrDefault() as UserControl);
            }

            if (form.Controls.Find("resultUserControl1", true).FirstOrDefault() != null)
            {
                OtherUCList.Add(form.Controls.Find("resultUserControl1", true).FirstOrDefault() as UserControl);
            }

        }

        public void FillLists(Form1 form) //Calls all to List functions
        {
            NewGame();

            AddToAnswers(form);
            AddToPBs(form);
            AddTasks(form);
            AddOtherUCs(form);
            AddButtonsToList(form);
            AddPanelsToList(form);
        }

        #endregion

        #region UIFunctions

        private void HideOtherTasks() //Removes remaining tasks from lists
        {
            foreach (Button btn in taskButtonsList)
            {
                btn.Visible = false;
            }

            TaskUCList.RemoveRange(numOfTasks, TaskUCList.Count - numOfTasks); //removing remaining UserControls, buttons, answers... 
            PBsList.RemoveRange(numOfTasks, PBsList.Count - numOfTasks);
            TBAnswersList.RemoveRange(numOfTasks, TBAnswersList.Count - numOfTasks);
            taskButtonsList.RemoveRange(numOfTasks, taskButtonsList.Count - numOfTasks);

            /*foreach (Button btn in taskButtonsList)
            {
                btn.Visible = true;
            }*/
        }

        public void SetPanels(int index, bool isTask) //panels moving ( that small thing by the buttons )
        {
            if (isTask)
            {
                taskButtonsList[index].Enabled = true;
                panelsList[0].Top = taskButtonsList[index].Top;
                panelsList[0].BringToFront();
            }

            else // is menu. 1, welcome   2, menu    3, settings
            {
                panelsList[2].Top = menuButtonsList[index].Top;
                panelsList[2].BringToFront();
            }
        }

        public void BringControlToFront(int index, bool isTask) 
        {
            if (isTask)
            {
                foreach (UserControl c in TaskUCList) //Hiding other Tasks
                {
                    c.Visible = false;
                }

                foreach (UserControl UC in OtherUCList)
                {
                    UC.Visible = false;
                }

                TaskUCList[index].Visible = true;
                TaskUCList[index].Enabled = true;
                TaskUCList[index].BringToFront();
            }

            else
            {
                foreach (UserControl UC in OtherUCList)
                {
                    UC.Visible = false;
                }

                OtherUCList[index].Visible = true;
                OtherUCList[index].BringToFront();
            }
        }

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

        public void AnswersReset()
        {
            foreach (TextBox TB in TBAnswersList)
            {
                TB.Text = "Type in the answer";
            }
        }

        public void AssignPic(int index) //Adds picture to Task.PictureBox
        {
            if (GetWord(index) != null && GetWord(index).Length > 0)
            {
                PBsList[index].Image = Image.FromFile(string.Format(path_files + "/{0}.jpg", GetWord(index)));
            }

            else MessageBox.Show("Error during image loading occured.");
        }

        public void ShowButtons(bool isMenu) //switching between task buttons and menu buttons
        {
            if (isMenu)
            {
                foreach (Button btn in menuButtonsList)
                {
                    btn.Visible = true;
                }

                foreach (Button btn in taskButtonsList)
                {
                    btn.Visible = false;
                }

                panelsList[2].Visible = true;
                panelsList[0].Visible = false;
            }

            else
            {
                foreach (Button btn in menuButtonsList)
                {
                    btn.Visible = false;
                }

                foreach (Button btn in taskButtonsList)
                {
                    btn.Visible = true;
                }

                panelsList[2].Visible = false;
                panelsList[0].Visible = true;
            }
        }

        #endregion

        #region OtherFunctions

        public void AssignTaskNum() //Finds out how many tasks From the file
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(path_words))
            {
                numOfTasks = int.Parse(reader.ReadLine());
            }

            HideOtherTasks();

            foreach (UserControl UC in TaskUCList)
            {
                UC.Controls.Find("btnConfirm", true).FirstOrDefault().Enabled = true;
                UC.Controls.Find("btnNext", true).FirstOrDefault().Enabled = false;
                UC.Controls.Find("btnNext", true).FirstOrDefault().Visible = true;
            }

            TaskUCList[numOfTasks - 1].Controls.Find("btnNext", true).FirstOrDefault().Visible = false; //removing next button in last task UC 
        }

        public void CheckAnswer(TextBox answer, int currentIndex) 
        {
            if (answer.Text == GetWord(currentIndex) || answer.Text == GetWord(currentIndex).ToLower()) //comparing text with reader.Readline from Words.txt
            {
                numOfCorrect++;

                if (currentIndex + 1 < numOfTasks)
                {
                    OtherUCList[3].Controls.Find("LblAnswerGood", true).FirstOrDefault().Visible = true;
                    OtherUCList[3].Controls.Find("LblAnswerWrong", true).FirstOrDefault().Visible = false;
                }

                else
                {
                    OtherUCList[3].Controls.Find("LblAnswerGood", true).FirstOrDefault().Visible = true;
                    OtherUCList[3].Controls.Find("LblAnswerWrong", true).FirstOrDefault().Visible = false;
                    OtherUCList[3].Controls.Find("btnConfirm", true).FirstOrDefault().Visible = true;
                    OtherUCList[3].Controls.Find("btnContinue", true).FirstOrDefault().Visible = false;
                }

                OtherUCList[3].Location = new Point(350, 150);
                OtherUCList[3].BringToFront();
                OtherUCList[3].Visible = true;

                TaskUCList[currentIndex].Visible = false;
                TaskUCList[currentIndex].Controls.Find("btnConfirm", true).FirstOrDefault().Enabled = false;
            }

            else
            {
                if (currentIndex + 1 < numOfTasks)
                {
                    OtherUCList[3].Controls.Find("LblAnswerGood", true).FirstOrDefault().Visible = false;
                    OtherUCList[3].Controls.Find("LblAnswerWrong", true).FirstOrDefault().Visible = true;
                }

                else
                {
                    OtherUCList[3].Controls.Find("LblAnswerGood", true).FirstOrDefault().Visible = false;
                    OtherUCList[3].Controls.Find("LblAnswerWrong", true).FirstOrDefault().Visible = true;
                    OtherUCList[3].Controls.Find("btnConfirm", true).FirstOrDefault().Visible = true;
                    OtherUCList[3].Controls.Find("btnContinue", true).FirstOrDefault().Visible = false;
                }

                OtherUCList[3].Location = new Point(350, 150);
                OtherUCList[3].BringToFront();
                OtherUCList[3].Visible = true;

                TaskUCList[currentIndex].Visible = false;
                TaskUCList[currentIndex].Controls.Find("btnConfirm", true).FirstOrDefault().Enabled = false;
            }
        }

        public void ShowResult()
        {
            double resultPerc = ((double)numOfCorrect / (double)numOfTasks);
            OtherUCList[4].Controls.Find("lblResult",true).FirstOrDefault().Text = string.Format("{0}/{1}", numOfCorrect, numOfTasks);
            OtherUCList[4].Controls.Find("lblResultPercent", true).FirstOrDefault().Text = resultPerc.ToString("P", CultureInfo.InvariantCulture);
            OtherUCList[4].Location = new Point(350, 110);
        }

        public void Speak(string input) //Reads the answer !!! finish settings for changing voice
        {
            synthesizer.SelectVoiceByHints(speakerGender);

            synthesizer.Volume = speakerVolume;
            synthesizer.Rate = speakerRate;
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
