using AutoMapper;
using Ecommerce.Services.CouponAPI.Models;
using Ecommerce.Services.CouponAPI.Models.Dto;

namespace Ecommerce.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMapConfig()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto,Coupon>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
