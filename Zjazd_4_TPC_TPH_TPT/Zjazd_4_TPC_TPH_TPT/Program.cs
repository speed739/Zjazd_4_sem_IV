using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var tph = new TPHContet();
            //tph.Komputery.Add(new PC { CoolingType = "liquid", Description = "Chlodzenie" });
            //tph.SaveChanges();

            //var tpt = new TPTContext();
            //tpt.Komputery.Add(new PC { CoolingType = "wind", Description = "Chlodzenie_1" });
            //tpt.SaveChanges();

            var tpc = new TPC_Context();
            tpc.Komputery.Add(new Laptop { Maufacture = "test", Description = "Chlodzenie_1" });
            tpc.SaveChanges();
        }
    }
}
