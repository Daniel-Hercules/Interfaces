using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Interfaces
{
    class Plane : Vehicle, IFly
    {
        public Plane(String nameOfManfactuer, UsageType usageType, int noOfWheels, int passengers) : base(nameOfManfactuer, usageType, noOfWheels, passengers)
        {
            Altitude = 0; 
        }

        public int Altitude { get; set; }

        public override void Accelerate()
        {
            VehicleState += 10000;
        }

        public void TakeOff()
        {
            Altitude += 200;   
        }
    }
}
