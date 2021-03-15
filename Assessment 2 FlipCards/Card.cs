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
        public bool IsFlipped()
        {
            return Flipped;
        }
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
        public string GetQuestion()
        {
            return Question;
        }
        public string GetAnswer()
        {
            if (!Flipped)
            {
                return ("NO CHEATING");
            }
            return Answer;
        }


    }
}
