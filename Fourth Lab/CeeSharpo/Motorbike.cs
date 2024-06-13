using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeeSharpo
{
    internal class Motorbike : Vehicle
    {
        public Motorbike()
        {
            Console.WriteLine("Def Motorbike Constructor");
        }
        public override void status()
        {
            Console.WriteLine("Bike is working fine");
        }
    }
}
