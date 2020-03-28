using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TPC_Context : DbContext
    {
        public DbSet<Computer> Komputery { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PC>().Map(x =>
            {
                x.MapInheritedProperties();
                x.ToTable("Pecety");

            });
            
            modelBuilder.Entity<Laptop>().Map(x =>
            {
                x.MapInheritedProperties();
                x.ToTable("Laptopy");
            });
        }
    }
}