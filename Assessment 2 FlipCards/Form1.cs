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
        Deck[] Decks;
        int DeckCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            MessageBox.Show(openFileDialog1.FileName);
            string FileName = openFileDialog1.FileName;
            Decks[DeckCount] = new Deck();
            Decks[0].
            //QuestionLabel.Text = Decks[DeckCount].
        }
    }
}
