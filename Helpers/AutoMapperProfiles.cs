using AutoMapper;
using CulinaryGuide.API.Dtos;
using CulinaryGuide.API.Models;

namespace CulinaryGuide.API.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
           CreateMap<UserForRegisterDto, User>();
        CreateMap<User, UserForList>()
        .ForMember(dest => dest.Age, opt => {
                opt.MapFrom(d => d.DateOfBirth.CalculateAge());
            });;

        }
    }
}