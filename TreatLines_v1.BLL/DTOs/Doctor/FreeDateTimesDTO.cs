﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TreatLines_v1.BLL.DTOs.Doctor
{
    public class FreeDateTimesDTO
    {
        public string Date { get; set; }
        public IList<string> Times { get; set; }
    }
}
