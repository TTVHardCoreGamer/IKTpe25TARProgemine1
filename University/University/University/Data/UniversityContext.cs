using Microsoft.EntityFrameworkCore;
using University.Models;

namespace University.Data
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssigment> OfficeAssigments { get; set; }
        public DbSet<CourseAssigment> CourseAssigment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Department>().ToTable("Department"); 
            modelBuilder.Entity<Instructor>().ToTable("Instructor"); 
            modelBuilder.Entity<OfficeAssigment>().ToTable("OfficeAssigment"); 
            modelBuilder.Entity<CourseAssigment>().ToTable("CourseAssigment");

            modelBuilder.Entity<CourseAssigment>()
                .HasKey(c => new { c.CourseId, c.InstructorId });
        }
    }
}
