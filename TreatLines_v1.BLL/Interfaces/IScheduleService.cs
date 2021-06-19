using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TreatLines_v1.BLL.DTOs.Schedule;

namespace TreatLines_v1.BLL.Interfaces
{
    public interface IScheduleService
    {
        Task<ScheduleInfoDTO> GetScheduleByIdAsync(int scheduleId);
        Task<IEnumerable<ScheduleInfoDTO>> GetSchedules(int hospitalId);
        Task<int> AddScheduleAsync(ScheduleDTO scheduleDto);
        Task UpdateSchedule(ScheduleInfoDTO scheduleDto);
    }
}
