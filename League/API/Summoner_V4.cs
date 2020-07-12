using League.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace League.API
{
    public class Summoner_V4 : Key
    {
        public Summoner_V4(string region): base(region)
        {

        }

        public SummonerDTO GetSummonerByName(string summonerName)
        {
            string path =  $"summoner/v4/summoners/by-name/{summonerName}";
            var response = Get(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<SummonerDTO>(content);
            else
                return null;
        }
    }
}
