using ExamenPOO_U2.Dtos.Common;
using ExamenPOO_U2.Dtos.DetailSheet;

namespace ExamenPOO_U2.Services.Interfaces
{
    public interface IDetailSheetService
    {
        Task<ResponseDto<DetailSheetActionResponseDto>> CreateAsync(DetailSheetCreateDto dto);
        Task<ResponseDto<DetailSheetActionResponseDto>> DeleteAsync(Guid id);
        Task<ResponseDto<DetailSheetActionResponseDto>> EditAsync(DetailSheetEditDto dto, Guid id);
        Task<ResponseDto<List<DetailSheetDto>>> GetListAsync();
        Task<ResponseDto<DetailSheetDto>> GetOneByIdAsync(Guid id);

    }
}
