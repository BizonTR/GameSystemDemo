using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogIntro
{
    internal class BuyManager : IBuyGame
    {
        public void Buy(Games game, Player player)
        {
            Console.WriteLine($"'{game.GameName}' added to player account who nicknamed {player.nickname}. Game cost is {game.GamePrice} TL");
        }
    }
}
