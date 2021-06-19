using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TreatLines_v1.BLL.DTOs.HospitalCreate;

namespace TreatLines_v1.BLL.Interfaces
{
    public interface IHospitalRegistrationRequestsService
    {
        Task<HospitalCreationResultDTO> CreateHospitalAsync(RequestToCreateHospitalViewDTO createRequestDTO);
        Task AddRequestAsync(RequestToCreateHospitalDTO creationInfo);
        Task<IEnumerable<RequestToCreateHospitalViewDTO>> GetAllRequestsAsync();
        Task ApproveRequestAsync(int id);
        Task RejectRequestAsync(int id);
    }
}
