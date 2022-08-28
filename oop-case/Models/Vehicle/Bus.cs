using System;
using oop_case.Interfaces;

namespace oop_case.Models
{
    public class Bus : IVehicle
    {
        public IVehicle.VehicleClass vehicleClass { get; set; } = IVehicle.VehicleClass.Bus;
        public string HGSNo { get; set; } = string.Empty;
        public string OwnerName { get; set; } = string.Empty;
        public string OwnerSurname { get; set; } = string.Empty;
        public double Balance { get; set; } = double.MinValue;
    }
}

