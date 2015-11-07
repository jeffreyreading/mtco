using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_the_Cloning
{
    class Player
    {
        private Library deck;
        private Hand hand;
        private List<Mana> manaPool;
        private Graveyard graveyard;       //Definitely here, inherit from Zones.cs
        private Exile exile;           //Definitely here, inherit from Zones.cs
        private List<Card> revealed;        //Toggleable by both players. Shared? If so, in Zones.cs
        private int life;               //Initialize to 20.
        private bool isActivePlayer;    //Randomly determine at beginning of game.
        private bool hasPriority;
        private bool hasPlayedLand;
        private int roll;
        private bool isMulliganing;
        private bool isPassingPriority;
        private bool loseGame;

       public Player()
        {
            deck = null;
            hand = null;
            manaPool = null;
            graveyard = null;
            exile = null;
            revealed = null;
            life = 0;
            isActivePlayer = false;
            hasPriority = false;
            hasPlayedLand = false;
            roll = 0;
            IsMulliganing = true;
        }

        public void concede()
        {
            loseGame = true;
        }

        public void draw()
        {
            //Take top card of library, put it in hand.
            //If drawing from empty library, loseGame = true;
            //Check draw triggers.
        }

        internal Library Deck
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

        internal Hand Hand
        {
            get
            {
                return hand;
            }

            set
            {
                hand = value;
            }
        }

        internal List<Mana> ManaPool
        {
            get
            {
                return manaPool;
            }

            set
            {
                manaPool = value;
            }
        }

        internal Graveyard Graveyard
        {
            get
            {
                return graveyard;
            }

            set
            {
                graveyard = value;
            }
        }

        internal Exile Exile
        {
            get
            {
                return exile;
            }

            set
            {
                exile = value;
            }
        }

        internal List<Card> Revealed
        {
            get
            {
                return revealed;
            }

            set
            {
                revealed = value;
            }
        }

        public int Life
        {
            get
            {
                return life;
            }

            set
            {
                life = value;
            }
        }

        public bool IsActivePlayer
        {
            get
            {
                return isActivePlayer;
            }

            set
            {
                isActivePlayer = value;
            }
        }

        public bool HasPriority
        {
            get
            {
                return hasPriority;
            }

            set
            {
                hasPriority = value;
            }
        }

        public bool HasPlayedLand
        {
            get
            {
                return hasPlayedLand;
            }

            set
            {
                hasPlayedLand = value;
            }
        }

        public int Roll
        {
            get
            {
                return roll;
            }

            set
            {
                roll = value;
            }
        }

        public bool IsMulliganing
        {
            get
            {
                return isMulliganing;
            }

            set
            {
                isMulliganing = value;
            }
        }

        public bool IsPassingPriority
        {
            get
            {
                return isPassingPriority;
            }

            set
            {
                isPassingPriority = value;
            }
        }

        public bool LoseGame
        {
            get
            {
                return loseGame;
            }

            set
            {
                loseGame = value;
            }
        }

        //Player actions
        public void playCard()     //Handles casting of spells, playing of lands, activation of abilities
        {

        }

        public void declareAtk()   //Handles declaration of attacks
        {

        }

        public void declareBlocks()    //Handles declaration of blocks.
        {

        }

        public void changeLife(int lifeChange) //Manages life gain and loss (damage causes loss of life, loss of life not always dmg)
        {
            
        }

        public void sacPerm(/*Card type*/)
        {
            //Handles sacrifice effects.
        }

        //Getters and Setters
     
    }
}
