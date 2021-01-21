namespace Project_Model_DDD.Domain.Entities
{
    public class Product : Base
    {     
        public string BarCode { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public bool ProductIsAvailable(Product product)
        {
            return product.Price > 0 && product.Stock > 0;
        }

    }
}
