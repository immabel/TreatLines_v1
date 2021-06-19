using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TreatLines_v1.BLL.Interfaces;
using TreatLines_v1.DAL.Entities;
using TreatLines_v1.DAL.Interfaces;
using TreatLines_v1.DAL.Repositories;
using TreatLines_v1.BLL.DTOs.Auth;
using TreatLines_v1.BLL.Exceptions;
using TreatLines_v1.DAL.Constants;
using System;

namespace TreatLines_v1.BLL.Services
{
    public sealed class AuthService : IAuthService
    {
        private readonly UserRepository usersRepository;

        private readonly IHospitalRepository hospitalRepository;

        private readonly IHospitalAdminRepository hospitalAdminRepository;

        private readonly IDoctorRepository doctorRepository;

        private readonly IPatientRepository patientRepository;

        private readonly IDoctorPatientRepository doctorPatientRepository;

        private readonly IRepository<Schedule> scheduleRepository;

        private readonly IJwtAuthenticationManager jwtAuthenticationManager;

        public AuthService(
            UserRepository usersRepository,
            IHospitalRepository hospitalRepository,
            IHospitalAdminRepository hospitalAdminRepository,
            IDoctorRepository doctorRepository,
            IPatientRepository patientRepository,
            IDoctorPatientRepository doctorPatientRepository,
            IRepository<Schedule> scheduleRepository,
            IJwtAuthenticationManager jwtAuthenticationManager)
        {
            this.usersRepository = usersRepository;
            this.hospitalRepository = hospitalRepository;
            this.hospitalAdminRepository = hospitalAdminRepository;
            this.doctorRepository = doctorRepository;
            this.patientRepository = patientRepository;
            this.doctorPatientRepository = doctorPatientRepository;
            this.scheduleRepository = scheduleRepository;
            this.jwtAuthenticationManager = jwtAuthenticationManager;
        }

        public async Task<LoginResponseDTO> LoginAsync(LoginRequestDTO request)
        {
            User user = await usersRepository.FindByEmailAsync(request.Email);
            if (user == null)
            {
                throw new BadRequestException("User does not exist!");
            }
            if (user.Blocked)
                return null;

            bool passwordIsCorrect = await usersRepository.CheckPasswordAsync(user, request.Password);
            if (!passwordIsCorrect)
            {
                throw new ForbiddenException("Password is incorrect!");
            }
            Claim[] userClaims = await GetAuthTokenClaimsForUserAsync(user);

            var accessToken = jwtAuthenticationManager.GenerateTokenForClaims(userClaims);

            string role = userClaims[1].Value;
            int hospitalId = 0;

            if (role.Equals("HospitalAdmin"))
                hospitalId = hospitalAdminRepository.GetHospitalByHospitalAdminId(user.Id).Id;
            else if (role.Equals("Doctor"))
                hospitalId = doctorRepository.GetByIdAsync(user.Id).Result.HospitalId;
            else if (role.Equals("Patient"))
                hospitalId = patientRepository.GetByIdAsync(user.Id).Result.HospitalId;

            return new LoginResponseDTO
            {
                UserId = user.Id,
                Email = user.Email,
                Token = accessToken,
                Role = role,
                HospitalId = hospitalId
            };
        }

        public async Task RegisterHospitalAdminAsync(HospitalAdminRegistrationDTO request)
        {
            //var hospitalId = hospitalAdminRepository.GetHospitalIdByHospitalAdminId(request.HospitalAdminId);
            Hospital hospital = await hospitalRepository.GetByIdAsync(request.HospitalId);
            if (hospital == null)
            {
                throw new BadRequestException("Hospital doesn't exist!");
            }

            User hospitalAdminUser = await RegisterAsync(request);
            await usersRepository.AddUserToRoleAsync(hospitalAdminUser, Rolename.HOSPITAL_ADMIN);
            await hospitalAdminRepository.AddAsync(new HospitalAdmin
            {
                UserId = hospitalAdminUser.Id,
                HospitalId = request.HospitalId
            });
            await hospitalAdminRepository.SaveChangesAsync();
        }

        private async Task<User> RegisterAsync(RegistrationDTO request)
        {
            var user = new User
            {
                UserName = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
            };
            var registerResult = await usersRepository.TryCreateAsync(
                user: user,
                password: request.Password);

            if (!registerResult.Succeeded)
            {
                throw new BadRequestException(registerResult.Errors.First().Description);
            }

            return user;
        }

        private async Task<Claim[]> GetAuthTokenClaimsForUserAsync(User user)
        {
            IList<string> userRoles = await usersRepository.GetRolesAsync(user);
            var userClaims = new[]
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, userRoles.FirstOrDefault())
            };
            return userClaims;
        }

        public string MySort(string str)
        {
            int[] arr = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
                arr[i] = str[i];
            Array.Sort(arr);
            str = arr.ToString();
            return str;
        }

        public async Task RegisterDoctorAsync(DoctorRegistrationDTO request)
        {
            //var hospitalId = hospitalAdminRepository.GetHospitalByHospitalAdminId(request.HospitalAdminId).Id;
            Hospital hospital = await hospitalRepository.GetByIdAsync(request.HospitalId);
            if (hospital == null)
            {
                throw new BadRequestException("Hospital doesn't exist!");
            }

            Schedule schedule = new Schedule
            {
                StartTime = request.StartTime,
                EndTime = request.EndTime,
                WorkDays = request.WorkDays
            };
            await scheduleRepository.AddAsync(schedule);
            await scheduleRepository.SaveChangesAsync();

            //int scheduleId = scheduleRepository.Find(sch => sch.Equals(schedule)).Result.FirstOrDefault().Id;

            User doctor = await RegisterAsync(request);
            await usersRepository.AddUserToRoleAsync(doctor, Rolename.DOCTOR);
            await doctorRepository.AddAsync(new Doctor
            {
                UserId = doctor.Id,
                Position = request.Position,
                OnHoliday = request.OnHoliday,
                HospitalId = request.HospitalId,
                ScheduleId = schedule.Id
            });
            await doctorRepository.SaveChangesAsync();
        }

        public async Task RegisterPatientAsync(PatientRegistrationDTO request)
        {
            User patient = await RegisterAsync(request);
            await usersRepository.AddUserToRoleAsync(patient, Rolename.PATIENT);
            await patientRepository.AddAsync(new Patient
            {
                UserId = patient.Id,
                BloodType = request.BloodType,
                Sex = request.Sex,
                HospitalId = request.HospitalId
            });
            await patientRepository.SaveChangesAsync();

            /*Doctor doctor = await doctorRepository.GetByEmailAsync(request.DoctorEmail);
            if (doctor != null)
            {
                await doctorPatientRepository.AddAsync(new DoctorPatient
                {
                    DoctorId = doctor.UserId,
                    PatientId = patient.Id
                });
                await doctorPatientRepository.SaveChangesAsync();
            }*/
        }
    }
}
