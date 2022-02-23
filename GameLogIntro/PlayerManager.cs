using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogIntro
{
    public class PlayerManager
    {
        PlayerList playerList = new PlayerList();
        //public List<Player> players = new List<Player>() { };
        public void PlayerAdd(Player player)
        {
            playerList.players.Add(player);
        }
        public void PlayerList()
        {
            int i = 1;
            foreach (var item in playerList.players)
            {
                Console.WriteLine(i.ToString()+ "- " + item.nickname);
                i += 1;
            }
        }
        public void PlayerUpdate(Player player,string nickname, string password)
        {
            player.nickname = nickname;
            player.password = password;
        }
        public void PlayerRemove(Player player)
        {
            playerList.players.Remove(player);
        }
        public List<Player> GetList()
        {
            return playerList.players;
        }
    }
}
