using AutoMapper;
using Project_Model_DDD.Application.Dtos;
using Project_Model_DDD.Domain.Entities;


namespace Project_Model_DDD.Application.Mappers
{
    public class ModelToDtoMappingClient : Profile
    {
        public ModelToDtoMappingClient()
        {
            ClientDtoMap();
        }

        private void ClientDtoMap()
        {
            CreateMap<Client, ClientDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.CellNumber, opt => opt.MapFrom(x => x.CellNumber))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(x => x.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.CellNumber, opt => opt.MapFrom(x => x.CellNumber));

        }
    }
}