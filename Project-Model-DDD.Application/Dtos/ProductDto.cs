﻿namespace Project_Model_DDD.Application.Dtos
{
    public class ProductDto
    {
        public int Id { get; internal set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}