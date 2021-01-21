using Project_Model_DDD.Domain.Core.Interfaces.Repositories;
using Project_Model_DDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Project_Model_DDD.Infra.Data.Repositories
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        public IEnumerable<Product> GetByName(string name)
        {
            return sqlContext.Products.Where(p => p.Name.StartsWith(name));
        }
    }
}