#pragma checksum "C:\Users\Bondo\source\repos\principlesformen\principlesformen\Pages\Shared\_SidebarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7521318e14eed88824f947686fd11bc51072cf95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(principlesformen.Pages.Shared.Pages_Shared__SidebarPartial), @"mvc.1.0.view", @"/Pages/Shared/_SidebarPartial.cshtml")]
namespace principlesformen.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Bondo\source\repos\principlesformen\principlesformen\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bondo\source\repos\principlesformen\principlesformen\Pages\_ViewImports.cshtml"
using principlesformen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bondo\source\repos\principlesformen\principlesformen\Pages\_ViewImports.cshtml"
using principlesformen.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7521318e14eed88824f947686fd11bc51072cf95", @"/Pages/Shared/_SidebarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c150b80bb3ffd4126f03b164ebfc4edab0f4935", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__SidebarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<aside class=\"col-12 col-lg-3 float-right\">\r\n    <div class=\"d-inline-block width-100 margin-45px-bottom sm-margin-25px-bottom\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7521318e14eed88824f947686fd11bc51072cf953691", async() => {
                WriteLiteral(@"
            <div class=""position-relative"">
                <input type=""email"" class=""bg-transparent text-small m-0 border-color-extra-light-gray medium-input float-left"" placeholder=""Enter your keywords..."">
                <button type=""submit"" class=""bg-transparent  btn position-absolute right-0 top-1""><i class=""fas fa-search no-margin-left""></i></button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""margin-45px-bottom sm-margin-25px-bottom"">
        <div class=""text-extra-dark-gray margin-20px-bottom alt-font text-uppercase text-small font-weight-600 aside-title""><span>About Me</span></div>
        <a href=""about-me.html""><img src=""images/aside-image-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 840, "\"", 846, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""margin-25px-bottom"" /></a>
        <p class=""margin-20px-bottom text-small"">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry’s standard.</p>
        <a class=""btn btn-very-small btn-dark-gray text-uppercase"" href=""about-me.html"">About Author</a>
    </div>
    <div class=""margin-50px-bottom"">
        <div class=""text-extra-dark-gray margin-20px-bottom alt-font text-uppercase font-weight-600 text-small aside-title""><span>Follow Us</span></div>
        <div class=""social-icon-style-1 text-center"">
            <ul class=""extra-small-icon"">
                <li><a class=""facebook"" href=""http://facebook.com/"" target=""_blank""><i class=""fab fa-facebook-f""></i></a></li>
                <li><a class=""twitter"" href=""http://twitter.com/"" target=""_blank""><i class=""fab fa-twitter""></i></a></li>
                <li><a class=""google"" href=""http://google.com/"" target=""_blank""><i class=""fab fa-google-plus-g""></i></a></li>
                <li><a clas");
            WriteLiteral(@"s=""dribbble"" href=""http://dribbble.com/"" target=""_blank""><i class=""fab fa-dribbble""></i></a></li>
                <li><a class=""linkedin"" href=""http://linkedin.com/"" target=""_blank""><i class=""fab fa-linkedin-in""></i></a></li>
            </ul>
        </div>
    </div>
    <div class=""margin-45px-bottom sm-margin-25px-bottom"">
        <div class=""text-extra-dark-gray margin-20px-bottom alt-font text-uppercase font-weight-600 text-small aside-title""><span>Categories</span></div>
        <ul class=""list-style-6 margin-50px-bottom text-small"">
            <li><a href=""blog-masonry.html"">Arts and Entertainment</a><span>12</span></li>
            <li><a href=""blog-masonry.html"">Blog</a><span>05</span></li>
            <li><a href=""blog-masonry.html"">Blog Full width</a><span>08</span></li>
            <li><a href=""blog-masonry.html"">Blog Grid</a><span>10</span></li>
            <li><a href=""blog-masonry.html"">Branding</a><span>21</span></li>
            <li><a href=""blog-masonry.html"">Design Tutorials<");
            WriteLiteral(@"/a><span>09</span></li>
            <li><a href=""blog-masonry.html"">Designing</a><span>07</span></li>
            <li><a href=""blog-masonry.html"">Feature</a><span>06</span></li>
            <li><a href=""blog-masonry.html"">Home Blog</a><span>10</span></li>
            <li><a href=""blog-masonry.html"">Onepage Fashion</a><span>11</span></li>
            <li><a href=""blog-masonry.html"">Sample</a><span>06</span></li>
        </ul>
    </div>
    <div class=""bg-deep-pink padding-30px-all text-white-2 text-center margin-45px-bottom sm-margin-25px-bottom"">
        <i class=""fas fa-quote-left icon-small margin-15px-bottom d-block""></i>
        <span class=""text-extra-large font-weight-300 margin-20px-bottom d-block"">The future belongs to those who believe in the beauty of their dreams.</span>
        <a class=""btn btn-very-small btn-transparent-white border-width-1 text-uppercase"" href=""portfolio-boxed-grid-overlay.html"">Explore Portfolio</a>
    </div>
    <div class=""margin-45px-bottom sm-margin-25px-bot");
            WriteLiteral(@"tom"">
        <div class=""text-extra-dark-gray margin-25px-bottom alt-font text-uppercase font-weight-600 text-small aside-title""><span>Popular post</span></div>
        <ul class=""latest-post position-relative"">
            <li class=""media"">
                <figure>
                    <a href=""blog-masonry.html""><img src=""images/aside-image-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4276, "\"", 4282, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                </figure>
                <div class=""media-body text-small""><a href=""blog-masonry.html"" class=""text-extra-dark-gray""><span class=""d-inline-block margin-5px-bottom"">Traveling abroad will change you forever</span></a> <span class=""d-block text-medium-gray text-small"">April 30, 2016</span></div>
            </li>
            <li class=""media"">
                <figure>
                    <a href=""blog-masonry.html""><img src=""images/aside-image-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4763, "\"", 4769, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                </figure>
                <div class=""media-body text-small""><a href=""blog-masonry.html"" class=""text-extra-dark-gray""><span class=""d-inline-block margin-5px-bottom"">Having a new perspec-tive on new york city</span></a> <span class=""d-block text-medium-gray text-small"">March 10, 2016</span></div>
            </li>
            <li class=""media"">
                <figure>
                    <a href=""blog-masonry.html""><img src=""images/aside-image-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5252, "\"", 5258, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                </figure>
                <div class=""media-body text-small""><a href=""blog-masonry.html"" class=""text-extra-dark-gray""><span class=""d-inline-block margin-5px-bottom"">The incredible talents of street performers</span></a> <span class=""d-block text-medium-gray text-small"">March 05, 2016</span></div>
            </li>
            <li class=""media"">
                <figure>
                    <a href=""blog-masonry.html""><img src=""images/aside-image-5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5742, "\"", 5748, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                </figure>
                <div class=""media-body text-small""><a href=""blog-masonry.html"" class=""text-extra-dark-gray""><span class=""d-inline-block margin-5px-bottom"">Praesent placerat risus quis eros</span></a> <span class=""d-block text-medium-gray text-small"">March  01, 2016</span></div>
            </li>
        </ul>
    </div>   
    <div class=""margin-45px-bottom sm-margin-25px-bottom"">
        <div class=""text-extra-dark-gray margin-25px-bottom alt-font text-uppercase font-weight-600 text-small aside-title""><span>Newsletter</span></div>
        <div class=""d-inline-block width-100"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7521318e14eed88824f947686fd11bc51072cf9512098", async() => {
                WriteLiteral(@"
                <div class=""position-relative"">
                    <input type=""email"" class=""bg-transparent text-small m-0 border-color-extra-light-gray medium-input float-left"" placeholder=""Enter your email..."">
                    <button type=""submit"" class=""bg-transparent text-large btn position-absolute right-0 top-3""><i class=""far fa-envelope no-margin-left""></i></button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>   \r\n</aside>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
