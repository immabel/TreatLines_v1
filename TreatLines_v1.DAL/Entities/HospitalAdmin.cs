﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TreatLines_v1.DAL.Entities
{
    public class HospitalAdmin
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }
    }
}
