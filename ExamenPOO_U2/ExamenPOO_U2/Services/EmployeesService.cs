using AutoMapper;
using ExamenPOO_U2.Constants;
using ExamenPOO_U2.Database;
using ExamenPOO_U2.Database.Entities;
using ExamenPOO_U2.Dtos.Common;
using ExamenPOO_U2.Dtos.Employees;
using ExamenPOO_U2.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Net;
using HttpStatusCode = ExamenPOO_U2.Constants.HttpStatusCode;

namespace ExamenPOO_U2.Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly PlanillaDbContext _context;
        private readonly IMapper _mapper;

        public EmployeesService(PlanillaDbContext context, IMapper mapper)
        {
            
            _context = context;
            _mapper = mapper;
        }

        //public async Task<ResponseDto<EmployeeActionResponseDto>> GetListAsync()
        //{
        //    var personDto = _mapper.Map<List<EmployeeDto>>
        //}

       public async Task<ResponseDto<EmployeeDto>> GetOneByIdAsync(Guid id)
        {
            var employeeEntity = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);

            if (employeeEntity == null)
            {
                return new ResponseDto<EmployeeDto>
                {
                    StatusCode = HttpStatusCode.NOT_FOUND,
                    Status = false,
                    Message = "Registro no encontrado",
                };
            }

            return new ResponseDto<EmployeeDto>
            {
                StatusCode = HttpStatusCode.OK,
                Status = false,
                Message = "Registro encontrado",
                Data = _mapper.Map<EmployeeDto>(employeeEntity)
            };
        }

        public async Task<ResponseDto<EmployeeActionResponseDto>> CreateAsync(EmployeeCreateDto dto)
        {
            try
            {
                var employeeEntity = _mapper.Map<EmployeeEntity>(dto);

                _context.Employees.Add(employeeEntity);
                await _context.SaveChangesAsync();

                return new ResponseDto<EmployeeActionResponseDto>
                {
                    StatusCode = (int)HttpStatusCode.CREATED,
                    Status = true,
                    Message = "Registro creado Correctamente",
                    Data = _mapper.Map<EmployeeActionResponseDto>(employeeEntity)
                };
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


                return new ResponseDto<EmployeeActionResponseDto>
                {
                    StatusCode = (int)(HttpStatusCode.INTERNAL_SERVER_ERROR),
                    Status = false,
                    Message = "Error interno en el servidor, contacte al administrador",
                };
            }
          
        }

        public async Task<ResponseDto<EmployeeActionResponseDto>> EditAsync(EmployeeEditDto dto, Guid id)
        {
            try
            {
                var employeeEntity = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);

                if (employeeEntity == null)
                {
                    return new ResponseDto<EmployeeActionResponseDto>
                    {
                        StatusCode = HttpStatusCode.NOT_FOUND,
                        Status = false,
                        Message = "El registro no fue encontrado",
                    };
                }

                _mapper.Map<EmployeeEditDto, EmployeeEntity>(dto, employeeEntity);
                _context.Employees.Update(employeeEntity);
                await _context.SaveChangesAsync();

                return new ResponseDto<EmployeeActionResponseDto>
                {
                    StatusCode = HttpStatusCode.OK,
                    Status = true,
                    Message = "Registro modificado correctamente",
                    Data = _mapper.Map<EmployeeActionResponseDto>(employeeEntity)
                };
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return new ResponseDto<EmployeeActionResponseDto>
                {
                    StatusCode = HttpStatusCode.INTERNAL_SERVER_ERROR,
                    Status = false,
                    Message = "Error interno en el servidor, contacte al administrador",
                };

            }
        }

        public async Task<ResponseDto<EmployeeActionResponseDto>> DeleteAsync(Guid id)
        {
            var employeeEntity = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);

            if (employeeEntity == null)
            {
                return new ResponseDto<EmployeeActionResponseDto>
                {
                    StatusCode = HttpStatusCode.NOT_FOUND,
                    Status = false,
                    Message = "Registro no fue encontrado",
                };
            }

            _context.Employees.Remove(employeeEntity);
            await _context.SaveChangesAsync();

            return new ResponseDto<EmployeeActionResponseDto>
            {
                StatusCode = HttpStatusCode.OK,
                Status = true,
                Message = "Registro borrado correctamente",
                Data = _mapper.Map<EmployeeActionResponseDto>(employeeEntity),
            };

        }

    }
}
