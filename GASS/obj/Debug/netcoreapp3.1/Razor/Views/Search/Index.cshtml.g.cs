#pragma checksum "C:\HtmlFiles\GASS\GASS\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c47fcd06a888c9d5fbb8ab0714f5c7b2a6137f71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\HtmlFiles\GASS\GASS\Views\_ViewImports.cshtml"
using GASS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\HtmlFiles\GASS\GASS\Views\_ViewImports.cshtml"
using GASS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c47fcd06a888c9d5fbb8ab0714f5c7b2a6137f71", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792ae6809f9bfc3ee449a666f1cc9e8d797c0e08", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p class=\"text-center h4\">");
#nullable restore
#line 1 "C:\HtmlFiles\GASS\GASS\Views\Search\Index.cshtml"
                     Write(ViewData["keyword"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" related AssetPacks</p>\r\n<div class=\"row text-light\">\r\n");
#nullable restore
#line 3 "C:\HtmlFiles\GASS\GASS\Views\Search\Index.cshtml"
       
        foreach(var item in ViewBag.assetlist)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>");
#nullable restore
#line 6 "C:\HtmlFiles\GASS\GASS\Views\Search\Index.cshtml"
            Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 7 "C:\HtmlFiles\GASS\GASS\Views\Search\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
