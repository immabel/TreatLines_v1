using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreatLines_v1.WEB.Models.Requests
{
    public sealed class ScheduleCreationRequest
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string WorkDays { get; set; }
    }
}
