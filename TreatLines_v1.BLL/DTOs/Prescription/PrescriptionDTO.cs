using System;
using System.Collections.Generic;
using System.Text;
using TreatLines_v1.BLL.DTOs.Appointment;

namespace TreatLines_v1.BLL.DTOs.Prescription
{
    public class PrescriptionDTO
    {
        public int AppointmentId { get; set; }
        public string Description { get; set; }
    }
}
