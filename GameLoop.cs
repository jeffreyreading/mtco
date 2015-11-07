using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_the_Cloning
{
    class GameLoop
    {
        GameActions actionChecker = new GameActions();
        MStack theStack = new MStack();
        Player player1 = new Player();
        Player player2 = new Player();
        int activePlayer;
        int priorityPlayer;
        bool noTriggers = false;
        bool movePhase = false;
        bool endGame = false;

        Player[] playerArr = { player1, player2 };

        public bool changePhase()
        {
            movePhase = false;
            while (!movePhase)  //Make movePhase(). Put in GameActions?
            {
                foreach (var player in playerArr)
                {
                    player.IsPassingPriority = false;
                }

                priorityPlayer = actionChecker.passPriority(priorityPlayer);
                if (playerArr[0].IsPassingPriority && playerArr[1].IsPassingPriority)
                {
                    if (theStack.empty())
                    {
                        movePhase = true;
                    }
                    else
                    {
                        theStack.resolveObject();
                    }
                }
            }
            return movePhase;
        }

        public bool endGame()
        {
            bool endGame = false;
            foreach (var player in playerArr)
            {
                if (player.LoseGame || player.Life <= 0)
                {
                    player.LoseGame = true;
                    endGame = true;
                }
            }

            if (playerArr[activePlayer].LoseGame && playerArr[(activePlayer + 1) % 2].LoseGame)
            {
                endGame = true;
            }

            return endGame;
        }
        public void PreGame()
        {
            //Set up players (Life, Library, Grave, Exile, Mana Pool, Hand)
            foreach (var player in playerArr)
            {
                player.Deck = libFile;
                player.Life = 20;
                player.Graveyard = new Graveyard();
                player.Exile = new Exile();
                player.ManaPool = new List<Mana>();
                player.Revealed = new List<Card>();
                player.IsActivePlayer = false;
                player.HasPriority = false;
                player.HasPlayedLand = false;
            }
            //Shuffle all libraries
            foreach (var player in playerArr)
            {
                player.Deck.shuffle();
            }

            //Determine first player
            Random rnd = new Random();
            bool rollDie = true;
            while (rollDie)
            {
                foreach (var player in playerArr)
                {
                    player.Roll = rnd.Next(1, 20);
                }
                if (playerArr[0].Roll > playerArr[1].Roll)
                {
                    playerArr[0].IsActivePlayer = true;
                    activePlayer = 0;
                    priorityPlayer = 0;
                    rollDie = false;
                }
                else if (playerArr[1].Roll > playerArr[0].Roll)
                {
                    playerArr[1].IsActivePlayer = true;
                    activePlayer = 1;
                    priorityPlayer = 1;
                    rollDie = false;
                }
            }
            //Set life to starting values
            foreach (var player in playerArr)
            {
                player.Life = 20;
            }
            //Draw opening hands, mulligan (Vancouver)
            foreach (var player in playerArr)
            {
                for (int i = 0; i < player.Hand.MaxSize; i++)
                {
                    player.draw();
                }
            }
            bool noMull = false;
            while (!noMull)
            {
                //Prompt if player wants to mulligan.
                playerArr[priorityPlayer].IsMulliganing = /*event result*/;
                if (playerArr[priorityPlayer].IsMulliganing)
                {
                    //Mulligan.
                    priorityPlayer = actionChecker.passPriority(priorityPlayer);
                }
                else
                {
                    priorityPlayer = actionChecker.passPriority(priorityPlayer);
                }
                if (!playerArr[0].IsMulliganing && !playerArr[1].IsMulliganing)
                {
                    noMull = true;
                }
            }
        }
        
       
        public void Untap()
        {
            foreach (var permanent in actionChecker.Field.CardsOnField)
            {
                if (permanent.Owner == playerArr[activePlayer] && permanent.IsUntapping)
                {
                    permanent.IsTapped = false;
                }
            }
        }

        public void Upkeep()
        {
            while (!movePhase)
            {
                noTriggers = false;
                while (!noTriggers)
                {
                    noTriggers = actionChecker.timeEffects("upkeep", "untaps");
                }
                movePhase = changePhase();
            }
        }

        public void Draw()
        {
            movePhase = false;
            while (!movePhase)
            {
                noTriggers = false;
                playerArr[activePlayer].draw(); //Put drawTrigger check in Player.draw
                movePhase = changePhase();
            }
        }

        public void PrecombatMain()
        {
            movePhase = false;
            while (!movePhase)
            {
                movePhase = changePhase()
            }
        }

        public void BeginCombat()
        {
            movePhase = false;
            while (!movePhase)
            {
                movePhase = changePhase();
            }
        }

        public bool DeclareAttacks()
        {
            movePhase = false;
            playerArr[activePlayer].declareAtk();
            if (actionChecker.checkAttacks())
            {
                while (!movePhase)
                {
                    movePhase = changePhase();
                }
                return true;
            }
            return false;
        }

        public void DeclareBlocks()
        {
            movePhase = false;
            playerArr[(activePlayer + 1) % 2].declareBlocks();
            while (!movePhase)
            {
                movePhase = changePhase();
            }
        }

        public void CombatDamage()
        {
            movePhase = false;
            actionChecker.checkFirstStrike();
            if (actionChecker.checkFirstStrike())
            {
                actionChecker.firstStrikeDamage();
                actionChecker.stateBasedActions();
                actionChecker.timeEffects("dies", "leaves the battlefield");
                while (!movePhase)
                {
                    movePhase = changePhase();
                }
            }
            actionChecker.regularDmg();
            movePhase = true;
        }

        public void EndCombat()
        {
            movePhase = false;
            actionChecker.stateBasedActions();  //while fails?
            actionChecker.timeEffects("dies", "leaves the battlefield");    //Here?
            while (!movePhase)
            {
                movePhase = changePhase();
            }
        }

        public void PostcombatMain()
        {
            movePhase = false;
            while (!movePhase)
            {
                changePhase();
            }
        }

        public void EndStep()
        {
            movePhase = false;
            actionChecker.timeEffects("beginning of the end step", "beginning of the next end step");
            while (!movePhase)
            {
                movePhase = changePhase();
            }
        }

        public void Cleanup()
        {
            while (playerArr[activePlayer].Hand.HandCards.Count > playerArr[activePlayer].Hand.MaxSize)
            {
                //Discard
            }
            noTriggers = false;
            //Cleanup steps
            actionChecker.clearDamage();
            while (!noTriggers)
            {
                noTriggers = actionChecker.timeEffects("Until end of turn", "This turn");
            }

        }
    }
}
