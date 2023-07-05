using Ecommerce.Web.Models;

namespace Ecommerce.Web.Services.IServices
{
    public interface ICouponService
    {
        public Task<ResponseDto?> GetAllCouponsAsync();
        public Task<ResponseDto?> GetCouponAsync(string couponCode);
        public Task<ResponseDto?> GetCouponByIdAsync(int id);
        public Task<ResponseDto?> CreateCouponAsync(CouponDto coupon);
        public Task<ResponseDto?> UpdateCouponAsync(CouponDto coupon);
        public Task<ResponseDto?> DeleteCouponAsync(int id);

    }
}
