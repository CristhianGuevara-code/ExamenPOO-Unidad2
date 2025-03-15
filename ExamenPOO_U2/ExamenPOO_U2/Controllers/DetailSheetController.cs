using ExamenPOO_U2.Dtos.Common;
using ExamenPOO_U2.Dtos.DetailSheet;
using ExamenPOO_U2.Dtos.Employees;
using ExamenPOO_U2.Services;
using ExamenPOO_U2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExamenPOO_U2.Controllers
{
    [ApiController]
    [Route("api/detailsheets")]
    public class DetailSheetController : ControllerBase
    {
        private readonly IDetailSheetService _detailSheetService;

        public DetailSheetController(IDetailSheetService detailSheetService)
        {
            _detailSheetService = detailSheetService;
        }

        //Obtener lista
        [HttpGet]
        public async Task<ActionResult<ResponseDto<List<DetailSheetDto>>>> GetList()
        {
            var response = await _detailSheetService.GetListAsync();

            return StatusCode(response.StatusCode, new
            {
                response.Status,
                response.Message,
                response.Data
            });
        }


        //Obtener uno
        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseDto<DetailSheetDto>>> GetOne(Guid id)
        {
            var response = await _detailSheetService.GetOneByIdAsync(id);

            return StatusCode(response.StatusCode, new
            {
                response.Status,
                response.Message,
                response.Data
            });
        }

        //Crear
        [HttpPost]
        public async Task<ActionResult<ResponseDto<DetailSheetActionResponseDto>>> Post([FromBody] DetailSheetCreateDto dto)
        {
            var response = await _detailSheetService.CreateAsync(dto);
            return StatusCode(response.StatusCode, new
            {
                response.Status,
                response.Message,
                response.Data
            });
        }

        //Editar
        [HttpPut("{id}")]
        public async Task<ActionResult<ResponseDto<EmployeeActionResponseDto>>> Edit([FromBody] DetailSheetEditDto dto, Guid id)
        {
            var response = await _detailSheetService.EditAsync(dto, id);

            return StatusCode(response.StatusCode, response);
        }

        //Eliminar
        [HttpDelete("{id}")]
        public async Task<ActionResult<ResponseDto<EmployeeActionResponseDto>>> Delete(Guid id)
        {
            var response = await _detailSheetService.DeleteAsync(id);
            return StatusCode(response.StatusCode, response);
        }
    }
}
