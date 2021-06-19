using System;
using System.Collections.Generic;
using System.Text;

namespace TreatLines_v1.DAL.Entities
{
    public class Schedule : BaseEntity
    {
        public DateTimeOffset StartTime { get; set; } 
        public DateTimeOffset EndTime { get; set; } 
        public string WorkDays { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
