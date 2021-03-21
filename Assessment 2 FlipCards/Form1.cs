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
        public Form1()
        {
            InitializeComponent();
            Decks = new Deck[100];
        }

        private void ChangeFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            File = openFileDialog1.FileName;
            FileName = openFileDialog1.SafeFileName;
            MessageBox.Show(FileName + "  selected");
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            Decks[DeckCount] = new Deck(File);
            AddDeck();
            DeckCount += 1;
        }

        public void AddDeck()
        {
            DeckList.Items.Add(FileName);
        }
        private void DeckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChosenFileIndex = DeckList.SelectedIndex;
            QuestionLabel.Text = Decks[ChosenFileIndex].GetCard(0).GetQuestion();
            ProgressBarValue = 1;
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = Decks[ChosenFileIndex].GetCardsLength();
            ProgressBar.Value = ProgressBarValue;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Decks[ChosenFileIndex].NextCard();

            QuestionLabel.Text = Decks[ChosenFileIndex].GetCard
                ( Decks[ChosenFileIndex].GetCardIndex() )
                .GetQuestion();
            IncreaseProgressBar();
            ProgressBar.Value = ProgressBarValue;
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            Decks[ChosenFileIndex].PreviousCard();

            QuestionLabel.Text = Decks[ChosenFileIndex].GetCard
                (Decks[ChosenFileIndex].GetCardIndex())
                .GetQuestion();
            DecreaseProgressBar();
            ProgressBar.Value = ProgressBarValue;
        }

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

        private void GetRandomCard_Click(object sender, EventArgs e)
        {

            int CardIndex = Decks[ChosenFileIndex].GetCardIndex();

            string RandomCard = Decks[ChosenFileIndex].GetRandomCard().GetQuestion();

            /*
            while (Decks[ChosenFileIndex].GetCard(CardIndex).GetQuestion() == RandomCard)
            {
                RandomCard = Decks[ChosenFileIndex].GetRandomCard().GetQuestion();
            }
            */

            Decks[ChosenFileIndex].SetCardIndex(CardIndex);
            QuestionLabel.Text = RandomCard;
            ProgressBarValue = CardIndex + 1;
            ProgressBar.Value = ProgressBarValue;
        }

        private void ShuffleCard_Click(object sender, EventArgs e)
        {
            Decks[ChosenFileIndex].ShuffleDeck();
            QuestionLabel.Text = Decks[ChosenFileIndex].GetCard(0).GetQuestion();
            ProgressBarValue = 1;
            ProgressBar.Value = ProgressBarValue;
        }
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
    }
}
