using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_the_Cloning
{
    class Hand
    {
        private List<Card> handCards;
        private int maxSize;
        private int numCards;


        public void reveal(List<Player> players)
        {
            //GUI: Reveal contents of hand to given players.
        }

        public List<Card> HandCards
        {
            get
            {
                return handCards;
            }

            set
            {
                handCards = value;
            }
        }
        public int MaxSize
        {
            get
            {
                return maxSize;
            }

            set
            {
                maxSize = value;
            }
        }

        public int NumCards
        {
            get
            {
                return numCards;
            }

            set
            {
                numCards = value;
            }
        }

        //Getters and Setters
       
    }
}
