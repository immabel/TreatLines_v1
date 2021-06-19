using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreatLines_v1.WEB.Models.Requests.Users
{
    public sealed class DoctorRegistrationRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public int OnHoliday { get; set; }
        public int HospitalId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string WorkDays { get; set; }
        public int? DeviceId { get; set; }
    }
}
