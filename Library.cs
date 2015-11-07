using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_the_Cloning
{
    class Library
    {
        private List<Card> deck;
        private int size;

        public void lookAt(int n)
        {
            //Show top n cards of library to possessing player.
        }

        public void reveal(int n)
        {
            //Show top n cards of library to all players.
        }

        public void search(/*Condition*/)
        {
            //Allow user to search library for a card that satisfies given condition(s).
        }

        public void shuffle()
        {
            //Randomly reorder all objects in this library.
            //Assign each card some value, invoke setDeck to reorder library.
        }

        internal List<Card> Deck
        {
            get
            {
                return deck;
            }

            set
            {
                deck = value;
            }
        }

        public int Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }
    }
}
