using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CeeSharpo
{
    internal class Vehicle
    {
        private string vehicleName;
        private string vehicleId;
        static public int vehicleCount;
        public string VehicleName { get => vehicleName; set => vehicleName = value; }
        public string VehicleId { get => vehicleId; set => vehicleId = value; }
        public Vehicle() 
        {
            vehicleCount++;
            Console.WriteLine("Def Vehicle Constructor"); 
        }
        public virtual void status()
        {
            Console.WriteLine("Vehicle is working fine");
        }
        public void showInfo()
        {
            Console.WriteLine("Vehicle Name: {0}", VehicleName);
            Console.WriteLine("Vehicle ID: {0}", VehicleId);
        }
    }
}
