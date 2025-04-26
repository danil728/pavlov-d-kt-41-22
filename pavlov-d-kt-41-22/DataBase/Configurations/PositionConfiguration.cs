using pavlov_d_kt_41_22.DataBase.Helpers;
using pavlov_d_kt_41_22.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using pavlov_d_kt_41_22.DataBase.Helpers;

namespace pavlov_d_kt_41_22.DataBase.Configurations
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        private const string TableName = "Position";

        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(p => p.PositionId)
                .HasName($"pk_{TableName}_position_id");

            builder.Property(p => p.PositionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("position_id")
                .HasComment("Идентификатор должности");

            builder.Property(p => p.Title)
                .IsRequired()
                .HasColumnName("c_position_title")
                .HasColumnType("varchar(100)")
                .HasComment("Название должности");

            builder.ToTable(TableName);
        }
    }
}
