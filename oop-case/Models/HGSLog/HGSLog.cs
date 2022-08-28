using System;
using oop_case.Interfaces;

namespace oop_case.Models
{
    public class HGSLog
    {
        public IVehicle Vehicle { get; set; }
        public DateTime PassThroughDate { get; set; }
        public double Toll { get; set; }

        public static void CreateLog(List<HGSLog> hGSLogs,IVehicle vehicle)
        {
            HGSLog hGSLog = new()
            {
                Vehicle = vehicle,
                PassThroughDate = DateTime.Now,
                Toll = Booth.CalculateToll(vehicle)
            };
            hGSLogs.Add(hGSLog);
        }
    } 
}

