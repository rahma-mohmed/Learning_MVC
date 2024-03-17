using Day3.Models;
using Microsoft.EntityFrameworkCore;

namespace Day3.Models
{
    public class ITIEntities2 :DbContext
    {
        public ITIEntities2() : base()
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CrsResult> CrsResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Day3DB ;Integrated Security=True ; Encrypt = False");
        }
    }
}
