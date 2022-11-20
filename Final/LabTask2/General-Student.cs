using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    internal class GeneralStudent : Student, Student_Status
    {
        public GeneralStudent(string a, int b, string c, string d, double e, int f)
        {
            Name = a;
            Age = b;
            Address = c;
            StudentId = d;
            Cgpa = e;
            CreditComplete = f;
            Console.WriteLine("Par General Student Cons");
        }

        public void StudentStatus()
        {
            Console.WriteLine("I am a General Student");
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
        }

    }
}
