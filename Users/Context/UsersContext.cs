using Microsoft.EntityFrameworkCore;

namespace Users.Context
{
    public class UsersContext : DbContext
    {

        public UsersContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Users.Entities.Users> Users { get; set; }
    }
}
