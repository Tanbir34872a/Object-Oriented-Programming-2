using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExam
{
	internal abstract class Faculty : Person
	{
		private string facultyId;
		private string joiningDate;
		private int salary;

		public string FacultyId
		{
			get { return facultyId; }
			set { facultyId = value; }
		}
		public string JoiningDate
		{
			get { return joiningDate; }
			set { joiningDate = value; }
		}
		public int Salary
		{ 
			get { return salary; } 
			set { salary = value; } 
		}

		public abstract void FacultyStatus();

		public Faculty()
		{
			Console.WriteLine("Default Faculty Cons");
		}
        public Faculty(string x, int y, string z, string a, string b, int c)
        {
			Name = x;
			Age = y;
			Address = z;
			FacultyId = a;
			JoiningDate = b;
			Salary = c;
            Console.WriteLine("Par Faculty Cons");
        }
        public override void PersonStatus() 
		{
			Console.WriteLine("I am a Faculty");
		}
		public virtual void ShowDetails()
		{
            Console.WriteLine("Faculty ID: {0}", FacultyId);
            Console.WriteLine("Name: {0}", Name);
			Console.WriteLine("Age: {0}", Age);
			Console.WriteLine("Address: {0}", Address);
			Console.WriteLine("Joinig Date: {0}", JoiningDate);
			Console.WriteLine("Salary: {0}", Salary);
        }
    }
}
