using TakeAwayNight.Catalog.Dtos.SliderDtos;

namespace TakeAwayNight.Catalog.Services.SliderServices
{
    public interface ISliderService
    {
        Task<List<ResultSliderDto>> GetAllSliderAsync();
        Task CreateSliderAsync(CreateSliderDto SliderDto);
        Task UpdateSliderAsync(UpdateSliderDto updateDto);
        Task DeleteSliderAsync(string id);
        Task<GetByIdSliderDto> GetByIdSliderAsync(string id);
    }
}
