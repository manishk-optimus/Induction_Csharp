using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class Student
    {
        public int Enrolment_no { get; set; }
        public string name { get; set; }
        public string contact_no { get; set; }
        public int age { get; set; }

    }
    class CollegeStudent : Student
    {
        public string program { get; set; }
        public int year { get; set; }
    }
    class SchoolStudent:Student
    {
        public int standard{ get;set;}
        public string house_name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
