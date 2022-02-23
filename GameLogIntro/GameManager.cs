using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogIntro
{
    public class GameManager : IGameManager
    {
        GameList _gameList;
        public GameManager(GameList gameList)
        {
            _gameList = gameList;
        }
        public void AddGame(Games game)
        {
            _gameList.GetList().Add(game);
        }

        public void RemoveGame(Games game)
        {
            _gameList.GetList().Remove(game);
        }
        public void GamesWrite()
        {
            for (int i = 0; i < _gameList.GetList().Count; i++)
            {
                Console.WriteLine("Game Name: " + _gameList.GetList()[i].GameName + " - " + "Game Price: " + _gameList.GetList()[i].GamePrice.ToString() + "TL");
            }
        }
    }
}
