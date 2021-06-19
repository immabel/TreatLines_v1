using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreatLines_v1.WEB.Models.Requests
{
    public class AppointmentCreationRequest
    {
        public string DateTimeAppointment { get; set; }
        public string PatientEmail { get; set; }
        public string DoctorEmail { get; set; }
    }
}
