using System;
using Nancy;
using Newtonsoft.Json;
using sam_linehan_assessment.Models;

namespace sam_linehan_assessment.Modules
{
    public class SystemModule : NancyModule
    {
        public SystemModule() : base("/system")
        {
            Get("/", args =>
            {
                var currentSystem = new CurrentSystem();
                currentSystem.MachineName = Environment.MachineName;
                currentSystem.ProcessorCount = Environment.ProcessorCount.ToString();

                // .NET core doesn't have a Environment.OsVersion propertry
                currentSystem.OsVersion = System.Runtime.InteropServices.RuntimeInformation.OSDescription;

                return JsonConvert.SerializeObject(currentSystem);
            });
        }
    }
}
