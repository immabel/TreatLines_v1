using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreatLines_v1.BLL.DTOs.Appointment;
using TreatLines_v1.BLL.DTOs.Doctor;
using TreatLines_v1.BLL.DTOs.Patient;
using TreatLines_v1.BLL.Interfaces;

namespace TreatLines_v1.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : Controller
    {
        private readonly IDoctorService doctorService;

        private readonly IPatientService patientService;

        private readonly IMapper mapper;

        public PatientController(
            IDoctorService doctorService,
            IPatientService patientService,
            IMapper mapper)
        {
            this.doctorService = doctorService;
            this.patientService = patientService;
            this.mapper = mapper;
        }

        [HttpGet("doctors/{id}"), AllowAnonymous]
        public IActionResult GetDoctorsByPatientId(string id)
        {
            IEnumerable<DoctorInfoDTO> doctors = patientService.GetPatientDoctorsAsync(id);
            return Ok(doctors);
        }

        [HttpGet("patientInfo/{id}"), AllowAnonymous]
        public async Task<IActionResult> GetPatientInfoById(string id)
        {
            PatientInfoDTO patient = await patientService.GetPatientInfoAsync(id);
            return Ok(patient);
        }

        [HttpGet("getFutureAppointments/{id}"), AllowAnonymous]
        public IActionResult GetFutureAppointments(string id)
        {
            IEnumerable<AppointmentsPatientFutureInfoDTO> appointments = patientService.GetFutureAppointmentsByPatientId(id);
            return Ok(appointments);
        }

        [HttpGet("getPastAppointmentsInfo/{id}"), AllowAnonymous]
        public IActionResult GetPastAppointments(string id)
        {
            IEnumerable<PastAppointmentsPatientInfoDTO> appointments = patientService.GetPastAppointmentsByPatientId(id);
            return Ok(appointments);
        }

        [HttpGet("getDoctorFreeDateTime/{email}"), AllowAnonymous]
        public async Task<IActionResult> GetDoctorFreeDateTime(string email)
        {
            IEnumerable<FreeDateTimesDTO> freeDT = await doctorService.GetFreeDateTimesByDoctorEmail(email);
            return Ok(freeDT);
        }
    }
}
