using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreatLines_v1.BLL.DTOs.Auth;
using TreatLines_v1.BLL.DTOs.Hospital;
using TreatLines_v1.BLL.DTOs.HospitalAdmin;
using TreatLines_v1.BLL.DTOs.HospitalCreate;
using TreatLines_v1.BLL.Exceptions;
using TreatLines_v1.BLL.Interfaces;
using TreatLines_v1.WEB.Extensions;
using TreatLines_v1.WEB.Models.Requests.HospitalCreation;
using TreatLines_v1.WEB.Models.Requests.Users;
using TreatLines_v1.WEB.Models.Responses.HospitalCreation;

namespace TreatLines_v1.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : Controller
    {
        private readonly IHospitalRegistrationRequestsService hospitalRegistrationRequestsService;

        private readonly IHospitalService hospitalService;

        private readonly IMapper mapper;

        public AdminController(
            IHospitalRegistrationRequestsService hospitalRegistrationRequestsService,
            IHospitalService hospitalService,
            IMapper mapper)
        {
            this.hospitalRegistrationRequestsService = hospitalRegistrationRequestsService;
            this.hospitalService = hospitalService;
            this.mapper = mapper;
        }

        [HttpGet("allRequests"), Authorize(Roles = "Admin")]
        //[HttpGet("allRequests"), AllowAnonymous]
        public async Task<ActionResult<IEnumerable<RequestToCreateHospitalModel>>> GetAllRequestsAsync()
        {
            IEnumerable<RequestToCreateHospitalViewDTO> requests = await hospitalRegistrationRequestsService.GetAllRequestsAsync();
            IEnumerable<RequestToCreateHospitalModel> models = mapper.Map<IEnumerable<RequestToCreateHospitalModel>>(requests);
            return Ok(models);
        }

        //[HttpPost("approve"), Authorize(Roles = "Admin")]
        [HttpPost("approve/{id}"), AllowAnonymous]
        public async Task<IActionResult> ApproveRequestAsync(int id)
        {
            await hospitalRegistrationRequestsService.ApproveRequestAsync(id);
            return Ok();
        }

        //[HttpPost("reject"), Authorize(Roles = "Admin")]
        [HttpPost("reject/{id}"), AllowAnonymous]
        public async Task<IActionResult> RejectRequestAsync(int id)
        {
            await hospitalRegistrationRequestsService.RejectRequestAsync(id);
            return Ok();
        }

        //[HttpGet("allHospitals"), Authorize(Roles = "Admin")]
        [HttpGet("allHospitals"), AllowAnonymous]
        public async Task<ActionResult<IEnumerable<HospitalInfoDTO>>> GetAllHospitals()
        {
            IEnumerable<HospitalInfoDTO> hospitals = await hospitalService.GetHospitals();
            //IEnumerable<HospitalInfoModel> models = mapper.Map<IEnumerable<HospitalInfoModel>>(hospitals);
            return Ok(hospitals);
        }

        //[HttpGet("allHospitalAdmins"), Authorize(Roles = "Admin")]
        [HttpGet("allHospitalAdmins"), AllowAnonymous]
        public ActionResult<IEnumerable<HospitalAdminInfoDTO>> GetAllHospitalAdmins()
        {
            IEnumerable<HospitalAdminInfoDTO> hospitalAdmins = hospitalService.GetHospitalAdmins();
            return Ok(hospitalAdmins);
        }

        [HttpPost("blockUser/{email}"), AllowAnonymous]
        public async Task<IActionResult> BlockUser(string email)
        {
            await hospitalService.BlockUser(email);
            return Ok();
        }

        [HttpDelete("deleteUser/{email}"), AllowAnonymous]
        public async Task<IActionResult> DeleteUser(string email)
        {
            await hospitalService.DeleteUser(email);
            return Ok();
        }

        [HttpDelete("deleteHospital/{id}"), AllowAnonymous]
        public async Task<IActionResult> Delete(int id)
        {
            await hospitalService.DeleteHospitalByIdAsync(id);
            return Ok();
        }
    }
}
