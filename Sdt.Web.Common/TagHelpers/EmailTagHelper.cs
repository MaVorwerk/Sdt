using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sdt.Web.Common.TagHelpers
{
    // <email display-name="admin" adresse="mailto:admin@admin.com">admin</email>
    public class EmailTagHelper : TagHelper
    {
        public string DisplayName { get; set; }
        public string Adresse { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a"; // ersetzt <email> mit <a>
            var adresse = $"mailto:{Adresse}";
            output.Attributes.SetAttribute("href", adresse);
            output.Content.SetContent(DisplayName);
        }
    }
}
