namespace Culture
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Localization;

    public class MyRequestCultureProvider : IRequestCultureProvider
    {
        public Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
        {
                var pathSegments = httpContext.Request.Path.Value.Split('/');

                var culture = pathSegments.FirstOrDefault(x => x.StartsWith("custom-culture-"))?.Substring("custom-culture-".Length);
                var uiCulture = pathSegments.FirstOrDefault(x => x.StartsWith("custom-ui-culture-"))?.Substring("custom-ui-culture-".Length);

                var result = new ProviderCultureResult(culture, uiCulture);
                
                return Task.FromResult(result);
        }
    }
}