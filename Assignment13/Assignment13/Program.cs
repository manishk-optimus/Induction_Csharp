using System;
using System.Collections;

public class Vehicle
{
    public string Make { get; set; }
    public int Cost { get; set; }
    public string Model { get; set; }

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
    public ArrayList VehicleList = new ArrayList();
    public void Data()
    {
        VehicleList.Add(new Vehicle("mahindra", "Centuro 4567", 56200));

        VehicleList.Add(new Vehicle("toyota", "DC323", 82200));

        VehicleList.Add(new Vehicle("honda", "GHT678", 65200));

        VehicleList.Add(new Vehicle("hero", "HL124", 95621));

        VehicleList.Add(new Vehicle("bajaj", "AQ5631", 45213));
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
            obj.Data();

           
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("data at Index {0} is : \n {1}",i,obj.VehicleList[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
