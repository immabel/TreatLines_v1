using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using TreatLines_v1.DAL.Configurations;
using TreatLines_v1.DAL.Entities;

namespace TreatLines_v1.DAL
{
    public class TLinesDbContext : IdentityDbContext<User>
    {
        public TLinesDbContext(DbContextOptions<TLinesDbContext> options)
            : base(options)
        { }
        //public DbSet<User> Users { get; set; }
        public DbSet<HospitalAdmin> HospitalAdmins { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Dialog> Dialogs { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<DoctorPatient> DoctorPatients { get; set; }
        public DbSet<RequestToCreate> RequestsToCreate { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new HospitalAdminConfiguration());
            modelBuilder.ApplyConfiguration(new HospitalConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            modelBuilder.ApplyConfiguration(new ScheduleConfiguration());
            modelBuilder.ApplyConfiguration(new DeviceConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new DialogConfiguration());
            modelBuilder.ApplyConfiguration(new MessageConfiguration());
            modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
            modelBuilder.ApplyConfiguration(new PrescriptionConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorPatientConfiguration());
            modelBuilder.ApplyConfiguration(new RequestToCreateConfiguration());

            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
