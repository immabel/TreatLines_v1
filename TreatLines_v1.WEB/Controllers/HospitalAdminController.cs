using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreatLines_v1.BLL.DTOs.Doctor;
using TreatLines_v1.BLL.DTOs.Hospital;
using TreatLines_v1.BLL.DTOs.HospitalAdmin;
using TreatLines_v1.BLL.DTOs.Patient;
using TreatLines_v1.BLL.DTOs.Schedule;
using TreatLines_v1.BLL.Interfaces;
using TreatLines_v1.WEB.Models.Requests;
using TreatLines_v1.WEB.Models.Responses.Users;

namespace TreatLines_v1.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalAdminController : Controller
    {
        private readonly IHospitalService hospitalService;

        private readonly IDoctorService doctorService;

        private readonly IPatientService patientService;

        private readonly IScheduleService scheduleService;

        private readonly IMapper mapper;

        public HospitalAdminController(
            IHospitalService hospitalService,
            IScheduleService scheduleService,
            IDoctorService doctorService,
            IPatientService patientService,
            IMapper mapper)
        {
            this.hospitalService = hospitalService;
            this.scheduleService = scheduleService;
            this.doctorService = doctorService;
            this.patientService = patientService;
            this.mapper = mapper;
        }

        //[HttpGet("hospitalAdmins/{hospitalId}"), Authorize(Roles = "Admin, HospitalAdmin")]
        [HttpGet("hospitalAdmins/{id}"), AllowAnonymous]
        public ActionResult<IEnumerable<HospitalAdminInfoDTO>> GetHospitalAdminsById(string id)
        {
            IEnumerable<HospitalAdminInfoDTO> hospitalAdmins = hospitalService.GetHospitalAdminsById(id);
            return Ok(hospitalAdmins);
        }

        //[HttpPost("addSchedule"), Authorize(Roles = "HospitalAdmin")]
        [HttpPost("addSchedule"), AllowAnonymous]
        public async Task<ActionResult> AddSchedule(ScheduleCreationRequest request)
        {
            var dto = mapper.Map<ScheduleDTO>(request);
            await scheduleService.AddScheduleAsync(dto);
            return Ok();
        }

        //[HttpGet("schedule"), Authorize(Roles = "HospitalAdmin, Doctor, Patient")]
        [HttpGet("getSchedule/{email}"), AllowAnonymous]
        public async Task<IActionResult> GetScheduleByDoctorEmail(string email)
        {
            ScheduleInfoDTO schedule = await doctorService.GetScheduleByEmailAsync(email);
            return Ok(schedule);
        }

        //[HttpGet("schedule"), Authorize(Roles = "HospitalAdmin, Doctor, Patient")]
        [HttpPost("updateSchedule"), AllowAnonymous]
        public async Task<ActionResult> UpdateScheduleById([FromBody]ScheduleInfoDTO schedule)
        {
            await scheduleService.UpdateSchedule(schedule);
            return Ok();
        }

        //[HttpGet("schedule"), Authorize(Roles = "HospitalAdmin, Doctor, Patient")]
        [HttpPost("updateDoctor"), AllowAnonymous]
        public async Task<ActionResult> UpdateDoctor([FromBody]DoctorInfoDTO doctor)
        {
            await doctorService.UpdateDoctor(doctor);
            return Ok();
        }

        //[HttpGet("schedule"), Authorize(Roles = "HospitalAdmin, Doctor, Patient")]
        [HttpPost("updatePatient"), AllowAnonymous]
        public async Task<ActionResult> UpdatePatient([FromBody]PatientInfoDTO patient)
        {
            await patientService.UpdatePatient(patient);
            return Ok();
        }

        //[HttpGet("doctors"), AllowAnonymous]
        [HttpGet("doctors/{id}"), AllowAnonymous]
        public IActionResult GetDoctorsByHospitalAdminId(string id)
        {
            IEnumerable<DoctorInfoDTO> doctors = doctorService.GetDoctorsByHospitalAdminId(id);
            return Ok(doctors);
        }

        [HttpGet("doctorsEmails/{id}"), AllowAnonymous]
        public IActionResult GetDoctorsEmailsByHospitalId(int id)
        {
            IEnumerable<string> doctors = doctorService.GetDoctorsEmailsByHospitalId(id);
            return Ok(doctors);
        }

        [HttpGet("patients/{id}"), AllowAnonymous]
        public IActionResult GetPatientsByHospitalAdminId(string id)
        {
            IEnumerable<PatientsInfoDTO> patients = patientService.GetPatientsByHospitalAdminId(id);
            return Ok(patients);
        }

        [HttpGet("doctor/{email}"), AllowAnonymous]
        public async Task<IActionResult> GetDoctorInfoByEmail(string email)
        {
            DoctorInfoDTO doctor = await doctorService.GetDoctorInfoByEmailAsync(email);
            return Ok(doctor);
        }
    }
}
