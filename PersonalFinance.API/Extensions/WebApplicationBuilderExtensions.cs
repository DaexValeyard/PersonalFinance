using PersonalFinance.API.Middlewares;
using Serilog;

namespace PersonalFinance.API.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static void AddPresentation(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();

        // Middleware
        builder.Services.AddScoped<RequestTimeLoggingMiddleware>();
        builder.Services.AddScoped<ErrorHandlingMiddleware>();

        // Logging settings using Serilog
        builder.Host.UseSerilog((context, configuration) =>
            configuration.ReadFrom.Configuration(context.Configuration)
        );
    }
}
