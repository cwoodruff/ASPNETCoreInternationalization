using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Localization;

namespace Culture
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRequestLocalization(BuildLocalizationOptions());

            app.Run(async (context) =>
            {
                context.Response.StatusCode = 200;
                context.Response.ContentType = "text/html; charset=utf-8";
                
                await context.Response.WriteAsync(BuildResponse());
            });
        }

        private RequestLocalizationOptions BuildLocalizationOptions()
        {
            var supportedCultures = new List<CultureInfo>
            {
                new CultureInfo("en-US"),
                new CultureInfo("es-ES"),
                new CultureInfo("de-DE"),
                new CultureInfo("fr-FR"),
                new CultureInfo("sv-SE")
            };

            var options = new RequestLocalizationOptions {
                DefaultRequestCulture = new RequestCulture("en-US"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            };

            return options;
        }
        
        private string BuildResponse()
        {
            var currentCultureName = CultureInfo.CurrentCulture.EnglishName;
            var currentUICultureName = CultureInfo.CurrentUICulture.EnglishName;
            
            return "<html><body>" 
                + "<table border=\"1\" cellpadding=\"5\" style=\"border-collapse:collapse;\">"
                + $"<tr><td>Current Culture</td><td>{currentCultureName}</td></tr>"
                + $"<tr><td>Current UI Culture</td><td>{currentUICultureName}</td></tr>"
                + $"<tr><td>The Current Date</td><td>{DateTime.Now.ToString("D")}</td></tr>"
                + $"<tr><td>A Formatted Number</td><td>{(1234567.89).ToString("n")}</td></tr>"
                + $"<tr><td>A Currency Value</td><td>{(42).ToString("C")}</td></tr>"
                + "</table></body></html>";            
        }
    }
}
