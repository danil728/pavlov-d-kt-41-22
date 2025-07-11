﻿using pavlov_d_kt_41_22.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pavlov_d_kt_41_22.Models;

namespace pavlov_d_kt_41_22.Database.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name).HasMaxLength(100).IsRequired();

            builder.Property(d => d.FoundationDate)
                   .HasColumnType("date")
                   .IsRequired(false);   // дата может быть NULL

            builder.HasMany(d => d.Teachers)
                .WithOne(t => t.Department)
                .HasForeignKey(t => t.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(d => d.Head)
            .WithOne(t => t.ManagedDepartment)
            .HasForeignKey<Department>(d => d.HeadId)
            .OnDelete(DeleteBehavior.NoAction);

        }

    }
}
