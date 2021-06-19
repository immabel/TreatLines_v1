using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreatLines_v1.DAL;
using TreatLines_v1.DAL.Entities;
using TreatLines_v1.WEB.Extensions;

namespace TreatLines_v1.WEB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TLinesDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddTransient<DbContext, TLinesDbContext>();

            services.AddIdentity<User, IdentityRole>(
                    config =>
                    {
                        // Our UserNames = Emails. When registering new user with already registered email
                        // there will be two unique violations unless emails ain't requiered to be unique.
                        config.User.RequireUniqueEmail = false;
                        config.Password.RequireNonAlphanumeric = false;
                        config.Password.RequireDigit = true;
                    })
                .AddEntityFrameworkStores<TLinesDbContext>();


            services.RegisterIoRep();

            services.AddJwtTokenAuthentication(Configuration);

            services.SwaggerConfiguration();

            services.AddControllers();

            services.AddCors(options => {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        .AllowAnyMethod()
                        .AllowCredentials()
                        .SetIsOriginAllowed((host) => true)
                        .AllowAnyHeader()
                        .WithOrigins("http://localhost:3000")
                        );
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(options => 
            options.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod()); 

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
