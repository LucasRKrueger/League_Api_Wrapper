using League.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace League.API
{
    public class League_V4 : Key
    {
        public League_V4(string region) : base(region) { }

        public List<LeagueEntryDTO> GetRankByEncryptedSummonerId(string encryptedSummonerId)
        {
            string path = $"league/v4/entries/by-summoner/{encryptedSummonerId}";

            var response = Get(GetURI(path));

            string content = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<List<LeagueEntryDTO>>(content);
            else
                return null;
        }
    }
}
