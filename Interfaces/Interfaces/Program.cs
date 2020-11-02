using System;
using System.Collections.Generic;
using System.Numerics;
using System.Collections;
using System.Linq;
using System.Net;

namespace Interfaces
{
    class Program
    {

        static void Main(string[] args)
        {
            
            var transport = new List<IVehicle>();
            var veichleList = new Vehicles();
            Car car = new Car("VOLVO",UsageType.Commercial,8);
            Car car2 = new Car("FIAT",UsageType.GovernmentOwned,5);
            var plane = new Boat("BOEING",UsageType.PrivatelyOwned,8,400);
            var plane2 = new Plane("AIRBUS",UsageType.Commercial,16, 200);
            Boat boat = new Boat("SEA RAY",UsageType.PrivatelyOwned,3,500);



            transport.Add(car);
            transport.Add(car2);
            transport.Add(plane);
            transport.Add(plane2);
            transport.Add(boat);

            veichleList.addVehicle(car);
            veichleList.addVehicle(car2);
            veichleList.addVehicle(plane);
            veichleList.addVehicle(plane2);
            veichleList.addVehicle(boat);

            veichleList.showAllAmountsOfWheels();
            Console.WriteLine("");
            veichleList.showAllManufactuers();
            Console.WriteLine("");
            veichleList.showAllPassengerCapacities();
            Console.WriteLine("");
            //ShowDetailsOfAllVehicles(transport);
            ShowDetailsOfAllVehicles(transport);
            showVehicleCount(transport);







        }
        //Linq functions (To be completed)
        private static void FirstElement(IEnumerable<IVehicle> vehicles) 
        {
            //Console.WriteLine(vehicles.First);
        }
        private static void showVehicleCount(IEnumerable<IVehicle> vehicles) 
        {
            Console.WriteLine(vehicles.Count());
        }
        private static void ShowDetailsOfAllVehicles(IEnumerable<IVehicle> vehicles)
        {
            //convert for each loop to linq for each loop
            var four = vehicles.Where(x=>x.Wheels==4).ToArray();
            
            //var result = vehicles.ToList().ForEach()

            

            //look at select function.
            foreach (IVehicle vehicle in vehicles)
            {
               
                //Debug.Print
                Console.WriteLine("");
                Console.WriteLine($"Amount of Wheels : {vehicle.Wheels}");
                Console.WriteLine($"Manufactuer : {vehicle.Manufactuer}");
                Console.WriteLine($"Amount of Passengers : {vehicle.NoOfPassengers}");
                Console.WriteLine("");
            }
        }
    }
}
