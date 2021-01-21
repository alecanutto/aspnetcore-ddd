using System;

namespace Project_Model_DDD.Domain.Entities
{
    public class Client : Base
    {  
        public string LastName { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }      

        public bool ClientHasDiscount(Client client)
        {
            return client.IsActive && (DateTime.Now.Subtract(client.RegistrationDate).TotalDays / 365) >= 5;
        }

        public string GetFullName()
        {
            return $"{LastName}, {Name}";
        }

        public string GetFullAddress()
        {
            return $"{Address}, {City} - {State}";
        }
    }
}
