using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Sdt.Web.Common.TagHelpers
{
    [HtmlTargetElement("imagedataurl")]
    public class ImageDataUrlTagHelper : TagHelper
    {
        public string ImageMimeType { get; set; }
        public byte[] Image { get; set; }
        public string Width { get; set; } = "120";
        public string AltSrc { get; set; } = "/images/noimg.jpg";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img"; // <img>
            output.Attributes.SetAttribute("width", Width); // <img width="120">
            var src = !string.IsNullOrEmpty(ImageMimeType) && Image?.Length > 0
                ? $"data:{ImageMimeType};base64,{Convert.ToBase64String(Image)}"  
                : AltSrc;

            output.Attributes.SetAttribute("src", src); // <img src="data... oder <img src="/images/noimg.jpg
            output.TagMode = TagMode.SelfClosing;
        }
    }
}
