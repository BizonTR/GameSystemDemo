using System;
using System.Collections.Generic;

namespace GameLogIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager();
            PlayerList playerList = new PlayerList();
            Login login = new Login(playerManager);
            
            Player player1 = new Player();
            player1.nickname = "BizonTR";
            player1.password = "12345";
            playerManager.PlayerAdd(player1);

            Player player2 = new Player();
            player2.nickname = "Rukawa";
            player2.password = "abcde";
            playerManager.PlayerAdd(player2);

            Player player3 = new Player();
            player3.nickname = "qwe";
            player3.password = "abcdef";
            playerManager.PlayerAdd(player3);

            playerManager.PlayerUpdate(player2, "abcdefg", "98446");

            playerManager.PlayerRemove(player2);

            playerManager.PlayerList();

            login.Check("BizonTR", "12345");

            Games game1 = new Games() { GameName = "Valorant", GamePrice = 0 };
            Games game2 = new Games() { GameName = "Human Fall Flat", GamePrice = 12.99 };
            Games game3 = new Games() { GameName = "Counter Strike: Global Offensive", GamePrice = 16 };
            Games game4 = new Games() { GameName = "Lost Ark", GamePrice = 0 };
            Games game5 = new Games() { GameName = "Stick Fight The Game", GamePrice = 4.99 };

            GameList gameList = new GameList() { };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign("Summer Sale", game3, 10);

            GameManager gameManager = new GameManager(gameList);
            gameManager.AddGame(game1);
            gameManager.AddGame(game2);
            gameManager.AddGame(game3);
            gameManager.AddGame(game4);
            gameManager.AddGame(game5);

            gameManager.GamesWrite();

            BuyManager buyManager = new BuyManager();
            buyManager.Buy(game3, player1);
        }
    }
}
