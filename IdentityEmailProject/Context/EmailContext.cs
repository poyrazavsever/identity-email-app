using IdentityEmailProject.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityEmailProject.Context
{
    public class EmailContext : IdentityDbContext<AppUser>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;initial catalog=IdentityEmailDb;database=IdentityEmailDb;integrated security=true;trust server certificate=true");
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Message> Messages { get; set; }

    }
}
