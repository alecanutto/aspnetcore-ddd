using Project_Model_DDD.Domain.Core.Interfaces.Repositories;
using Project_Model_DDD.Domain.Core.Interfaces.Services;
using Project_Model_DDD.Domain.Entities;

namespace Project_Model_DDD.Domain.Services
{
    public class ServiceProduct : ServiceBase<Product>, IServiceProduct
    {
        private readonly IRepositoryProduct repositoryProduct;

        public ServiceProduct(IRepositoryProduct repositoryProduct) : base(repositoryProduct)
        {
            this.repositoryProduct = repositoryProduct;
        }
    }
}