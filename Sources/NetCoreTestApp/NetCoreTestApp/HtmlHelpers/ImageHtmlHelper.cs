using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NetCoreTestApp.HtmlHelpers
{
    public static class ImageHtmlHelper
    {
        public static IHtmlContent NorthwindImageLink(this IHtmlHelper htmlHelper, int imageId, string linkText)
           => new HtmlString($"<a href='/images/{imageId}'>{linkText}</a>");
    }
}
