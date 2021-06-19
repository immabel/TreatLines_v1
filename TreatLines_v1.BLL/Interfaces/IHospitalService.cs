using System.Collections.Generic;
using System.Threading.Tasks;
using TreatLines_v1.BLL.DTOs.Doctor;
using TreatLines_v1.BLL.DTOs.Hospital;
using TreatLines_v1.BLL.DTOs.HospitalAdmin;

namespace TreatLines_v1.BLL.Interfaces
{
    public interface IHospitalService
    {
        Task<bool> HasHospitalAdminAsync(int hospitalId, string userName);
        Task<bool> HasDoctorAsync(int hospitalId, string userName);
        Task<bool> HasPatientAsync(int hospitalId, string userName);
        Task<IEnumerable<HospitalInfoDTO>> GetHospitals();
        Task<bool> DeleteHospitalByIdAsync(int hospitalId);
        IEnumerable<HospitalAdminInfoDTO> GetHospitalAdmins();
        IEnumerable<HospitalAdminInfoDTO> GetHospitalAdminsById(string id);
        Task BlockUser(string email);
        int GetHospitalIdByHospitalAdminId(string id);
        Task DeleteUser(string email);
    }
}
