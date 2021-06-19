﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TreatLines_v1.BLL.DTOs.HospitalCreate
{
    public sealed class RequestToCreateHospitalViewDTO
    {
        public int Id { get; set; }
        public string HospitalName { get; set; }
        public string Address { get; set; }        
        public string Country { get; set; }        
        public string SubmitterFirstName { get; set; }        
        public string SubmitterLastName { get; set; }        
        public string Email { get; set; }
        public DateTimeOffset DateOfCreation { get; set; }
    }
}
