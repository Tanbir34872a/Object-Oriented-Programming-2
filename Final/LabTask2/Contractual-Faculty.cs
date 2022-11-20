using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    internal class ContractualFaculty : Faculty, Faculty_Stats
    {
        private string duration;
        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public ContractualFaculty()
        {
            Console.WriteLine("Def Contractual Faculty cons");
        }
        public ContractualFaculty(string x, int y, string z, string a, string b, int c, string d)
        {
            Name = x;
            Age = y;
            Address = z;
            FacultyId = a;
            JoiningDate = b;
            Salary = c;
            Duration = d;
            Console.WriteLine("Par Contractual Faculty cons");
        }
        public void FacultyStatus()
        {
            Console.WriteLine("I am a Part Time Faculty for {0} years", Duration);
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Duration: {0}", Duration);
        }
    }
}
