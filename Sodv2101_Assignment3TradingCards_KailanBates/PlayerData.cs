using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Sodv2101_Assignment3TradingCards_KailanBates
{
    internal class PlayerData
    {

        public static BindingList<Player> GetPlayers()
        {

            BindingList<Player> players = new BindingList<Player>();
			//List<Player> players = new List<Player>();






			// utilized chat GPT to help create sample data for this section
			// ALL Images courtesy of getty images
			players.Add(new Player
			{
				Id = 1,
				Name = "Fred Warner",
				Team = "San Francisco 49ers",
				Interceptions = 2,
				PassesDefended = 6,
				TotalTackles = 132,
				SoloTackles = 46,
				TeamColorR = 184,  // Gold
				TeamColorG = 49,
				TeamColorB = 47,    // Red
				// https://www.gettyimages.ca/search/2/image?phrase=fred+warner
				Image = "..\\..\\..\\images\\FredWarner.jpg"
			});

			players.Add(new Player
			{
				Id = 2,
				Name = "Roquan Smith",
				Team = "Baltimore Ravens",
				Interceptions = 1,
				PassesDefended = 3,
				TotalTackles = 110,
				SoloTackles = 44,
				TeamColorR = 26,   // Purple
				TeamColorG = 13,
				TeamColorB = 171,
				// https://www.gettyimages.ca/search/2/image?phrase=roquan+smith
				Image = "..\\..\\..\\images\\RoquanSmith.jpg"
			});

			players.Add(new Player
			{
				Id = 3,
				Name = "Zaire Franklin",
				Team = "Indianapolis Colts",
				Interceptions = 1,
				PassesDefended = 3,
				TotalTackles = 110,
				SoloTackles = 53,
				TeamColorR = 0,    // Blue
				TeamColorG = 85,
				TeamColorB = 184,
				// https://www.gettyimages.ca/search/2/image?phrase=zaire+franklin
				Image = "..\\..\\..\\images\\ZaireFranklin.jpg"
			});

			players.Add(new Player
			{
				Id = 4,
				Name = "Logan Wilson",
				Team = "Cincinnati Bengals",
				Interceptions = 1,
				PassesDefended = 3,
				TotalTackles = 104,
				SoloTackles = 50,
				TeamColorR = 247,  // Orange
				TeamColorG = 78,
				TeamColorB = 32,
				// https://www.gettyimages.ca/search/2/image?phrase=logan%20wilson%20bengals&sort=mostpopular&license=rf%2Crm
				Image = "..\\..\\..\\images\\LoganWilson.jpg"
			});

			players.Add(new Player
			{
				Id = 5,
				Name = "Zack Baun",
				Team = "Philadelphia Eagles",
				Interceptions = 1,
				PassesDefended = 2,
				TotalTackles = 101,
				SoloTackles = 55,
				TeamColorR = 0,    // Midnight green
				TeamColorG = 76,
				TeamColorB = 84,
				// https://www.gettyimages.ca/search/2/image?phrase=zack+baun
				Image = "..\\..\\..\\images\\ZackBaun.jpg"
			});

			players.Add(new Player
			{
				Id = 6,
				Name = "Nick Cross",
				Team = "Indianapolis Colts",
				Interceptions = 1,
				PassesDefended = 3,
				TotalTackles = 102,
				SoloTackles = 50,
				TeamColorR = 0,    // Blue
				TeamColorG = 85,
				TeamColorB = 184,
				// https://www.gettyimages.ca/search/2/image?phrase=nick+cross
				Image = "..\\..\\..\\images\\NickCross.jpg"
			});

			players.Add(new Player
			{
				Id = 7,
				Name = "Bobby Wagner",
				Team = "Washington Commanders",
				Interceptions = 2,
				PassesDefended = 2,
				TotalTackles = 91,
				SoloTackles = 40,
				TeamColorR = 63,   // Burgundy
				TeamColorG = 16,
				TeamColorB = 16,
				// https://www.gettyimages.ca/search/2/image?phrase=bobby+wagner
				Image = "..\\..\\..\\images\\BobbyWagner.jpg"
			});

			players.Add(new Player
			{
				Id = 8,
				Name = "Patrick Queen",
				Team = "Pittsburgh Steelers",
				Interceptions = 1,
				PassesDefended = 2,
				TotalTackles = 97,
				SoloTackles = 38,
				TeamColorR = 255,  //  yellow
				TeamColorG = 223,
				TeamColorB = 0,
				// https://www.gettyimages.ca/search/2/image?phrase=patrick+queen
				Image = "..\\..\\..\\images\\PatrickQueen.jpg"
			});

			players.Add(new Player
			{
				Id = 9,
				Name = "Demario Davis",
				Team = "New Orleans Saints",
				Interceptions = 1,
				PassesDefended = 1,
				TotalTackles = 79,
				SoloTackles = 44,
				TeamColorR = 211,  // Gold
				TeamColorG = 178,
				TeamColorB = 123,
				// https://www.gettyimages.ca/search/2/image?phrase=demario+davis
				Image = "..\\..\\..\\images\\DemarioDavis.jpg"
			});

			players.Add(new Player
			{
				Id = 10,
				Name = "Devin Lloyd",
				Team = "Jacksonville Jaguars",
				Interceptions = 1,
				PassesDefended = 1,
				TotalTackles = 79,
				SoloTackles = 35,
				TeamColorR = 0,    // Teal
				TeamColorG = 122,
				TeamColorB = 122,
				// https://www.gettyimages.ca/search/2/image?phrase=devin+lloyd
				Image = "..\\..\\..\\images\\DevinLloyd.jpg"
			});












			//         player = new Player
			//         {
			//             Id = 2,
			//             Name = "ScramBiss",
			//             Team = "Away",
			//	TeamColorR = 0,
			//	TeamColorG = 150,
			//	TeamColorB = 75
			//};
			//         players.Add(player);


			//         player = new Player
			//         {
			//             Id = 3,
			//             Name = "Fluff Bucket",
			//             Team = "Kebabs",
			//	TeamColorR = 150,
			//	TeamColorG = 0,
			//	TeamColorB = 150
			//};
			//         players.Add(player);



			return players;


        }


    }
}
