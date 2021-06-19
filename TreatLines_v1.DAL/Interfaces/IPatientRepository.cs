using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TreatLines_v1.DAL.Entities;

namespace TreatLines_v1.DAL.Interfaces
{
    public interface IPatientRepository : IRepository<Patient>
    {
        Task<Patient> GetByIdAsync(string id);
        Task<Patient> GetByEmailAsync(string email);
        Task<IEnumerable<Patient>> GetAllWithUserAsync();
    }
}
