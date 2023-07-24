using Ecommerce.Services.ShoppingCartAPI.Models.Dto;

namespace Ecommerce.Services.ShoppingCartAPI.Services.IServices
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
