using AutoMapper;
using PersonalFinance.Application.Users.Commands.CreateUser;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Application.Users.Dtos;

public class UsersProfile : Profile
{
    public UsersProfile()
    {
        CreateMap<CreateUserCommand, User>()
            .ForMember(u => u.UserName, opt =>
                opt.MapFrom(src => src.Email))
            .ForMember(u => u.ConcurrencyStamp, opt =>
                opt.UseDestinationValue());
    }
}
