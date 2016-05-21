using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorialMVC70486.TagHelpers
{
    public static class ImageHelper
    {
        public static MvcHtmlString image(this HtmlHelper helper,string url,string id,string alternateText)
        {
            
            var builder = new TagBuilder("img");

            builder.AddCssClass("img-responsive");
            builder.GenerateId(id);
            builder.MergeAttribute("src",url);
            builder.MergeAttribute("alt",alternateText);

            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));

        }


    }
}