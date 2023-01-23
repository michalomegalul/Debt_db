using Microsoft.EntityFrameworkCore;
using dluhy.Pages;
using Microsoft.EntityFrameworkCore.Design;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace dluhy.Module
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Input> input { get; set; }
        public class Input
        {
            public int Id { get; set; }
            public string input { get; set; } = "";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=myDataBase;User Id=kys;Password=owo;Timeout=60;");
        }

    }
}

