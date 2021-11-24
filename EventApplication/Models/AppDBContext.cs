using Microsoft.EntityFrameworkCore;

namespace EventApplication.Models
{
    public class AppDBContext : DbContext
    {
        public static string ConnectionString { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options) { }

        public AppDBContext()
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Interests> Interests { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }

    }
}