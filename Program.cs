using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_the_Cloning
{
    class Program
    {
        static void Main(string[] args)
        {
            GameLoop loop = new GameLoop();
            loop.PreGame();

            //AP's permanents all untap (if able)
            //Upkeep
                //Beginning of upkeep/turn abilities resolve.
                //Priority passes.
            //Draw
                //AP draws top card of library. Priority passes.
            //Precombat Main
                //AP may play lands, creatures, sorceries. Priority passes.
            //Combat
            //Beg. Combat
                //Priority passes
            //Declare attacks
                //AP declares attacking monsters. If none declared, proceed to MP2.
                //Priority passes
            //Declare blocks
                //Defending player(s) declare blocks.
                //Priority passes
            //Combat Damage
                //Creatures assign damage equal to total power to player/planeswalker or blocking creature.
                //1st strike, priority (if 1st strike happens), normal damage.
            //End of Combat
                //Priority passes
            //Postcombat Main
                //AP may play lands, creature, sorceries. Priority passes.
            //End Phase
            //End Step
                //Priority passes
            //Cleanup Step
                //AP discards to max hand size.
                //"End of turn" effects resolve.
            //End game triggers
            //Concession (Conceding player immediately loses).
            //A player's life <= 0 (That player loses).
            //A player draws when lib.size == 0 (That player loses).
        }
    }
}
