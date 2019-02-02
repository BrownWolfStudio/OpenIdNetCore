using Microsoft.EntityFrameworkCore;

namespace OpenIdNetCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
    }
}
