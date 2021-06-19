using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TreatLines_v1.DAL.Constants;
using TreatLines_v1.DAL.Entities;

namespace TreatLines_v1.DAL
{
    public static class ModelBuilderExtentions
        {
            private const int HOSPITAL_ID = 1;

            private const string ADMIN_ROLE_ID = "2AEFE1C5-C5F0-4399-8FB8-420813567554";
            private const string HOSPITAL_ADMIN_ROLE_ID = "99DA7670-5471-414F-834E-9B3A6B6C8F6F";
            private const string DOCTOR_ROLE_ID = "828A3B02-77C0-45C1-8E97-6ED57711E577";
            private const string PATIENT_ROLE_ID = "422EEB6A-3031-4B66-ABA8-0F85AFC07C3C";

            private const string ADMIN_USER_ID = "00CA41A9-C962-4230-937E-D5F54772C062";
            private const string HOSPITAL_ADMIN_USER_ID = "BFCC8BAB-AD20-4F70-9CD9-D2003FAE6F09";
            private const string DOCTOR_USER_ID = "E8D13331-62AB-463E-A283-6493B68A3622";
            private const string PATIENT_USER_ID = "E3A6BF34-A57D-4709-97CC-6AD1B2B3985B";

            public static void Seed(this ModelBuilder modelBuilder)
            {
                SeedRoles(modelBuilder);
                SeedHospital(modelBuilder);
                SeedUsers(modelBuilder);
            }

            private static void SeedRoles(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
                {
                    Id = ADMIN_ROLE_ID,
                    Name = Rolename.ADMIN,
                    NormalizedName = Rolename.ADMIN.ToUpper()
                });

                modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
                {
                    Id = HOSPITAL_ADMIN_ROLE_ID,
                    Name = Rolename.HOSPITAL_ADMIN,
                    NormalizedName = Rolename.HOSPITAL_ADMIN.ToUpper()
                });

                modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
                {
                    Id = DOCTOR_ROLE_ID,
                    Name = Rolename.DOCTOR,
                    NormalizedName = Rolename.DOCTOR.ToUpper()
                });

                modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
                {
                    Id = PATIENT_ROLE_ID,
                    Name = Rolename.PATIENT,
                    NormalizedName = Rolename.PATIENT.ToUpper()
                });
            }

            private static void SeedHospital(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Hospital>()
                    .HasData(new Hospital
                    {
                        Id = HOSPITAL_ID,
                        Name = "SeventhSeason",
                        Address = "Petrovna Ave. 2, Kharkiv",
                        Country = "Ukraine",                        
                    });
            }

            private static void SeedUsers(ModelBuilder modelBuilder)
            {
                SeedUser(
                    modelBuilder: modelBuilder,
                    id: ADMIN_USER_ID,
                    firstName: "Admin",
                    lastName: "Adminovich",
                    email: "admin@gmail.com",
                    password: "Qwerty12345",
                    roleId: ADMIN_ROLE_ID);

                SeedUser(
                    modelBuilder: modelBuilder,
                    id: HOSPITAL_ADMIN_USER_ID,
                    firstName: "Katya",
                    lastName: "Zamolodchikova",
                    email: "ssadmin@gmail.com",
                    password: "Qwerty12345",
                    roleId: HOSPITAL_ADMIN_ROLE_ID);

                SeedUser(
                    modelBuilder: modelBuilder,
                    id: DOCTOR_USER_ID,
                    firstName: "Alaska",
                    lastName: "Thunderfuck",
                    email: "alaska.thunderfuck@gmail.com",
                    password: "Qwerty12345",
                    roleId: DOCTOR_ROLE_ID);

                SeedUser(
                    modelBuilder: modelBuilder,
                    id: PATIENT_USER_ID,
                    firstName: "De",
                    lastName: "Tox",
                    email: "de.tox@gmail.com",
                    password: "Qwerty12345",
                    roleId: PATIENT_ROLE_ID);
            }

            private static void SeedUser(
                ModelBuilder modelBuilder,
                string id,
                string firstName,
                string lastName,
                string email,
                string password,
                string roleId)
            {
                modelBuilder.Entity<User>().HasData(new User
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    UserName = email,
                    NormalizedUserName = email,
                    Email = email,
                    NormalizedEmail = email,
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, password)
                });
                modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
                {
                    RoleId = roleId,
                    UserId = id
                });

                switch (roleId)
                {
                    case HOSPITAL_ADMIN_ROLE_ID:
                        modelBuilder.Entity<HospitalAdmin>().HasData(
                            new HospitalAdmin
                            {
                                UserId = id,
                                HospitalId = HOSPITAL_ID
                            });
                        break;
                    case DOCTOR_ROLE_ID:
                        modelBuilder.Entity<Doctor>().HasData(new Doctor
                        {
                            UserId = id,
                            HospitalId = HOSPITAL_ID
                        });
                        break;
                    case PATIENT_ROLE_ID:                        
                        modelBuilder.Entity<Patient>().HasData(new Patient
                        {
                            UserId = id
                        });
                        break;
                    default: break;
                }
            }
    }
}