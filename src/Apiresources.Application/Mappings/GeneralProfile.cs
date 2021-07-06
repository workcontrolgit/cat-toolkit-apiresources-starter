using Apiresources.Application.Features.Employees.Queries.GetEmployees;
using Apiresources.Application.Features.Positions.Commands.CreatePosition;
using Apiresources.Application.Features.Positions.Queries.GetPositions;
using Apiresources.Domain.Entities;
using AutoMapper;

namespace Apiresources.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Position, GetPositionsViewModel>().ReverseMap();
            CreateMap<Employee, GetEmployeesViewModel>().ReverseMap();
            CreateMap<CreatePositionCommand, Position>();
        }
    }
}