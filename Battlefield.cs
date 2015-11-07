using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_the_Cloning
{
    class Battlefield
    {
        //Mostly GUI work.
        private List<Card> cardsOnField;
        private List<Card> cardsInRedZone;  //Area for attacking/blocking cards.

        internal List<Card> CardsOnField
        {
            get
            {
                return cardsOnField;
            }

            set
            {
                cardsOnField = value;
            }
        }

        internal List<Card> CardsInRedZone
        {
            get
            {
                return cardsInRedZone;
            }

            set
            {
                cardsInRedZone = value;
            }
        }
    }
}
