#pragma checksum "C:\Users\Bondo\source\repos\principlesformen\principlesformen\Pages\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddd9a1307f7da18ac722c5e4abfe5964d72f8f8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(principlesformen.Pages.Pages_Post), @"mvc.1.0.razor-page", @"/Pages/Post.cshtml")]
namespace principlesformen.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddd9a1307f7da18ac722c5e4abfe5964d72f8f8d", @"/Pages/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c150b80bb3ffd4126f03b164ebfc4edab0f4935", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Post : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Bondo\source\repos\principlesformen\principlesformen\Pages\Post.cshtml"
  
    ViewData["Title"] = "Post";
    Layout = "~/Pages/Shared/_PageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Post</h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<principlesformen.Pages.PostModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<principlesformen.Pages.PostModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<principlesformen.Pages.PostModel>)PageContext?.ViewData;
        public principlesformen.Pages.PostModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
