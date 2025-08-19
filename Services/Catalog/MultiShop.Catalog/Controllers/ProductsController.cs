using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.ProductDetailDtos;
using MultiShop.Catalog.Services.ProductServices;

namespace MultiShop.Catalog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
       private readonly IProductService _productService;

        public ProductsController(IProductService ProductService)
        {
            _productService = ProductService;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productService.GetAllProductAsync();
            return Ok(values);
        }

         [HttpGet("{id}")]
        public async Task<IActionResult> GetProductByID(string id)
        {
            var value = await _productService.GetByIDProductAsync(id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productService.CreateProductAsync(createProductDto);
            return Ok("Ürün başarıyla eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return Ok("Ürün başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _productService.UpdateProductAsync(updateProductDto);
            return Ok("Ürün başarıyla güncellendi");
        }
 
    }
}