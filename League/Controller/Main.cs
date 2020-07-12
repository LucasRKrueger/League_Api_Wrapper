using League.API;
using League.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace League.Controller
{
    public class Main
    {
        private static SummonerDTO GetSummonerModel(string region, string summonerName)
        {
            var summoner_V4 = new Summoner_V4(region);

            return summoner_V4.GetSummonerByName(summonerName);            
        }

        public SummonerDTO GetSummoner(string region, string summonerName)
        {
            if (!string.IsNullOrEmpty(region) && !string.IsNullOrEmpty(summonerName))
                return GetSummonerModel(region, summonerName);    
            
            return null;
        }
    }
}
