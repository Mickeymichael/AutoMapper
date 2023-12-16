using AutoMapper;
using TestAutoMapper.Dtos;
using TestAutoMapper.Models;

namespace TestAutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<Book, BookDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(src => src.BookId))
                .ForMember(dest => dest.isFree, src => src.MapFrom(src => src.Price == 0))
                .ReverseMap();











           
        }
    }
}
