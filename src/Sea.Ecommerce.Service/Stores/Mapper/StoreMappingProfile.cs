using AutoMapper;
using Sea.Ecommerce.Repository.Models;
using Sea.Ecommerce.Service.Stores.Dto;

namespace Sea.Ecommerce.Service.Stores.Mapper
{
    public class StoreMappingProfile : Profile
    {
        public StoreMappingProfile()
        {
            CreateMap<Store, StoreResult>();
        }
    }
}
