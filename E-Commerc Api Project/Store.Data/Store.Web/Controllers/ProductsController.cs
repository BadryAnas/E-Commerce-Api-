using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Store.Service.Services.Product;
using Store.Service.Services.Product.Dto;

namespace Store.Web.Controllers
{
    [Route("api/[controller]/[action]" )]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<BrandTypesDetailsDto>>> GetAllBrandsAsync()
            => Ok(await _productService.GetAllBrandsAsync());

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<BrandTypesDetailsDto>>> GetAllTypesAsync()
            => Ok(await _productService.GetAllTypesAsync());

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ProductDetailsDto>>> GetAllProductsAsync()
            => Ok(await _productService.GetAllProductAsync());

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ProductDetailsDto>>> GetProductByIdAsync(int? id)
            => Ok(await _productService.GetProductById(id));

    }
}
