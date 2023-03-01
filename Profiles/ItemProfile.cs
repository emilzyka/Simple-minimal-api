using AutoMapper;
using MinimalAPI.Contracts;
using MinimalAPI.Models;

namespace MinimalAPI.Profiles
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            //source -> target
            CreateMap<Item, ItemReadDto>();
            CreateMap<ItemCreateDto, Item>();
            CreateMap<ItemUpdateDto, Item>();
        }
    }
}
