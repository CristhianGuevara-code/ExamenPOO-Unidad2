using AutoMapper;
using ExamenPOO_U2.Database.Entities;
using ExamenPOO_U2.Dtos.DetailSheet;
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

            CreateMap<DetailSheetEntity, DetailSheetDto>();
            CreateMap<DetailSheetEntity, DetailSheetActionResponseDto>();
            CreateMap<DetailSheetCreateDto, DetailSheetEntity>();
            CreateMap<DetailSheetEditDto, DetailSheetEntity>();
        }
    }
}
