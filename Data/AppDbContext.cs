
using GranadaITELEC1C.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GranadaITELEC1C.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {} 
 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student()
            {
                Id = 1,
                FirstName = "Jasper",
                LastName = "Arangali",
                Course = Course.BSIT,
                AdmissionDate = DateTime.Parse("2022-08-26"),
                GPA = 1.5,
                Email = "jarangali@gmail.com"
                 
            },
                new Student()
                {
                    Id = 2,
                    FirstName = "Lourdes",
                    LastName = "Santos",
                    Course = Course.BSIS,
                    AdmissionDate = DateTime.Parse("2022-08-07"),
                    GPA = 1,
                    Email = "juskolourdes@gmail.com"
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Jose Goldie",
                    LastName = "Calimlim",
                    Course = Course.BSCS,
                    AdmissionDate = DateTime.Parse("2020-01-25"),
                    GPA = 1.5,
                    Email = "jogoca@gmail.com"
                },
                new Student()
                {
                    Id = 4,
                    FirstName = "Alyannah",
                    LastName = "Roman",
                    Course = Course.BSCS,
                    AdmissionDate = DateTime.Parse("2020-01-25"),
                    GPA = 1.5,
                    Email = "slayyy@gmail.com"
                }
                
                );
        }
    }
}
