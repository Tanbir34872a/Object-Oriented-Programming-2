using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeeSharpo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vehicle obj1 = new Motorbike();
            Console.WriteLine();
            Vehicle obj2 = new Truck();
            Console.WriteLine();
            Vehicle obj3 = new Car();
            Console.WriteLine();
            Vehicle obj4 = new Saloon();
            Console.WriteLine();
            Vehicle obj5 = new MPV();
            Console.WriteLine();
            obj1.status();
            obj2.status();
            obj3.status();
            obj4.status();
            obj5.status();
            Console.WriteLine();
            Console.WriteLine("Number of Vehicles: {0}", Vehicle.vehicleCount);
        }
    }
}