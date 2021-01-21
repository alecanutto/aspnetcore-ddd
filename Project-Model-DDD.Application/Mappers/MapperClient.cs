using Project_Model_DDD.Application.Dtos;
using Project_Model_DDD.Application.Interfaces.Mappers;
using Project_Model_DDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Project_Model_DDD.Application.Mappers
{
    public class MapperClient : IMapperClient
    {
        public Client MapperDtoToEntity(ClientDto clientDto)
        {
            var client = new Client()
            {
                Id = clientDto.Id,
                Name = clientDto.Name,
                LastName = clientDto.LastName,
                Email = clientDto.Email
            };
            return client;
        }

        public ClientDto MapperEntityToDto(Client client)
        {
            var clientDto = new ClientDto()
            {
                Id = client.Id,
                Name = client.Name,
                LastName = client.LastName,
                Email = client.Email
            };
            return clientDto;
        }

        public IEnumerable<ClientDto> MapperListClientsDto(IEnumerable<Client> clients)
        {
            return clients.Select(c => new ClientDto { Id = c.Id, Name = c.Name, LastName = c.LastName, Email = c.Email });
        }
    }
}