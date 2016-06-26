using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TesteCustomTagHelper
{
    [HtmlTargetElement("a", Attributes = ConfirmationMessageAttributeName)]
    public class ConfirmationMessageTagHelper : TagHelper
    {
        private const string ConfirmationMessageAttributeName = "confirmation-message";

        [HtmlAttributeName(ConfirmationMessageAttributeName)]
        public string ConfirmationMessage { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (output.Attributes.Where(a => a.Name.ToLower() == "onclick").Count() == 0)
            {
                output.Attributes.Add("onclick",
                    new HtmlString($"return confirm('{ConfirmationMessage}');"));
            }
        }
    }
}