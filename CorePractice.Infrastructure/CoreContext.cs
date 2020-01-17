using Microsoft.EntityFrameworkCore;
using CorePractice.Application.Models;

namespace CorePractice.Infrastructure
{
    public class CoreContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        private const string connectionString = @"server=coresample.database.windows.net; database=coresample;user id=coredev;password='s+_v_#anXLZHzzpzAgT'";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>(entity =>
            {
                entity.HasKey(user => user.UserId);
            });
        }
    }
}
