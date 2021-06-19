﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreatLines_v1.DAL.Entities;
using TreatLines_v1.DAL.Interfaces;

namespace TreatLines_v1.DAL.Repositories
{
    public class DoctorPatientRepository : Repository<DoctorPatient>, IDoctorPatientRepository
    {
        public DoctorPatientRepository(DbContext context) : base(context)
        { }

        public IEnumerable<Patient> GetDoctorPatientsById(string doctorId)
        {
            /*IEnumerable<Patient> docP = context.Set<DoctorPatient>()
                .Include(dp => dp.Patient.User)
                .Where(dp => dp.DoctorId.Equals(doctorId))
                .Select(dp => dp.Patient)
                .GroupBy(p => p.UserId)
                .Select(p => new Patient
                {
                    UserId = p.Key,
                    User = p.First().User,
                    BloodType = p.First().BloodType,
                    HospitalId = p.First().HospitalId,
                    Sex = p.First().Sex,
                })
                .AsNoTracking()
                .ToArray();*/
            return context.Set<DoctorPatient>()
                .Include(dp => dp.Patient.User)
                .Where(dp => dp.DoctorId.Equals(doctorId))
                .Select(dp => dp.Patient)
                .AsNoTracking()
                .ToArray();
        }

        public IEnumerable<Patient> GetDoctorPatientsByEmail(string email)
        {
            return context.Set<DoctorPatient>()
                .Include(dp => dp.Patient.User)
                .Where(dp => dp.Doctor.User.Email.Equals(email))
                .Select(dp => dp.Patient)
                .AsNoTracking()
                .ToArray();
        }

        public IEnumerable<Doctor> GetPatientDoctors(string patientId)
        {
            return context.Set<DoctorPatient>()
                .Include(dp => dp.Doctor.User)
                .Where(dp => dp.PatientId.Equals(patientId))
                .Select(dp => dp.Doctor)
                .AsNoTracking()
                .ToArray();
        }

        public IEnumerable<DoctorPatient> GetAppointmentsByDoctorEmail(string email)
        {
            return context.Set<DoctorPatient>()
                .Include(dp => dp.Patient.User)
                .Include(dp => dp.Doctor.User)
                .Include(dp => dp.Appointment)
                .Where(dp => dp.Doctor.User.Email.Equals(email))
                .AsNoTracking()
                .ToArray();
        }

        public IEnumerable<DoctorPatient> GetAppointmentsByPatientId(string id)
        {
            return context.Set<DoctorPatient>()
                .Include(dp => dp.Patient.User)
                .Include(dp => dp.Doctor.User)
                .Include(dp => dp.Appointment)
                .Include(dp => dp.Appointment.Prescription)
                .Where(dp => dp.Patient.UserId.Equals(id))
                .AsNoTracking()
                .ToArray();
        }

        public IEnumerable<DoctorPatient> GetAppointmentsInfoForDoctorByPatientId(string id)
        {
            return context.Set<DoctorPatient>()
                .Include(dp => dp.Appointment)
                .Include(dp => dp.Appointment.Prescription)
                .Where(dp => dp.PatientId.Equals(id))
                .AsNoTracking()
                .ToArray();
        }

        public IEnumerable<Appointment> GetAppointments(string docId, string patId)
        {
            return context.Set<DoctorPatient>()
                .Include(dp => dp.Appointment)
                .Where(dp => dp.DoctorId.Equals(docId) && dp.PatientId.Equals(patId))
                .Select(dp => dp.Appointment)
                .AsNoTracking()
                .ToArray();
        }
    }
}
