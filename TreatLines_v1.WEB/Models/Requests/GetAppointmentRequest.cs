using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreatLines_v1.WEB.Models.Requests
{
    public class GetAppointmentRequest
    {
        public string PatientId { get; set; }
        public string DoctorId { get; set; }
    }
}
