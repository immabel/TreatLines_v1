using System;
using System.Collections.Generic;
using System.Text;

namespace TreatLines_v1.DAL.Entities
{
    public class Appointment : BaseEntity
    {
        public string SkinType { get; set; }
        public int Elasticity { get; set; }
        public double PHlevel { get; set; }
        public int LevelOfMoisture { get; set; }
        public string SkinColor { get; set; }
        public bool Canceled { get; set; }
        public DateTimeOffset DateTimeAppointment { get; set; }
        public int? PrescriptionId { get; set; }
        public Prescription Prescription { get; set; }
    }
}
