using Microsoft.EntityFrameworkCore;

namespace Day1.Models
{
    public class ITIEntities : DbContext
    {
        public ITIEntities() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ITI_DB;Integrated Security=True;Encrypt=False"); //dbms - name server - auth;
        }
    }
}
