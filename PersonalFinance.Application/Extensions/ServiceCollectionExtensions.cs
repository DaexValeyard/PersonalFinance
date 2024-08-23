using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PersonalFinance.Application.Users;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddAplication(this IServiceCollection services)
    {
        var applicationAssembly = typeof(ServiceCollectionExtensions).Assembly;

        // Middleware
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(applicationAssembly));

        services.AddAutoMapper(applicationAssembly);

        services.AddValidatorsFromAssembly(applicationAssembly)
            .AddFluentValidationAutoValidation();

        // Services
        services.AddScoped<IUserContext, UserContext>();
        services.AddHttpContextAccessor();
    }
}
