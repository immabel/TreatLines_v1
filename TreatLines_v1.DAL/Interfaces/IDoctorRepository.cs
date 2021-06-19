using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TreatLines_v1.DAL.Entities;

namespace TreatLines_v1.DAL.Interfaces
{
    public interface IDoctorRepository : IRepository<Doctor>
    {
        Task<Doctor> GetByIdAsync(string id);
        Task<Doctor> GetByEmailAsync(string email);
        IEnumerable<Doctor> GetDoctors(int hospitalId);
    }
}
