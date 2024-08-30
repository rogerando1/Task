using Microsoft.EntityFrameworkCore;

namespace Sample.Models
{
    public class DB_Context : DbContext
    {
        public DB_Context(DbContextOptions<DB_Context> options) : base(options)
        { 

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<User> User { get; set; }
    }
}
