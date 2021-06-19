using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TreatLines_v1.BLL.DTOs.Auth;
using TreatLines_v1.BLL.DTOs.HospitalCreate;
using TreatLines_v1.BLL.Exceptions;
using TreatLines_v1.BLL.Interfaces;
using TreatLines_v1.DAL.Entities;
using TreatLines_v1.DAL.Interfaces;

namespace TreatLines_v1.BLL.Services
{
    public class HospitalRegistrationRequestsService : IHospitalRegistrationRequestsService
    {
        private readonly IHospitalRepository hospitalRepository;

        private readonly IAuthService authService;

        private readonly IRepository<RequestToCreate> requestsRepository;

        private readonly IMailService mailService;

        private readonly IMapper mapper;

        public HospitalRegistrationRequestsService(
            IRepository<RequestToCreate> requestsRepository,
            IMailService emailService,
            IMapper mapper,
            IHospitalRepository hospitalRepository,
            IAuthService authService)
        {
            this.hospitalRepository = hospitalRepository;
            this.authService = authService;
            this.requestsRepository = requestsRepository;
            this.mailService = emailService;
            this.mapper = mapper;
        }

        public async Task<HospitalCreationResultDTO> CreateHospitalAsync(RequestToCreateHospitalViewDTO createRequestDTO)
        {
            var hospital = new Hospital
            {
                Name = createRequestDTO.HospitalName,
                Address = createRequestDTO.Address,
                Country = createRequestDTO.Country
            };
            await hospitalRepository.AddAsync(hospital);
            await hospitalRepository.SaveChangesAsync();

            HospitalAdminRegistrationDTO adminRegisterRequest = new HospitalAdminRegistrationDTO
            {
                FirstName = createRequestDTO.SubmitterFirstName,
                LastName = createRequestDTO.SubmitterLastName,
                Email = createRequestDTO.Email,
                Password = "Qwerty12345",
                HospitalId = hospital.Id
            };
            await authService.RegisterHospitalAdminAsync(adminRegisterRequest);

            return new HospitalCreationResultDTO
            {
                HospitalId = hospital.Id,
                HospitalName = hospital.Name,
                AdminEmail = adminRegisterRequest.Email,
                AdminPassword = adminRegisterRequest.Password
            };
        }

        public async Task AddRequestAsync(RequestToCreateHospitalDTO creationInfo)
        {
            RequestToCreate createRequest = mapper.Map<RequestToCreate>(creationInfo);
            createRequest.DateOfCreation = DateTime.Now;
            await requestsRepository.AddAsync(createRequest);
            await requestsRepository.SaveChangesAsync();
        }

        public async Task ApproveRequestAsync(int id)
        {
            RequestToCreate request = await requestsRepository.GetByIdAsync(id);
            if (request == null)
            {
                throw new BadRequestException("Creation request doesn't exist!");
            }

            RequestToCreateHospitalViewDTO registerDto = mapper.Map<RequestToCreateHospitalViewDTO>(request);
            HospitalCreationResultDTO result = await CreateHospitalAsync(registerDto);

            // TODO: load html letter template and fill it in
            await mailService.SendAsync(
                receiver: result.AdminEmail,
                subject: $"{result.HospitalName} registration",
                bodyHtml: "Your hospital is registered! Use these credentials to sign in to the system:" +
                          $"<br>Email: {result.AdminEmail}<br>Password: {result.AdminPassword}");

            requestsRepository.Remove(request);
            await requestsRepository.SaveChangesAsync();
        }

        public async Task RejectRequestAsync(int id)
        {
            RequestToCreate request = await requestsRepository.GetByIdAsync(id);
            if (request == null)
            {
                throw new BadRequestException("Creation request doesn't exist!");
            }

            // TODO: Load email HTML template from file and fill it in
            await mailService.SendAsync(
                request.Email,
                "Your request has been denied",
                $"{request.HospitalName} won't be registered");

            requestsRepository.Remove(request);
            await requestsRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<RequestToCreateHospitalViewDTO>> GetAllRequestsAsync()
        {
            IEnumerable<RequestToCreate> requests = await requestsRepository.Find(_ => true);
            return mapper.Map<IEnumerable<RequestToCreateHospitalViewDTO>>(requests);
        }
    }
}
