﻿using ExamenPOO_U2.Dtos.Common;
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

        //Obtener lista
        [HttpGet]
        public async Task<ActionResult<ResponseDto<List<EmployeeDto>>>> GetList()
        {
            var response = await _employeesService.GetListAsync();

            return StatusCode(response.StatusCode, new
            {
                response.Status,
                response.Message,
                response.Data
            });
        }


        //Obtener uno
        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseDto<EmployeeDto>>> GetOne(Guid id)
        {
            var response = await _employeesService.GetOneByIdAsync(id);

            return StatusCode(response.StatusCode, new
            {
                response.Status,
                response.Message,
                response.Data
            });
        }

        //Crear
        [HttpPost]
        public async Task<ActionResult<ResponseDto<EmployeeActionResponseDto>>> Post([FromBody] Dtos.Employees.EmployeeCreateDto dto)
        {
            var response = await _employeesService.CreateAsync(dto);
            return StatusCode(response.StatusCode, new
            {
                response.Status,
                response.Message,
                response.Data
            });
        }

        //Editar
        [HttpPut("{id}")] 
        public async Task<ActionResult<ResponseDto<EmployeeActionResponseDto>>> Edit([FromBody] EmployeeEditDto dto, Guid id)
        {
            var response = await _employeesService.EditAsync(dto, id);

            return StatusCode(response.StatusCode, response);
        }

        //Eliminar
        [HttpDelete("{id}")]
        public async Task<ActionResult<ResponseDto<EmployeeActionResponseDto>>> Delete(Guid id)
        {
            var response = await _employeesService.DeleteAsync(id);
            return StatusCode(response.StatusCode, response);
        }
    }
}
