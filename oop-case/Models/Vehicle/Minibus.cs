using System;
using oop_case.Interfaces;

namespace oop_case.Models
{
    public class Minibus : IVehicle
    {
        public IVehicle.VehicleClass vehicleClass { get; set; } = IVehicle.VehicleClass.Minibus;
        public string HGSNo { get; set; } = string.Empty;
        public string OwnerName { get; set; } = string.Empty;
        public string OwnerSurname { get; set; } = string.Empty;
        public double Balance { get; set; } = double.MinValue;
    }
}

