using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace Geolocation {
    public class Startup {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices (IServiceCollection services) {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor> ();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env, IHttpContextAccessor contextAccessor) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }

            app.Run (async (context) => {
                await context.Response.WriteAsync (BuildResponse (contextAccessor));
            });
        }

        private string BuildResponse (IHttpContextAccessor contextAccessor) {
            String UserIP = contextAccessor.HttpContext.Connection.LocalIpAddress.ToString ();
            if (string.IsNullOrEmpty (UserIP)) {
                UserIP = contextAccessor.HttpContext.Features.Get<IHttpConnectionFeature>()?.RemoteIpAddress?.ToString();
            }
            if (String.Compare(UserIP, "::1") == 0) {
                UserIP = "216.84.189.6";
            }
            string url = "http://freegeoip.net/json/" + UserIP;
            HttpClient client = new HttpClient ();
            Task<string> jsonstring = GetGeoAsync (client, url);
            jsonstring.Wait ();
            var dynObj = JsonConvert.DeserializeObject<GeoIP> (jsonstring.Result);

            return "<html><body>" +
                "<table border=\"1\" cellpadding=\"5\" style=\"border-collapse:collapse;\">" +
                $"<tr><td>IP</td><td>{dynObj.ip}</td></tr>" +
                $"<tr><td>Country</td><td>{dynObj.country_name}</td></tr>" +
                $"<tr><td>Region</td><td>{dynObj.region_name}</td></tr>" +
                $"<tr><td>Timezone</td><td>{dynObj.time_zone}</td></tr>" +
                $"<tr><td>Laitude</td><td>{dynObj.latitude}</td></tr>" +
                $"<tr><td>Longitude</td><td>{dynObj.longitude}</td></tr>" +
                "</table></body></html>";
        }
        private async Task<String> GetGeoAsync (HttpClient client, string url) {
            String geolocation = null;
            HttpResponseMessage response = await client.GetAsync (url);
            if (response.IsSuccessStatusCode) {
                geolocation = await response.Content.ReadAsStringAsync ();
            }
            return geolocation;
        }

        private class GeoIP {
            [JsonProperty("ip")]
            public string ip { get; private set; }

            [JsonProperty("country_code")]
            public string country_code { get; private set; }

            [JsonProperty("country_name")]
            public string country_name { get; private set; }

            [JsonProperty("region_code")]
            public string region_code { get; private set; }

            [JsonProperty("region_name")]
            public string region_name { get; private set; }

            [JsonProperty("city")]
            public string city { get; private set; }

            [JsonProperty("zip_code")]
            public string zip_code { get; private set; }

            [JsonProperty("time_zone")]
            public string time_zone { get; private set; }

            [JsonProperty("latitude")]
            public string latitude { get; private set; }

            [JsonProperty("longitude")]
            public string longitude { get; private set; }

            [JsonProperty("metro_code")]
            public string metro_code { get; private set; }
        }
    }
}