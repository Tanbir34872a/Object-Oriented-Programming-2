using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeeSharpo
{
    internal class Saloon:Car
    {
        public Saloon()
        {
            Console.WriteLine("Def Saloon Constructor");
        }
        public override void status()
        {
            Console.WriteLine("Saloon Car is working fine");
        }
    }
}
