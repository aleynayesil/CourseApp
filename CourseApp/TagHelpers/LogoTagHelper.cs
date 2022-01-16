using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.TagHelpers
{

    public static class BsElementType
    {
        public const string Navbar = "navbar-brand";
    }
    public static class BsSize
    {
        public const string Sm = "50";
        public const string Md = "60px";
        public const string Lg = "70px";
        public const string Xlg = "80px";
    }
    public static class Bsimages
    {
        public const string Book = "book.png";
        public const string Books = "books.png";
        public const string Coding = "coding.png";
        public const string Graduation = "graduation.png";
    }
    [HtmlTargetElement("bs-logo", Attributes = "images")]
    public class LogoTagHelper : TagHelper
    {
        public string Images { get; set; }
        public string Size { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";
            output.Attributes.Add("class", $"{BsElementType.Navbar}");
            output.Attributes.Add("src", $"{Images}");
            output.Attributes.Add("width", $"{Size}");
            output.Attributes.Add("height", $"{Size}");

            base.Process(context, output);
        }
    }
}
//}  <a class="navbar-brand" href="#">Navbar</a>
//     < a class= "nav-link" href = "#" > Features </ a >


//    <nav class="navbar navbar-expand-lg navbar-light bg-light">
//
//  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
//    <span class="navbar-toggler-icon"></span>
//  </button>
//  <div class="collapse navbar-collapse" id="navbarNav">
//    <ul class="navbar-nav">
//      <li class="nav-item">
//       
//      </li>
//      <li class="nav-item">
//        <a class="nav-link" href="#">Pricing</a>
//      </li>
//    </ul>
//  </div>
//</nav>