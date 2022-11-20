using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    internal abstract class Person
    {
        private string name;
        private int age;
        private string address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public Person()
        {
            Console.WriteLine("Def Person Cons");
        }
    }
    public interface Person_Status
    {
        void PersonStatus();
    }
}
