using System;
namespace oop_case.Models
{
    public class Booth
    {
        public static bool PaymentProcess(Vehicle vehicle)
        {
            double toll = CalculateToll(vehicle);
            if (vehicle.Balance < toll)
            {
                return false;
            }
            vehicle.Balance -= toll;
            return true;
        }

        public static double CalculateToll(Vehicle vehicle)
        {
            return vehicle.VehicleClassNo switch
            {
                1 => 20.80,
                2 => 35.50,
                3 => 60.75,
                _ => 20,
            };
        }
    }
}

