using System.Data.SqlClient;
using IfeedsApi.Core.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IfeedsApi.Core.Configs
{
    public class DatabaseConfig
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            var builder = new SqlConnectionStringBuilder(configuration["Ifeeds:ConnectionString"]);
            builder.Password = configuration["Ifeeds:Password"];

            services.AddDbContextPool<ApplicationDbContext>(options =>
                options.UseMySql(builder.ConnectionString, MySqlServerVersion.AutoDetect(builder.ConnectionString)));

        }
    }
}