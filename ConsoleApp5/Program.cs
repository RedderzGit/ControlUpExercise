using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;

namespace ControlUp
{
    public class Cruise
    {
        [JsonProperty("seoName")]
        public string ShipName { get; set; }

        [JsonProperty("crew")]
        public int Crew { get; set; }
    }

    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                var endpoint = new Uri("https://tripadvisor16.p.rapidapi.com/api/v1/cruises/searchCruises?destinationId=147237&order=popularity");

                // Add the API key and Value
                client.DefaultRequestHeaders.Add("x-rapidapi-key", "609d9bed1bmsh424781362865668p128838jsn95074634995e");
                client.DefaultRequestHeaders.Add("x-rapidapi-host", "tripadvisor16.p.rapidapi.com");

                var response = await client.GetAsync(endpoint);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();

                // Deserialize JSON
                var cruises = JsonConvert.DeserializeObject<List<Cruise>>(json);

                // Order the list by crew
                var orderedCruises = cruises.OrderByDescending(c => c.Crew).ToList();

                // Print the results
                foreach (var cruise in orderedCruises)
                {
                    Console.WriteLine($"Ship Name: {cruise.ShipName}, Crew Size: {cruise.Crew}");
                }
            }
        }
    }
}
