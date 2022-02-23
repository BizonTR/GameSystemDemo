using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogIntro
{
    public class GameList
    {
        public List<Games> gamesList = new List<Games>() { };

        public List<Games> GetList()
        {
            return gamesList;
        }
    }
}
