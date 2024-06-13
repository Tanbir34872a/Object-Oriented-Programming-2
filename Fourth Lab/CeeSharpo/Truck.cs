using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeeSharpo
{
    internal class Truck : Vehicle
    {
        public Truck()
        {
            Console.WriteLine("Def Truck Constructor");
        }
        public override void status()
        {
            Console.WriteLine("Truck is working fine");
        }
    }
}
