#pragma checksum "D:\Study\ASP .NET Core\ShopPC\ShopPC\Views\MB\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb58fef8e712f0b0b3520378630084e73841d78a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MB_List), @"mvc.1.0.view", @"/Views/MB/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MB/List.cshtml", typeof(AspNetCore.Views_MB_List))]
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
#line 1 "D:\Study\ASP .NET Core\ShopPC\ShopPC\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb58fef8e712f0b0b3520378630084e73841d78a", @"/Views/MB/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8698b1ec29562463bc33480ac52eac0346944c13", @"/Views/_ViewImports.cshtml")]
    public class Views_MB_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(2, 89, true);
            WriteLiteral(" <div class=\"container\">\r\n    <div id=\"slider\">\r\n        <div class=\"slides-container\">\r\n");
            EndContext();
#line 4 "D:\Study\ASP .NET Core\ShopPC\ShopPC\Views\MB\List.cshtml"
             foreach (var item in Model.Products)
            {


#line default
#line hidden
            BeginContext(159, 58, true);
            WriteLiteral("                <div class=\"slide\"><img class=\"slider_img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 217, "\"", 232, 1);
#line 7 "D:\Study\ASP .NET Core\ShopPC\ShopPC\Views\MB\List.cshtml"
WriteAttributeValue("", 223, item.Img, 223, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(233, 26, true);
            WriteLiteral(" alt=\"Slider img\"></div>\r\n");
            EndContext();
#line 8 "D:\Study\ASP .NET Core\ShopPC\ShopPC\Views\MB\List.cshtml"
            }

#line default
#line hidden
            BeginContext(274, 164, true);
            WriteLiteral("        </div><div class=\"arrows\">\r\n            <a class=\"prev\" href=\"#\"><</a>\r\n            <a class=\"next\" href=\"#\">></a>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n");
            EndContext();
#line 17 "D:\Study\ASP .NET Core\ShopPC\ShopPC\Views\MB\List.cshtml"
    foreach (var item in Model.Products)
    {

#line default
#line hidden
            BeginContext(487, 56, true);
            WriteLiteral("<div class=\"itemProduct\">\r\n    <img class=\"productImage\"");
            EndContext();
            BeginWriteAttribute("src", "src=\"", 543, "\"", 557, 1);
#line 20 "D:\Study\ASP .NET Core\ShopPC\ShopPC\Views\MB\List.cshtml"
WriteAttributeValue("", 548, item.Img, 548, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 558, "\"", 574, 1);
#line 20 "D:\Study\ASP .NET Core\ShopPC\ShopPC\Views\MB\List.cshtml"
WriteAttributeValue("", 564, item.Name, 564, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(575, 77, true);
            WriteLiteral("></img>\r\n    <div class=\"additionally_information\">\r\n        <p class=\"name\">");
            EndContext();
            BeginContext(653, 9, false);
#line 22 "D:\Study\ASP .NET Core\ShopPC\ShopPC\Views\MB\List.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(662, 68, true);
            WriteLiteral("</p>\r\n        <p class=\"additionally_information_text\"> Description:");
            EndContext();
            BeginContext(731, 16, false);
#line 23 "D:\Study\ASP .NET Core\ShopPC\ShopPC\Views\MB\List.cshtml"
                                                         Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(747, 61, true);
            WriteLiteral("</p>\r\n        <p class=\"additionally_information_text\">Price:");
            EndContext();
            BeginContext(809, 10, false);
#line 24 "D:\Study\ASP .NET Core\ShopPC\ShopPC\Views\MB\List.cshtml"
                                                  Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(819, 64, true);
            WriteLiteral("</p>\r\n        <p class=\"additionally_information_text\">Category:");
            EndContext();
            BeginContext(884, 18, false);
#line 25 "D:\Study\ASP .NET Core\ShopPC\ShopPC\Views\MB\List.cshtml"
                                                     Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(902, 31, true);
            WriteLiteral("</p>\r\n    </div>\r\n   \r\n</div>\r\n");
            EndContext();
#line 29 "D:\Study\ASP .NET Core\ShopPC\ShopPC\Views\MB\List.cshtml"
      
    }

#line default
#line hidden
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
