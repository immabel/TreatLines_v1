﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TreatLines_v1.BLL.DTOs.Appointment
{
    public class AppointmentDTO
    {
        public int Id { get; set; }
        public string DateTimeAppointment { get; set; }
        public int Canceled { get; set; }
    }
}
