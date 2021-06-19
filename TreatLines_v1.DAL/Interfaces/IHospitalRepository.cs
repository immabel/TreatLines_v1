using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TreatLines_v1.DAL.Entities;

namespace TreatLines_v1.DAL.Interfaces
{
    public interface IHospitalRepository : IRepository<Hospital>
    {
        Task<bool> HasHospitalAdminAsync(int hospitalId, string userName);
        Task<bool> HasDoctorAsync(int hospitalId, string userName);
        Task<bool> HasPatientAsync(int hospitalId, string userName);
    }
}
