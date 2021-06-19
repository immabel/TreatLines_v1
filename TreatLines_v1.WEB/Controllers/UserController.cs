using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreatLines_v1.BLL.DTOs.Auth;
using TreatLines_v1.BLL.DTOs.HospitalCreate;
using TreatLines_v1.BLL.Exceptions;
using TreatLines_v1.BLL.Interfaces;
using TreatLines_v1.WEB.Extensions;
using TreatLines_v1.WEB.Models.Requests.HospitalCreation;
using TreatLines_v1.WEB.Models.Requests.Users;
using TreatLines_v1.WEB.Models.Responses.Users;

namespace TreatLines_v1.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAuthService authService;

        private readonly IHospitalRegistrationRequestsService hospitalRegistrationRequestsService;

        private readonly IHospitalService hospitalService;

        private readonly IMapper mapper;

        public UserController(
            IAuthService authService,
            IHospitalRegistrationRequestsService hospitalRegistrationRequestsService,
            IHospitalService hospitalService,
            IMapper mapper)
        {
            this.authService = authService;
            this.hospitalRegistrationRequestsService = hospitalRegistrationRequestsService;
            this.hospitalService = hospitalService;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(LoginRequestDTO request)
        {
            var response = await authService.LoginAsync(request);
            if (response != null)
            {
                var result = mapper.Map<LoginResponse>(response);
                return Ok(result);
            }
            else
                return Forbid();
            //else
            //return BadRequest();
        }

        [HttpPost("sendRequest")]
        public async Task<IActionResult> MakeCreationRequestAsync([FromBody] RequestToCreateHospitalRequest request)
        {
            var dto = mapper.Map<RequestToCreateHospitalDTO>(request);
            await hospitalRegistrationRequestsService.AddRequestAsync(dto);
            return Ok();
        }

        //[Authorize(Roles = "Admin, HospitalAdmin")]
        [HttpPost("registerHospitalAdmin")]
        public async Task<ActionResult> RegisterHospitalAdminAsync([FromBody]HospitalAdminRegistrationRequest request)
        {
            /*if (!await User.IsHospitalAdminOrHigherAsync(request.HospitalId, hospitalService))
            {
                throw new ForbiddenException("Don't have rights!");
            }*/

            var dto = mapper.Map<HospitalAdminRegistrationDTO>(request);/*
            var hospitalId = hospitalService.GetHospitalIdByHospitalAdminId(request.HospitalAdminId);
            var dto = new HospitalAdminRegistrationDTO
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Password = request.Password,
                HospitalId = hospitalId
            };*/
            await authService.RegisterHospitalAdminAsync(dto);

            return Ok();
        }

        //[Authorize(Roles = "Admin, HospitalAdmin")]
        [HttpPost("registerDoctor")]
        public async Task<ActionResult> RegisterDoctorAsync([FromBody]DoctorRegistrationRequest request)
        {
            /*if (!await User.IsHospitalAdminOrHigherAsync(request.HospitalId, hospitalService))
            {
                throw new ForbiddenException("Don't have rights!");
            }*/

            var dto = mapper.Map<DoctorRegistrationDTO>(request);
            await authService.RegisterDoctorAsync(dto);

            return Ok();
        }

        //[Authorize(Roles = "Admin, HospitalAdmin, Doctor")]
        [HttpPost("registerPatient")]
        public async Task<ActionResult> RegisterPatientAsync(PatientRegistrationRequest request)
        {
            /*if (!await User.IsHospitalAdminOrHigherAsync(request.HospitalId, hospitalService))
            {
                throw new ForbiddenException("Don't have rights!");
            }*/

            var dto = mapper.Map<PatientRegistrationDTO>(request);
            await authService.RegisterPatientAsync(dto);

            return Ok();
        }
    }
}
