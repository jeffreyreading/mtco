using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_the_Cloning
{
    class Graveyard
    {
        private List<Card> cardsInGrave;

        internal List<Card> CardsInGrave
        {
            get
            {
                return cardsInGrave;
            }

            set
            {
                cardsInGrave = value;
            }
        }
    }
}
