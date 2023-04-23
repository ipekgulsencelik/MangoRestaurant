using AutoMapper;
using MangoRestaurant.Services.ProductAPI.Models;
using MangoRestaurant.Services.ProductAPI.Models.DTO;

namespace MangoRestaurant.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDTO, Product>();
                config.CreateMap<Product, ProductDTO>();
            });

            return mappingConfig;
        }
    }
}
