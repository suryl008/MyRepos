using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace apiConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var httpClient = new HttpClient())
            {
                //  httpClient.BaseAddress = @"http://localhost:1992/api/Crowe/GetHeartbeat"
                var results = httpClient.GetStringAsync("http://localhost:1992/api/Crowe/GetHeartbeat").Result;
                Console.WriteLine(results);
                Console.Read();
            }
        }
    }
}
