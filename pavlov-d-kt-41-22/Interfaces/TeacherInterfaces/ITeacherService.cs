using pavlov_d_kt_41_22.Filters.TeacherFilters;
using pavlov_d_kt_41_22.Models;
using pavlov_d_kt_41_22.Models;

namespace pavlov_d_kt_41_22.Interfaces.TeachersInterfaces
{
    public interface ITeacherService
    {
        Task<Teacher[]> GetTeachersAsync(TeacherFilter filter, CancellationToken cancellationToken = default);
        Task AddTeacherAsync(Teacher teacher, CancellationToken cancellationToken = default);
        Task UpdateTeacherAsync(Teacher teacher, CancellationToken cancellationToken = default);
        Task DeleteTeacherAsync(int teacherId, CancellationToken cancellationToken = default);
    }
}