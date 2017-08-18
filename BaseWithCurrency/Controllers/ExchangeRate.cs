using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BaseInternational.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;
using System.Net.Http;
using Newtonsoft.Json;

namespace BaseInternational.Controllers
{
    public class ExchangeRate
    {
        private const string BaseUri = "http://api.fixer.io/latest?symbols=USD";

        public double ConvertToUSD(double amount)
        {
            var rate = GetRate();

            return amount * rate.Rates.USD;
        }

        public double ConvertToEUR(double amount)
        {
            var rate = GetRate();

            return amount / rate.Rates.USD;
        }

        private Rate GetRate ()
        {
             using (var client = new HttpClient())
            {
                string url = "http://api.fixer.io/latest?symbols=USD";

                Task<string> ratestring = GetRateAsync (client, url);
                ratestring.Wait ();
                var rateObj = JsonConvert.DeserializeObject<Rate> (ratestring.Result);

                return rateObj;
            }
        }

        private async static Task<String> GetRateAsync (HttpClient client, string url) {
            String rate = null;
            HttpResponseMessage response = await client.GetAsync (url);
            if (response.IsSuccessStatusCode) {
                rate = await response.Content.ReadAsStringAsync ();
            }
            return rate;
        }

    }

    public class Rate
    {
        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("rates")]
        public Rates Rates { get; set; }
    }

    public class Rates
    {

        [JsonProperty("USD")]
        public double USD { get; set; }
    }
}