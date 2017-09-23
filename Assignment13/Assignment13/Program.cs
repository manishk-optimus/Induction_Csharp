using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

public class Vehicle
{
    public string make { get; set; }
    public int cost { get; set; }
    public string model { get; set; }

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
    public ArrayList VehicleList = new ArrayList();
    public void data()
    {
        VehicleList.Add(new Vehicle() { make = "mahindra", model = "Centuro 4567", cost = 56200 });

        VehicleList.Add(new Vehicle() { make = "toyota", model = "DC323", cost = 82200 });

        VehicleList.Add(new Vehicle() { make = "honda", model = "GHT678", cost = 65200 });

        VehicleList.Add(new Vehicle() { make = "hero", model = "HL124", cost = 95621 });

        VehicleList.Add(new Vehicle() { make = "bajaj", model = "AQ5631", cost = 45213 });

       
    }
    public IEnumerator GetEnumerator()
    {
        return VehicleList.GetEnumerator();
    }
}


namespace Assignment13
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleCollection obj = new VehicleCollection();
            obj.data();

            //foreach (var var in obj)
            //{
            //    Console.WriteLine(var.ToString());
            //}
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("data at Index {0} is : \n {1}",i,obj.VehicleList[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
