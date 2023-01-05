using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    internal class CourseDbContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public CourseDbContext() {
            _connectionString = "Server =.\\SQLEXPRESS; Trusted_Connection = True; Encrypt = False; Database = CSharpB9; User Id = sa; Password = saba2005";
            _assemblyName = Assembly.GetExecutingAssembly().FullName;
        }

        public CourseDbContext(string connectionString, string assemblyName)
        {
            _connectionString = connectionString;
            _assemblyName = assemblyName;
        }

        //Create Connection
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
