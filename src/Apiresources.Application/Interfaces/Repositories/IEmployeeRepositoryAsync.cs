using Apiresources.Application.Features.Employees.Queries.GetEmployees;
using Apiresources.Application.Parameters;
using Apiresources.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apiresources.Application.Interfaces.Repositories
{
    public interface IEmployeeRepositoryAsync : IGenericRepositoryAsync<Employee>
    {
        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedEmployeeReponseAsync(GetEmployeesQuery requestParameter);
    }
}