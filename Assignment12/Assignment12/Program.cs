using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment12
{
    public class Vehicle : IComparable
    {
        public string make { get; set; }
        public int cost{ get; set; }
        public string model { get; set; }

        public int CompareTo(object obj)
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

    }
    public class VehicleCollection : IEnumerable
    {
        List<Vehicle> bike = new List<Vehicle>();
        public void data()
        {
            bike.Add(new Vehicle() { make = "mahindra", model = "Centuro 4567", cost = 56200 });

            bike.Add(new Vehicle() { make = "toyota", model = "DC323", cost = 82200 });

            bike.Add(new Vehicle() { make = "honda", model = "GHT678", cost = 65200 });

            bike.Add(new Vehicle() { make = "hero", model = "HL124", cost = 95621 });

            bike.Add(new Vehicle() { make = "bajaj", model = "AQ5631", cost = 45213 });

            bike.Sort();
        }

        public IEnumerator GetEnumerator()
        {
            return bike.GetEnumerator();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            VehicleCollection obj = new VehicleCollection();
            obj.data();
                        
            foreach (var var in obj)
            {
              Console.WriteLine(var);
            }

      
               Console.ReadLine();
            
        }
    }
}
