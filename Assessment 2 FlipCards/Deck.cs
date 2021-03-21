using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2_FlipCards
{
    class Deck
    {
        private Card[] Cards;
        private string FileName;
        private int CardIndex = 0;

        public Deck(string FileName)
        {
            this.FileName = FileName;

            int FileLength = GetFileLength(FileName);

            Cards = new Card[FileLength];

            LoadFile(FileName);
        }
        /// <summary>
        /// Gets a Random Card
        /// </summary>
        /// <returns> Random Card </returns>
        public Card GetRandomCard()
        {
            Random rnd = new Random();
            int Index = rnd.Next(0, Cards.Length - 1);
            while (Index == CardIndex)
            {
                Index = rnd.Next(0, Cards.Length - 1);
            }
            return Cards[Index];
        }
        public void NextCard()
        {
            if (CardIndex == Cards.Length - 1)
            {
                CardIndex = 0;
            }
            else
            {
                CardIndex += 1;
            }
        }
        public void PreviousCard()
        {
            if (CardIndex == 0)
            {
                CardIndex = Cards.Length - 1;
            }
            else
            {
                CardIndex -= 1;
            }
        }
        public void LoadFile(string FileName)
        {
            int Count = 0;
            StreamReader FileReader = new StreamReader(FileName);
            string Line = "";
            while ((Line = FileReader.ReadLine()) != null)
            {
                string[] Cells = Line.Split(',');
                string Question = Cells[0];
                string Answer = Cells[1];

                Cards[Count] = new Card(Question,Answer);
                Count += 1;
            }
        }
        public int GetFileLength(string FileName)
        {
            int Count = 0;
            StreamReader FileReader = new StreamReader(FileName);
            string Line = "";
            while ((Line = FileReader.ReadLine()) != null)
            {
                Count += 1;
            }
            return Count;
        }
        public Card GetCard(int i)
        {
            return Cards[i];
        }
        public int GetCardIndex()
        {
            return CardIndex;
        }
        public void ShuffleDeck()
        {
            Random rnd = new Random();
            int NewIndex;

            for (int i = 0; i < Cards.Length; i += 1)
            {
                NewIndex = rnd.Next(0, Cards.Length - 1);
                Card TempCard = Cards[i];
                Cards[i] = Cards[NewIndex];
                Cards[NewIndex] = TempCard;
            }
        }
        public int GetCardsLength()
        {
            return Cards.Length;
        }
        public void SetCardIndex(int i)
        {
            CardIndex = i;
        }
    }
}
