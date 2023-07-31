using demo_web_app.Models;
using Microsoft.EntityFrameworkCore;

namespace demo_web_app.AppContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>().HasData(
                new Person() { Id = 1, Name = "John Smith" },
                new Person() { Id = 2, Name = "Alice Taylor" }
            );
        }
        public DbSet<Person>? Persons { get; set; }
    }
}
