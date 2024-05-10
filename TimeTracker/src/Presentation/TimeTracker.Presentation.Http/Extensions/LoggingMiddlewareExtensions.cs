using TimeTracker.Presentation.Http.Middlewares;

namespace TimeTracker.Presentation.Http.Extensions;

public static class LoggingMiddlewareExtensions
{
    public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder app)
    {
        app.UseMiddleware<LoggingMiddleware>();
        return app;
    }
}