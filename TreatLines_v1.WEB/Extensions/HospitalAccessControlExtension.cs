using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TreatLines_v1.BLL.Interfaces;

namespace TreatLines_v1.WEB.Extensions
{
    public static class HospitalAccessControlExtension
    {
        public static async Task<bool> IsHospitalAdminOrHigherAsync(
            this ClaimsPrincipal user,
            int universityId,
            IHospitalService hospitalService)
        {
            if (user.IsInRole("Admin"))
            {
                return true;
            }

            if (user.IsInRole("HospitalAdmin"))
            {
                return await hospitalService.HasHospitalAdminAsync(universityId, user.Identity.Name);
            }

            return false;
        }
    }
}
