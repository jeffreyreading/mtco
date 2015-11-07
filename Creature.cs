using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_the_Cloning
{
    class Creature
    {
        private int basePower;      //Creature
        private int tempPower;      //Creature
        private int totPower;       //Creature
        private int baseToughness;  //Creautre
        private int tempToughness;  //Creature
        private int totToughness;   //Creature
        private bool isNewlyControlled; //Creature
        private bool isAttacking;       //Creature
        private bool isBlocking;        //Creature
        private bool isBlocked;     //Creature
        private int damagingObject; //Battleield ID of creature/player/PW to damage. Position in Battlefield List.
        private int damageMarked;       //Creature
        private int numPlusPlusCounters;        //Creature (tech. general, but corner case)
        private int numMinusMinusCounters;      //Creature

        public Creature()
        {
            basePower = xml.basePower;
            tempPower = 0;
            baseToughness = xml.baseToughness;
            tempToughness = 0;
            isNewlyControlled = false;
            isAttacking = false;
            isBlocking = false;
            isBlocked = false;
            damageMarked = 0;
            numPlusPlusCounters = 0;
            numMinusMinusCounters = 0;
        }

        public int BasePower
        {
            get
            {
                return basePower;
            }

            set
            {
                basePower = value;
            }
        }

        public int TempPower
        {
            get
            {
                return tempPower;
            }

            set
            {
                tempPower = value;
            }
        }

        public int TotPower
        {
            get
            {
                return totPower;
            }

            set
            {
                totPower = value;
            }
        }

        public int BaseToughness
        {
            get
            {
                return baseToughness;
            }

            set
            {
                baseToughness = value;
            }
        }

        public int TempToughness
        {
            get
            {
                return tempToughness;
            }

            set
            {
                tempToughness = value;
            }
        }

        public int TotToughness
        {
            get
            {
                return totToughness;
            }

            set
            {
                totToughness = value;
            }
        }

        public bool IsNewlyControlled
        {
            get
            {
                return isNewlyControlled;
            }

            set
            {
                isNewlyControlled = value;
            }
        }

        public bool IsAttacking
        {
            get
            {
                return isAttacking;
            }

            set
            {
                isAttacking = value;
            }
        }

        public bool IsBlocking
        {
            get
            {
                return isBlocking;
            }

            set
            {
                isBlocking = value;
            }
        }

        public bool IsBlocked
        {
            get
            {
                return isBlocked;
            }

            set
            {
                isBlocked = value;
            }
        }

        public int DamagingObject
        {
            get
            {
                return damagingObject;
            }

            set
            {
                damagingObject = value;
            }
        }

        public int DamageMarked
        {
            get
            {
                return damageMarked;
            }

            set
            {
                damageMarked = value;
            }
        }

        public int NumPlusPlusCounters
        {
            get
            {
                return numPlusPlusCounters;
            }

            set
            {
                numPlusPlusCounters = value;
            }
        }

        public int NumMinusMinusCounters
        {
            get
            {
                return numMinusMinusCounters;
            }

            set
            {
                numMinusMinusCounters = value;
            }
        }
    }
}
