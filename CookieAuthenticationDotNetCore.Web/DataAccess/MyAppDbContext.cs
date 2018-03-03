using Microsoft.EntityFrameworkCore;

namespace CookieAuthenticationDotNetCore.Web.DataAccess
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext>
        options) : base(options)
        {

        }

        public DbSet<MyAppUser> MyAppUsers { get; set; }
    }
}
