using Ecommerce.Web.Models;
using Ecommerce.Web.Services.IServices;

namespace Ecommerce.Web.Services
{
    public class ProductService : IProductService
    {
        public Task<ResponseDto?> CreateProductsAsync(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> DeleteProductsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> UpdateProductsAsync(ProductDto productDto)
        {
            throw new NotImplementedException();
        }
    }
}
