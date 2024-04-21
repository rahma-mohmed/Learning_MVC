using Microsoft.EntityFrameworkCore;

namespace Day1.Models
{
    //databse name -name server - authantic
    public class ITIEnitities :DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Attandance> Attandance { get; set; }   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer("Data Source=.;Initial Catalog=ITI_DB;Integrated Security=True");
            //dbms - name server -db - autha
        }

    }
}
