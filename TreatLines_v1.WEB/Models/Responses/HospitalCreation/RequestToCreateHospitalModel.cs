using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreatLines_v1.WEB.Models.Responses.HospitalCreation
{
    public class RequestToCreateHospitalModel
    {
        public int Id { get; set; }
        public string HospitalName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string SubmitterFirstName { get; set; }
        public string SubmitterLastName { get; set; }
        public string Email { get; set; }
        public string DateOfCreation { get; set; }
    }
}
