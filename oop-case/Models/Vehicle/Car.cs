using System;
using oop_case.Interfaces;

namespace oop_case.Models
{
    public class Car : IVehicle
    {
        public IVehicle.VehicleClass vehicleClass { get; set; } = IVehicle.VehicleClass.Car;
        public string HGSNo { get; set; } = string.Empty;
        public string OwnerName { get; set; } = string.Empty;
        public string OwnerSurname { get; set; } = string.Empty;
        public double Balance { get; set; } = double.MinValue;
    }
}

