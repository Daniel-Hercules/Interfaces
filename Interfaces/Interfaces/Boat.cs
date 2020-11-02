using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Boat : Vehicle
    {

        public Boat(String nameOfManfactuer, UsageType usageType, int noOfWheels, int passengers) : base(nameOfManfactuer, usageType, noOfWheels, passengers)
        {
            
        }

        public override void Accelerate()
        {
            VehicleState += 300000;
        }
    }
}
