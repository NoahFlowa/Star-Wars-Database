using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using System.Threading;

namespace Winforms_Dataviewer
{
    public static class GetJsonFiles
    {
        /// <summary>
        /// Method gets random number for the end of the request url
        /// </summary>
        /// <returns></returns>
        public static int GetRandNum()
        {
            Random rand = new Random();
            int cycle = rand.Next(1,81);

            return cycle;
        }

        /// <summary>
        /// Method requests API to get a person
        /// </summary>
        /// <returns></returns>
        public static async Task <StarWarsPeople> GetPeopleFile()
        {
            string url;

            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.Append("https://swapi.co/api/people/");
            sb.Append($"{GetRandNum().ToString()}");

            url = sb.ToString();

            StarWarsPeople starWarsPeople = new StarWarsPeople();

            Task<StarWarsPeople> getSWPeople = HttpGetCurrentPerson(url);

            getSWPeople.Wait();

            starWarsPeople = await getSWPeople;

            return starWarsPeople;
        }

        /// <summary>
        /// Method requests the Server with the URL and returns the persons file
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static async Task<StarWarsPeople> HttpGetCurrentPerson(string url)
        {
            string result = null;

            using (HttpClient syncClient = new HttpClient())
            {
                var response = await syncClient.GetAsync(url);
                result = await response.Content.ReadAsStringAsync();
            }

            StarWarsPeople starWarsPeople = JsonConvert.DeserializeObject<StarWarsPeople>(result);

            return starWarsPeople;
        }


    }
}
