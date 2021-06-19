using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TreatLines_v1.DAL.Entities;

namespace TreatLines_v1.DAL.Configurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("Messages").HasKey(k => k.Id);
            builder.Property(p => p.Text);
            builder.Property(p => p.DateSent);
            builder.Property(p => p.SenderId);
            builder
                .HasOne(h => h.Dialog)
                .WithMany(m => m.Messages);
        }
    }
}
