using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreatLines_v1.DAL.Entities;
using TreatLines_v1.DAL.Interfaces;

namespace TreatLines_v1.DAL.Repositories
{
    public class HospitalRepository : Repository<Hospital>, IHospitalRepository
    {
        private readonly IMapper mapper;
        public HospitalRepository(DbContext context,
            IMapper mapper) : base(context)
        {
            this.mapper = mapper;
        }

        public Task<bool> HasHospitalAdminAsync(int hospitalId, string userName)
        {
            return context.Set<HospitalAdmin>()
                .AnyAsync(hadmin => hadmin.HospitalId == hospitalId && hadmin.User.UserName == userName);
        }

        public Task<bool> HasDoctorAsync(int hospitalId, string userName)
        {
            return context.Set<Doctor>()
                .AnyAsync(doc => doc.HospitalId == hospitalId && doc.User.UserName == userName);
        }

        public Task<bool> HasPatientAsync(int hospitalId, string userName)
        {
            return context.Set<DoctorPatient>()
                .AnyAsync(docP => docP.Doctor.HospitalId == hospitalId && docP.Patient.User.UserName == userName);
        }        
    }
}
