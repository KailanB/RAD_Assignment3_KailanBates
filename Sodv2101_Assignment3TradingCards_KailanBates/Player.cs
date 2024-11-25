using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Assignment3TradingCards_KailanBates
{
    internal class Player
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public string TeamColor { get; set; }


        public override bool Equals(object? obj)
        {
            if (obj is Player other)
            {
                return Id == other.Id &&
                       Name == other.Name &&
                       Team == other.Team &&
                       TeamColor == other.TeamColor;

            }
            return false;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Team, TeamColor);
        }

    }
}
