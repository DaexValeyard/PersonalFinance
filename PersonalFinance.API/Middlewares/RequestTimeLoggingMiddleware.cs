using System.Diagnostics;

namespace PersonalFinance.API.Middlewares;

public class RequestTimeLoggingMiddleware(ILogger<RequestTimeLoggingMiddleware> logger) : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var watchdog = Stopwatch.StartNew();

        await next.Invoke(context);

        watchdog.Stop();

        if (watchdog.ElapsedMilliseconds > 4000)
            logger.LogInformation("Request [{Verb} at {Path} took {Time} ms]",
                context.Request.Method,
                context.Request.Path,
                watchdog.ElapsedMilliseconds);
    }
}
