using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{   class Student
    {
        private string studentClass;
        private string studentName;
        private int enrolmentNo;
        private int age;
        private float percentage;
      
        public string StudentName
        {
            get {return studentName;}
            set
            {
                if (value != null)
                { studentName = value; }
                else
                { throw new ArgumentException("name cant be null"); }
            }
          }
         public string StudentClass
         {
            get { return studentClass; }
            set
            {
                if (value != null)
                { studentClass = value; }
                else
                { throw new ArgumentException("class cant be null"); }
            }
          }
        public float Percentage
        {
            get { return percentage; }
            set
            {
                if (value != null)
                { percentage = value; }
                else
                { throw new ArgumentException("percentage cant be null"); }
            }
        }

    

        public int EnrolmentNo
        {
            get;set;
        }

        public int Age
        {
            get; set;
        }

        public float PercentageCalculate(float MarksObtained, int TotalMarks)
        {
            return (MarksObtained / TotalMarks) * 100; 
        }
      

        public Student()
            {
              this.studentName="A";
              this.studentClass = "I";
              this.EnrolmentNo = 111;
              this.Age = 3;
            }
    }
    class Program
    {    
        public enum data {name,age,enrolment_number,percentage};
        static void Main(string[] args)
        {
            Random number = new Random();
            Student S1 = new Student();

            Console.WriteLine("enter the name:");

            S1.StudentName = Console.ReadLine();

            S1.EnrolmentNo = number.Next(101, 999);

            Console.WriteLine("enter the class:");

            S1.StudentClass = Console.ReadLine();

            Console.WriteLine("enter the age:");

            S1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("enter marks out of 500");

            S1.Percentage = S1.PercentageCalculate(float.Parse(Console.ReadLine()), 500);

            Console.WriteLine("which detail of student that you want");
            Console.WriteLine("For All enter 0");
            Console.WriteLine("For name enter 1");
            Console.WriteLine("For age enter 2");
            Console.WriteLine("For enrolment_number enter 3");
            Console.WriteLine("For percentage of marks enter 4");
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                print(S1);
            }
            else
            { print(S1,x); }
        }

        static void print(Student index)
        {
            Console.WriteLine("hello {0} \nyourdetails are as follows ",index.StudentName);
            Console.WriteLine("class: {0}",index.StudentClass);
            Console.WriteLine("EnrolmentNo: {0}",index.EnrolmentNo);
            Console.WriteLine("age : {0}", index.Age);
            Console.WriteLine("percentage obtained : {0}",index.Percentage);
            Console.ReadLine();
       }
        static void print(Student index, int x)
        {
            switch (x)
            {
                case (int)data.name:
                    Console.WriteLine("name is : {0}",index.StudentName);
                    break;
                case (int)data.age:
                    Console.WriteLine("age is : {0}",index.Age);
                    break;
                case (int)data.enrolment_number:
                    Console.WriteLine("enrolment number is : {0}", index.EnrolmentNo);
                    break;
                case (int)data.percentage:
                    Console.WriteLine("percentage is : {0}", index.Percentage);
                    break;
                default:
                    Console.WriteLine("data not relevent");
                    break;
            }
            Console.ReadLine(); 

        }
    }
}
