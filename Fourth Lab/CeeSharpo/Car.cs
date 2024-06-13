using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeeSharpo
{
    internal class Car:Vehicle
    {
        public Car()
        {
            Console.WriteLine("Def Car Constructor");
        }
        public override void status()
        {
            Console.WriteLine("Car is working fine");
        }
    }
}
