using AutoMapper;
using Project_Model_DDD.Application.Dtos;
using Project_Model_DDD.Domain.Entities;

namespace Project_Model_DDD.Application.Mappers
{
    public class DtoToModelMappingProduct : Profile
    {
        public DtoToModelMappingProduct()
        {
            ProductMap();
        }

        private void ProductMap()
        {
            CreateMap<ProductDto, Product>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(x => x.Price))
                .ForMember(dest => dest.IsActive, opt => opt.Ignore());
        }
    }
}