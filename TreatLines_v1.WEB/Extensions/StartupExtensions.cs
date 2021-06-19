using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreatLines_v1.BLL.Interfaces;
using TreatLines_v1.BLL.JwtAuthentication;
using TreatLines_v1.BLL.Services;
using TreatLines_v1.DAL.Entities;
using TreatLines_v1.DAL.Interfaces;
using TreatLines_v1.DAL.Repositories;
using TreatLines_v1.WEB.Configuration;

namespace TreatLines_v1.WEB.Extensions
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddJwtTokenAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var tokenProvider = new JwtAuthenticationManager(configuration);
            services
                .AddSingleton<IJwtAuthenticationManager>(tokenProvider)
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(
                    authenticationScheme: JwtBearerDefaults.AuthenticationScheme,
                    configureOptions: options =>
                    {
                        options.RequireHttpsMetadata = true;
                        options.TokenValidationParameters = tokenProvider.TokenValidationParameters;
                    });
            return services;
        }

        public static IServiceCollection RegisterIoRep(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<UserRepository>();
            services.AddScoped<IRepository<RequestToCreate>, Repository<RequestToCreate>>();
            services.AddScoped<IRepository<Hospital>, Repository<Hospital>>();
            services.AddScoped<IHospitalAdminRepository, HospitalAdminRepository>();
            services.AddScoped<IHospitalRepository, HospitalRepository>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IDoctorPatientRepository, DoctorPatientRepository>();

            services.AddSingleton<IMailService, MailService>();

            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IHospitalService, HospitalService>();
            services.AddTransient<IDoctorService, DoctorService>();
            services.AddTransient<IPatientService, PatientService>();
            services.AddTransient<IScheduleService, ScheduleService>();
            services.AddScoped<IHospitalRegistrationRequestsService, HospitalRegistrationRequestsService>();

            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }

        public static IServiceCollection SwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(
                options =>
                {
                    options.SwaggerDoc("v1", new OpenApiInfo { Title = "TreatLines.API", Version = "v1" });

                    var security = new Dictionary<string, IEnumerable<string>>
                    {
                        {"Bearer", new string[] { }},
                    };

                    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                    {
                        Name = "Authorization",
                        Type = SecuritySchemeType.ApiKey,
                        Scheme = "Bearer",
                        BearerFormat = "JWT",
                        In = ParameterLocation.Header,
                        Description = "JWT Authorization header using the Bearer scheme."
                    });

                    var securityScheme = new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Id = "Bearer",
                            Type = ReferenceType.SecurityScheme
                        }
                    };
                    var requirements = new OpenApiSecurityRequirement
                    {
                        {securityScheme, new List<string>()}
                    };
                    options.AddSecurityRequirement(requirements);
                }
            );
            return services;
        }
    }
}
