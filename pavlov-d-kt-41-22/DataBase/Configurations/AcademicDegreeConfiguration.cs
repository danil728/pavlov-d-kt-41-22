﻿using pavlov_d_kt_41_22.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pavlov_d_kt_41_22.Models;

namespace pavlov_d_kt_41_22.Database.Configurations
{
    public class AcademicDegreeConfiguration : IEntityTypeConfiguration<AcademicDegree>
    {
        public void Configure(EntityTypeBuilder<AcademicDegree> builder)
        {
            builder.ToTable("AcademicDegrees");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Title).HasMaxLength(100).IsRequired();
        }

    }
}
