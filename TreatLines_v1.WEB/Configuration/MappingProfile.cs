using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreatLines_v1.BLL.DTOs.Appointment;
using TreatLines_v1.BLL.DTOs.Auth;
using TreatLines_v1.BLL.DTOs.Doctor;
using TreatLines_v1.BLL.DTOs.Hospital;
using TreatLines_v1.BLL.DTOs.HospitalAdmin;
using TreatLines_v1.BLL.DTOs.HospitalCreate;
using TreatLines_v1.BLL.DTOs.Patient;
using TreatLines_v1.BLL.DTOs.Prescription;
using TreatLines_v1.BLL.DTOs.Schedule;
using TreatLines_v1.DAL.Entities;
using TreatLines_v1.WEB.Models.Requests;
using TreatLines_v1.WEB.Models.Requests.HospitalCreation;
using TreatLines_v1.WEB.Models.Requests.Users;
using TreatLines_v1.WEB.Models.Responses.HospitalCreation;
using TreatLines_v1.WEB.Models.Responses.Users;

namespace TreatLines_v1.WEB.Configuration
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<HospitalAdminRegistrationRequest, HospitalAdminRegistrationDTO>();
            CreateMap<DoctorRegistrationRequest, DoctorRegistrationDTO>()
                .ForMember(
                dest => dest.OnHoliday,
                opt => opt.MapFrom(src => src.OnHoliday == 1 ? true : false))
                .ForMember(
                dest => dest.StartTime,
                opt => opt.MapFrom(src => DateTimeOffset.Parse(src.StartTime)))
                .ForMember(
                dest => dest.EndTime,
                opt => opt.MapFrom(src => DateTimeOffset.Parse(src.EndTime)));
            CreateMap<PatientRegistrationRequest, PatientRegistrationDTO>();
            CreateMap<UpsertPrescriptionRequest, PrescriptionDTO>();
            CreateMap<ScheduleCreationRequest, ScheduleDTO>()
                .ForMember(
                dest => dest.StartTime,
                opt => opt.MapFrom(src => DateTimeOffset.Parse(src.StartTime)))
                .ForMember(
                dest => dest.EndTime,
                opt => opt.MapFrom(src => DateTimeOffset.Parse(src.EndTime)));
            CreateMap<AppointmentCreationRequest, AppointmentCreationDTO>()
                .ForMember(
                dest => dest.DateTimeAppointment,
                opt => opt.MapFrom(src => DateTimeOffset.Parse(src.DateTimeAppointment)));

            CreateMap<RequestToCreateHospitalRequest, RequestToCreateHospitalDTO>();
            CreateMap<RequestToCreateHospitalDTO, RequestToCreate>();
            CreateMap<RequestToCreate, RequestToCreateHospitalViewDTO>();
            CreateMap<RequestToCreateHospitalViewDTO, RequestToCreateHospitalModel>()
                .ForMember(
                dest => dest.DateOfCreation,
                opt => opt.MapFrom(src => src.DateOfCreation.ToString("g")));

            //CreateMap<HospitalInfoDTO, HospitalInfoModel>();

            CreateMap<Hospital, HospitalInfoDTO>();
            //CreateMap<User, HospitalAdminInfoDTO>();
            //CreateMap<Doctor, DoctorInfoDTO>();
            CreateMap<User, DoctorInfoDTO>();
            CreateMap<Appointment, AppointmentInfoDTO>();
            CreateMap<Appointment, AppointmentDTO>()
                .ForMember(
                dest => dest.Canceled,
                opt => opt.MapFrom(src => src.Canceled ? 1 : 0))
                .ForMember(
                dest => dest.DateTimeAppointment,
                opt => opt.MapFrom(src => src.DateTimeAppointment.ToString("g")));
            CreateMap<Patient, PatientInfoDTO>()
                .ForMember(
                dest => dest.Id,
                opt => opt.MapFrom(src => src.UserId))
                .ForMember(
                dest => dest.FirstName,
                opt => opt.MapFrom(src => src.User.FirstName))
                .ForMember(
                dest => dest.LastName,
                opt => opt.MapFrom(src => src.User.LastName))
                .ForMember(
                dest => dest.Email,
                opt => opt.MapFrom(src => src.User.Email));
            CreateMap<ScheduleDTO, Schedule>();
            CreateMap<Schedule, ScheduleInfoDTO>()
                .ForMember(
                dest => dest.StartTime,
                opt => opt.MapFrom(src => src.StartTime.ToString("HH:mm")))
                .ForMember(
                dest => dest.EndTime,
                opt => opt.MapFrom(src => src.EndTime.ToString("HH:mm")));
            CreateMap<PrescriptionDTO, Prescription>();
            
            CreateMap<User, PatientResponse>();
            CreateMap<LoginResponseDTO, LoginResponse>()
                .ForMember(
                dest => dest.AccessToken,
                opt => opt.MapFrom(src => "Bearer " + src.Token));
        }
    }
}
