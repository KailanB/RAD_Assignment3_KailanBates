using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Assignment3TradingCards_KailanBates
{
    internal class PlayerData
    {

        public static BindingList<Player> GetPlayers()
        {

            BindingList<Player> players = new BindingList<Player>();
            //List<Player> players = new List<Player>();


            Player player = new Player
            {
                Id = 1,
                Name = "Tiny Teen",
                Team = "Home",
                TeamColor = "Black"
            };
            players.Add(player);


            player = new Player
            {
                Id = 2,
                Name = "ScramBiss",
                Team = "Away",
                TeamColor = "Orange"
            };
            players.Add(player);


            player = new Player
            {
                Id = 3,
                Name = "Fluff Bucket",
                Team = "Kebabs",
                TeamColor = "Purple"
            };
            players.Add(player);



            return players;


        }


    }
}
