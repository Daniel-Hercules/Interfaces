using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Interfaces
{
    public enum UsageType
    {
        Commercial,
        PrivatelyOwned,
        GovernmentOwned
    }
    public abstract class Vehicle : IVehicle
    {
        public Vehicle(String nameOfManfactuer, UsageType usageType, int noOfWheels, int passengers)
        {
            VehicleState = 0;
            Usage = usageType;
            Manufactuer = nameOfManfactuer;
            Wheels = noOfWheels;
            NoOfPassengers = passengers;
        }
        
        public int Wheels { get; set; }
        public string Manufactuer { get; set; }
        public int NoOfPassengers { get; set; }
        public int VehicleState { get; set; }
        public UsageType Usage { get; set; }
        public abstract void Accelerate();

        public virtual void Brake()
        {
            VehicleState = 0;
        }
    }
}
