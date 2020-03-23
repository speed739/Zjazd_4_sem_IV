using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TPT_Context:DbContext
    { 
        public DbSet<Computer> Komputery { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PC>().ToTable("PC");
            modelBuilder.Entity<Laptop>().ToTable("Lapotop");
        }
    }
}
