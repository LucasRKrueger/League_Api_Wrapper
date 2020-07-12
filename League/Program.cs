using League.Controller;
using System;

namespace League
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert your region");
            string region = Console.ReadLine();

            Console.WriteLine("insert your SummonerName");
            string summonerName = Console.ReadLine();

            Main main = new Main();
            var summoner = main.GetSummoner(region, summonerName);

            Console.WriteLine($"Your level is: {summoner.SummonerLevel}");
        }
    }
}
