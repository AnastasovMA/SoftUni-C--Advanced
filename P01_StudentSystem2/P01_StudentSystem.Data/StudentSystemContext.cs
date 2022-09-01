
namespace P01_StudentSystem.Data
{
    using Microsoft.EntityFrameworkCore;
    using P01_StudentSystem.Data.Models;
    using System;
    using System.Diagnostics.CodeAnalysis;
    public class StudentSystemContext : DbContext
    {

        public StudentSystemContext()
        {

        }

        public StudentSystemContext(DbContextOptions<StudentSystemContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Homework> Homeworks { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<StudentCourse> StudentCourses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.CONNECTION_STRING);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentCourse>().HasKey(e => new
            {
                e.StudentId,
                e.CourseId
            });

            modelBuilder.Entity<Student>(e =>
            {
                e.Property(e => e.Name).IsUnicode(true);
                e.Property(e => e.PhoneNumber).IsUnicode(false);
            });

            modelBuilder.Entity<Course>(e =>
            {
                e.Property(e => e.Name).IsUnicode(true);
                e.Property(e => e.Description).IsUnicode(true);
            });

            modelBuilder.Entity<Resource>(e =>
            {
                e.Property(e => e.Name).IsUnicode(true);
                e.Property(e => e.Url).IsUnicode(false);
            });

            modelBuilder.Entity<Homework>(x =>
            {
                x.Property(x => x.Content).IsUnicode(false);
            });


            modelBuilder.Entity<StudentCourse>()
                .HasOne(e => e.Student)
                .WithMany(e => e.CourseEnrollments)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Homework>()
                .HasOne(e => e.Student)
                .WithMany(e => e.HomeworkSubmissions)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(e => e.Course)
                .WithMany(e => e.StudentsEnrolled)
                .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<Resource>()
                .HasOne(e => e.Course)
                .WithMany(e => e.Resources)
                .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<Homework>()
                .HasOne(e => e.Course)
                .WithMany(e => e.HomeworkSubmissions)
                .HasForeignKey(e => e.CourseId);
        }

    }
}
