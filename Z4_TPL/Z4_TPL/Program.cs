using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Z4_TPL
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            var google = new WebSite("http://google.pl", "/");
            var ath = new WebSite("https://www.ath.bielsko.pl/", "/");
            var wikipedia = new WebSite("https://pl.wikipedia.org", "/wiki/.Net_Core");
            var youtube = new WebSite("http://youtube.com", "/");

            var tasks = new List<Task<string>>();
            
            stopwatch.Start();
            tasks.Add(google.Download());
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Start();
            tasks.Add(ath.Download());
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Start();
            tasks.Add(wikipedia.Download());
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Start();
            tasks.Add(youtube.Download());
            Console.WriteLine(stopwatch.Elapsed);

            Console.WriteLine("-----------------");
            await Task.WhenAny(tasks);
            Console.WriteLine(stopwatch.Elapsed);
            var htmls =  await Task.WhenAll(tasks);
            Console.WriteLine(stopwatch.Elapsed);
            
            foreach (var html in htmls)
            {
                Console.WriteLine(html.Length);
            }
        }
    }
}
