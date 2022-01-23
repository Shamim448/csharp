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
            _connectionString = "";
            _assemblyName = Assembly.GetExecutingAssembly().FullName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_assemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }
        public DbSet<Course> Courses { get; set; }
    }
}
