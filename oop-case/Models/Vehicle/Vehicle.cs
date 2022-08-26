using System;
namespace oop_case.Models
{
    public class Vehicle
    {
        public int VehicleClassNo { get; set; } = 0;
        public string VehicleClassName { get; set; } = string.Empty;
        public string HGSNo { get; set; } = string.Empty;
        public string OwnerName { get; set; } = string.Empty;
        public string OwnerSurname { get; set; } = string.Empty;
        public double Balance { get; set; } = 0;

        public enum VehicleClass { Car = 1, Minibus = 2, Bus = 3 };

        public static Vehicle CreateRandomVehicle()
        {
            long timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();

            return (timestamp % 3) switch
            {
                0 => new Car()
                {
                    VehicleClassNo = (int) VehicleClass.Car,
                    VehicleClassName = VehicleClass.Car.ToString(),
                    HGSNo = $"hsg{timestamp}",
                    OwnerName = "Ömer Faruk",
                    OwnerSurname = "Orhan",
                    Balance = 78.54
                },
                1 => new Minibus()
                {
                    VehicleClassNo = (int)VehicleClass.Minibus,
                    VehicleClassName = VehicleClass.Minibus.ToString(),
                    HGSNo = $"hsg{timestamp}",
                    OwnerName = "Mehmet",
                    OwnerSurname = "Orhan",
                    Balance = 167.45
                },
                2 => new Bus()
                {
                    VehicleClassNo = (int)VehicleClass.Bus,
                    VehicleClassName = VehicleClass.Bus.ToString(),
                    HGSNo = $"hsg{timestamp}",
                    OwnerName = "Zuhal",
                    OwnerSurname = "Orhan",
                    Balance = 167.45
                },
                _ => throw new NotImplementedException(),
            };

        }
    }
}

