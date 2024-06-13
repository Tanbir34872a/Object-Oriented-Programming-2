using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeeSharpo
{
    internal class MPV:Car
    {
        public MPV()
        {
            Console.WriteLine("Def MVP Constructor");
        }
        public override void status()
        {
            Console.WriteLine("MPV Car is working fine");
        }
    }
}
