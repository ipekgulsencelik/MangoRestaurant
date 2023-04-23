using MangoRestaurant.WebUI.Models;

namespace MangoRestaurant.WebUI.Services.Abstract
{
    public interface IBaseService : IDisposable
    {
        ResponseDTO responseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
