
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrackRecordOfPharmacy
{
    public class DBContext : DbContext
    {
        private readonly string? _connectionString;
        private readonly string? _assemblyName;
        //Set Connection string in constractor
        public DBContext()
        {
            _connectionString = "Server=.\\SQLEXPRESS;Database=CSharpB9;User Id=csharpb9;Password=123456;";
            _assemblyName = Assembly.GetExecutingAssembly().FullName ;
        }
        //configure connection builder
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_assemblyName));
            }
            base.OnConfiguring(dbContextOptionsBuilder);
        }
        //connect MedicineRecords class for create table
        public DbSet<MedicineRecord> MedicineRecords { get; set; }
    }
}
