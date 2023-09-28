using GranadaITELEC1C.Models;
using GranadaITELEC1C.Services;

using System;

namespace GranadaITELEC1C.Services    
{
    public class MyFakeDataServices : IMyFakeDataService
    {
        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }
        public MyFakeDataServices() 
        {
            StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Jasper",LastName = "Arangali", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.5, Email = "jarangali@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Lourdes",LastName = "Santos", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1, Email = "juskolourdes@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Jose Goldie",LastName = "Calimlim", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "jogoca@gmail.com"
                },
                new Student()
                {
                    Id= 4,FirstName = "Alyannah",LastName = "Roman", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "slayyy@gmail.com"
                }
            };

            InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", IsTenured = true, rank = Rank.Instructor, HiringDate = DateTime.Parse("2022-08-26")
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Luis",LastName = "Granada", IsTenured = true, rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("2022-08-27")
                },
                new Instructor()
                {
                    Id= 3,FirstName = "Albert",LastName = "Montano", IsTenured = false, rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("2022-08-28")
                }
            };
        }

        
        
    }
}
