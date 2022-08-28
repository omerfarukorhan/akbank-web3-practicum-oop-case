using System;
using oop_case.Interfaces;

namespace oop_case.Models
{
    public class Booth
    {
        public static bool PaymentProcess(IVehicle vehicle)
        {
            double toll = CalculateToll(vehicle);
            if (vehicle.Balance < toll)
            {
                return false;
            }
            vehicle.Balance -= toll;
            return true;
        }

        public static double CalculateToll(IVehicle vehicle)
        {
            return vehicle.vehicleClass switch
            {
                IVehicle.VehicleClass.Car => 20.80,
                IVehicle.VehicleClass.Minibus => 35.50,
                IVehicle.VehicleClass.Bus => 60.75,
                _ => 20,
            };
        }
    }
}

