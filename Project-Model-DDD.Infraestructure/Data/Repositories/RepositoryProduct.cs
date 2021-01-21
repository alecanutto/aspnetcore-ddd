using Project_Model_DDD.Domain.Core.Interfaces.Repositories;
using Project_Model_DDD.Domain.Entities;
using Project_Model_DDD.Infraestructure.Data;

namespace Project_Model_DDD.Infrastructure.Data.Repositories
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        private readonly SqlContext sqlContext;

        public RepositoryProduct(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}