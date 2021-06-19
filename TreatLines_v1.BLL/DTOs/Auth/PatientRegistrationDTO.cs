using System;
using System.Collections.Generic;
using System.Text;

namespace TreatLines_v1.BLL.DTOs.Auth
{
    public class PatientRegistrationDTO : RegistrationDTO
    {
        public string DoctorEmail { get; set; }
        public string BloodType { get; set; }
        public string Sex {get; set;}
        public int HospitalId { get; set; }
    }
}
