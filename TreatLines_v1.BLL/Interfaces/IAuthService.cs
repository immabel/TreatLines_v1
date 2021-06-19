using System.Threading.Tasks;
using TreatLines_v1.BLL.DTOs.Auth;

namespace TreatLines_v1.BLL.Interfaces
{
    public interface IAuthService
    {
        Task RegisterHospitalAdminAsync(HospitalAdminRegistrationDTO request);
        Task RegisterDoctorAsync(DoctorRegistrationDTO request);
        Task RegisterPatientAsync(PatientRegistrationDTO request);
        Task<LoginResponseDTO> LoginAsync(LoginRequestDTO request);
    }
}