﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TreatLines_v1.DAL.Entities
{
    public class Prescription : BaseEntity
    {
        public string Description { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
