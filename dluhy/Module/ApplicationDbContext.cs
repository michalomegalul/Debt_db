using Microsoft.EntityFrameworkCore;
using dluhy.Pages;

namespace dluhy.Module
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Input> input { get; set; }
        public class Input
        {
            public int Id { get; set; }
            public string input { get; set; } = "";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=mydb;Trusted_Connection=True;");
        }
    }
}
