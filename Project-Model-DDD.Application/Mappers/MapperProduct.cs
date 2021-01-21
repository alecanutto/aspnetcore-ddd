using Project_Model_DDD.Application.Dtos;
using Project_Model_DDD.Application.Interfaces.Mappers;
using Project_Model_DDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Project_Model_DDD.Application.Mappers
{
    public class MapperProduct : IMapperProduct
    {
        public Product MapperDtoToEntity(ProductDto productDto)
        {
            var product = new Product()
            {
                Id = productDto.Id,
                Name = productDto.Name,
                Price = productDto.Price,
                Stock = productDto.Stock
            };
            return product;
        }

        public ProductDto MapperEntityToDto(Product product)
        {
            var productDto = new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock
            };
            return productDto;
        }

        public IEnumerable<ProductDto> MapperListProductsDto(IEnumerable<Product> products)
        {
            return products.Select(p => new ProductDto { Id = p.Id, Name = p.Name, Price = p.Price, Stock = p.Stock });
        }
    }
}