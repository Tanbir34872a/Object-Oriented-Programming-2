using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person P1 = new ScholarshipStudent("Tanbir", 20, "Ramna", "21-44394-1", 3.95, 71, "35%");
			((Student)P1).PersonStatus();
            ((ScholarshipStudent)P1).StudentStatus();
            ((ScholarshipStudent)P1).ShowDetails();

        }
    }
}
