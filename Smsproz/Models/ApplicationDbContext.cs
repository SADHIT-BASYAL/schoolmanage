using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Smsproz.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public DbSet<cla>Clas { get; set; } 
        public DbSet<Subject> SubjectClas { get; set; }
        public DbSet<Student> StudentClas { get; set;}
        public DbSet<Teacher> TeachersClas { get;set; }
        public DbSet<TeacherSubject> TeachersSubjectClas { get; set; }
        public DbSet<TeacherAttendence > TeachersAttendenceClas { get; set; }
        public DbSet <StudentAttendence> StudentAttendenceClas { get; set; }
        public DbSet<Fees> FeesClas { get; set;}
        public DbSet<Exam> Exams { get; set; }
        }
}