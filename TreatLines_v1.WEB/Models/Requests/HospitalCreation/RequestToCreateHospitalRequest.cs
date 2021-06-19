using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TreatLines_v1.WEB.Models.Requests.HospitalCreation
{
    public class RequestToCreateHospitalRequest
    {
        [Required]
        public string HospitalName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string SubmitterFirstName { get; set; }
        [Required]
        public string SubmitterLastName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
