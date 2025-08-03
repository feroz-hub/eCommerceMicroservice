namespace eCommerce.API.Middlewares;

public class ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
{
    public async Task Invoke(HttpContext httpContext)
    {
        try
        {
            await next(httpContext);
        }
        catch (Exception ex)
        {
            // Log the exception type and message
            logger.LogError("{S}:{ExMessage}", ex.GetType().ToString(), ex.Message);
            if (ex.InnerException != null)
            {
                logger.LogError("{S}:{ExMessage}", ex.InnerException.GetType().ToString(), ex.InnerException.Message);
            }

            // Set the response status code and content type
            httpContext.Response.StatusCode = 500; // Internal Server Error
            httpContext.Response.ContentType = "application/json";
            // Create a response object
            await httpContext.Response.WriteAsJsonAsync(new
            {
                Message = ex.Message,
                ExceptionType = ex.GetType().ToString()
            });
        }

    }
}
public static class ExceptionHandlingMiddlewareExtensions
{
    public static IApplicationBuilder UseExceptionHandlingMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ExceptionHandlingMiddleware>();
    }
}