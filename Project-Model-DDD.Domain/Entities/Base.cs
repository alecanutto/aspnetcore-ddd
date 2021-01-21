using System;

namespace Project_Model_DDD.Domain.Entities
{
    public class Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
