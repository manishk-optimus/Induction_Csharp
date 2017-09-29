using System;
using System.Collections.Generic;
using System.Collections;

namespace Assignment12
{
    public class Vehicle : IComparable
    {
        public string Make { get; set; }
        public int Cost{ get; set; }
        public string Model { get; set; }

        public int CompareTo(object obj)
        {
            Vehicle other = (Vehicle)obj;
            if (this.Cost < other.Cost)
            {
                return 1;
            }
            else if (this.Cost > other.Cost)
            {
                return -1;
            }
            else
                return 0;
        }

        public Vehicle(string make,string model,int cost)
        {
            Make = make;
            Cost = cost;
            Model = model;
        }
        public override string ToString()
       {
           return "menufacturer=" + Make + "  " + "model_no=" + Model + " " + "cost=" + Cost;
        }

    }
    public class VehicleCollection : IEnumerable
    {
        List<Vehicle> bike = new List<Vehicle>();
        public void Data()
        {
            bike.Add(new Vehicle("mahindra", "Centuro 4567", 56200));

            bike.Add(new Vehicle("toyota", "DC323", 82200)); 

            bike.Add(new Vehicle("honda", "GHT678", 65200));

            bike.Add(new Vehicle("hero", "HL124", 95621));

            bike.Add(new Vehicle("bajaj", "AQ5631", 45213));

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
            obj.Data();
                        
            foreach (var var in obj)
            {
              Console.WriteLine(var);
            }

      
               Console.ReadLine();
            
        }
    }
}
