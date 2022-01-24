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
            _connectionString = "Server=DESKTOP-7T438A0\\SQLEXPRESS;Database=CSharpB9;User Id=shamim;Password=saba2005;";
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
        public DbSet<Course> Courses { get; set; }
    }
}
