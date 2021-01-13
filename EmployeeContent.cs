using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entityfarmework
{
    internal class EmployeeContent :DbContext
    {
        private readonly string connectionString;

        public EmployeeContent(string connectionString) {
            this.connectionString = connectionString;
        }

    public DbSet<Employee> Employees { get; set; }   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
  