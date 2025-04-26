using pavlov_d_kt_41_22.DataBase.Helpers;
using pavlov_d_kt_41_22.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using pavlov_d_kt_41_22.DataBase.Helpers;

namespace pavlov_d_kt_41_22.DataBase.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        private const string TableName = "Kafedra";

        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(p => p.DepartmentId)
                .HasName($"pk_{TableName}_department_id");

            builder.Property(p => p.DepartmentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("department_id")
                .HasComment("Идентификатор кафедры");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnName("c_department_name")
                .HasColumnType("varchar(100)")
                .HasComment("Название кафедры");

            builder.Property(d => d.HeadTeacherId)
                .IsRequired()
                .HasColumnName("f_head_teacher_id")
                .HasComment("Идентификатор заведующего кафедрой");

            builder.HasOne(d => d.HeadTeacher)
               .WithOne()
               .HasForeignKey<Department>(d => d.HeadTeacherId)
               .HasConstraintName("fk_department_head_teacher")
               .OnDelete(DeleteBehavior.Restrict); 

            builder.ToTable(TableName);
        }
    }
}
