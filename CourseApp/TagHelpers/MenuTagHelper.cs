using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.TagHelpers
{
    //     < a class= "nav-link" href = "#" > Features </ a >
    public static class BsClass
    {
        public const string NavLink = "nav-link";
    }
    public static class Bslink
    {
        public const string Link1 = "menu-1.html";
        public const string Link2 = "menu-2.html";
        public const string Link3 = "menu-3.html";
    }
    [HtmlTargetElement("bs-link", Attributes = "title,link")]
    public class MenuTagHelper:TagHelper
    {
        public string Title { get; set; }
        public string Link { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.Add("class", $"{BsClass.NavLink}");
            output.Attributes.Add("href", $"{Link}");
            output.Content.SetContent(Title);
            base.Process(context, output);
        }
    }
}
