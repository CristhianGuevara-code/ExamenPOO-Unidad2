using AutoMapper;
using ExamenPOO_U2.Constants;
using ExamenPOO_U2.Database;
using ExamenPOO_U2.Database.Entities;
using ExamenPOO_U2.Dtos.Common;
using ExamenPOO_U2.Dtos.DetailSheet;
using ExamenPOO_U2.Dtos.Employees;
using ExamenPOO_U2.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExamenPOO_U2.Services
{
    public class DetailSheetService : IDetailSheetService
    {
        private readonly PlanillaDbContext _context;
        private readonly IMapper _mapper;

        public DetailSheetService(PlanillaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ResponseDto<List<DetailSheetDto>>> GetListAsync()
        {
            var detailSheetEntity = await _context.DetailSheets.ToListAsync();
            var detailSheetDto = _mapper.Map<List<DetailSheetDto>>(detailSheetEntity);

            return new ResponseDto<List<DetailSheetDto>>
            {
                StatusCode = HttpStatusCode.OK,
                Status = true,
                Message = detailSheetEntity.Count() > 0 ? "Registros encontrados" : "No se encontraron registros",
                Data = detailSheetDto
            };
        }

        public async Task<ResponseDto<DetailSheetDto>> GetOneByIdAsync(Guid id)
        {
            var detailSheetEntity = await _context.DetailSheets.FirstOrDefaultAsync(x => x.Id == id);

            if (detailSheetEntity == null)
            {
                return new ResponseDto<DetailSheetDto>
                {
                    StatusCode = HttpStatusCode.NOT_FOUND,
                    Status = false,
                    Message = "Registro no encontrado",
                };
            }

            return new ResponseDto<DetailSheetDto>
            {
                StatusCode = HttpStatusCode.OK,
                Status = false,
                Message = "Registro encontrado",
                Data = _mapper.Map<DetailSheetDto>(detailSheetEntity)
            };
        }

        public async Task<ResponseDto<DetailSheetActionResponseDto>> CreateAsync(DetailSheetCreateDto dto)
        {
            try
            {
                var detailSheetEntity = _mapper.Map<DetailSheetEntity>(dto);

                _context.DetailSheets.Add(detailSheetEntity);
                await _context.SaveChangesAsync();

                return new ResponseDto<DetailSheetActionResponseDto>
                {
                    StatusCode = (int)HttpStatusCode.CREATED,
                    Status = true,
                    Message = "Registro creado Correctamente",
                    Data = _mapper.Map<DetailSheetActionResponseDto>(detailSheetEntity)
                };
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


                return new ResponseDto<DetailSheetActionResponseDto>
                {
                    StatusCode = (int)(HttpStatusCode.INTERNAL_SERVER_ERROR),
                    Status = false,
                    Message = "Error interno en el servidor, contacte al administrador",
                };
            }

        }

        public async Task<ResponseDto<DetailSheetActionResponseDto>> EditAsync(DetailSheetEditDto dto, Guid id)
        {
            try
            {
                var detailSheetEntity = await _context.DetailSheets.FirstOrDefaultAsync(x => x.Id == id);

                if (detailSheetEntity == null)
                {
                    return new ResponseDto<DetailSheetActionResponseDto>
                    {
                        StatusCode = HttpStatusCode.NOT_FOUND,
                        Status = false,
                        Message = "El registro no fue encontrado",
                    };
                }

                _mapper.Map<DetailSheetEditDto, DetailSheetEntity>(dto, detailSheetEntity);
                _context.DetailSheets.Update(detailSheetEntity);
                await _context.SaveChangesAsync();

                return new ResponseDto<DetailSheetActionResponseDto>
                {
                    StatusCode = HttpStatusCode.OK,
                    Status = true,
                    Message = "Registro modificado correctamente",
                    Data = _mapper.Map<DetailSheetActionResponseDto>(detailSheetEntity)
                };
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return new ResponseDto<DetailSheetActionResponseDto>
                {
                    StatusCode = HttpStatusCode.INTERNAL_SERVER_ERROR,
                    Status = false,
                    Message = "Error interno en el servidor, contacte al administrador",
                };

            }
        }

        public async Task<ResponseDto<DetailSheetActionResponseDto>> DeleteAsync(Guid id)
        {
            var detailSheetEntity = await _context.DetailSheets.FirstOrDefaultAsync(x => x.Id == id);

            if (detailSheetEntity == null)
            {
                return new ResponseDto<DetailSheetActionResponseDto>
                {
                    StatusCode = HttpStatusCode.NOT_FOUND,
                    Status = false,
                    Message = "Registro no fue encontrado",
                };
            }

            _context.DetailSheets.Remove(detailSheetEntity);
            await _context.SaveChangesAsync();

            return new ResponseDto<DetailSheetActionResponseDto>
            {
                StatusCode = HttpStatusCode.OK,
                Status = true,
                Message = "Registro borrado correctamente",
                Data = _mapper.Map<DetailSheetActionResponseDto>(detailSheetEntity),
            };

        }
    }
}
