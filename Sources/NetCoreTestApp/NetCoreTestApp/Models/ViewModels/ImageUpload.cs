using Microsoft.AspNetCore.Http;
namespace NetCoreTestApp.Models
{
    public class ImageUpload
    {
        public IFormFile File { get; set; }
        public int CategoryId { get; set; }

    }
}
