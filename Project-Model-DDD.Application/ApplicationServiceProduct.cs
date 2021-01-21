using Project_Model_DDD.Application.Dtos;
using Project_Model_DDD.Application.Interfaces;
using Project_Model_DDD.Application.Interfaces.Mappers;
using Project_Model_DDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace Project_Model_DDD.Application
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct serviceProduct;
        private readonly IMapperProduct mapperProduct;

        public ApplicationServiceProduct(IServiceProduct serviceProduct, IMapperProduct mapperProduct)
        {
            this.serviceProduct = serviceProduct;
            this.mapperProduct = mapperProduct;
        }

        public void Add(ProductDto productDto)
        {
            var product = mapperProduct.MapperDtoToEntity(productDto);
            serviceProduct.Add(product);
        }

        public IEnumerable<ProductDto> GetAll()
        {
            var products = serviceProduct.GetAll();
            return mapperProduct.MapperListProductsDto(products);
        }

        public ProductDto GetById(int id)
        {
            var product = serviceProduct.GetById(id);
            return mapperProduct.MapperEntityToDto(product);
        }

        public void Remove(ProductDto productDto)
        {
            var product = mapperProduct.MapperDtoToEntity(productDto);
            serviceProduct.Remove(product);
        }

        public void Update(ProductDto productDto)
        {
            var product = mapperProduct.MapperDtoToEntity(productDto);
            serviceProduct.Update(product);
        }
    }
}