using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork
{
    public class CourseDbContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public CourseDbContext()
        {
            _connectionString = "Server=DESKTOP-DP23GAJ\\SQLEXPRESS;Database=CSharpB9;User Id=shamim;Password=saba2005;";
            _assemblyName = Assembly.GetExecutingAssembly().FullName;
        }
        public CourseDbContext( string connectionString, string assembly)
        {
            connectionString = _connectionString;
            assembly = _assemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_assemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        //many to many
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CourseStudent>()
                 .HasKey(cs => new { cs.CourseId, cs.StudentId });
            //one to many
            builder.Entity<Course>()
                .HasMany(p => p.Topics)
                .WithOne(i => i.Course);

            //many to many
            builder.Entity<CourseStudent>()
                .HasOne(pc => pc.Course)
                .WithMany(p => p.CourseStudents)
                .HasForeignKey(pc => pc.CourseId);
            builder.Entity<CourseStudent>()
                .HasOne(pc => pc.Student)
                .WithMany(c => c.CoursesStudents)
                .HasForeignKey(pc => pc.StudentId);
                
            base.OnModelCreating(builder);
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
