using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPractice
{
    public class MedicineDbContext:DbContext
    {
        private readonly string? _connectionString;
        private readonly string? _assemblyName;

        public MedicineDbContext()
        {
            _assemblyName = Assembly.GetExecutingAssembly().FullName; ;
            _connectionString = "Server=.\\SQLEXPRESS; Database = CSharpB9; User Id = csharpb9; Password = 123456;";
        }
        public MedicineDbContext( string conn, string assem)
        {
            _connectionString = conn;
            _assemblyName = assem;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_assemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }
        public DbSet<MedicinInfo> MedicinInfo { get; set; }
    }
}
