using pavlov_d_kt_41_22.DataBase.Helpers;
using pavlov_d_kt_41_22.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pavlov_d_kt_41_22.DataBase.Helpers;

namespace pavlov_d_kt_41_22.DataBase.Configurations
{
    public class AcademicDegreeConfiguration : IEntityTypeConfiguration<AcademicDegree>
    {
        private const string TableName = "Academic_degree";

        public void Configure(EntityTypeBuilder<AcademicDegree> builder)
        {
            builder.HasKey(p => p.ADId)
                .HasName($"pk_{TableName}_ad_id");

            builder.Property(p => p.ADId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ad_id")
                .HasComment("Идентификатор ученой степени");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnName("c_ad_name")
                .HasColumnType("varchar(100)")
                .HasComment("Название ученой степени");

            builder.ToTable(TableName);
        }
    }
}
