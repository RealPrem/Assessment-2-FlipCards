using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2_FlipCards
{
    class Card
    {
        private string Question;
        private string Answer;
        private bool Flipped;

        public Card(string Question, string Answer)
        {
            this.Question = Question;
            this.Answer = Answer;
            Flipped = false;
        }
        /// <summary>
        /// Checks if the Card is flipped or not
        /// </summary>
        /// <returns> Returns the Flipped boolean </returns>
        public bool IsFlipped()
        {
            return Flipped;
        }
        /// <summary>
        /// It flips the card
        /// </summary>
        public void Flip()
        {
            if (!Flipped)
            {
                Flipped = true;
            }
            else
            {
                Flipped = false;
            }
        }
        /// <summary>
        /// Gets the Question
        /// </summary>
        /// <returns> Return Question </returns>
        public string GetQuestion()
        {
            return Question;
        }
        /// <summary>
        /// Get the Answer
        /// </summary>
        /// <returns> Return Answer </returns>
        public string GetAnswer()
        {
            return Answer;
        }


    }
}
