using AutoMapper;
using Ecommerce.Services.ShoppingCartAPI.Models.Dto;
using Ecommerce.Services.ShoppingCartAPI.Models;

namespace Ecommerce.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMapConfig()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
