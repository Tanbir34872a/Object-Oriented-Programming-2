using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExam
{
    internal abstract class Student : Person
    {
        private string studentId;
        private double cgpa;
        private int creditComplete;

        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public double Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public int CreditComplete
        {
            get { return creditComplete; }
            set { creditComplete = value; }
        }

        public abstract void StudentStatus();

        public Student()
        {
            Console.WriteLine("Def Student Cons");
        }
        public Student(string a, int b, string c, string d, double e, int f)
        {
            Name = a;
            Age = b;
            Address = c;
            StudentId = d;
            Cgpa = e;
            CreditComplete = f;
            Console.WriteLine("Par Student Cons");
        }
        public override void PersonStatus() 
        {
            Console.WriteLine("I am a Student");
        }
        public virtual void ShowDetails()
        {
            Console.WriteLine("Student ID: {0}", StudentId);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Address: {0}", Address);
            Console.WriteLine("CGPA: {0}", Cgpa);
            Console.WriteLine("Credit Complete: {0}", CreditComplete);
        }
    }
}
