using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeeSharpo
{
    internal class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;
        public string CourseName 
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }
        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }
        }
        public Course()
        { 
            Console.WriteLine("Def Course Cons");
        }
        public Course(string a, string b, int c)
        {
            this.courseName = a;
            this.courseCode = b;
            this.courseCredit = c;
            Console.WriteLine("Param Course Cons");
        }
        public void showCourseInfo() 
        {
            Console.WriteLine("Course Name: {0}", courseName);
            Console.WriteLine("Course Code: {0}", courseCode);
            Console.WriteLine("Course Credit: {0}", courseCredit);
        }
    }
}
