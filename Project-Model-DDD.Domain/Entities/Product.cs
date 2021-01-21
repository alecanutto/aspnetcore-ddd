namespace Project_Model_DDD.Domain.Entities
{
    public class Product : Base
    {     
        public string BarCode { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}
