using League.API;
using League.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace League.Controller
{
    public class Main
    {
        public SummonerDTO GetSummoner(string region, string summonerName)
        {
            if (!string.IsNullOrEmpty(region) && !string.IsNullOrEmpty(summonerName))
            {
                var summoner_V4 = new Summoner_V4(region);

                return summoner_V4.GetSummonerByName(summonerName);
            }            
            return null;
        }

        public List<LeagueEntryDTO> GetSummonerRankStuffs(string region, string encryptedSummonerId)
        {
            if (!string.IsNullOrEmpty(encryptedSummonerId))
            {
                var league_V4 = new League_V4(region);
                return league_V4.GetRankByEncryptedSummonerId(encryptedSummonerId);
            }
            return null;
        }

    }
}
