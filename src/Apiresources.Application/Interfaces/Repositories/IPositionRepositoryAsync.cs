using Apiresources.Application.Features.Positions.Queries.GetPositions;
using Apiresources.Application.Parameters;
using Apiresources.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apiresources.Application.Interfaces.Repositories
{
    public interface IPositionRepositoryAsync : IGenericRepositoryAsync<Position>
    {
        Task<bool> IsUniquePositionNumberAsync(string positionNumber);

        Task<bool> SeedDataAsync(int rowCount);

        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedPositionReponseAsync(GetPositionsQuery requestParameters);
    }
}