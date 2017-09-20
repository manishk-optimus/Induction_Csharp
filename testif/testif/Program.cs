using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a language of your choice");
            string lang = Console.ReadLine();
            if (lang == "VB")
                Console.WriteLine("VB.NET :OOP ,multithreding and more !");
            else if(lang == "C#")
                Console.WriteLine("Good choice ,C# is a fine language");
            else
                Console.WriteLine("well,good luck with that!!");
            Console.ReadLine();
        }
    }
}
