using Microsoft.Extensions.Configuration;

namespace IfeedsApi.Core.Auth
{
    public class JwtSettings
    {
        public JwtSettings(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public string GetSecret()
        {
            return Configuration["Ifeeds:JwtSecret"];
        }
        
    }
}