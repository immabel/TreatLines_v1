using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TreatLines_v1.DAL.Entities;
using TreatLines_v1.DAL.Interfaces;

namespace TreatLines_v1.DAL.Repositories
{
    public class AppointmentRepository : Repository<Appointment>, IAppointmentRepository
    {
        private readonly IMapper mapper;
        public AppointmentRepository(
            DbContext context,
            IMapper mapper) : base(context)
        {
            this.mapper = mapper;
        }

        public async Task<bool> DeleteAppointmenteByIdAsync(int appointmentId)
        {
            var appointment = await GetByIdAsync(appointmentId);
            if (appointment == null)
            {
                return false;
            }
            base.Remove(appointment);
            await base.SaveChangesAsync();
            return true;
        }
    }
}
