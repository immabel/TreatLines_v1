using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreatLines_v1.BLL.DTOs.Appointment;
using TreatLines_v1.BLL.DTOs.Patient;
using TreatLines_v1.BLL.DTOs.Prescription;
using TreatLines_v1.BLL.Interfaces;
using TreatLines_v1.WEB.Models.Requests;

namespace TreatLines_v1.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : Controller
    {
        private readonly IDoctorService doctorService;

        private readonly IMapper mapper;

        public DoctorController(
            IDoctorService doctorService,
            IMapper mapper)
        {
            this.doctorService = doctorService;
            this.mapper = mapper;
        }

        //[HttpGet("patients"), Authorize(Roles = "Admin, HospitalAdmin, Doctor")]
        [HttpGet("patients/{email}"), AllowAnonymous]
        public IActionResult GetPatients(string email)
        {
            IEnumerable<PatientsInfoDTO> patients = doctorService.GetDoctorPatientsByEmailAsync(email);
            return Ok(patients);
        }


        //[HttpPost("addAppointment"), Authorize(Roles = "HospitalAdmin, Doctor")]
        [HttpPost("addAppointment"), AllowAnonymous]
        public async Task<ActionResult> AddAppointment(AppointmentCreationRequest request)
        {
            //var dto = mapper.Map<AppointmentCreationDTO>(request);
            request.DateTimeAppointment = request.DateTimeAppointment.Replace('T', ' ');
            DateTimeOffset dt = DateTimeOffset.Parse(request.DateTimeAppointment);
            var dto = new AppointmentCreationDTO
            {
                PatientEmail = request.PatientEmail,
                DoctorEmail = request.DoctorEmail,
                DateTimeAppointment = dt
            };
            await doctorService.AddAppointment(dto);
            return Ok();
        }

        /*[HttpPost("addSkinInfo"), Authorize(Roles = "HospitalAdmin, Doctor")]
        public async Task<ActionResult> AddSkinInfo(SkinInfoAddingRequest request)
        {
            var dto = mapper.Map<SkinInfoDTO>(request);
            await doctorService.AddSkinInfoToAppointment(dto);
            return Ok();
        }*/

        //[HttpGet("getAppointments/{email}"), Authorize(Roles = "HospitalAdmin, Doctor")]
        [HttpGet("getAppointments/{email}"), AllowAnonymous]
        public IActionResult GetAppointments(string email)
        {
            IEnumerable<AppointmentFutureInfoDTO> appointments = doctorService.GetFutureAppointmentsByDoctorEmail(email);
            return Ok(appointments);
        }

        //[HttpPost("cancelAppointment"), Authorize(Roles = "HospitalAdmin, Doctor")]
        [HttpPost("cancelAppointment/{id}"), AllowAnonymous]
        public async Task<ActionResult> CancelAppointment(int id)
        {
            await doctorService.CancelAppointment(id);
            return Ok();
        }

        [HttpGet("getLastAppointmentsForPatient/{id}"), AllowAnonymous]
        public IActionResult GetLastAppointmentsByPatientId(string id)
        {
            IEnumerable<AppointmentInfoDTO> appointments = doctorService.GetLastAppointmentsByPatientId(id);
            return Ok(appointments);
        }

        [HttpGet("getNearestAppointment/{docId}&&{patId}"), AllowAnonymous]
        public IActionResult GetNearestAppointmentByPatient(string docId, string patId)
        {
            AppointmentDTO appointment = doctorService.GetNearestAppointment(docId, patId);
            return Ok(appointment);
        }

        [HttpPost("upsertPrescription"), AllowAnonymous]
        public async Task<IActionResult> UpsertPrescriptionByAppointmentValue([FromBody] UpsertPrescriptionRequest request)
        {
            PrescriptionDTO dto = mapper.Map<PrescriptionDTO>(request);
            await doctorService.UpsertPrescriptionByAppointmentId(dto);
            return Ok();
        }

        [HttpGet("getPatientsEmails/{id}"), AllowAnonymous]
        public IActionResult GetPatientsEmails(string id)
        {
            IEnumerable<string> patientsEmails = doctorService.GetPatientsEmailsByDoctorId(id);
            return Ok(patientsEmails);
        }
    }
}
