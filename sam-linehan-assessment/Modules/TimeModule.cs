using System;
using sam_linehan_assessment.Models;
using Newtonsoft.Json;
using Nancy;

namespace sam_linehan_assessment.Modules
{
    public class TimeModule : NancyModule
    {
        public TimeModule() : base("/time")
        {
            Get("/", args =>
            {
                var time = new Time();
                time.milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();
                time.FullDate = DateTime.UtcNow.ToString("yyyyMMddTHH:mm:ssZ");

				return JsonConvert.SerializeObject(time);
            });
        }
    }
}
