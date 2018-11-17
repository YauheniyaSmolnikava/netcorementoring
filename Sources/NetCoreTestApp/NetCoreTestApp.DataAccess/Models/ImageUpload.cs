using Microsoft.AspNetCore.Http;
namespace NetCoreTestApp.DataAccess.Models
{
    public class ImageUpload
    {
        public IFormFile File { get; set; }
        public int CategoryId { get; set; }

    }
}
