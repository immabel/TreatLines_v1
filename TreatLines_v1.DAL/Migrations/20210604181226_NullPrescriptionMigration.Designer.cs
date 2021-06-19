﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TreatLines_v1.DAL;

namespace TreatLines_v1.DAL.Migrations
{
    [DbContext(typeof(TLinesDbContext))]
    [Migration("20210604181226_NullPrescriptionMigration")]
    partial class NullPrescriptionMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "2AEFE1C5-C5F0-4399-8FB8-420813567554",
                            ConcurrencyStamp = "cffee31c-dc58-465d-b00d-88e1d9749b85",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "99DA7670-5471-414F-834E-9B3A6B6C8F6F",
                            ConcurrencyStamp = "6a4d4b73-529d-4913-8d75-c7b131d0b8fd",
                            Name = "HospitalAdmin",
                            NormalizedName = "HOSPITALADMIN"
                        },
                        new
                        {
                            Id = "828A3B02-77C0-45C1-8E97-6ED57711E577",
                            ConcurrencyStamp = "2d52d24a-1f11-47ae-97b4-4de074be6309",
                            Name = "Doctor",
                            NormalizedName = "DOCTOR"
                        },
                        new
                        {
                            Id = "422EEB6A-3031-4B66-ABA8-0F85AFC07C3C",
                            ConcurrencyStamp = "93a6ed27-27c6-4085-95ac-eea6d096da3c",
                            Name = "Patient",
                            NormalizedName = "PATIENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "00CA41A9-C962-4230-937E-D5F54772C062",
                            RoleId = "2AEFE1C5-C5F0-4399-8FB8-420813567554"
                        },
                        new
                        {
                            UserId = "BFCC8BAB-AD20-4F70-9CD9-D2003FAE6F09",
                            RoleId = "99DA7670-5471-414F-834E-9B3A6B6C8F6F"
                        },
                        new
                        {
                            UserId = "E8D13331-62AB-463E-A283-6493B68A3622",
                            RoleId = "828A3B02-77C0-45C1-8E97-6ED57711E577"
                        },
                        new
                        {
                            UserId = "E3A6BF34-A57D-4709-97CC-6AD1B2B3985B",
                            RoleId = "422EEB6A-3031-4B66-ABA8-0F85AFC07C3C"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("DateTimeAppointment")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Elasticity")
                        .HasColumnType("int");

                    b.Property<int>("LevelOfMoisture")
                        .HasColumnType("int");

                    b.Property<double>("PHlevel")
                        .HasColumnType("float");

                    b.Property<int?>("PrescriptionId")
                        .HasColumnType("int");

                    b.Property<string>("SkinColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SkinType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Dialog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Dialogs");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Doctor", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("DeviceId")
                        .HasColumnType("int");

                    b.Property<int>("HospitalId")
                        .HasColumnType("int");

                    b.Property<bool>("OnHoliday")
                        .HasColumnType("bit");

                    b.Property<string>("Position")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("ScheduleId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("DeviceId")
                        .IsUnique()
                        .HasFilter("[DeviceId] IS NOT NULL");

                    b.HasIndex("HospitalId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            UserId = "E8D13331-62AB-463E-A283-6493B68A3622",
                            HospitalId = 1,
                            OnHoliday = false
                        });
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.DoctorPatient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<int?>("DialogId")
                        .HasColumnType("int");

                    b.Property<string>("DoctorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PatientId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId")
                        .IsUnique()
                        .HasFilter("[AppointmentId] IS NOT NULL");

                    b.HasIndex("DialogId")
                        .IsUnique()
                        .HasFilter("[DialogId] IS NOT NULL");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("DoctorPatient");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Country")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Hospitals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Petrovna Ave. 2, Kharkiv",
                            Country = "Ukraine",
                            Name = "SeventhSeason"
                        });
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.HospitalAdmin", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("HospitalId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("HospitalId");

                    b.ToTable("HospitalsAdmins");

                    b.HasData(
                        new
                        {
                            UserId = "BFCC8BAB-AD20-4F70-9CD9-D2003FAE6F09",
                            HospitalId = 1
                        });
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("DateSent")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("DialogId")
                        .HasColumnType("int");

                    b.Property<string>("SenderId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DialogId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Patient", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BloodType")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Sex")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("UserId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            UserId = "E3A6BF34-A57D-4709-97CC-6AD1B2B3985B"
                        });
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Prescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.RequestToCreate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("DateOfCreation")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HospitalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubmitterFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubmitterLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RequestsToCreate");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("EndTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("StartTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("WorkDays")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "00CA41A9-C962-4230-937E-D5F54772C062",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1c655a56-d103-4b76-adf0-bd7e50cba5a8",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Adminovich",
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@gmail.com",
                            NormalizedUserName = "admin@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAENAm5YUx/UvPweYwJXuv5dObu0e7s6601DxqmjmquJs/wy6MMDj6NlnPOnpMLnkz0Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bc5fa690-d382-4144-9668-69e1e85aec01",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "BFCC8BAB-AD20-4F70-9CD9-D2003FAE6F09",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e3782114-95f2-4ec5-92cb-67c5f8fc6080",
                            Email = "ssadmin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Katya",
                            LastName = "Zamolodchikova",
                            LockoutEnabled = false,
                            NormalizedEmail = "ssadmin@gmail.com",
                            NormalizedUserName = "ssadmin@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEEyPIX3ItqJG9EgPU3GgUtg5+W55XXclRGX4+4Dyv6wz2oAd/0bNCLNUKdv5c39+Ig==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e9c34b31-4ebb-4882-9446-a27b4bf34e2c",
                            TwoFactorEnabled = false,
                            UserName = "ssadmin@gmail.com"
                        },
                        new
                        {
                            Id = "E8D13331-62AB-463E-A283-6493B68A3622",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dfd45fda-0cf1-4fdb-ab44-09806d60f0b1",
                            Email = "alaska.thunderfuck@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Alaska",
                            LastName = "Thunderfuck",
                            LockoutEnabled = false,
                            NormalizedEmail = "alaska.thunderfuck@gmail.com",
                            NormalizedUserName = "alaska.thunderfuck@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEFcboCXRBTae95Ezzxgv+9tFCrzmc4qIJo9/O6lgj7KHVAD1Z2otcr5KQv1cDjkkYg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3d3f296d-3d8f-46a0-9755-f917755a547f",
                            TwoFactorEnabled = false,
                            UserName = "alaska.thunderfuck@gmail.com"
                        },
                        new
                        {
                            Id = "E3A6BF34-A57D-4709-97CC-6AD1B2B3985B",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d878f5aa-fe47-4b41-9a20-6eb69c36746b",
                            Email = "de.tox@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "De",
                            LastName = "Tox",
                            LockoutEnabled = false,
                            NormalizedEmail = "de.tox@gmail.com",
                            NormalizedUserName = "de.tox@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEEOqtgJ60qId5HpiqfR32RIwLgdb4zudt/MeWpGbF+9alWVElGjVDxxnM4wSipp6CQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9cd05f93-d365-4249-b6ec-8792c262a73f",
                            TwoFactorEnabled = false,
                            UserName = "de.tox@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TreatLines_v1.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TreatLines_v1.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TreatLines_v1.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TreatLines_v1.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Appointment", b =>
                {
                    b.HasOne("TreatLines_v1.DAL.Entities.Prescription", "Prescription")
                        .WithMany("Appointments")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Doctor", b =>
                {
                    b.HasOne("TreatLines_v1.DAL.Entities.Device", "Device")
                        .WithOne()
                        .HasForeignKey("TreatLines_v1.DAL.Entities.Doctor", "DeviceId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("TreatLines_v1.DAL.Entities.Hospital", "Hospital")
                        .WithMany("Doctors")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TreatLines_v1.DAL.Entities.Schedule", "Schedule")
                        .WithMany("Doctors")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("TreatLines_v1.DAL.Entities.User", "User")
                        .WithOne()
                        .HasForeignKey("TreatLines_v1.DAL.Entities.Doctor", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");

                    b.Navigation("Hospital");

                    b.Navigation("Schedule");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.DoctorPatient", b =>
                {
                    b.HasOne("TreatLines_v1.DAL.Entities.Appointment", "Appointment")
                        .WithOne()
                        .HasForeignKey("TreatLines_v1.DAL.Entities.DoctorPatient", "AppointmentId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("TreatLines_v1.DAL.Entities.Dialog", "Dialog")
                        .WithOne()
                        .HasForeignKey("TreatLines_v1.DAL.Entities.DoctorPatient", "DialogId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("TreatLines_v1.DAL.Entities.Doctor", "Doctor")
                        .WithMany("DoctorPatients")
                        .HasForeignKey("DoctorId");

                    b.HasOne("TreatLines_v1.DAL.Entities.Patient", "Patient")
                        .WithMany("PatientDoctors")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Appointment");

                    b.Navigation("Dialog");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.HospitalAdmin", b =>
                {
                    b.HasOne("TreatLines_v1.DAL.Entities.Hospital", "Hospital")
                        .WithMany("HospitalAdmins")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TreatLines_v1.DAL.Entities.User", "User")
                        .WithOne()
                        .HasForeignKey("TreatLines_v1.DAL.Entities.HospitalAdmin", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hospital");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Message", b =>
                {
                    b.HasOne("TreatLines_v1.DAL.Entities.Dialog", "Dialog")
                        .WithMany("Messages")
                        .HasForeignKey("DialogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dialog");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Patient", b =>
                {
                    b.HasOne("TreatLines_v1.DAL.Entities.User", "User")
                        .WithOne()
                        .HasForeignKey("TreatLines_v1.DAL.Entities.Patient", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Dialog", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Doctor", b =>
                {
                    b.Navigation("DoctorPatients");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Hospital", b =>
                {
                    b.Navigation("Doctors");

                    b.Navigation("HospitalAdmins");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Patient", b =>
                {
                    b.Navigation("PatientDoctors");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Prescription", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("TreatLines_v1.DAL.Entities.Schedule", b =>
                {
                    b.Navigation("Doctors");
                });
#pragma warning restore 612, 618
        }
    }
}
