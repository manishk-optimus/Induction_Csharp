using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment14
{
    public class Vehicle : IComparable<Vehicle>, IEquatable<Vehicle>
    {

        public string Make { get; set; }
        public int Cost { get; set; }
        public string Model { get; set; }

        public int CompareTo(Vehicle obj)
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

        public override string ToString()
        {
            return "menufacturer=" + Make + "  " + "model_no=" + Model + " " + "cost=" + Cost;
        }

        public bool Equals(Vehicle other)
        {
            if (this.Cost < other.Cost)
            {
                return false;
            }
            else if (this.Cost > other.Cost)
            {
                return false;
            }
            else
                return true;
        }

        protected static IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class Car : Vehicle
    {
        public bool SUV { get; set; }

        public Car(bool suv, string make, string model, int cost)
        {
            SUV = suv;
            Make = make;
            Model = model;
            Cost = cost;
        }
    }
    class Truck : Vehicle
    {
        public bool PowerBrake { get; set; }

        public Truck(bool pb, string make, string model, int cost)
        {
            PowerBrake = pb;
            Make = make;
            Model = model;
            Cost = cost;
        }
    }
    public class VehicleCollection : Vehicle
    {
        public void Data()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            Car datsun = new Car(true, "hyundai", "2017", 958000);
            Car i20 = new Car(false, "Maruti", "2015", 656000);
            Truck eicher = new Truck(true, "Eicher_India", "1613", 958000);
            Truck maxo = new Truck(true, "Tata", "1613", 955000);
            vehicles.Add(datsun);
            vehicles.Add(i20);
            vehicles.Add(eicher);
            vehicles.Add(maxo);

            Console.WriteLine("Vehicle collection :");
            foreach (var var in vehicles)
            {
                Console.WriteLine(var);
            }
            vehicles.Sort();
            Console.WriteLine(" ");
            Console.WriteLine("Vehicle collection after sorting according to the cost:");
            foreach (var var in vehicles)
            {
                Console.WriteLine(var);
            }
            Console.WriteLine("");
            if (datsun.Equals(eicher))
            {
                Console.WriteLine("The cost of car datsun and truck eicher is equal");
            }
            else
            {
                Console.WriteLine("The cost of car datsun and truck eicher is not equal");
            }
            Console.ReadLine();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            VehicleCollection obj = new VehicleCollection();
            obj.Data();

        }
    }
}
