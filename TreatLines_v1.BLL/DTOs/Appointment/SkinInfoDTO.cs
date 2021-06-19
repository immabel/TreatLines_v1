using System;
using System.Collections.Generic;
using System.Text;

namespace TreatLines_v1.BLL.DTOs.Appointment
{
    public class SkinInfoDTO
    {
        public int AppointmentId { get; set; }
        public string SkinType { get; set; }
        public int Elasticity { get; set; }
        public double PHlevel { get; set; }
        public int LevelOfMoisture { get; set; }
        public string SkinColor { get; set; }
    }
}
