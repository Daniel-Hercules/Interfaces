using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Car : Vehicle
        
    {
        public Car(String nameOfManfactuer, UsageType usageType, int passengers) : base(nameOfManfactuer, usageType,  4,  passengers)
        {
            
        }

        public override void Accelerate()
        {
            VehicleState += 1;
        }
       

    }
}
