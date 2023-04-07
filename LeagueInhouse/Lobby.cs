using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueInhouse
{
    internal class Lobby
    {

        private List<Summoner> summoners = new List<Summoner>();
        private List<Summoner> teamOne = new List<Summoner>();
        private List<Summoner> teamTwo = new List<Summoner>();

        public void AddSummoner(Summoner summoner)
        {
            summoners.Add(summoner);
        }

        public List<Summoner> GetSummoners()
        {
            return summoners;
        }

        public void AddTeamOne(Summoner summoner)
        {
            teamOne.Add(summoner);
        }

        public List<Summoner> GetTeamOne()
        {
            return teamOne;
        }

        public List<Summoner> GetTeamTwo()
        {
            return teamTwo;
        }

        public void AddTeamTwo(Summoner summoner)
        {
            teamTwo.Add(summoner);
        }

        public int LobbySize()
        {
            return summoners.Count;
        }

    }
}
