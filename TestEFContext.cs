using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class TestEFContext: DbContext
    {
        public TestEFContext(DbContextOptions<TestEFContext> options): base(options)
        {

        }

        public DbSet<CountryTeam> CountryTeams { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryTeam>().ToTable("CountryTeam");
            modelBuilder.Entity<Group>().ToTable("Group");
        }
    }
}