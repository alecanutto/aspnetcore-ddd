using Project_Model_DDD.Application.Dtos;
using Project_Model_DDD.Domain.Entities;
using System.Collections.Generic;

namespace Project_Model_DDD.Application.Interfaces.Mappers
{
    public interface IMapperClient
    {
        Client MapperDtoToEntity(ClientDto clientDto);

        IEnumerable<ClientDto> MapperListClientsDto(IEnumerable<Client> clients);

        ClientDto MapperEntityToDto(Client client);
    }
}