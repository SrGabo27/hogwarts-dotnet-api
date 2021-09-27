using Microsoft.EntityFrameworkCore;
using hogwartsApi.Domain.Models;

namespace hogwartsApi.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Application>().ToTable("Applications");
            builder.Entity<Application>().HasKey(p => p.Id);
            builder.Entity<Application>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Application>().Property(p => p.Name).IsRequired().HasMaxLength(20);
            builder.Entity<Application>().Property(p => p.Lastname).IsRequired().HasMaxLength(20);
            builder.Entity<Application>().Property(p => p.Identification).IsRequired().HasMaxLength(10);
            builder.Entity<Application>().Property(p => p.Age).IsRequired().HasMaxLength(2);
            builder.Entity<Application>().Property(p => p.House).IsRequired();
        }
    }
}
