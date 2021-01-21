using Project_Model_DDD.Application.Dtos;
using Project_Model_DDD.Domain.Entities;
using System.Collections.Generic;

namespace Project_Model_DDD.Application.Interfaces.Mappers
{
    public interface IMapperProduct
    {
        Product MapperDtoToEntity(ProductDto productDto);

        IEnumerable<ProductDto> MapperListProductsDto(IEnumerable<Product> products);

        ProductDto MapperEntityToDto(Product product);
    }
}