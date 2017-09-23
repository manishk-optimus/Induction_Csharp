using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();

            string[] arr1 = new string[3];
            foreach(var item in p1.GetStringArray())
            {
               
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        public string[] GetStringArray()
        {
            string[] arr = { "one", "two", "three" };
                return arr;
        }
    }
}
