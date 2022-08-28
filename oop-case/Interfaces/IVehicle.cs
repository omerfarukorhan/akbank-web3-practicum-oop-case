using System;
namespace oop_case.Interfaces
{
    public interface IVehicle
    {
        VehicleClass vehicleClass { get; set; }
        string HGSNo { get; set; }
        string OwnerName { get; set; }
        string OwnerSurname { get; set; }
        double Balance { get; set; }

        enum VehicleClass { Car = 1, Minibus = 2, Bus = 3 };
    }
}

