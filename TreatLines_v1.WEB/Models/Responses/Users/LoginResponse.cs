using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreatLines_v1.WEB.Models.Responses.Users
{
    public class LoginResponse
    {
        public string UserId { get; set; }
        public string AccessToken { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public int HospitalId { get; set; }
    }
}
