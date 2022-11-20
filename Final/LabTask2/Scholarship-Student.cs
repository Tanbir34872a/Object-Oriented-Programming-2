using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    internal class ScholarshipStudent : Student, Student_Status
    {
        private string schoAmount;
        public string SchoAmount
        {
            get { return schoAmount; }
            set { schoAmount = value; }
        }

        public ScholarshipStudent() 
        {
            Console.WriteLine("Def Scholarship student");
        }
        public ScholarshipStudent(string a, int b, string c, string d, double e, int f, string g)
        {
            Name = a;
            Age = b;
            Address = c;
            StudentId = d;
            Cgpa = e;
            CreditComplete = f;
            SchoAmount = g;
            Console.WriteLine("Par General Student Cons");
        }
        public void StudentStatus()
        {
            Console.WriteLine("I am a Scholarship Student availing {0} scholarship", SchoAmount);
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Scholarship: {0}", SchoAmount);
        }
    }
}
