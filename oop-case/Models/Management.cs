using System;
namespace oop_case.Models
{
    public class Management
    {
        public static double CalculateDailyEndorsement(List<HGSLog> hGSLogs)
        {
            double endorsement = 0;
            foreach (HGSLog hGSLog in hGSLogs)
            {
                if (hGSLog.PassThroughDate.Date == DateTime.Now.Date)
                {
                    endorsement += hGSLog.Toll;
                }
            }
            return endorsement;
        }

        public static List<HGSLog> DailyHGSLog(List<HGSLog> hGSLogs)
        {
            List<HGSLog> dailyHGSLogs = new();
            foreach (HGSLog hGSLog in hGSLogs)
            {
                if (hGSLog.PassThroughDate.Date == DateTime.Now.Date)
                {
                    dailyHGSLogs.Add(hGSLog);
                }
            }
            return dailyHGSLogs;
        }
    }
}

