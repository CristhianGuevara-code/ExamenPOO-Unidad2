using ExamenPOO_U2.Dtos.Common;
using ExamenPOO_U2.Dtos.Employees;
using ExamenPOO_U2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExamenPOO_U2.Controllers
{
    [ApiController]
    [Route("api/employess")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService _employeesService;

        public EmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        //Obtener uno
        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseDto<EmployeeDto>>> GetOne(Guid id)
        {
            var response = _employeesService.GetOneByIdAsync(id);

            return StatusCode(response.StatusCode, new
            {
                response.Status,
                response.Message,
                response.Data
            });
        }

        //Crear
        [HttpPost]
        public async Task<ActionResult<ResponseDto<EmployeeActionResponseDto>>> Post()
        {

        }
    }
}
