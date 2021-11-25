using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models.DbModels
{
    public class CourseContext : DbContext
    {
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<InsuredEvent> InsuredEvents { get; set; }
        public DbSet<Police> Polices { get; set; }
        public DbSet<Police_Insurance> Polices_Insurances { get; set; }
        public DbSet<TypeAgent> TypesAgent { get; set; }
        public DbSet<TypeInsurance> TypesInsurance { get; set; }
        public DbSet<TypePayment> TypesPayment { get; set; }
        public CourseContext() { }

        public CourseContext(DbContextOptions<CourseContext> options)
           : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-SI5K88R\\SQLEXPRESS;Initial Catalog=CoursDB;Integrated Security=True");
            }
        }
    }
}
