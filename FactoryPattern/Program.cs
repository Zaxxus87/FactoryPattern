using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = VehicleFactory.GetVehicle(2);
            v1.Drive();

            var v2 = VehicleFactory.GetVehicle(4);
            v2.Drive();

        }
    }
}
