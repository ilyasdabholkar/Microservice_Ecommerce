using AutoMapper;
using Ecommerce.Services.ProductAPI.Models;
using Ecommerce.Services.ProductAPI.Models.Dto;

namespace Ecommerce.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMapConfig()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto,Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
