using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TreatLines_v1.DAL.Entities;

namespace TreatLines_v1.DAL.Configurations
{
    public class RequestToCreateConfiguration : IEntityTypeConfiguration<RequestToCreate>
    {
        public void Configure(EntityTypeBuilder<RequestToCreate> builder)
        {
            builder.ToTable("RequestsToCreate").HasKey(k => k.Id);
            builder.Property(p => p.HospitalName).IsRequired(); ;
            builder.Property(p => p.SubmitterFirstName).IsRequired();
            builder.Property(p => p.SubmitterLastName).IsRequired();
            builder.Property(p => p.Email).IsRequired();
            builder.Property(p => p.Address).IsRequired();
            builder.Property(p => p.Country).IsRequired();
            builder.Property(p => p.DateOfCreation).IsRequired();
        }
    }
}
