﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TreatLines_v1.DAL.Entities
{
    public class Patient
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public string BloodType { get; set; }
        public string Sex { get; set; }
        public int HospitalId { get; set; }
        public List<DoctorPatient> PatientDoctors { get; set; }
    }
}
