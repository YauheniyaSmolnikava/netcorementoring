using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;

namespace NetCoreTestApp.Middleware
{
    public static class ImagesCacheMiddlewareExtensions
    {
        public static IApplicationBuilder UseImagesCache(this IApplicationBuilder app, ImagesCacheOptions options)
        {
            return app.UseMiddleware<ImagesCacheMiddleware>(Options.Create(options));
        }
    }
}
