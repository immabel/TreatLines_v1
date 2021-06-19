using System;
using System.Collections.Generic;
using System.Text;
using TreatLines_v1.BLL.DTOs.Appointment;

namespace TreatLines_v1.BLL.DTOs.Patient
{
    public class PatientsInfoDTO
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string BloodType { get; set; }
        public string Sex { get; set; }
        public int Blocked { get; set; }
    }
}
