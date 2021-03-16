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

        public Deck()
        {
            Cards = new Card[]
            {
                new Card("Is Water Wet?","Yes"),
                new Card("Is Sky Blue?","Yes"),
                new Card("Is Red = Blue?","No")
            };
        }
        /// <summary>
        /// Gets a Random Card
        /// </summary>
        /// <returns> Random Card </returns>
        public Card GetRandomCard()
        {
            Random rnd = new Random();
            int Index = rnd.Next(Cards.Length);
            while (Index == CardIndex)
            {
                Index = rnd.Next(Cards.Length);
            }
            return Cards[Index];
        }
        public void NextCard()
        {
            if (CardIndex == Cards.Length)
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
                CardIndex = Cards.Length;
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
        public Card GetCard(int i)
        {
            return Cards[i];
        }
    }
}
