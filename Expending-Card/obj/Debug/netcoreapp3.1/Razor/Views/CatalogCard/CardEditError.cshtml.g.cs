#pragma checksum "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\CatalogCard\CardEditError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ac3e5afb3e327bb17da89560497d860db4f810e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CatalogCard_CardEditError), @"mvc.1.0.view", @"/Views/CatalogCard/CardEditError.cshtml")]
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
#line 1 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\_ViewImports.cshtml"
using Expending_Card;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\_ViewImports.cshtml"
using Expending_Card.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ac3e5afb3e327bb17da89560497d860db4f810e", @"/Views/CatalogCard/CardEditError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f62cca8ba3e715d2fd7b760ce6785b65277a337", @"/Views/_ViewImports.cshtml")]
    public class Views_CatalogCard_CardEditError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Expending_Card.ViewModels.ErrorPageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\CatalogCard\CardEditError.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>卡片 ");
#nullable restore
#line 7 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\CatalogCard\CardEditError.cshtml"
  Write(Model.errorName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 錯誤</h2>\r\n<p>");
#nullable restore
#line 8 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\CatalogCard\CardEditError.cshtml"
Write(Model.errorDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Expending_Card.ViewModels.ErrorPageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
