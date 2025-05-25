using pavlov_d_kt_41_22.Filters.DepartmentFilters;
using pavlov_d_kt_41_22.Models;
using pavlov_d_kt_41_22.Models;

namespace pavlov_d_kt_41_22.Interfaces.DepartmentInterfaces
{
    public interface IDepartmentService
    {
        Task<Department[]> GetDepartmentsAsync(DepartmentFilter filter, CancellationToken cancellationToken = default);
        Task AddDepartmentAsync(Department department, CancellationToken cancellationToken = default);
        Task UpdateDepartmentAsync(Department department, CancellationToken cancellationToken = default);
        Task<bool> DeleteDepartmentAsync(int departmentId, CancellationToken cancellationToken = default);
    }
}