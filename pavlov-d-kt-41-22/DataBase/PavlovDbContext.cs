using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using pavlov_d_kt_41_22.DataBase.Configurations;
using pavlov_d_kt_41_22.Models;
using pavlov_d_kt_41_22.DataBase;

namespace pavlov_d_kt_41_22.DataBase
{
    public class PavlovDbContext : DbContext
    {
        //Добавляем таблицы
        DbSet<AcademicDegree> AcademicDegree { get; set; }
        DbSet<Department> Department { get; set; }
        DbSet<Direction> Direction { get; set; }
        DbSet<Discipline> Discipline { get; set; }
        DbSet<Position> Position { get; set; }
        DbSet<Teacher> Teacher { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Добавляем конфигурации к таблицам
            modelBuilder.ApplyConfiguration(new AcademicDegreeConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new DirectionConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new PositionConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
        }
        public PavlovDbContext(DbContextOptions<PavlovDbContext> options) : base(options)
        {
        }
    }
}




