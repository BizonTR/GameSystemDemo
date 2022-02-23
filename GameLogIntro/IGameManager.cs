using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogIntro
{
    internal interface IGameManager
    {
        public void AddGame(Games game);
        public void RemoveGame(Games game);
        public void GamesWrite();
    }
}
