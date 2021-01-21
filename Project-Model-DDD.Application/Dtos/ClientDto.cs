namespace Project_Model_DDD.Application.Dtos
{
    public class ClientDto
    {
        public int Id { get; internal set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
    }
}