using AutoMapper;
using Project_Model_DDD.Application.Dtos;
using Project_Model_DDD.Application.Interfaces;
using Project_Model_DDD.Domain.Core.Interfaces.Services;
using Project_Model_DDD.Domain.Entities;
using System.Collections.Generic;

namespace Project_Model_DDD.Application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient serviceClient;
        private readonly IMapper mapper;

        public ApplicationServiceClient(IServiceClient serviceClient, IMapper mapper)
        {
            this.serviceClient = serviceClient;
            this.mapper = mapper;
        }

        public void Add(ClientDto clientDto)
        {
            var client = mapper.Map<Client>(clientDto);
            serviceClient.Add(client);
        }

        public IEnumerable<ClientDto> GetAll()
        {
            var clients = serviceClient.GetAll();
            return mapper.Map<IEnumerable<ClientDto>>(clients);
        }

        public ClientDto GetById(int id)
        {
            var client = serviceClient.GetById(id);
            return mapper.Map<ClientDto>(client);
        }

        public void Remove(ClientDto clientDto)
        {
            var client = mapper.Map<Client>(clientDto);
            serviceClient.Remove(client);
        }

        public void Update(ClientDto clientDto)
        {
            var client = mapper.Map<Client>(clientDto);
            serviceClient.Update(client);
        }
    }
}