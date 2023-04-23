using MangoRestaurant.WebUI.Models;

namespace MangoRestaurant.WebUI.Services.Abstract
{
    public interface IProductService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductByIDAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDTO productDTO);
        Task<T> UpdateProductAsync<T>(ProductDTO productDTO);
        Task<T> DeleteProductAsync<T>(int id);
    }
}
