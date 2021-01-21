using AutoMapper;
using Project_Model_DDD.Application.Dtos;
using Project_Model_DDD.Domain.Entities;

namespace Project_Model_DDD.Application.Mappers
{
    public class ModelToDtoMappingProduct : Profile
    {
        public ModelToDtoMappingProduct()
        {
            ProductDtoMap();
        }

        private void ProductDtoMap()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(x => x.Price))
                .ForMember(dest => dest.Stock, opt => opt.MapFrom(x => x.Stock));
        }
    }
}