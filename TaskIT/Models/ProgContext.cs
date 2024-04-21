using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Principal;

namespace TaskIT.Models
{
    public class ProgContext : DbContext
    {


        public ProgContext() : base()
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=BookDb ;Integrated Security=True");
        }
    }
}
