using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_the_Cloning
{
    class GameActions
    {
        Battlefield field = new Battlefield();

        internal Battlefield Field
        {
            get
            {
                return field;
            }

            set
            {
                field = value;
            }
        }

        //For all game and state-based actions
        public int passPriority(int priorityPlayer)
        {
            bool isFailSBAs = true;
            while(isFailSBAs)
            {
                isFailSBAs = stateBasedActions();
            }
            return (priorityPlayer + 1) % 2;
        }

        public bool stateBasedActions()
        {
            bool isSBAtriggered = false;
            
            return isSBAtriggered;
        }


        public bool checkAttacks()
        {
            if(field.CardsInRedZone.Count == 0)
            {
                return false;
            }
            return true;
        }

        public bool checkFirstStrike()
        {
            bool firstStrikeCreature = false;
            foreach (var permanent in field.CardsInRedZone)
            {
                if (permanent.Effects.hasFirstStrike || permanent.Effects.hasDoubleStrike)
                {
                    firstStrikeCreature = true;
                }
            }
            return firstStrikeCreature;
        }

        public void firstStrikeDamage()
        {
            foreach(var permanent in field.CardsInRedZone)
            {
                if(permanent.Effects.hasFirstStrike || permanent.Effects.hasDoubleStrike)
                {
                    //Recipient (player/PW/creature).damageMarked = that.damageMarked + this.totPower
                }
            }
        }

        public void combatDamage()
        {
            foreach (var permanent in field.CardsInRedZone)
            {
                if(!permanent.Effects.hasFirstStrike || permanent.Effects.hasDoubleStrike)
                {
                    //Clone code from 1stStrikeDmg.
                }
            }
        }
        public void clearDamage()
        {
            foreach (var permanent in field.CardsOnField)
            {
                permanent.DamageMarked = 0;
            }
        }

        public bool timeEffects(string condition1, string condition2)
        {
            bool notTrigger = true;
            foreach (var permanent in field.CardsOnField)
            {
                if (permanent.Textbox.Contains(condition1) || permanent.Textbox.Contains(condition2))
                {
                    //Put copy of effect on stack.
                    notTrigger = false;
                }
                //Check for "Until end of turn" or "This turn" effects expiring.
            }
            return notTrigger;
        }
    }
}
