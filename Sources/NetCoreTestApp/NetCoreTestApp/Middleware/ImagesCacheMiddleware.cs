using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;

namespace NetCoreTestApp.Middleware
{
    public class ImagesCacheMiddleware
    {
        private readonly ImagesCacheOptions _options;
        private readonly RequestDelegate _next;

        public ImagesCacheMiddleware(RequestDelegate next, IOptions<ImagesCacheOptions> options)
        {
            _options = options.Value;
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var path = context.Request.Path.Value;

            if (path.Contains("images"))
            {
                var categoryId = path.Substring(path.LastIndexOf('/') + 1);

                var cacheDirectoryPath = Path.Combine(Directory.GetCurrentDirectory(), _options.CacheDirectory);

                if (!Directory.Exists(cacheDirectoryPath))
                {
                    Directory.CreateDirectory(cacheDirectoryPath);
                }

                var fileFullPath = Path.Combine(cacheDirectoryPath, categoryId + ".bmp");

                if (File.Exists(fileFullPath))
                {
                    DateTime creationDate = File.GetCreationTime(fileFullPath);

                    if ((DateTime.Now - creationDate).TotalMinutes < _options.CahceExpirationTimeInMinutes.TotalMinutes)
                    {
                        var bytes = File.ReadAllBytes(Path.Combine(cacheDirectoryPath, $"{categoryId}.bmp"));
                        context.Response.ContentType = "image/bmp";
                        await context.Response.Body.WriteAsync(bytes, 0, bytes.Length);
                        return;
                    }

                    File.Delete(fileFullPath);
                }

                var originalBodyStream = context.Response.Body;

                using (var responseBody = new MemoryStream())
                {
                    context.Response.Body = responseBody;

                    await _next(context);

                    var filesCount = Directory.GetFiles(cacheDirectoryPath, "*", SearchOption.TopDirectoryOnly).Length;

                    if (filesCount < _options.MaxCachedImagesCount)
                    {
                        Image img = Image.FromStream(context.Response.Body);
                        img.Save(Path.Combine(cacheDirectoryPath, $"{categoryId}.bmp"), ImageFormat.Bmp);
                    }

                    context.Response.Body.Seek(0, SeekOrigin.Begin);

                    await responseBody.CopyToAsync(originalBodyStream);
                }
            }
            else
            {
                await _next(context);
            }
        }

        private void FormatResponse(HttpResponse response)
        {
            response.Body.Seek(0, SeekOrigin.Begin);
        }
    }
}
