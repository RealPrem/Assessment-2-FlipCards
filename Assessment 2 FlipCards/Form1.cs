using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_2_FlipCards
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Array of Decks
        /// </summary>
        private Deck[] Decks;
        /// <summary>
        /// Temporary Deck for TestMySelf and Challenge Mode
        /// </summary>
        private Deck[] TempDecks;
        /// <summary>
        /// Amount of Decks loaded
        /// </summary>
        private int DeckCount = 0;
        /// <summary>
        /// File is the FileName + Paths
        /// </summary>
        private string File = "";
        /// <summary>
        /// The index of the file that was chosen in dropdown box
        /// </summary>
        private int ChosenFileIndex;
        /// <summary>
        /// The FileName without path
        /// </summary>
        private string FileName;
        /// <summary>
        /// The value of the ProgressBar
        /// </summary>
        private int ProgressBarValue;
        /// <summary>
        /// The Word inputted when doing TestMySelf or ChallengeMode
        /// </summary>
        private string Word = " ";
        /// <summary>
        /// If TestMySelf or ChallengeMode is completed
        /// </summary>
        private bool TMSFinished = false;
        /// <summary>
        /// The Score the user recieves when answering questions in TestMySelf or ChallengeMode
        /// </summary>
        private int Score = 0;
        /// <summary>
        /// The Amount of time the user has when answering questions in TestMySelf or ChallengeMode
        /// </summary>
        private int counter = 15;
        /// <summary>
        /// Timer for ChallengeMode
        /// </summary>
        private System.Windows.Forms.Timer timer1;
        /// <summary>
        /// X value of Colour
        /// </summary>
        private int X = 0;
        /// <summary>
        /// Y value of Colour
        /// </summary>
        private int Y = 128;
        /// <summary>
        /// Z value of Colour
        /// </summary>
        private int Z = 0;
        public Form1()
        {
            InitializeComponent();
            Decks = new Deck[100];
            TempDecks = new Deck[1];
            Next.Visible = false;
            Previous.Visible = false;
            Flip.Visible = false;
            GetRandomCard.Visible = false;
            ShuffleCard.Visible = false;
            AnswerBox.Visible = false;
            TestMyself.Visible = false;
            ExitButton.Visible = false;
            Answers.Visible = false;
            label1.Visible = false;
            ChallengeButton.Visible = false;
            QuestionLabel.Visible = false;
            ProgressBar.Visible = false;
            CardPosition.Visible = false;
    }
        /// <summary>
        /// Changes the file that will be chosen to load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            File = openFileDialog1.FileName;
            FileName = openFileDialog1.SafeFileName;
            MessageBox.Show(FileName + "  selected");
        }
        /// <summary>
        /// Loads the file that was chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadFile_Click(object sender, EventArgs e)
        {
            Decks[DeckCount] = new Deck(File);
            AddDeck();
            DeckCount += 1;
            
        }

        /// <summary>
        /// Adds a new deck
        /// </summary>
        public void AddDeck()
        {
            DeckList.Items.Add(FileName);
        }

        /// <summary>
        /// Changes the question and deck according to the one chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChosenFileIndex = DeckList.SelectedIndex;
            QuestionLabel.Text = Decks[ChosenFileIndex].GetCard(0).GetQuestion();
            ProgressBarValue = 1;
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = Decks[ChosenFileIndex].GetCardsLength();
            ProgressBar.Value = ProgressBarValue;
            ChangeCardPosition();
            Previous.Visible = true;
            Next.Visible = true;
            Flip.Visible = true;
            GetRandomCard.Visible = true;
            ShuffleCard.Visible = true;
            TestMyself.Visible = true;
            ExitButton.Visible = true;
            ChallengeButton.Visible = true;
            QuestionLabel.Visible = true;
            ProgressBar.Visible = true;
            CardPosition.Visible = true;
        }
        /// <summary>
        /// Changes to the next card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Next_Click(object sender, EventArgs e)
        {
            Decks[ChosenFileIndex].NextCard();

            QuestionLabel.Text = Decks[ChosenFileIndex].GetCard
                ( Decks[ChosenFileIndex].GetCardIndex() )
                .GetQuestion();
            IncreaseProgressBar();
            ProgressBar.Value = ProgressBarValue;
            ChangeCardPosition();
        }
        /// <summary>
        /// Changes to the previous card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Previous_Click(object sender, EventArgs e)
        {
            Decks[ChosenFileIndex].PreviousCard();

            QuestionLabel.Text = Decks[ChosenFileIndex].GetCard
                (Decks[ChosenFileIndex].GetCardIndex())
                .GetQuestion();
            DecreaseProgressBar();
            ProgressBar.Value = ProgressBarValue;
            ChangeCardPosition();
        }
        /// <summary>
        /// Flips the card from Q to A or A to Q
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Flip_Click(object sender, EventArgs e)
        {
            Decks[ChosenFileIndex].GetCard
                (Decks[ChosenFileIndex].GetCardIndex())
                .Flip();

            bool Flipped = Decks[ChosenFileIndex].GetCard
                (Decks[ChosenFileIndex].GetCardIndex())
                .IsFlipped();

            if (Flipped)
            {
                QuestionLabel.Text = Decks[ChosenFileIndex].GetCard
                (Decks[ChosenFileIndex].GetCardIndex())
                .GetAnswer();
            }
            else
            {
                QuestionLabel.Text = Decks[ChosenFileIndex].GetCard
                (Decks[ChosenFileIndex].GetCardIndex())
                .GetQuestion();
            }
        }
        /// <summary>
        /// Gets a random card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetRandomCard_Click(object sender, EventArgs e)
        {

            Card RandomCard = Decks[ChosenFileIndex].GetRandomCard();

            int CardIndex = Decks[ChosenFileIndex].GetCardIndex();

            string Question = RandomCard.GetQuestion();

            Decks[ChosenFileIndex].SetCardIndex(CardIndex);
            QuestionLabel.Text = Question;
            ProgressBarValue = CardIndex + 1;
            ProgressBar.Value = ProgressBarValue;
            ChangeCardPosition();
        }
        /// <summary>
        /// Shuffles the card around in the deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShuffleCard_Click(object sender, EventArgs e)
        {
            Decks[ChosenFileIndex].ShuffleDeck();
            QuestionLabel.Text = Decks[ChosenFileIndex].GetCard(0).GetQuestion();
            ProgressBarValue = 1;
            ProgressBar.Value = ProgressBarValue;
        }
        /// <summary>
        /// Increases the progress bar when it changes to the next card
        /// </summary>
        private void IncreaseProgressBar()
        {
            if (ProgressBarValue == Decks[ChosenFileIndex].GetCardsLength())
            {
                ProgressBarValue = 1;
            }
            else
            {
                ProgressBarValue += 1;
            }
        }
        /// <summary>
        /// Decreases the progress bar when it changes to the previous card
        /// </summary>
        private void DecreaseProgressBar()
        {
            if (ProgressBarValue == 1)
            {
                ProgressBarValue = Decks[ChosenFileIndex].GetCardsLength();
            }
            else
            {
                ProgressBarValue -= 1;
            }
        }
        /// <summary>
        /// It changes the text that shows which position the card it is at currently
        /// </summary>
        private void ChangeCardPosition()
        {
            int CardIndex = Decks[ChosenFileIndex].GetCardIndex() + 1;
            string CurrentCardSpace = CardIndex.ToString();
            string CardLength = Decks[ChosenFileIndex].GetCardsLength().ToString();
            CardPosition.Text = "CARD  " + CurrentCardSpace + " / " + CardLength;
        }

        /// <summary>
        /// It activates the TestMyself mode and hides the flip button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestMyself_Click(object sender, EventArgs e)
        {
            Score = 0;

            AnswerBox.Visible = true;
            Flip.Visible = false;
            Previous.Visible = false;
            Next.Visible = false;
            
            TempDecks[0] = Decks[ChosenFileIndex];
            TempDecks[0].ShuffleDeck();
            TempDecks[0].SetCardIndex(0);
            ProgressBarValue = 1;
            ProgressBar.Value = ProgressBarValue;
            ChangeCardPosition();
            QuestionLabel.Text = TempDecks[0].GetCard(0).GetQuestion();
            ResetAnswerBox();
        }

        /// <summary>
        /// Checks the answers to the question and showing the user their results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerBox_KeyDown(object sender, KeyEventArgs e)
        {
            Word = AnswerBox.Text;
            int CardIndex = TempDecks[ChosenFileIndex].GetCardIndex();
            int CardsLength = TempDecks[ChosenFileIndex].GetCardsLength();

            bool[] Correct = new bool[CardsLength - 1];
            int i = 0;

            //If I press enter then it would get the word from the textbox
            if (e.KeyCode == Keys.Enter)
            {
                if (Word.ToLower() == TempDecks[ChosenFileIndex].GetCard(CardIndex).GetAnswer().ToLower())
                {
                    Correct[i] = true;
                    Score += 1;
                }
                else
                {
                    Correct[i] = false;
                }
                //Resetting the Timer
                X = 0;
                Y = 128;
                counter = 15;
                label1.ForeColor = Color.FromArgb(X, Y, Z);
                label1.Text = counter.ToString();

                //Adds the Question and checks the box if I got it right in the CheckBox
                string Question = TempDecks[ChosenFileIndex].GetCard(CardIndex).GetQuestion();
                string Answer = TempDecks[ChosenFileIndex].GetCard(CardIndex).GetAnswer();
                string QnA = string.Format("Q:{0}  A:{1,2}", Question, Answer);
                if (Correct[i] == true)
                {
                    Answers.SelectionColor = Color.Green;
                    Answers.AppendText("\r\n" + QnA);
                    Answers.ScrollToCaret();

                }
                else
                {
                    Answers.SelectionColor = Color.Red;
                    Answers.AppendText("\r\n" + QnA);
                    Answers.ScrollToCaret();
                }

                i += 1;

                //Checking whether the user got 50% or more
                if (TempDecks[ChosenFileIndex].GetCardIndex() == TempDecks[ChosenFileIndex].GetCardsLength() - 1)
                {
                    if (((double) Score/TempDecks[ChosenFileIndex].GetCardsLength()) * 100 >= 50)
                    {
                        QuestionLabel.ForeColor = Color.Green;
                    }
                    else
                    {
                        QuestionLabel.ForeColor = Color.Red;
                    }
                    QuestionLabel.Text = "YOU SCORED " + Score + " / " + TempDecks[ChosenFileIndex].GetCardsLength();
                    Answers.Visible = true;
                    TMSFinished = true;
                    label1.Visible = false;
                }
                // Changes to the next card when the user finishes answering the question
                else
                {
                    TempDecks[ChosenFileIndex].NextCard();

                    QuestionLabel.Text = TempDecks[ChosenFileIndex].GetCard
                        (TempDecks[ChosenFileIndex].GetCardIndex())
                        .GetQuestion();
                    IncreaseProgressBar();
                    ProgressBar.Value = ProgressBarValue;
                    ChangeCardPosition();
                }
            }
        }
        /// <summary>
        /// Hides the AnswerBox and Shows the Flip , Previous and Next buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Flip.Visible = true;
            AnswerBox.Visible = false;
            Previous.Visible = true;
            Next.Visible = true;
            Answers.Visible = false;
            TMSFinished = false;
            label1.Visible = false;

            //Resetting everything and going back to first card
            QuestionLabel.ForeColor = Color.Black;
            Decks[ChosenFileIndex].NextCard();
            int CardIndex = Decks[ChosenFileIndex].GetCardIndex();
            QuestionLabel.Text = Decks[ChosenFileIndex].GetCard(CardIndex).GetQuestion();
            ProgressBarValue = 1;
            ProgressBar.Value = ProgressBarValue;
            ChangeCardPosition();

        }
        /// <summary>
        /// Clears the AnswerBox if the user uses TestMySelf or Challenge Mode again and adds the Question + CorrectAnswers as a title 
        /// </summary>
        private void ResetAnswerBox()
        {
            Answers.Text = "";
            Answers.AppendText("Question" + "        " + "CorrectAnswers");
        }

        /// <summary>
        /// Activates ChallengeMode and Starts the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChallengeButton_Click(object sender, EventArgs e)
        {
            //Creating Timer and setting the amount of the user has
            Score = 0;
            counter = 15;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            label1.ForeColor = Color.FromArgb(X, Y, Z);
            label1.Text = counter.ToString();

            AnswerBox.Visible = true;
            Flip.Visible = false;
            Previous.Visible = false;
            Next.Visible = false;
            ChallengeButton.Visible = true;
            label1.Visible = true;
            

            TempDecks[0] = Decks[ChosenFileIndex];
            TempDecks[0].ShuffleDeck();
            TempDecks[0].SetCardIndex(0);
            ProgressBarValue = 1;
            ProgressBar.Value = ProgressBarValue;
            ChangeCardPosition();
            QuestionLabel.Text = TempDecks[0].GetCard(0).GetQuestion();
            ResetAnswerBox();
        }
        /// <summary>
        /// When time changed by 1 second, updates the Time Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Constantly changing colour
            X = X + (255 / 15);
            Y = Y - (128 / 15);
            label1.ForeColor = Color.FromArgb(X, Y, Z);

            counter -= 1;
            if (counter == 0)
            {
                timer1.Stop();
                QuestionLabel.Text = "ANSWER NOW";
            }
            else if (TMSFinished == true)
            {
                timer1.Stop();
            }
            label1.Text = counter.ToString();
        }
    }
}
