using ExamenPOO_U2.Dtos.Common;
using ExamenPOO_U2.Dtos.Employees;

namespace ExamenPOO_U2.Services.Interfaces
{
    public interface IEmployeesService
    {
        Task<ResponseDto<EmployeeActionResponseDto>> CreateAsync(Dtos.Employees.EmployeeCreateDto dto);

        //Task<ResponseDto<EmployeeActionResponseDto>> CreateAsync(EmployeeCreateDto dto);
        Task<ResponseDto<EmployeeActionResponseDto>> DeleteAsync(Guid id);
        Task<ResponseDto<EmployeeActionResponseDto>> EditAsync(EmployeeEditDto dto, Guid id);
        Task<ResponseDto<List<EmployeeDto>>> GetListAsync();
        Task<ResponseDto<EmployeeDto>> GetOneByIdAsync(Guid id);
    }
}
