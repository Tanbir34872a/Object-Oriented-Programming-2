using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    internal class FulltimeFaculty : Faculty, Faculty_Stats
    {
        private string nextIncrementDate;
        public string NextIncrementDate
        {
            get { return nextIncrementDate; }
            set { nextIncrementDate = value; }
        }
        public FulltimeFaculty()
        {
            Console.WriteLine("Def Fulltime Faculty cons");
        }
        public FulltimeFaculty(string x, int y, string z, string a, string b, int c, string d)
        {
            Name = x;
            Age = y;
            Address = z;
            FacultyId = a;
            JoiningDate = b;
            Salary = c;
            NextIncrementDate = d;
            Console.WriteLine("Par Fulltime Faculty cons");
        }
        public void FacultyStatus()
        {
            Console.WriteLine("I am a Full Time faculty");
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Next Increment Date: {0}", nextIncrementDate);
        }
    }
}
