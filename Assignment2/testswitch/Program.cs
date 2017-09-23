using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a language of your choice");
            string lang = Console.ReadLine();
            switch (lang)
            {
                case "VB":
                    Console.WriteLine("vb.net,oop,multithreading and many more");
                    Console.ReadLine();
                    break;
                case "C#":
                    Console.WriteLine("good choice,c# is a good language "); 
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("well,good luck with that!!!!!");
                    Console.ReadLine();
                    break;

            }
            

        }
    }
}
