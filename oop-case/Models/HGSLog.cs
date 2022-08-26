using System;
namespace oop_case.Models
{
    public class HGSLog
    {
        public Vehicle Vehicle { get; set; }
        public DateTime PassThroughDate { get; set; }
        public double Toll { get; set; }

        public static void CreateLog(List<HGSLog> hGSLogs,Vehicle vehicle)
        {
            HGSLog hGSLog = new()
            {
                Vehicle = vehicle,
                PassThroughDate = DateTime.Now,
                Toll = Booth.CalculateToll(vehicle),
            };
            hGSLogs.Add(hGSLog);
        }
    }
}

