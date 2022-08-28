using Microsoft.AspNetCore.Mvc;
using oop_case.Interfaces;
using oop_case.Models;

namespace oop_case.Controllers
{
    [Route("[controller]")]
    public class HGSController : Controller
    {
        public static List<HGSLog> hGSLogs = new();

        [HttpGet("PassThroughProcess")]
        public ActionResult PassThroughProcess()
        {
            IVehicle vehicle = Utilities.Random.CreateRandomVehicle();

            if (!Booth.PaymentProcess(vehicle))
            {
                return Ok("Insufficient balance.");
            }

            HGSLog.CreateLog(hGSLogs, vehicle);
            return Ok("Successful.");
        }

        [HttpGet("GetDailyHGSLog")]
        public ActionResult DailyHGSLog()
        {
            List<HGSLog> dailyHGSLogs = Management.DailyHGSLog(hGSLogs);
            return Ok(dailyHGSLogs);
        }

        [HttpGet("GetDailyEndorsement")]
        public ActionResult DailyEndorsement()
        {
            double endorsement = Management.CalculateDailyEndorsement(hGSLogs);
            return Ok(endorsement);
        }
    }
}

