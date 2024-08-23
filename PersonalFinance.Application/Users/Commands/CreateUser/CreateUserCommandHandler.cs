using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Application.Users.Commands.CreateUser;

public class CreateUserCommandHandler(ILogger<CreateUserCommandHandler> logger,
    IMapper mapper,
    UserManager<User> userManager,
    SignInManager<User> signInManager) : IRequestHandler<CreateUserCommand, string>
{
    public async Task<string> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        logger.LogInformation("\nCreating new user: {Email} [{RFC}]", request.Email, request.RFC);

        var user = mapper.Map<User>(request);

        var result = await userManager.CreateAsync(user, request.Password);

        if (!result.Succeeded)
        {
            throw new Exception($"{nameof(CreateUserCommandHandler)} | {result.Errors.ToString()}");
        }

        return user.Email;
    }
}
