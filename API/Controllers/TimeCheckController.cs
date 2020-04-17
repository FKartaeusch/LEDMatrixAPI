using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeCheckController : Controller
    {
        [HttpGet]
        [Route("GetTimezones")]
        public List<string> TimeZones()
        {
            {
                foreach (var z in TimeZoneInfo.GetSystemTimeZones())
                {
                    if (z.Id.Contains("Berlin") || z.Id.Contains("Europe"))
                    {
                        Console.WriteLine(z.Id);
                    }
                }
            }
            return TimeZoneInfo.GetSystemTimeZones().Select(t => t.Id).ToList();
        }


        // GET
        [HttpGet]
        [Route("test")]
        public string CheckTime()
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture("de-DE");
            var time = GetLocalDateTime().ToString("t", cultureInfo);
            return time;
        }

        private DateTime GetLocalDateTime()
        {
            var timeZoneID = "Europe/Berlin";
            var utcTime = DateTime.Now.ToUniversalTime();
            Console.WriteLine("UTC: " + utcTime);
            var timeInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZoneID);

            var localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, timeInfo);
            Console.WriteLine("local: " + localTime);

            return localTime;
        }
    }
}