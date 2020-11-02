using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Interfaces
{
    class Vehicles
    {
        List<IVehicle> vehicles = new List<IVehicle>();
        public Vehicles() 
        {
            
            vehicles = new List<IVehicle>();

        }

      

        public void addVehicle(IVehicle veichle) 
        {
            vehicles.Add(veichle);
            Console.WriteLine("Veichle Added \n");
        }
        public void showAllAmountsOfWheels() 
        {
            Console.WriteLine("Each Vehicles Amount Of Wheels: ");
            foreach (IVehicle vehicle in vehicles)
            {
                int amountOfWheels = vehicle.Wheels;

                Console.WriteLine("Veichle " + vehicles.IndexOf(vehicle) + " has " + amountOfWheels + " wheels");
            }
        }

        public void showAllManufactuers()
        {
            Console.WriteLine("Vehicle Manufactuers: ");
            foreach (IVehicle vehicle in vehicles)
            {
                

                Console.WriteLine("Veichle " + vehicles.IndexOf(vehicle) + " : " + vehicle.Manufactuer);
            }
        }

        public void showAllPassengerCapacities()
        {
            Console.WriteLine("Each Vehicles Passenger Capacity:");
            foreach (IVehicle vehicle in vehicles)
            {
                int amountOfPassengers = vehicle.NoOfPassengers;

                Console.WriteLine("Veichle " + vehicles.IndexOf(vehicle) + " can fit " + amountOfPassengers + " passengers");
            }
        }





    }
}
