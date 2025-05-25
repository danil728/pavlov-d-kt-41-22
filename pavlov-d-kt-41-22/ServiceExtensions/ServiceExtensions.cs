using pavlov_d_kt_41_22.Interfaces.DepartmentInterfaces;
using pavlov_d_kt_41_22.Interfaces.DisciplineInterfaces;
using pavlov_d_kt_41_22.Interfaces.LoadInterfaces;
using pavlov_d_kt_41_22.Interfaces.TeachersInterfaces;

namespace pavlov_d_kt_41_22.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IDisciplineService, DisciplineService>();
            services.AddScoped<ILoadService, LoadService>();

            return services;
        }
    }
}