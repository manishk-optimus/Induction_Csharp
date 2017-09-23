using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    public class Vehicle : IComparable <Vehicle>,IEquatable<Vehicle>
    {
        public string type { get; set; }
        public string make { get; set; }
        public int cost { get; set; }
        public string model { get; set; }

        public int CompareTo(Vehicle obj)
        {
            Vehicle other = (Vehicle)obj;
            if (this.cost < other.cost)
            {
                return 1;
            }
            else if (this.cost > other.cost)
            {
                return -1;
            }
            else
                return 0;
        }

        public Vehicle()
        {
            make = "none";
            cost = 0000;
            model = "none";
        }
        public override string ToString()
        {
            return "menufacturer=" + make + "  " + "model_no=" + model + " " + "cost=" + cost;
        }

        public bool Equals(Vehicle other)
        {
            if (this.cost < other.cost)
            {
                return false;
            }
            else if (this.cost > other.cost)
            {
                return false;
            }
            else
                return true;
        }
    }
    class car : Vehicle
    {

    }
    class truck : Vehicle
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            car maruti = new car();
            truck toyota = new truck();

            maruti.model = "JH2563";
            maruti.cost = 32562;

            toyota.model = "AD5236";
            toyota.cost = 32562;

            if (toyota.Equals(maruti))
            {
                Console.WriteLine("the cost of the car maruti and truck toyota is equal");
            }
            else
            {
                Console.WriteLine("the costs are not equal");
            }
            Console.ReadLine();
        }
    }
}
