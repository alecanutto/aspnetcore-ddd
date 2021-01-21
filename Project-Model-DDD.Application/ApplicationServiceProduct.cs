using AutoMapper;
using Project_Model_DDD.Application.Dtos;
using Project_Model_DDD.Application.Interfaces;
using Project_Model_DDD.Domain.Core.Interfaces.Services;
using Project_Model_DDD.Domain.Entities;
using System.Collections.Generic;

namespace Project_Model_DDD.Application
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct serviceProduct;
        private readonly IMapper mapper;

        public ApplicationServiceProduct(IServiceProduct serviceProduct, IMapper mapper)
        {
            this.serviceProduct = serviceProduct;
            this.mapper = mapper;
        }

        public void Add(ProductDto productDto)
        {
            var product = mapper.Map<Product>(productDto);
            serviceProduct.Add(product);
        }

        public IEnumerable<ProductDto> GetAll()
        {
            var products = serviceProduct.GetAll();
            return mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public ProductDto GetById(int id)
        {
            var product = serviceProduct.GetById(id);
            return mapper.Map<ProductDto>(product);
        }

        public void Remove(ProductDto productDto)
        {
            var product = mapper.Map<Product>(productDto);
            serviceProduct.Remove(product);
        }

        public void Update(ProductDto productDto)
        {
            var product = mapper.Map<Product>(productDto);
            serviceProduct.Update(product);
        }
    }
}