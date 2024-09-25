using Store.Service.Services.Product.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Services.Product
{
    public interface IProductService
    {
        Task<ProductDetailsDto> GetProductById(int? productId);
        Task<IReadOnlyList<ProductDetailsDto>> GetAllProductAsync();
        Task<IReadOnlyList<BrandTypesDetailsDto>> GetAllBrandsAsync();
        Task<IReadOnlyList<BrandTypesDetailsDto>> GetAllTypesAsync();

    }
}
