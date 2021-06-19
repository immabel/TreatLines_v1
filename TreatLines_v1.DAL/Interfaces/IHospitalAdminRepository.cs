using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TreatLines_v1.DAL.Entities;

namespace TreatLines_v1.DAL.Interfaces
{
    public interface IHospitalAdminRepository : IRepository<HospitalAdmin>
    {
        Task<IEnumerable<HospitalAdmin>> GetAllHospitalAdminsAsync();
        Hospital GetHospitalByHospitalAdminId(string id);
    }
}
