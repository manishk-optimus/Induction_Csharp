using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class Vehicle
    {
        public string make { get; set; }
        public int YearOfMenufacture { get; set; }
        public string model { get; set; }
        public float speed { get; set; }
        public static int flag;

        public void accelerate()
        {
            flag = 1;
            Console.WriteLine("Accelerating");
        }
        public void Deaccelerate()
        {
            flag = 1;
            Console.WriteLine("deaccelerating");
        }
        public void stop()
        {
            flag = 0;
            Console.WriteLine("stopped");
        }
        public bool _ismoving()
        {
            if (flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public Vehicle()
        {
            make = "none";
            YearOfMenufacture = 2000;
            model = "latest";
            speed = 140;
            flag = 0;
        }
    }

    class Bicycle : Vehicle
    {
        public int gears;

    }
    class Bike : Vehicle
    {
        public string reg_number;
        public int fuel_capacity;

        public void disc_brake()
        {
            Console.WriteLine("applying disc_brake");
        }
    }
    class Car : Vehicle
    {
        public string reg_number;
        public int fuel_capacity;
        public string engine_type;

        public void air_bags()
        {
            Console.WriteLine("opening air bags");
        }

    }
    class Truck : Vehicle
    {
        public string reg_number;
        public int fuel_capacity;
        public string engine_type;
        public int no_of_tyres;

        public void power_brake()
        {
            Console.WriteLine("power_brake");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Truck T1 = new Truck();
            T1.make = "Mahindra";
            T1.model = "1613";
            T1.speed = 120;
            T1.YearOfMenufacture = 2016;

            T1.accelerate();
            if (T1._ismoving())
            {
                Console.WriteLine("vehicle is moving");
            }
            else
            {
                Console.WriteLine("vehicle not moving");
            }
            Console.ReadLine();
        }
    }
}
