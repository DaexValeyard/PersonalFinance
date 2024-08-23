using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersonalFinance.Infrastructure.Persistence;

namespace PersonalFinance.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("PersonalFinanceDb");
        services.AddDbContext<PersonalFinanceDbContext>(options =>
            options.UseSqlServer(connectionString)
                .EnableSensitiveDataLogging());
    }
}
