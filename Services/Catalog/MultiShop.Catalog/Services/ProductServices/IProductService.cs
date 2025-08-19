using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MultiShop.Catalog.Dtos.ProductDetailDtos;

namespace MultiShop.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string id);
        Task<GetByIDProductDto> GetByIDProductAsync(string id);

    }
}