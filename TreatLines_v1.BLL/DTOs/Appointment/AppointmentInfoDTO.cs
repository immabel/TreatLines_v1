using System;
using System.Collections.Generic;
using System.Text;

namespace TreatLines_v1.BLL.DTOs.Appointment
{
    public class AppointmentInfoDTO
    {
        public int Id { get; set; }
        public string SkinType { get; set; }
        public int Elasticity { get; set; }
        public string PHlevel { get; set; }
        public int LevelOfMoisture { get; set; }
        public string SkinColor { get; set; }
        public string DateTimeAppointment { get; set; }
        public int PrescriptionId { get; set; }
        public string Prescription { get; set; }
    }
}
