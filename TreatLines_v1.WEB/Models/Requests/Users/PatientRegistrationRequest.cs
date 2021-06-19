using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreatLines_v1.WEB.Models.Requests.Users
{
    public sealed class PatientRegistrationRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int HospitalId { get; set; }
        public string BloodType { get; set; }
        public string Sex { get; set; }
    }
}
