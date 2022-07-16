using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    interface IGame
    {
        public void GameAdd(Game game);
        public void DeleteGame(Game game);
        public void UpdateGame(Game game);
    }
}
