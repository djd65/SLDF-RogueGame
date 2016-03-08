using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueGame
{
    public class Game
    {
        public enum GameState
        {
            PlayerTurn,
            BossTurn,
            EnemyTurn,
            OtherTurn,
        }


        int OverallState;

        public Game()
        {
        }

        public bool IsDone
        {
            get;
            internal set;
        }

        public void Loop()
        {
            Player player = new Player();
            GameMap map = new GameMap();

            for (;;)
            {
                OverallState = (int)GameState.PlayerTurn;
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    Console.Write(key);
                    player.Update(key.KeyChar);

                }
                OverallState = (int)GameState.BossTurn;
                //execute boss logic
                OverallState = (int)GameState.EnemyTurn;
                //enemy turn logic
                OverallState = (int)GameState.OtherTurn;
                //other npc/item logic
            }
        }
    }
}