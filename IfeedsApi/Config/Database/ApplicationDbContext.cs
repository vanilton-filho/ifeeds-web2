using Microsoft.EntityFrameworkCore;

namespace IfeedsApi.Config.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}