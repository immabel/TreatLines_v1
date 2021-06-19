using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TreatLines_v1.DAL.Entities;

namespace TreatLines_v1.DAL.Interfaces
{
    public interface IAppointmentRepository : IRepository<Appointment>
    {
        Task<bool> DeleteAppointmenteByIdAsync(int appointmentId);
    }
}
