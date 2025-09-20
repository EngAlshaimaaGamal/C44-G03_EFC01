using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DatabaseContext
{
    internal class CompanyDbContext : DbContext 
    {
        


        public CompanyDbContext() : base()
        {
        }

       override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database= CompanyG03;Trusted_Connection =True;TrustServerCertificate=True");
        }

        public DbSet<Models.Employee> Employees { get; set; }   
        public DbSet<Models.Department> Departments { get; set; }

        public DbSet<Models.Project> Projects { get; set; } 

      







    }
}
