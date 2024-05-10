using Request.Body.Peeker;

namespace TimeTracker.Presentation.Http.Middlewares;

public class LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger)
{
    public async Task InvokeAsync(HttpContext context)
    {
        logger.LogInformation("Request: {Method} {Path}", context.Request.Method, context.Request.Path);
        logger.LogInformation("Data: {Body}", await context.Request.PeekBodyAsync());

        await next(context);
    }
}