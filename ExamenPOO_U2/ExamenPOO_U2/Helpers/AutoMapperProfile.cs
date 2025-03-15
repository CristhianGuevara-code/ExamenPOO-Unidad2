using AutoMapper;
using ExamenPOO_U2.Database.Entities;
using ExamenPOO_U2.Dtos.Employees;

namespace ExamenPOO_U2.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmployeeEntity, EmployeeDto>();
            CreateMap<EmployeeEntity, EmployeeActionResponseDto>();
            CreateMap<EmployeeCreateDto, EmployeeEntity>();
            CreateMap<EmployeeEditDto, EmployeeEntity>();
        }
    }
}
