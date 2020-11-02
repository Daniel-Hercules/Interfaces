using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IFly
    {
        public int Altitude { get; set; }
        public void TakeOff(); 
    }
}
