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
        private Deck[] Decks;
        private int DeckCount = 0;
        private string File = "";
        private int ChosenFileIndex;
        private string FileName;
        private int ProgressBarValue;
        private string Word = " ";
        public Form1()
        {
            InitializeComponent();
            Decks = new Deck[100];
            Next.Visible = false;
            Previous.Visible = false;
            Flip.Visible = false;
            GetRandomCard.Visible = false;
            ShuffleCard.Visible = false;
            AnswerBox.Visible = false;
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

        private void TestMyself_Click(object sender, EventArgs e)
        {
            AnswerBox.Visible = true;
            Flip.Visible = false;
        }

        private void AnswerBox_KeyDown(object sender, KeyEventArgs e)
        {
            Word = AnswerBox.Text;
            int CardIndex = Decks[ChosenFileIndex].GetCardIndex();

            if (e.KeyCode == Keys.Enter)
            {
                if (Word == Decks[ChosenFileIndex].GetCard(CardIndex).GetAnswer())
                {
                    MessageBox.Show("CORRECT");
                }
                else
                {
                    MessageBox.Show("INCORRECT");
                }
            }           
        }
    }
}
