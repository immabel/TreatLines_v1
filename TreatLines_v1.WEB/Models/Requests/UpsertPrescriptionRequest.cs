using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreatLines_v1.WEB.Models.Requests
{
    public class UpsertPrescriptionRequest
    {
        public int AppointmentId { get; set; }
        public string Description { get; set; }
    }
}
