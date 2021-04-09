using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class SUV : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving SUV");
        }
    }
}
