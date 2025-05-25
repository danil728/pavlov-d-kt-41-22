using pavlov_d_kt_41_22.Filters.DisciplineFilters;
using pavlov_d_kt_41_22.Models;
using pavlov_d_kt_41_22.Models;

namespace pavlov_d_kt_41_22.Interfaces.DisciplineInterfaces
{
    public interface IDisciplineService
    {
        Task<Discipline[]> GetDisciplinesByDepartmentAsync(DepartmentDisciplineFilter filter, CancellationToken cancellationToken = default);
        Task<Discipline[]> GetDisciplinesAsync(DisciplineFilter filter, CancellationToken cancellationToken = default);
        Task AddDisciplineAsync(Discipline discipline, CancellationToken cancellationToken = default);
        Task UpdateDisciplineAsync(Discipline discipline, CancellationToken cancellationToken = default);
        Task DeleteDisciplineAsync(int disciplineId, CancellationToken cancellationToken = default);
    }
}