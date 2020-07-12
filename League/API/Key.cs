using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.Http;

namespace League.API
{
    public class Key
    {
        private string _Key { get; set; }
        private string _Region { get; set; }

        public Key(string region)
        {
            _Region = region;
            _Key = GetKey("Key.txt");
        }

        protected HttpResponseMessage Get(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(url);
                result.Wait();
                return result.Result;
            }
        }

        protected string GetURI(string path)
        {
            return $"https://{_Region}.api.riotgames.com/lol/{path}?api_key={_Key}";
        }

        public string GetKey(string path)
        {
            StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
        }
    }
}
