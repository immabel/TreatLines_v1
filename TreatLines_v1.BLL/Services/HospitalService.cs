using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;
using TreatLines_v1.BLL.DTOs.Hospital;
using TreatLines_v1.BLL.DTOs.HospitalAdmin;
using TreatLines_v1.BLL.Interfaces;
using TreatLines_v1.DAL.Entities;
using TreatLines_v1.DAL.Interfaces;
using TreatLines_v1.DAL.Repositories;
using TreatLines_v1.BLL.DTOs.Doctor;

namespace TreatLines_v1.BLL.Services
{
    public sealed class HospitalService : IHospitalService
    {
        private readonly UserRepository userRepository;

        private readonly IHospitalRepository hospitalRepository;

        private readonly IHospitalAdminRepository hospitalAdminRepository;

        private readonly IMapper mapper;

        public HospitalService(
            UserRepository userRepository,
            IHospitalRepository hospitalRepository,
            IHospitalAdminRepository hospitalAdminRepository,
            IMapper mapper)
        {
            this.userRepository = userRepository;
            this.hospitalRepository = hospitalRepository;
            this.hospitalAdminRepository = hospitalAdminRepository;
            this.mapper = mapper;
        }

        public Task<bool> HasHospitalAdminAsync(int hospitalId, string userName)
        {
            return hospitalRepository.HasHospitalAdminAsync(hospitalId, userName);
        }

        public Task<bool> HasDoctorAsync(int hospitalId, string userName)
        {
            return hospitalRepository.HasDoctorAsync(hospitalId, userName);
        }

        public Task<bool> HasPatientAsync(int hospitalId, string userName)
        {
            return hospitalRepository.HasPatientAsync(hospitalId, userName);
        }

        public async Task<IEnumerable<HospitalInfoDTO>> GetHospitals()
        {
            var hospitals = await hospitalRepository.GetAllAsync();
            return mapper.Map<IEnumerable<HospitalInfoDTO>>(hospitals);
        }

        public async Task<bool> DeleteHospitalByIdAsync(int hospitalId)
        {
            var hospital = await hospitalRepository.GetByIdAsync(hospitalId);
            if (hospital == null)
            {
                return false;
            }
            hospitalRepository.Remove(hospital);
            await hospitalRepository.SaveChangesAsync();
            return true;
        }

        public IEnumerable<HospitalAdminInfoDTO> GetHospitalAdmins()
        {
            var admins = hospitalAdminRepository.GetAllHospitalAdminsAsync()
                .Result
                .Select(ha => new HospitalAdminInfoDTO
                {
                    Id = ha.UserId,
                    Email = ha.User.Email,
                    FirstName = ha.User.FirstName,
                    LastName = ha.User.LastName,
                    HospitalName = ha.Hospital.Name,
                    HospitalId = ha.HospitalId,
                    Blocked = ha.User.Blocked ? 1 : 0
                });
            return admins;
        }

        public IEnumerable<HospitalAdminInfoDTO> GetHospitalAdminsById(string id)
        {
            var hospitalId = GetHospitalIdByHospitalAdminId(id);
            var hAdmins = GetHospitalAdmins().Where(hadm => hadm.HospitalId == hospitalId);
            return hAdmins;
        }

        public int GetHospitalIdByHospitalAdminId(string id)
        {
            var hId = hospitalAdminRepository.GetHospitalByHospitalAdminId(id).Id;
            return hId;
        }

        public async Task BlockUser(string email)
        {
            var user = await userRepository.FindByEmailAsync(email);
            user.Blocked = user.Blocked ? false : true;
            await userRepository.UpdateAsync(user);
        }

        public async Task DeleteUser(string email)
        {
            var user = await userRepository.FindByEmailAsync(email);
            await userRepository.DeleteAsync(user);
        }
    }
}
