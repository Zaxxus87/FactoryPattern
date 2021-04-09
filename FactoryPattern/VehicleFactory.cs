using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int tires)
        {
            if (tires == 2)
                return new Motorcycle();
            else
                return new SUV();
        }
    }
}
