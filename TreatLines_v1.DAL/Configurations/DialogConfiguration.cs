using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TreatLines_v1.DAL.Entities;

namespace TreatLines_v1.DAL.Configurations
{
    public class DialogConfiguration : IEntityTypeConfiguration<Dialog>
    {
        public void Configure(EntityTypeBuilder<Dialog> builder)
        {
            builder.ToTable("Dialogs").HasKey(k => k.Id);
            builder
                .HasMany(h => h.Messages)
                .WithOne(o => o.Dialog);
        }
    }
}
