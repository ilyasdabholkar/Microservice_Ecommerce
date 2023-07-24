using Ecommerce.Services.ShoppingCartAPI.Models.Dto;

namespace Ecommerce.Services.ShoppingCartAPI.Services.IServices
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductDto>> GetProducts();
    }
}
