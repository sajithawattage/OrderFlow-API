using System.Net;
using System.Text.Json;

namespace OrderFlow.Api.Middlewares
{
    public static class ResponseMiddlewareExtensions
    {
        public static IApplicationBuilder UseResponseMiddleware(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GenericResponseMiddleware>();
        }
    }

    public class GenericResponseMiddleware
    {
        private readonly RequestDelegate _next;

        public GenericResponseMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            var originalBodyStream = httpContext.Response.Body;
            using (var responseBody = new MemoryStream())
            {
                httpContext.Response.Body = responseBody;

                try
                {
                    await _next(httpContext);

                    var statusCode = httpContext.Response.StatusCode;
                    var responseBodyContent = await FormatResponse(httpContext.Response);

                    var response = new ResponseMetadata
                    {
                        StatusCode = (HttpStatusCode)statusCode,
                        isError = statusCode >= 400,
                        body = responseBodyContent
                    };

                    if (response.isError)
                        response.message = "An error occurred during your request.";

                    await httpContext.Response.WriteAsJsonAsync(response);
                }
                catch (Exception ex)
                {
                    // handle the exception however you need to.
                    throw;
                }
                finally
                {
                    httpContext.Response.Body = originalBodyStream;
                }
            }
        }

        private async Task<object> FormatResponse(HttpResponse response)
        {
            response.Body.Seek(0, SeekOrigin.Begin);
            var text = await new StreamReader(response.Body).ReadToEndAsync();
            response.Body.Seek(0, SeekOrigin.Begin);

            return string.IsNullOrWhiteSpace(text) ? null : JsonSerializer.Deserialize<object>(text);
        }
    }

    public class ResponseMetadata
    {
        public string message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public bool isError { get; set; } = false;
        public object body { get; set; }
    }
}
