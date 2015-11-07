using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;   //Images library?

namespace Magic_the_Cloning
{
    class Card
    {
        public enum Rarity { Co, Un, Ra, Mr, Sp };
        public enum CardColor { White, Blue, Black, Red, Green, Colorless}

        private string name;            //General
        private Mana[] manaCost;        //General
        private int convertedManaCost;  //General
        private Image illustration;     //General
        private CardColor[] colorIndicator;     //General
        private string type;        //General
        private Image expansionSymbol;  //General
        private Rarity rarity;      //General
        private string textbox;     //General
        private string flavorText;  //General, not req.
        private int loyalty;        //PW (Spell?)
        private string illustrateCredit;    //General
        private string legalText;       //General
        private string collectorNumber; //General, catalog purposes (BFZxxx)?
        private bool isTapped;      //General
        private bool isUntapping;       //General
        private bool isDestroyed;       //General
        private bool isExiled;      //General
        private Player owner;       //General
        private Player controller;      //General
        private int numLoyaltyCounters;        //PW
        private bool isToken;       //General (usually creature, use for stack objects?)
        private bool isCopy;        //General (almost always creature)
        private bool isMonocolor;   //General (most applicable to creature)
        private bool isMulticolor;  //General (applicable to creature)
        private bool isColorless;   //General (Creature, Artifact, Land)
        private Effect[] effects;   //General
        private Trigger[] triggers; //General


        public Card()   //Pull values from xml.
        {
            name = xml.name;
            manaCost = xml.manaCost;
            illustration = xml.illustration;
            colorIndicator = xml.colorIndicator;
            type = xml.type;
            expansionSymbol = xml.expansionSymbol;
            rarity = xml.rarity;
            textbox = xml.textbox;
            loyalty = xml.loyalty;
            illustrateCredit = xml.illustrateCredit;
            legalText = xml.legalText;
            collectorNumber = xml.collectorNumber;
            isTapped = false;
            isUntapping = true;
            isDestroyed = false;
            isExiled = true;
            owner = xml.owner;   //Initial deck's player
            controller = xml.controller;   //Casting player
            numLoyaltyCounters = 0;
            isToken = false;
            isCopy = false;
            isMonocolor = false;
            isMulticolor = false;
            isColorless = false;

        }
        public Card(Card copyCard)
        {
            name = copyCard.name;
            manaCost = copyCard.manaCost;
            illustration = copyCard.illustration;
            colorIndicator = copyCard.colorIndicator;
            type = copyCard.type;
            expansionSymbol = copyCard.expansionSymbol;
            rarity = copyCard.rarity;
            textbox = copyCard.textbox;
            basePower = copyCard.basePower;
            tempPower = 0;
            baseToughness = copyCard.baseToughness;
            tempToughness = 0;
            loyalty = copyCard.loyalty;
            illustrateCredit = copyCard.illustrateCredit;
            legalText = copyCard.legalText;
            collectorNumber = copyCard.collectorNumber;
            isTapped = copyCard.isTapped;
            isNewlyControlled = copyCard.isNewlyControlled;
            isAttacking = copyCard.isAttacking;
            isBlocking = copyCard.isBlocking;
            isBlocked = copyCard.isBlocked;
            damageMarked = copyCard.damageMarked;
            isUntapping = copyCard.isUntapping;
            isDestroyed = copyCard.isDestroyed;
            isExiled = copyCard.isExiled;
            owner = copyCard.owner;
            controller = copyCard.controller;   //Casting player
            numPlusPlusCounters = copyCard.numPlusPlusCounters;
            numMinusMinusCounters = copyCard.numMinusMinusCounters;
            numLoyaltyCounters = copyCard.numLoyaltyCounters;
            isToken = copyCard.isToken;
            isCopy = copyCard.isCopy;
            isMonocolor = copyCard.isMonocolor;
            isMulticolor = copyCard.isMulticolor;
            isColorless = copyCard.isColorless;
    }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        internal Mana[] ManaCost
        {
            get
            {
                return manaCost;
            }

            set
            {
                manaCost = value;
            }
        }

        public Image Illustration
        {
            get
            {
                return illustration;
            }

            set
            {
                illustration = value;
            }
        }

        public CardColor[] ColorIndicator
        {
            get
            {
                return colorIndicator;
            }

            set
            {
                colorIndicator = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public Image ExpansionSymbol
        {
            get
            {
                return expansionSymbol;
            }

            set
            {
                expansionSymbol = value;
            }
        }

        private Rarity Rarity1
        {
            get
            {
                return rarity;
            }

            set
            {
                rarity = value;
            }
        }

        public string Textbox
        {
            get
            {
                return textbox;
            }

            set
            {
                textbox = value;
            }
        }

        public int Loyalty
        {
            get
            {
                return loyalty;
            }

            set
            {
                loyalty = value;
            }
        }

        public string IllustrateCredit
        {
            get
            {
                return illustrateCredit;
            }

            set
            {
                illustrateCredit = value;
            }
        }

        public string LegalText
        {
            get
            {
                return legalText;
            }

            set
            {
                legalText = value;
            }
        }

        public string CollectorNumber
        {
            get
            {
                return collectorNumber;
            }

            set
            {
                collectorNumber = value;
            }
        }

        public bool IsTapped
        {
            get
            {
                return isTapped;
            }

            set
            {
                isTapped = value;
            }
        }

        public bool IsUntapping
        {
            get
            {
                return isUntapping;
            }

            set
            {
                isUntapping = value;
            }
        }

        public bool IsDestroyed
        {
            get
            {
                return isDestroyed;
            }

            set
            {
                isDestroyed = value;
            }
        }

        public bool IsExiled
        {
            get
            {
                return isExiled;
            }

            set
            {
                isExiled = value;
            }
        }

        internal Player Owner
        {
            get
            {
                return owner;
            }

            set
            {
                owner = value;
            }
        }

        internal Player Controller
        {
            get
            {
                return controller;
            }

            set
            {
                controller = value;
            }
        }

        public int NumLoyaltyCounters
        {
            get
            {
                return numLoyaltyCounters;
            }

            set
            {
                numLoyaltyCounters = value;
            }
        }

        public bool IsToken
        {
            get
            {
                return isToken;
            }

            set
            {
                isToken = value;
            }
        }

        public bool IsCopy
        {
            get
            {
                return isCopy;
            }

            set
            {
                isCopy = value;
            }
        }

        public bool IsMonocolor
        {
            get
            {
                return isMonocolor;
            }

            set
            {
                isMonocolor = value;
            }
        }

        public bool IsMulticolor
        {
            get
            {
                return isMulticolor;
            }

            set
            {
                isMulticolor = value;
            }
        }

        public bool IsColorless
        {
            get
            {
                return isColorless;
            }

            set
            {
                isColorless = value;
            }
        }

        public string FlavorText
        {
            get
            {
                return flavorText;
            }

            set
            {
                flavorText = value;
            }
        }

        public int ConvertedManaCost
        {
            get
            {
                return convertedManaCost;
            }

            set
            {
                convertedManaCost = value;
            }
        }
    }
}
