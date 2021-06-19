using System;
using System.Collections.Generic;
using System.Text;

namespace TreatLines_v1.BLL.DTOs.Appointment
{
    public class AppointmentCreationDTO
    {
        public DateTimeOffset DateTimeAppointment { get; set; }
        public string PatientEmail { get; set; }
        public string DoctorEmail { get; set; }
    }
}
