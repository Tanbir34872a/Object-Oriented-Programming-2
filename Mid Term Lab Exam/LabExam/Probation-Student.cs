using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExam
{
    internal class ProbationStudent : Student
    {
        int probationSeme;
        string counselorName;
        public int ProbationSeme
        {
            get { return probationSeme; }
            set { probationSeme = value; }
        }
        public string CounselorName
        {
            get { return counselorName; }
            set { counselorName = value; }
        }

        public ProbationStudent() 
        {
            Console.WriteLine("Def Probation Student cons");
        }
        public ProbationStudent(string a, int b, string c, string d, double e, int f, int g, string h)
        {
            Name = a;
            Age = b;
            Address = c;
            StudentId = d;
            Cgpa = e;
            CreditComplete = f;
            ProbationSeme = g;
            CounselorName = h;
            Console.WriteLine("Par Probation Student cons");
        }
        public override void StudentStatus()
        {
            Console.WriteLine("I am probation student under counselor: {0}", CounselorName);
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Probation Semester: {0}", ProbationSeme);
            Console.WriteLine("Counselor Name: {0}", CounselorName);
        }
    }
}
