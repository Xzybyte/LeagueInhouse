using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiotSharp;
using RiotSharp.Endpoints.LeagueEndpoint;

namespace LeagueInhouse
{
    internal class LeagueInformation
    {

        public static string GetRank(RiotSharp.Misc.Region region, string id, RiotApi api)
        {
            var position = api.League.GetLeagueEntriesBySummonerAsync(region, id).Result;
            var posEnumerator = position.GetEnumerator();
            string rank = null;
            while (posEnumerator.MoveNext())
            {
                rank = posEnumerator.Current.Rank;
            }
            return rank;
        }

        public static string GetTier(RiotSharp.Misc.Region region, string id, RiotApi api)
        {
            var position = api.League.GetLeagueEntriesBySummonerAsync(region, id).Result;
            var posEnumerator = position.GetEnumerator();
            string tier = "UNRANKED";
            while (posEnumerator.MoveNext())
            {
                tier = posEnumerator.Current.Tier;
            }
            return tier;
        }

        public static string GetMostPlayedChampion(RiotSharp.Misc.Region region, string id, RiotApi api)
        {
            var champs = api.ChampionMastery.GetChampionMasteriesAsync(region, id).Result;

            var allVersion = api.DataDragon.Versions.GetAllAsync().Result;
            var latestVersion = allVersion[0];

            string champName = null;

            for (var i = 0; i < 1; i++)
            {
                var champId = champs[i].ChampionId;
                champName = api.DataDragon.Champions.GetAllAsync(latestVersion).Result.Champions.Values.Single(x => x.Id == champId).Name;
            }


            return champName;
        }

        public static int CalculateWeight(string rank, string tier)
        {
            string[] ranks = {"IRON I", "IRON II", "IRON III", "IRON IV", "BRONZE I", "BRONZE II", "BRONZE III", "BRONZE IV",
            "SILVER I", "SILVER II", "SILVER III", "SILVER IV", "GOLD I", "GOLD II", "GOLD III", "GOLD IV",
            "PLATINUM I", "PLATINUM II", "PLATINUM III", "PLATINUM IV", "DIAMOND I", "DIAMOND II", "DIAMOND III", "DIAMOND IV",
            "MASTER I", "GRANDMASTER I", "CHALLENGER I"};
            int[] points = {0, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000, 1100, 1200, 1300, 1400, 1500, 1600, 1700, 1800, 1900,
            2000, 2100, 2200, 2300, 2400, 2500, 2600};

            int weight = 0;

            for (int i = 0; i < ranks.Length; i++)
            {
                if (ranks[i] == tier + " " + rank)
                {
                    weight = points[i];
                }
            }
            return weight;

    }


    }
}
