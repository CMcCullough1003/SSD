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

        private const int QuestionPosition = 0;
        private const int AnswerPosition = 1;
        private int answerLength = 0;

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
        }

        private void LblB_Click(object sender, EventArgs e)
        {
            letterClicked(lblB);
        }

        private void LblC_Click(object sender, EventArgs e)
        {
            letterClicked(lblC);
        }

        private void LblD_Click(object sender, EventArgs e)
        {
            letterClicked(lblD);
        }

        private void LblE_Click(object sender, EventArgs e)
        {
            letterClicked(lblE);
        }

        private void LblF_Click(object sender, EventArgs e)
        {
            letterClicked(lblF);
        }

        private void LblG_Click(object sender, EventArgs e)
        {
            letterClicked(lblG);
        }

        private void LblH_Click(object sender, EventArgs e)
        {
            letterClicked(lblH);
        }

        private void LblI_Click(object sender, EventArgs e)
        {
            letterClicked(lblI);
        }

        private void LblJ_Click(object sender, EventArgs e)
        {
            letterClicked(lblJ);
        }

        private void LblK_Click(object sender, EventArgs e)
        {
            letterClicked(lblK);
        }

        private void LblL_Click(object sender, EventArgs e)
        {
            letterClicked(lblL);
        }

        private void LblM_Click(object sender, EventArgs e)
        {
            letterClicked(lblM);
        }

        private void LblN_Click(object sender, EventArgs e)
        {
            letterClicked(lblN);
        }

        private void LblO_Click(object sender, EventArgs e)
        {
            letterClicked(lblO);
        }

        private void LblP_Click(object sender, EventArgs e)
        {
            letterClicked(lblP);
        }

        private void LblQ_Click(object sender, EventArgs e)
        {
            letterClicked(lblQ);
        }

        private void LblR_Click(object sender, EventArgs e)
        {
            letterClicked(lblR);
        }

        private void LblS_Click(object sender, EventArgs e)
        {
            letterClicked(lblS);
        }

        private void LblT_Click(object sender, EventArgs e)
        {
            letterClicked(lblT);
        }

        private void LblU_Click(object sender, EventArgs e)
        {
            letterClicked(lblU);
        }

        private void LblV_Click(object sender, EventArgs e)
        {
            letterClicked(lblV);
        }

        private void LblW_Click(object sender, EventArgs e)
        {
            letterClicked(lblW);
        }

        private void LblX_Click(object sender, EventArgs e)
        {
            letterClicked(lblX);
        }

        private void LblY_Click(object sender, EventArgs e)
        {
            letterClicked(lblY);
        }

        private void LblZ_Click(object sender, EventArgs e)
        {
            letterClicked(lblZ);
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
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

        private void displayCountdown()
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                pbxThought.Image = Properties.Resources.alarmClock;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            moveToNextScreen();
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
            string answer = questionsAnswers[selectedPosition, AnswerPosition];
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
    }
}
