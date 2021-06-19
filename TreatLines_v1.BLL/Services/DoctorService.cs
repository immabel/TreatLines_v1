﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreatLines_v1.BLL.Interfaces;
using TreatLines_v1.DAL.Entities;
using TreatLines_v1.DAL.Interfaces;
using TreatLines_v1.BLL.DTOs.Doctor;
using TreatLines_v1.BLL.DTOs.Patient;
using TreatLines_v1.DAL.Repositories;
using TreatLines_v1.BLL.DTOs.Auth;
using TreatLines_v1.BLL.DTOs.Schedule;
using TreatLines_v1.BLL.DTOs.Appointment;
using TreatLines_v1.BLL.DTOs.Prescription;
using System.Collections;

namespace TreatLines_v1.BLL.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly UserRepository userRepository;

        private readonly IDoctorRepository doctorRepository;

        private readonly IRepository<Schedule> scheduleRepository;

        private readonly IRepository<Appointment> appointmentRepository;

        private readonly IRepository<Prescription> prescriptionRepository;

        private readonly IPatientRepository patientRepository;

        private readonly IDoctorPatientRepository doctorPatientRepository;

        private readonly IHospitalAdminRepository hospitalAdminRepository;

        private readonly IHospitalRepository hospitalRepository;

        private readonly IMapper mapper;

        public DoctorService(
            UserRepository userRepository,
            IDoctorRepository doctorRepository,
            IRepository<Schedule> scheduleRepository,
            IRepository<Appointment> appointmentRepository,
            IDoctorPatientRepository doctorPatientRepository,
            IRepository<Prescription> prescriptionRepository,
            IPatientRepository patientRepository,
            IHospitalAdminRepository hospitalAdminRepository,
            IHospitalRepository hospitalRepository,
            IMapper mapper)
        {
            this.userRepository = userRepository;
            this.doctorRepository = doctorRepository;
            this.scheduleRepository = scheduleRepository;
            this.appointmentRepository = appointmentRepository;
            this.doctorPatientRepository = doctorPatientRepository;
            this.prescriptionRepository = prescriptionRepository;
            this.patientRepository = patientRepository;
            this.hospitalAdminRepository = hospitalAdminRepository;
            this.hospitalRepository = hospitalRepository;
            this.mapper = mapper;
        }

        public async Task<DoctorInfoDTO> GetDoctorInfoAsync(string id)
        {
            var doctor = await doctorRepository.GetByIdAsync(id);
            var hospital = await hospitalRepository.GetByIdAsync(doctor.HospitalId);
            return new DoctorInfoDTO
            {
                Email = doctor.User.Email,
                FirstName = doctor.User.FirstName,
                LastName = doctor.User.LastName,
                HospitaName = hospital.Name,
                Position = doctor.Position,
                OnHoliday = doctor.OnHoliday ? 1 : 0,
                Blocked = doctor.User.Blocked ? 1 : 0
            };
        }

        public async Task<DoctorInfoDTO> GetDoctorInfoByEmailAsync(string email)
        {
            var doctor = (await doctorRepository
                .Find(doc => doc.User.Email.Equals(email))).First();
            return await GetDoctorInfoAsync(doctor.UserId); 
        }

        public IEnumerable<PatientsInfoDTO> GetDoctorPatientsByEmailAsync(string email)
        {
            var patients = doctorPatientRepository.GetDoctorPatientsByEmail(email)
                .Select(p => new PatientsInfoDTO
                {
                    Id = p.UserId,
                    Email = p.User.Email,
                    FirstName = p.User.FirstName,
                    LastName = p.User.LastName,
                    BloodType = p.BloodType,
                    Sex = p.Sex
                });
            var pat1 = patients
                .GroupBy(p => p.Id);
            var pat2 = pat1
                .Select(p => p.First());
            return pat2;
        }

        public IEnumerable<string> GetDoctorsEmailsByHospitalId(int id)
        {
            var doctors = doctorRepository.GetDoctors(id)
                .Select(doc => doc.User.Email);
            return doctors;
        }

        public IEnumerable<DoctorInfoDTO> GetDoctorsByHospital(Hospital hospital)
        {
            var doctors = doctorRepository.GetDoctors(hospital.Id)
                .Select(doc => new DoctorInfoDTO
                {
                    Email = doc.User.Email,
                    FirstName = doc.User.FirstName,
                    LastName = doc.User.LastName,
                    HospitaName = hospital.Name,
                    Position = doc.Position,
                    OnHoliday = doc.OnHoliday ? 1 : 0,
                    Blocked = doc.User.Blocked ? 1 : 0
                });
            return doctors;
        }

        public IEnumerable<DoctorInfoDTO> GetDoctorsByHospitalAdminId(string id)
        {
            var hospital = hospitalAdminRepository.GetHospitalByHospitalAdminId(id);
            var doctors = GetDoctorsByHospital(hospital);
            return doctors;
        }

        public async Task<ScheduleInfoDTO> GetScheduleByEmailAsync(string email)
        {
            var doctor = await doctorRepository.GetByEmailAsync(email);
            var schedule = await scheduleRepository.Find(
                sched => sched.Id == doctor.ScheduleId);
            return mapper.Map<ScheduleInfoDTO>(schedule.First());
        }

        public async Task AddAppointment(AppointmentCreationDTO appointmentDto)
        {
            Appointment appointment = new Appointment
            {
                DateTimeAppointment = appointmentDto.DateTimeAppointment
            };
            await appointmentRepository.AddAsync(appointment);
            await appointmentRepository.SaveChangesAsync();

            var patientId = userRepository.FindByEmailAsync(appointmentDto.PatientEmail).Result.Id;
            var doctorId = userRepository.FindByEmailAsync(appointmentDto.DoctorEmail).Result.Id;

            await doctorPatientRepository.AddAsync(new DoctorPatient
            {
                DoctorId = doctorId,
                PatientId = patientId,
                AppointmentId = appointment.Id
            });
            await doctorPatientRepository.SaveChangesAsync();
        }

        public async Task AddSkinInfoToAppointment(SkinInfoDTO skinInfoDto)
        {
            Appointment appointment = await appointmentRepository.GetByIdAsync(skinInfoDto.AppointmentId);

            appointment.SkinType = skinInfoDto.SkinType;
            appointment.Elasticity = skinInfoDto.Elasticity;
            appointment.PHlevel = skinInfoDto.PHlevel;
            appointment.LevelOfMoisture = skinInfoDto.LevelOfMoisture;
            appointment.SkinColor = skinInfoDto.SkinColor;

            appointmentRepository.Update(appointment);
            await appointmentRepository.SaveChangesAsync();
        }

        public async Task AddPrescriptionToAppointment(PrescriptionDTO prescriptionDto)
        {
            Appointment appointment = await appointmentRepository.GetByIdAsync(prescriptionDto.AppointmentId);
            Prescription prescription = mapper.Map<Prescription>(prescriptionDto);

            await prescriptionRepository.AddAsync(prescription);
            await prescriptionRepository.SaveChangesAsync();

            int prId = prescriptionRepository
                .GetAllAsync()
                .Result
                .OrderByDescending(pr => pr.Id)
                .FirstOrDefault()
                .Id;
            appointment.PrescriptionId = prId;

            appointmentRepository.Update(appointment);
            await appointmentRepository.SaveChangesAsync();
        }

        public IEnumerable<AppointmentFutureInfoDTO> GetFutureAppointmentsByDoctorEmail(string email)
        {
            var appointInfo = doctorPatientRepository
                .GetAppointmentsByDoctorEmail(email);
            var tempAppoints = appointInfo
                .Where(ap => ap.Appointment.DateTimeAppointment.CompareTo(DateTimeOffset.Now) > 0)
                .Select(apInfo => new AppointmentFutureInfoDTO
                {
                    Id = (int)apInfo.AppointmentId,
                    DateTimeAppointment = apInfo.Appointment.DateTimeAppointment.ToString("g"),
                    PatientEmail = apInfo.Patient.User.Email,
                    FirstName = apInfo.Patient.User.FirstName,
                    LastName = apInfo.Patient.User.LastName,
                    Canceled = apInfo.Appointment.Canceled ? 1 : 0
                });
            return tempAppoints;
        }

        public async Task UpdateDoctor(DoctorInfoDTO doctor)
        {
            User user = await userRepository.FindByEmailAsync(doctor.Email);
            user.FirstName = doctor.FirstName;
            user.LastName = doctor.LastName;
            await userRepository.UpdateAsync(user);

            Doctor doctorTemp = await doctorRepository.GetByEmailAsync(doctor.Email);
            doctorTemp.Position = doctor.Position;
            doctorRepository.Update(doctorTemp);
            await doctorRepository.SaveChangesAsync();
        }

        public async Task CancelAppointment(int id)
        {
            var appoint = await appointmentRepository.GetByIdAsync(id);
            appoint.Canceled = true;
            appointmentRepository.Update(appoint);
            await appointmentRepository.SaveChangesAsync();
        }

        public IEnumerable<AppointmentInfoDTO> GetLastAppointmentsByPatientId(string id)
        {
            TimeSpan ts = new TimeSpan(-1, 30, 0);
            var appointInfo = doctorPatientRepository.GetAppointmentsInfoForDoctorByPatientId(id);
            if ((appointInfo.Count() == 1 || appointInfo.Count() == 0) && appointInfo.First().Appointment == null)
                return null;
            var appointmentsInfo = appointInfo.Where(ap => ap.Appointment.DateTimeAppointment.Subtract(DateTimeOffset.Now).CompareTo(ts) < 0)
                .Select(apInfo => new AppointmentInfoDTO
                {
                    Id = (int)apInfo.AppointmentId,
                    DateTimeAppointment = apInfo.Appointment.DateTimeAppointment.ToString("g"),
                    SkinType = apInfo.Appointment.SkinType,
                    Elasticity = apInfo.Appointment.Elasticity,
                    PHlevel = apInfo.Appointment.PHlevel.ToString(),
                    LevelOfMoisture = apInfo.Appointment.LevelOfMoisture,
                    SkinColor = apInfo.Appointment.SkinColor,
                    PrescriptionId = (int)apInfo.Appointment.PrescriptionId,
                    Prescription = apInfo.Appointment.Prescription.Description
                });                
            return appointmentsInfo;
        }

        public async Task UpsertPrescriptionByAppointmentId(PrescriptionDTO prescriptionDTO)
        {
            var appointment = await appointmentRepository.GetByIdAsync(prescriptionDTO.AppointmentId);
            if (appointment.PrescriptionId != null)
            {
                Prescription prescription = await prescriptionRepository.GetByIdAsync((int)appointment.PrescriptionId);
                prescription.Description = prescriptionDTO.Description;
                prescriptionRepository.Update(prescription);
                await prescriptionRepository.SaveChangesAsync();
            }
            else
            {
                Prescription prescription = new Prescription { Description = prescriptionDTO.Description };
                await prescriptionRepository.AddAsync(prescription);
                await prescriptionRepository.SaveChangesAsync();
                appointment.PrescriptionId = prescription.Id;
                appointmentRepository.Update(appointment);
                await appointmentRepository.SaveChangesAsync();
            }
        }

        public AppointmentDTO GetNearestAppointment(string doctorId, string patientId)
        {
            TimeSpan ts = new TimeSpan(-1, 30, 0);
            Appointment appointment = doctorPatientRepository.GetAppointments(doctorId, patientId)
                .Where(ap => ap.DateTimeAppointment.Subtract(DateTimeOffset.Now).CompareTo(ts) > 0)
                .FirstOrDefault();
            return mapper.Map<AppointmentDTO>(appointment);
        }

        public IEnumerable<string> GetPatientsEmailsByDoctorId(string id)
        {
            IEnumerable<string> patEms = doctorPatientRepository.GetDoctorPatientsById(id)
                .Select(dp => dp.User.Email)
                .Distinct();
            return patEms;
        }

        public async Task<IEnumerable<FreeDateTimesDTO>> GetFreeDateTimesByDoctorEmail(string email)
        {
            var schedId = doctorRepository.GetByEmailAsync(email).Result.ScheduleId;
            Schedule schedule = await scheduleRepository.GetByIdAsync((int)schedId);
            TimeSpan startTime = TimeSpan.Parse(schedule.StartTime.ToString("t"));
            TimeSpan endTime = TimeSpan.Parse(schedule.EndTime.ToString("t"));

            var appointments = GetFutureAppointmentsByDoctorEmail(email).Select(dt => dt.DateTimeAppointment).ToArray();

            //IDictionary<string, string[]> busyDateTime = new Dictionary<string, string[]>();
            IDictionary<string, IList<string>> busyDateTime = new Dictionary<string, IList<string>>();
            foreach (var appoint in appointments)
            {
                string date = appoint.Split(' ')[0];
                string time = appoint.Split(' ')[1];
                if (!busyDateTime.ContainsKey(date))
                    busyDateTime.Add(date, new List<string>());
                busyDateTime[date].Add(time);
            }

            //IDictionary<string, string[]> allDateTime = new Dictionary<string, string[]>();
            IDictionary<string, IList<string>> allDateTime = new Dictionary<string, IList<string>>();
            DateTimeOffset dateTimeNow = DateTimeOffset.Now;

            for (int i = 0; i < 7; i++)
            {
                string date = dateTimeNow.ToString("d");
                string time = dateTimeNow.ToString("t");
                allDateTime.Add(date, new List<string>());
                TimeSpan tempStart = startTime;
                while (tempStart.CompareTo(endTime) < 0)
                {
                    if (tempStart.CompareTo(TimeSpan.Parse(time)) < 0 && i == 0)
                    {
                        tempStart = tempStart.Add(new TimeSpan(2, 0, 0));
                        continue;
                    }
                    allDateTime[date].Add(DateTimeOffset.Parse(tempStart.ToString()).ToString("t"));
                    tempStart = tempStart.Add(new TimeSpan(2, 0, 0));
                }
                dateTimeNow = dateTimeNow.AddDays(1);
            }

            //IDictionary<string, string[]> freeDateTime = new Dictionary<string, string[]>();
            IDictionary<string, IList<string>> freeDateTime = new Dictionary<string, IList<string>>();

            foreach (var dateTimeAll in allDateTime)
            {
                string key = dateTimeAll.Key;
                freeDateTime.Add(key, new List<string>());
                if (busyDateTime.ContainsKey(key))
                    freeDateTime[key] = dateTimeAll.Value.Except(busyDateTime[key]).ToList();
                else
                    freeDateTime[key] = dateTimeAll.Value.ToList();
            }

            var result = freeDateTime.Select(dt => new FreeDateTimesDTO
            {
                Date = dt.Key,
                Times = dt.Value
            });

            return result;
        }
    }
}
