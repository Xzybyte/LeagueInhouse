using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueInhouse
{
    internal class Summoner
    {

        private string id;
        private string name;
        private string tier;
        private string rank;
        private int weight;
        private RiotSharp.Misc.Region region;

        public Summoner(string id, string name, string tier, string rank, RiotSharp.Misc.Region region, int weight)
        {
            this.id = id;
            this.name = name;
            this.tier = tier;
            this.rank = rank;
            this.region = region;
            this.weight = weight;
        }

        public string GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public string GetTier()
        {
            return tier;
        }

        public void SetTier(string t)
        {
            tier = t;
        }

        public string GetRank()
        {
            return rank;
        }

        public void SetRank(string r)
        {
            tier = r;
        }

        public RiotSharp.Misc.Region GetRegion()
        {
            return region;
        }

        public int GetWeight()
        {
            return weight;
        }


    }
}
