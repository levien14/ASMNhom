using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentManager.Models
{
    public class StudentManagerContext : DbContext
    {
        public StudentManagerContext (DbContextOptions<StudentManagerContext> options)
            : base(options)
        {
        }

        public DbSet<StudentManager.Models.Account> Account { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Grade>()
                .HasIndex(u => u.GradeName)
                .IsUnique();
        }
        public DbSet<StudentManager.Models.Person> Person { get; set; }
        public DbSet<StudentManager.Models.Subject> Subject { get; set; }
        public DbSet<StudentManager.Models.Grade> Grade { get; set; }
        public DbSet<StudentManager.Models.Mark> Mark { get; set; }
        public DbSet<StudentManager.Models.GradeStudent> GradeStudent { get; set; }
        public DbSet<StudentManager.Models.SubjectGrade> SubjectGrade { get; set; }
        public DbSet<StudentManager.Models.Role> Role { get; set; }
        public DbSet<StudentManager.Models.AccountRole> AccountRole { get; set; }
    }
}
