using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;

namespace postalcodes {
    public class Startup {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices (IServiceCollection services) { }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }

            app.Run (async (context) => {
                await context.Response.WriteAsync (BuildResponse ());
            });
        }

        private string BuildResponse () {
            bool MyZip = IsUsorCanadianZipCode("49418");
            bool CanadaPostal = IsUsorCanadianZipCode("K8N 5W6");
            bool SantaPostal = IsUsorCanadianZipCode("H0H 0H0");
            bool WhiteHouseZip = IsUsorCanadianZipCode("20500");
            bool AnotherPostal = IsUsorCanadianZipCode("K8N5W6");

            return "<html><body>" +
                "<table border=\"1\" cellpadding=\"5\" style=\"border-collapse:collapse;\">" +
                $"<tr><td>My Zip 49418</td><td>{MyZip}</td></tr>" +
                $"<tr><td>Canada K8N 5W6</td><td>{CanadaPostal}</td></tr>" +
                $"<tr><td>Santa H0H 0H0</td><td>{SantaPostal}</td></tr>" +
                $"<tr><td>White House 20500</td><td>{WhiteHouseZip}</td></tr>" +
                $"<tr><td>CA Postal w/o space K8N5W6</td><td>{WhiteHouseZip}</td></tr>" +
                "</table></body></html>";
        }

        string _usZipRegEx = @"^\d{5}(-\d{4})?$";
        string _caZipRegEx = @"^[ABCEGHJKLMNPRSTVXY]{1}\d{1}[A-Z]{1} *\d{1}[A-Z]{1}\d{1}$";

        private bool IsUsorCanadianZipCode (string zipCode) {
            bool validZipCode = true;
            if ((!Regex.Match (zipCode, _usZipRegEx).Success) && (!Regex.Match (zipCode, _caZipRegEx).Success)) {
                validZipCode = false;
            }
            return validZipCode;
        }
    }
}