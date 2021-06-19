using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TreatLines_v1.BLL.DTOs.Schedule;
using TreatLines_v1.BLL.Interfaces;
using TreatLines_v1.DAL.Entities;
using TreatLines_v1.DAL.Interfaces;

namespace TreatLines_v1.BLL.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly IRepository<Schedule> scheduleRepository;

        IMapper mapper;

        public ScheduleService(
            IRepository<Schedule> scheduleRepository,
            IMapper mapper)
        {
            this.scheduleRepository = scheduleRepository;
            this.mapper = mapper;
        }

        public async Task<ScheduleInfoDTO> GetScheduleByIdAsync(int scheduleId)
        {
            var schedule = await scheduleRepository.GetByIdAsync(scheduleId);
            return mapper.Map<ScheduleInfoDTO>(schedule);
        }

        public async Task<IEnumerable<ScheduleInfoDTO>> GetSchedules(int hospitalId)
        {
            var schedules = await scheduleRepository.Find(sched => sched.Doctors.Exists(doc => doc.HospitalId == hospitalId));
            return mapper.Map<IEnumerable<ScheduleInfoDTO>>(schedules);
        }

        public async Task<int> AddScheduleAsync(ScheduleDTO scheduleDto)
        {
            var schedule = mapper.Map<Schedule>(scheduleDto);
            await scheduleRepository.AddAsync(schedule);
            await scheduleRepository.SaveChangesAsync();
            return schedule.Id;
        }

        public async Task UpdateSchedule(ScheduleInfoDTO scheduleDto)
        {
            Schedule schedule = await scheduleRepository.GetByIdAsync(scheduleDto.Id);
            schedule.StartTime = DateTimeOffset.Parse(scheduleDto.StartTime);
            schedule.EndTime = DateTimeOffset.Parse(scheduleDto.EndTime);
            schedule.WorkDays = scheduleDto.WorkDays;
            scheduleRepository.Update(schedule);
            await scheduleRepository.SaveChangesAsync();
        }
    }
}
