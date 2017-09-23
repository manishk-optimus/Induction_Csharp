using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testenum
{
    class Program
    {
        public enum Weekday
        {
            monday, tuesday, wednesday, thursday, friday, saturday, sunday
        };

        static void Main(string[] args)
        {
          Console.WriteLine("what day is today:");
            string  day = Console.ReadLine();
            if (day.Equals(Weekday.monday.ToString()))
            {
                Console.WriteLine("happy monday");
            }
            else if (day.Equals(Weekday.tuesday.ToString()))
            {
                Console.WriteLine("happy tuesday");
            }
            else if (day.Equals(Weekday.wednesday.ToString()))
            {
                Console.WriteLine("happy wednesday");
            }
            else if (day.Equals(Weekday.thursday.ToString()))
            {
                Console.WriteLine("happy thursday");
            }
            else if (day.Equals(Weekday.friday.ToString()))
            {
                Console.WriteLine("happy friday");
            }
            else if (day.Equals(Weekday.saturday.ToString()))
            {
                Console.WriteLine("happy saturday");
            }
            else if (day.Equals(Weekday.sunday.ToString()))
            {
                Console.WriteLine("very happy sunday");
            }
            else
            {
                Console.WriteLine("wrong entry"); 
            }
            Console.ReadLine();
        }
    }
}
