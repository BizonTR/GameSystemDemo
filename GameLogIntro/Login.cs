using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogIntro
{
    public class Login : ILogin
    {
        PlayerManager _playerManager;
        public Login(PlayerManager playerManager)
        {
            _playerManager=playerManager;
        }
        PlayerList playerList = new PlayerList();
        public void Check(string nickname, string password)
        {
            foreach (Player item in _playerManager.GetList())
            {
                if (item.nickname == nickname)
                {
                    if (item.password == password)
                    {
                        Console.WriteLine("Logged in completely. Welcome " + $"{nickname}!");
                        break;
                    }
                }
            }
        }
    }
}
