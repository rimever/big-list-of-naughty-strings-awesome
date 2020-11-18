using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace NaughtyRequest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            foreach (var text in File.ReadLines("blns.txt"))
            {
                HttpClient httpClient = new HttpClient();
                string url = $"https://www.google.com/search?q={text}";
                var httpResponseMessage = await httpClient.GetAsync(url);
                Console.WriteLine(httpResponseMessage.StatusCode);
            }
        }
    }
}