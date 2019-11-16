using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Year_13_Coursework.Tools;

namespace Year_13_Coursework
{
    public partial class frmGame4 : frmGame
    {
        private const int maximumScore = 6;

        private const int QuestionPosition = 0;
        private const int AnswerPosition = 1;
        private int answerLength = 0;
        private int numberOfIncorrectGuesses = 0;
        private string answer = "";

        private List<string> letters = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};

        private string[,] questionsAnswers = new string[10, 2]{
             {"An animal from Australia","KANGAROO"},
             {"World's second largest country","CANADA"},
             {"Southernmost capital city","WELLINGTON"},
             {"Capital city of Brazil","BRASILIA"},
             {"Capital city of Australia","CANBERRA"},
             {"City of the largest Egyptian pyramid","GIZA"},
             {"Famous waterway","PANAMA CANAL"},
             {"Mountain range","ANDES"},
             {"World's smallest country","VATICAN CITY"},
             {"River in Italy","PO"}
        };

        int selectedPosition = 0;

        private int counter = 30;

        public frmGame4()
        {
            InitializeComponent();
        }

        //The form is created
        private void FrmGame4_Load(object sender, EventArgs e)
        {
            setUpTimer();
            displayAvatar();
            setTitle();
            displayQuestion();
            playGame();
        }

        //The form is shown after frmMenu closes
        private void FrmGame4_Activated(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //The timer countdown
        private void Timer1_Tick(object sender, EventArgs e)
        {
            displayCountdown();
        }


        //Stops the form being moved so the menu form is always on top of the game
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        /* BUTTON CLICKS  ======================================================================*/


        private void LblA_Click(object sender, EventArgs e)
        {
            letterClicked(lblA);
            isLetterInAnswer(lblA);
            answerComplete();
        }

        private void LblB_Click(object sender, EventArgs e)
        {
            letterClicked(lblB);
            isLetterInAnswer(lblB);
            answerComplete();
        }

        private void LblC_Click(object sender, EventArgs e)
        {
            letterClicked(lblC);
            isLetterInAnswer(lblC);
            answerComplete();
        }

        private void LblD_Click(object sender, EventArgs e)
        {
            letterClicked(lblD);
            isLetterInAnswer(lblD);
            answerComplete();
        }

        private void LblE_Click(object sender, EventArgs e)
        {
            letterClicked(lblE);
            isLetterInAnswer(lblE);
            answerComplete();
        }

        private void LblF_Click(object sender, EventArgs e)
        {
            letterClicked(lblF);
            isLetterInAnswer(lblF);
            answerComplete();
        }

        private void LblG_Click(object sender, EventArgs e)
        {
            letterClicked(lblG);
            isLetterInAnswer(lblG);
            answerComplete();
        }

        private void LblH_Click(object sender, EventArgs e)
        {
            letterClicked(lblH);
            isLetterInAnswer(lblH);
            answerComplete();
        }

        private void LblI_Click(object sender, EventArgs e)
        {
            letterClicked(lblI);
            isLetterInAnswer(lblI);
            answerComplete();
        }

        private void LblJ_Click(object sender, EventArgs e)
        {
            letterClicked(lblJ);
            isLetterInAnswer(lblJ);
            answerComplete();
        }

        private void LblK_Click(object sender, EventArgs e)
        {
            letterClicked(lblK);
            isLetterInAnswer(lblK);
            answerComplete();
        }

        private void LblL_Click(object sender, EventArgs e)
        {
            letterClicked(lblL);
            isLetterInAnswer(lblL);
            answerComplete();
        }

        private void LblM_Click(object sender, EventArgs e)
        {
            letterClicked(lblM);
            isLetterInAnswer(lblM);
            answerComplete();
        }

        private void LblN_Click(object sender, EventArgs e)
        {
            letterClicked(lblN);
            isLetterInAnswer(lblN);
            answerComplete();
        }

        private void LblO_Click(object sender, EventArgs e)
        {
            letterClicked(lblO);
            isLetterInAnswer(lblO);
            answerComplete();
        }

        private void LblP_Click(object sender, EventArgs e)
        {
            letterClicked(lblP);
            isLetterInAnswer(lblP);
            answerComplete();
        }

        private void LblQ_Click(object sender, EventArgs e)
        {
            letterClicked(lblQ);
            isLetterInAnswer(lblQ);
            answerComplete();
        }

        private void LblR_Click(object sender, EventArgs e)
        {
            letterClicked(lblR);
            isLetterInAnswer(lblR);
            answerComplete();
        }

        private void LblS_Click(object sender, EventArgs e)
        {
            letterClicked(lblS);
            isLetterInAnswer(lblS);
            answerComplete();
        }

        private void LblT_Click(object sender, EventArgs e)
        {
            letterClicked(lblT);
            isLetterInAnswer(lblT);
            answerComplete();
        }

        private void LblU_Click(object sender, EventArgs e)
        {
            letterClicked(lblU);
            isLetterInAnswer(lblU);
            answerComplete();
        }

        private void LblV_Click(object sender, EventArgs e)
        {
            letterClicked(lblV);
            isLetterInAnswer(lblV);
            answerComplete();
        }

        private void LblW_Click(object sender, EventArgs e)
        {
            letterClicked(lblW);
            isLetterInAnswer(lblW);
            answerComplete();
        }

        private void LblX_Click(object sender, EventArgs e)
        {
            letterClicked(lblX);
            isLetterInAnswer(lblX);
            answerComplete();
        }

        private void LblY_Click(object sender, EventArgs e)
        {
            letterClicked(lblY);
            isLetterInAnswer(lblY);
            answerComplete();
        }

        private void LblZ_Click(object sender, EventArgs e)
        {
            letterClicked(lblZ);
            isLetterInAnswer(lblZ);
            answerComplete();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            moveToMenuScreen();
        }

        /* MY METHODS ======================================================================*/

        private void playGame()
        {
        }

        private void setUpTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
            lblTimerCount.Text = counter.ToString();
        }

        private async void displayCountdown()
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                timer1 = null;
                pbxThought.Image = Properties.Resources.alarmClock;

                await Task.Delay(Constants.GameConstants.delayTimeInMilliseconds);

                moveToNextScreen();
            }
            lblTimerCount.Text = counter.ToString();
        }

        private void setTitle()
        {
            GameInfo gameInfo = new GameInfo();
            lblTitle.Text = gameInfo.gameName();
        }

        private void displayAvatar()
        {
            Avatars avatar = new Avatars();
            pbxAvatar.Image = avatar.getAvatarImage(Program.currentUser.currentAvatar);
        }

        private void moveToMenuScreen()
        {
            Form moveToMenu = new frmGameMenu();
            moveToMenu.Show();
        }

        private void displayQuestion()
        {
            int rowCount = questionsAnswers.GetLength(0);
            Random random = new Random();
            selectedPosition = random.Next(0, rowCount - 1);
            answerLength = questionsAnswers[selectedPosition, AnswerPosition].Length;

            for(int i = 0; i < answerLength; i++)
            {
                lblAnswer.Text += "_ ";
            }

            lblQuestion.Text = questionsAnswers[selectedPosition, QuestionPosition];
        }

        private void letterClicked(Label label)
        {
            label.BackColor = System.Drawing.Color.Plum;
            label.ForeColor = System.Drawing.Color.Red;
            label.Enabled = false;

            letters.Remove(label.Text);
            answer = questionsAnswers[selectedPosition, AnswerPosition];
            for (int i = 0; i < letters.Count; i++)
            {
                answer = answer.Replace(letters[i], "_");
            }

            lblAnswer.Text = "";

            for (int i = 0; i < answer.Length; i++)
            {
                lblAnswer.Text += answer[i].ToString() + " ";

            }
        }
        private async void isLetterInAnswer(Label label)
        {
            if (lblAnswer.Text.Contains(label.Text))
            {
                correctAnswer();
            }
            else
            {
                incorrectAnswer();
            }

            if (numberOfIncorrectGuesses == 6)
            {
                pbxHangman.Image = Properties.Resources.gallows6;
                saveScore(maximumScore - numberOfIncorrectGuesses);
                displayScore();
                timer1.Stop();
                timer1 = null;
                await Task.Delay(Constants.GameConstants.delayTimeInMilliseconds);
                moveToNextScreen();
            }

            switch (numberOfIncorrectGuesses)
            {
                case 1: pbxHangman.Image = Properties.Resources.gallows1; break;
                case 2: pbxHangman.Image = Properties.Resources.gallows2; break;
                case 3: pbxHangman.Image = Properties.Resources.gallows3; break;
                case 4: pbxHangman.Image = Properties.Resources.gallows4; break;
                case 5: pbxHangman.Image = Properties.Resources.gallows5; break;
                case 6: pbxHangman.Image = Properties.Resources.gallows6; break;
            }
        }

        private async void correctAnswer()
        {
            pbxThought.Image = Properties.Resources.Untitled;
            displayScore();
            await Task.Delay(Constants.GameConstants.delayTimeInMilliseconds);
            pbxThought.Image = Properties.Resources.questionMark2;
        }

        private async void incorrectAnswer()
        {
            pbxThought.Image = Properties.Resources.X;
            numberOfIncorrectGuesses++;
            displayScore();
            await Task.Delay(Constants.GameConstants.delayTimeInMilliseconds);
            pbxThought.Image = Properties.Resources.questionMark2;
        }
        
        private async void answerComplete()
        {
            string usersAnswer = lblAnswer.Text.Replace(" ", "");
            string correctAnswer = questionsAnswers[selectedPosition, AnswerPosition].Replace (" ", "");

            if (usersAnswer == correctAnswer)
            {
                pbxThought.Image = Properties.Resources.Untitled;
                saveScore(maximumScore - numberOfIncorrectGuesses);
                displayScore();
                timer1.Stop();
                timer1 = null;
                await Task.Delay(Constants.GameConstants.delayTimeInMilliseconds);
                moveToNextScreen();
            }
        }

        private void displayScore()
        {
            lblScoreCount.Text = (maximumScore - numberOfIncorrectGuesses).ToString();
        }
    }
}
