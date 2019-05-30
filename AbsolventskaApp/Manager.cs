using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.IO;

namespace AbsolventskaApp
{
    public class Manager
    {
        #region Variables

        protected string fileName;
        public int index;
        protected string path_files = Environment.GetEnvironmentVariable("Tunga", EnvironmentVariableTarget.User); //path to own exercise
        protected string path_words = Environment.GetEnvironmentVariable("Tunga", EnvironmentVariableTarget.User) + @"\Words.txt";

        protected List<UserControl> TaskUCList = new List<UserControl>(); // task user controls
        private List<TextBox> TBAnswersList = new List<TextBox>(); // task user controls textboxes
        private List<PictureBox> PBsList = new List<PictureBox>(); // task user controls pictureboxes
        private List<Panel> panelsList = new List<Panel>(); // small panels by buttons + logo panel
        private List<Button> taskButtonsList = new List<Button>(); //task buttons on the left
        private List<Button> menuButtonsList = new List<Button>(); //menu, welcome and settings buttons
        public List<UserControl> otherUCList = new List<UserControl>(); //menu, welcome and settings user controls

        private List<string> numExAnswers = new List<string>(); //answers to num up to 10 exercise
        private List<string> animExAnswers = new List<string>(); //answers to Animals exercise
        private List<string> numBExAnswers = new List<string>(); //answers to num up to 100 exercise
        private List<string> coloursExAnswers = new List<string>(); //answers to Colours exercise
        private List<string> foodExAnswers = new List<string>(); //answers to Food exercise
        private List<string> clothingExAnswers = new List<string>(); //answers to Clothing exercise

        public Point taskPosition = new Point(390, 80); // default

        public int numOfTasks; // pocet poloziek
        public int numOfCorrect = 0;

        protected SpeechSynthesizer synthesizer = new SpeechSynthesizer(); //speaker
        public int speakerVolume = 50;
        public int speakerRate = -3;
        public VoiceGender speakerGender = VoiceGender.Female;

        private bool renull; //sorting random list
        private bool isNumExercise; //Which exercise bools
        private bool isAnimExercise;
        private bool isOwnExercise;
        private bool isColourExercise;
        private bool isNum100Exercise;
        private bool isFoodExercise;
        private bool isClothingExercise;

        ResourceManager resourceManager = new ResourceManager(typeof(TungaApp.Properties.Resources));
        ResourceSet rSet; // for adding the answers from resources
        static Manager instance = new Manager();

        #endregion

        #region SetBoolMethods //settings bool which exericse

        public void SetNumBool()
        {
            isNumExercise = true;
        }

        public void SetAnimBool()
        {
            isAnimExercise = true;
        }

        public void SetOwnBool()
        {
            isOwnExercise = true;
        }

        public void SetColourBool()
        {
            isColourExercise = true;
        }

        public void SetNum100Bool()
        {
            isNum100Exercise = true;
        }

        public void SetFoodBool()
        {
            isFoodExercise = true;
        }

        public void SetClothingBool()
        {
            isClothingExercise = true;
        }

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

        public List<UserControl> GetOtherUCList()
        {
            return otherUCList;
        }

        #endregion

        #region List Functions

        public void NewGame() //clearing lists, setting bools to false
        {
            TaskUCList.Clear();
            TBAnswersList.Clear();
            PBsList.Clear();
            taskButtonsList.Clear();

            numOfCorrect = 0;
            index = 0;
            isAnimExercise = false;
            isNumExercise = false;
            isOwnExercise = false;
            isNum100Exercise = false;
            isFoodExercise = false;
            isClothingExercise = false;
            isColourExercise = false;

            FillLists(Form1.GetInstance());

            if (Environment.GetEnvironmentVariable("Tunga", EnvironmentVariableTarget.User) == null) menuButtonsList[1].Controls.Find("btnOwn", true).FirstOrDefault().Enabled = false;
        }

        private void AddTBToAnswers(Form1 form)
        {
            for (int i = 0; i < form.Controls.Count; i++)
            {
                if (form.Controls.Find(string.Format("TBAnswer{0}", i), true).FirstOrDefault() != null)
                {
                    TBAnswersList.Add((TextBox)form.Controls.Find(string.Format("TBAnswer{0}", i), true).FirstOrDefault());
                }
            }
        }

        public void AddExAnswers() //Exercise answers
        {
            rSet = resourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

            for (int i = 1; i < 14; i++)
            {
                if (i < 10)
                {
                    animExAnswers.Add(rSet.GetString(string.Format("a{0}Answer", i)));
                    coloursExAnswers.Add(rSet.GetString(string.Format("c{0}Answer", i)));
                }

                if (i < 11)
                {
                    clothingExAnswers.Add(rSet.GetString(string.Format("cl{0}Answer", i)));
                    numBExAnswers.Add(rSet.GetString(string.Format("nB{0}Answer", i)));
                }

                if (i < 14)
                {
                    foodExAnswers.Add(rSet.GetString(string.Format("f{0}Answer", i)));
                }
            }

            for (int i = 0; i < 11; i++)
            {
                numExAnswers.Add(rSet.GetString(string.Format("n{0}Answer", i)));
            }
        }

        private void AddToPBs(Form1 form) //Adding pictureboxes to list
        {
            for (int i = 0; i < form.Controls.Count; i++)
            {
                if (form.Controls.Find(string.Format("pictureBox{0}", i), true).FirstOrDefault() != null)
                {
                    PBsList.Add((PictureBox)form.Controls.Find(string.Format("pictureBox{0}", i), true).FirstOrDefault());
                }
            }
        }

        public void AddPanelsToList(Form1 form) //Adding panels to list
        {
            if (panelsList.Count != 3)
            {
                panelsList.Clear();
                panelsList.Add(form.Controls.Find("pnlSideSmall", true).FirstOrDefault() as Panel);
                panelsList.Add(form.Controls.Find("pnlLogo", true).FirstOrDefault() as Panel);
                panelsList.Add(form.Controls.Find("pnlSideLarge", true).FirstOrDefault() as Panel);
            }
        }

        private void AddTaskButtonsToList(Form1 form)
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
        }

        public void AddMenuButtonsToList(Form1 form)
        {
            if (menuButtonsList.Count != 3)
            {
                menuButtonsList.Clear();
                menuButtonsList.Add(form.Controls.Find("btnWelcome", true).FirstOrDefault() as Button);
                menuButtonsList.Add(form.Controls.Find("btnMenu", true).FirstOrDefault() as Button);
                menuButtonsList.Add(form.Controls.Find("btnSettings", true).FirstOrDefault() as Button);
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
                    if (random[i].Name == (string.Format("task{0}UserControl1", q)))
                    {
                        TaskUCList.Add(random[i]);
                        renull = true;
                        q++;
                    }
                }
                else i += random.Count;
            }
        }

        public void AddOtherUCs(Form1 form) // Adding other User Controls ( menu, settings.. )
        {
            if (otherUCList.Count != 5)
            {
                otherUCList.Clear();
                otherUCList.Add(form.Controls.Find("startUserControl1", true).FirstOrDefault() as UserControl);
                otherUCList.Add(form.Controls.Find("menuUserControl1", true).FirstOrDefault() as UserControl);
                otherUCList.Add(form.Controls.Find("settingsUserControl1", true).FirstOrDefault() as UserControl);
                otherUCList.Add(form.Controls.Find("assessUserControl1", true).FirstOrDefault() as UserControl);
                otherUCList.Add(form.Controls.Find("resultUserControl1", true).FirstOrDefault() as UserControl);
            }
        }

        public void FillLists(Form1 form) //Calls all to List functions
        {
            AddToPBs(form);
            AddTBToAnswers(form);
            AddTasks(form);
            AddTaskButtonsToList(form);
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

        public void BringControlToFront(int index, bool isTask)  //bring control to front, hiding other tasks
        {
            if (isTask)
            {
                foreach (UserControl c in TaskUCList)
                {
                    c.Visible = false;
                }

                foreach (UserControl UC in otherUCList)
                {
                    UC.Visible = false;
                }

                TaskUCList[index].Visible = true;
                TaskUCList[index].Enabled = true;
                TaskUCList[index].BringToFront();
            }

            else
            {
                foreach (UserControl UC in otherUCList)
                {
                    UC.Visible = false;
                }

                otherUCList[index].Visible = true;
                otherUCList[index].BringToFront();
            }

            panelsList[1].BringToFront(); // Panel with Logo
        }

        public void SetUcPositions() //Sets up TaskUserControl location + calls TBAnswerOnClick()
        {
            int tmp = 1;

            //MessageBox.Show(Screen.PrimaryScreen.Bounds.Width.ToString());
            
            if (Screen.PrimaryScreen.Bounds.Width == 1920 && Screen.PrimaryScreen.Bounds.Height == 1080) taskPosition = new Point(390, 80);
            else if (Screen.PrimaryScreen.Bounds.Width == 1366 && Screen.PrimaryScreen.Bounds.Height == 768) taskPosition = new Point(300, 50);

            foreach (UserControl UC in TaskUCList)
            {
                UC.Location = taskPosition;
                UC.Controls.Find(string.Format("TBAnswer{0}", tmp), true).FirstOrDefault().Click += new EventHandler(TBAnswerOnClick);
                tmp++;
            }

            foreach (UserControl UC in otherUCList)
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

        public void AssignPic(int index) //Adds picture to Task.PictureBox //Exercise
        {
            if (isAnimExercise)
            {
                for (int i = 0; i < TaskUCList.Count; i++)
                {
                    PBsList[i].Image = (Image)resourceManager.GetObject(string.Format("a{0}", i + 1));
                }
            }

            else if (isNumExercise)
            {
                for (int i = 0; i < TaskUCList.Count; i++)
                {
                    PBsList[i].Image = (Image)resourceManager.GetObject(string.Format("n{0}", i));//Image.FromStream(resourceManager.GetStream(string.Format("n{0}", i)));
                }
            }

            else if (isNum100Exercise)
            {
                for (int i = 0; i < TaskUCList.Count; i++)
                {
                    PBsList[i].Image = (Image)resourceManager.GetObject(string.Format("nB{0}", i + 1));//Image.FromStream(resourceManager.GetStream(string.Format("n{0}", i)));
                }
            }

            else if (isColourExercise)
            {
                for (int i = 0; i < TaskUCList.Count; i++)
                {
                    PBsList[i].Image = (Image)resourceManager.GetObject(string.Format("c{0}", i + 1));//Image.FromStream(resourceManager.GetStream(string.Format("n{0}", i)));
                }
            }

            else if (isFoodExercise)
            {
                for (int i = 0; i < TaskUCList.Count; i++)
                {
                    PBsList[i].Image = (Image)resourceManager.GetObject(string.Format("f{0}", i + 1));//Image.FromStream(resourceManager.GetStream(string.Format("n{0}", i)));
                }
            }

            else if (isClothingExercise)
            {
                for (int i = 0; i < TaskUCList.Count; i++)
                {
                    PBsList[i].Image = (Image)resourceManager.GetObject(string.Format("cl{0}", i + 1));//Image.FromStream(resourceManager.GetStream(string.Format("n{0}", i)));
                }
            }

            else if (GetWord(index) != null && GetWord(index).Length > 0 && isOwnExercise)
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

                panelsList[2].Visible = true; //small panels by buttons
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
            if (isNumExercise) numOfTasks = numExAnswers.Count;
            else if (isAnimExercise) numOfTasks = animExAnswers.Count;
            else if (isNum100Exercise) numOfTasks = numBExAnswers.Count;
            else if (isColourExercise) numOfTasks = coloursExAnswers.Count;
            else if (isFoodExercise) numOfTasks = foodExAnswers.Count;
            else if (isClothingExercise) numOfTasks = clothingExAnswers.Count;

            else if(isOwnExercise)
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(path_words))
                {
                    numOfTasks = int.Parse(reader.ReadLine());
                }
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

        public void CheckAnswer(TextBox answer, int currentIndex) //So long because of button manipulation of Assess UC 
        {
            if (answer != null && answer.Text != "" && answer.Text != "Type in the answer")
            {
                if (answer.Text == GetWord(currentIndex) || answer.Text == GetWord(currentIndex).ToLower()) //comparing text with reader.Readline from Words.txt
                {
                    numOfCorrect++;

                    if (currentIndex + 1 < numOfTasks)
                    {
                        otherUCList[3].Controls.Find("LblAnswerGood", true).FirstOrDefault().Visible = true;
                        otherUCList[3].Controls.Find("LblAnswerWrong", true).FirstOrDefault().Visible = false;
                    }

                    else
                    {
                        otherUCList[3].Controls.Find("LblAnswerGood", true).FirstOrDefault().Visible = true;
                        otherUCList[3].Controls.Find("LblAnswerWrong", true).FirstOrDefault().Visible = false;
                        otherUCList[3].Controls.Find("btnConfirm", true).FirstOrDefault().Visible = true;
                        otherUCList[3].Controls.Find("btnContinue", true).FirstOrDefault().Visible = false;
                    }

                    otherUCList[3].Location = new Point(350, 150); //default
                    if(Screen.PrimaryScreen.Bounds.Width == 1366 && Screen.PrimaryScreen.Bounds.Height == 768) otherUCList[3].Location = new Point(270, 100);
                    otherUCList[3].BringToFront();
                    otherUCList[3].Visible = true;

                    TaskUCList[currentIndex].Visible = false;
                    TaskUCList[currentIndex].Controls.Find("btnConfirm", true).FirstOrDefault().Enabled = false;
                }

                else
                {
                    if (currentIndex + 1 < numOfTasks)
                    {
                        otherUCList[3].Controls.Find("LblAnswerGood", true).FirstOrDefault().Visible = false;
                        otherUCList[3].Controls.Find("LblAnswerWrong", true).FirstOrDefault().Visible = true;
                        otherUCList[3].Controls.Find("lblCorrectAnswer", true).FirstOrDefault().Visible = true;
                        otherUCList[3].Controls.Find("lblCorrectAnswer", true).FirstOrDefault().Text = string.Format("The correct answer is : {0}", GetWord(index));
                    }

                    else
                    {
                        otherUCList[3].Controls.Find("LblAnswerGood", true).FirstOrDefault().Visible = false;
                        otherUCList[3].Controls.Find("LblAnswerWrong", true).FirstOrDefault().Visible = true;
                        otherUCList[3].Controls.Find("btnConfirm", true).FirstOrDefault().Visible = true;
                        otherUCList[3].Controls.Find("btnContinue", true).FirstOrDefault().Visible = false;
                        otherUCList[3].Controls.Find("lblCorrectAnswer", true).FirstOrDefault().Visible = true;
                        otherUCList[3].Controls.Find("lblCorrectAnswer", true).FirstOrDefault().Text = string.Format("The correct answer is : {0}", GetWord(index));
                    }

                    otherUCList[3].BringToFront();
                    otherUCList[3].Visible = true;

                    TaskUCList[currentIndex].Visible = false;
                    TaskUCList[currentIndex].Controls.Find("btnConfirm", true).FirstOrDefault().Enabled = false;
                }

                TaskUCList[currentIndex].Controls.Find("btnNext", true).FirstOrDefault().Enabled = true;

                if (Screen.PrimaryScreen.Bounds.Width == 1366 && Screen.PrimaryScreen.Bounds.Height == 768) otherUCList[3].Location = new Point(270, 100);
                else otherUCList[3].Location = new Point(350, 150); //default

                panelsList[1].BringToFront();
            }

            else
            {
                MessageBox.Show("Please, type in the answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TaskUCList[currentIndex].Controls.Find("btnNext", true).FirstOrDefault().Enabled = false;
            }
        }

        public void ShowResult()
        {
            double resultPerc = ((double)numOfCorrect / (double)numOfTasks);
            otherUCList[4].Controls.Find("lblResult",true).FirstOrDefault().Text = string.Format("{0}/{1}", numOfCorrect, numOfTasks);
            otherUCList[4].Controls.Find("lblResultPercent", true).FirstOrDefault().Text = resultPerc.ToString("P", CultureInfo.InvariantCulture);

            if (Screen.PrimaryScreen.Bounds.Width == 1366 && Screen.PrimaryScreen.Bounds.Height == 768) otherUCList[4].Location = new Point(270, 100);
            else otherUCList[4].Location = new Point(350, 110); // default

            panelsList[1].BringToFront();
        }

        public void Speak(string input) //Reads the answer
        {
            synthesizer.SelectVoiceByHints(speakerGender);

            synthesizer.Volume = speakerVolume;
            synthesizer.Rate = speakerRate;
            synthesizer.Speak(input);
        }

        public string GetWord(int index) // Gets file name / right answer from the file
        {
            string output = string.Empty;

            if (isNumExercise) output = numExAnswers[index];
            else if (isAnimExercise) output = animExAnswers[index];
            else if (isNum100Exercise) output = numBExAnswers[index];
            else if (isFoodExercise) output = foodExAnswers[index];
            else if (isColourExercise) output = coloursExAnswers[index];
            else if (isClothingExercise) output = clothingExAnswers[index];

            else if (isOwnExercise)
            {
                using (StreamReader reader = new StreamReader(path_words))
                {
                    reader.ReadLine(); //Avoiding Number of Tasks

                    for (int i = 0; i <= index; i++)
                    {
                        output = reader.ReadLine();
                    }
                }
            }

            if (output.Length > 0) return output;
            else return null;
        }

        #endregion
    }
}
