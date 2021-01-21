using AutoMapper;
using Project_Model_DDD.Application.Dtos;
using Project_Model_DDD.Domain.Entities;

namespace Project_Model_DDD.Application.Mappers
{
    public class DtoToModelMappingClient : Profile
    {
        public DtoToModelMappingClient()
        {
            ClientMap();
        }

        private void ClientMap()
        {
            CreateMap<ClientDto, Client>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(x => x.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.RegistrationDate, opt => opt.Ignore())
                .ForMember(dest => dest.IsActive, opt => opt.Ignore());
        }
    }
}