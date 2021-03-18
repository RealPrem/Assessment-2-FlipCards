﻿using System;
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
        private string FileName = "";
        private int ChosenFileIndex;
        private string Name;
        public Form1()
        {
            InitializeComponent();
            Decks = new Deck[100];
        }

        private void ChangeFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            MessageBox.Show(openFileDialog1.FileName);
            FileName = openFileDialog1.FileName;
            Name = openFileDialog1.SafeFileName;
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            Decks[DeckCount] = new Deck(FileName);
            AddDeck();
            DeckCount += 1;
        }

        public void AddDeck()
        {
            DeckList.Items.Add(Name);
        }
        private void DeckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChosenFileIndex = DeckList.SelectedIndex;
            QuestionLabel.Text = Decks[ChosenFileIndex].GetCard(0).GetQuestion();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Decks[ChosenFileIndex].NextCard();

            QuestionLabel.Text = Decks[ChosenFileIndex].GetCard
                ( Decks[ChosenFileIndex].GetCardIndex() )
                .GetQuestion();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            Decks[ChosenFileIndex].PreviousCard();

            QuestionLabel.Text = Decks[ChosenFileIndex].GetCard
                (Decks[ChosenFileIndex].GetCardIndex())
                .GetQuestion();
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
    }
}
