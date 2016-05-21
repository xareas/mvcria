using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorialMVC70486.TagHelpers
{
    /// <summary>
    /// una clase para de ayuda para la construccion de HTML.
    /// </summary>
    public static class TagHelperBuilder
    {
        
            #region Attribute

           
            public static TagBuilder THBAttribute(this TagBuilder builder, string attribute, string value, bool replaceExisting = false)
            {
                builder.MergeAttribute(attribute, value, replaceExisting);
                return builder;
            }

            public static TagBuilder THBAttribute(this TagBuilder builder, string attribute, IHtmlString html, bool replaceExisting = false)
            {
                return THBAttribute(builder, attribute, html.ToString(), replaceExisting);
            }

            #endregion

            #region Class

           
            public static TagBuilder THBClass(this TagBuilder builder, string @class)
            {
                builder.AddCssClass(@class);
                return builder;
            }

            #endregion

            #region Html
        
            public static TagBuilder THBHtml(this TagBuilder builder, string html)
            {
                builder.InnerHtml = html;
                return builder;
            }

              public static TagBuilder THBHtml(this TagBuilder builder, TagBuilder tag)
            {
                return THBHtml(builder, tag.ToString());
            }

            public static TagBuilder THBHtml(this TagBuilder builder, IHtmlString html)
            {
                return THBHtml(builder, html.ToString());
            }

            #endregion

            #region AppendHtml

         
            public static TagBuilder THBAppendHtml(this TagBuilder builder, string html)
            {
                if (builder.InnerHtml == null)
                    builder.InnerHtml = string.Empty;
                builder.InnerHtml += html;
                return builder;
            }

            public static TagBuilder THBAppendHtml(this TagBuilder builder, TagBuilder tag)
            {
                return THBAppendHtml(builder, tag.ToString());
            }

            public static TagBuilder THBAppendHtml(this TagBuilder builder, IHtmlString html)
            {
                return THBAppendHtml(builder, html.ToString());
            }

            #endregion

            #region PrependHtml

            public static TagBuilder THBPrependHtml(this TagBuilder builder, string html)
            {
                if (builder.InnerHtml == null)
                    builder.InnerHtml = string.Empty;
                builder.InnerHtml = html + builder.InnerHtml;
                return builder;
            }

            public static TagBuilder THBPrependHtml(this TagBuilder builder, TagBuilder tag)
            {
                return THBPrependHtml(builder, tag.ToString());
            }

            public static TagBuilder THBPrependHtml(this TagBuilder builder, IHtmlString html)
            {
                return THBPrependHtml(builder, html.ToString());
            }

            #endregion

            public static MvcHtmlString THBToHtml(this TagBuilder builder)
            {
                return MvcHtmlString.Create(builder.ToString());
            }

            public static MvcHtmlString THBToHtml(this TagBuilder builder, TagRenderMode renderMode)
            {
                return MvcHtmlString.Create(builder.ToString(renderMode));
            }
        }

    
}