using Microsoft.AspNetCore.Razor.TagHelpers;

namespace NetCoreTestApp.TagHelpers
{
    [HtmlTargetElement("a", Attributes = "northwind-id")]
    public class NorthwindIdTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.Add("href", $"/images/{context.AllAttributes["northwind-id"].Value}");
            output.Attributes.RemoveAll("northwind-id");
        }
    }
}
