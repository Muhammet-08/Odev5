using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class GameManager : IGame
    {
        public void DeleteGame(Game game)
        {
            Console.WriteLine(game.GameName+" Oyun silindi!");
        }

        public void GameAdd(Game game)
        {
            Console.WriteLine(game.GameName + " Oyun eklendi!");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine(game.GameName + " Oyun güncellendi!");
        }
    }
}
