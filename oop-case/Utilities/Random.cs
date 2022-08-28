using System;
using oop_case.Interfaces;
using oop_case.Models;

namespace oop_case.Utilities
{
    public class Random
    {
        // Random vehicle generation method based on timestamp simulating hgs vehicle transition
        public static IVehicle CreateRandomVehicle()
        {
            long timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();

            return (timestamp % 3) switch
            {
                0 => new Car()
                {
                    HGSNo = $"hsg{timestamp}",
                    OwnerName = "Ömer Faruk",
                    OwnerSurname = "Orhan",
                    Balance = 78.54
                },
                1 => new Minibus()
                {
                    HGSNo = $"hsg{timestamp}",
                    OwnerName = "Mehmet",
                    OwnerSurname = "Orhan",
                    Balance = 167.45
                },
                2 => new Bus()
                {
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

