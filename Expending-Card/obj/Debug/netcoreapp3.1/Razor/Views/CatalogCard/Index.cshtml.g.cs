#pragma checksum "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\CatalogCard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6a366fa637da3ef43d493297f8a92f34a8b4785"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CatalogCard_Index), @"mvc.1.0.view", @"/Views/CatalogCard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6a366fa637da3ef43d493297f8a92f34a8b4785", @"/Views/CatalogCard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f62cca8ba3e715d2fd7b760ce6785b65277a337", @"/Views/_ViewImports.cshtml")]
    public class Views_CatalogCard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Expending_Card.Models.CardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CatalogCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\CatalogCard\Index.cshtml"
  
    ViewData["Title"] = "卡片總覽";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>類別卡片</h2>\r\n<ol class=\"mt-3\">\r\n");
#nullable restore
#line 10 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\CatalogCard\Index.cshtml"
     foreach (var item in @Model.Cards)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"mt-0 mb-0\">\r\n            <a class=\"nav-link text-dark\"");
            BeginWriteAttribute("name", " name = \"", 268, "\"", 287, 1);
#nullable restore
#line 13 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\CatalogCard\Index.cshtml"
WriteAttributeValue("", 277, item.Name, 277, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"showCard(this);\">");
#nullable restore
#line 13 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\CatalogCard\Index.cshtml"
                                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n");
#nullable restore
#line 15 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\CatalogCard\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6a366fa637da3ef43d493297f8a92f34a8b47855582", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Edit\" class=\"btn btn-default\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://unpkg.com/axios/dist/axios.min.js\"></script>\r\n\r\n    <script>    \r\n    let cards = [];\r\n");
#nullable restore
#line 33 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\CatalogCard\Index.cshtml"
     foreach (var item in Model.Cards)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                WriteLiteral("cards.push(\'");
#nullable restore
#line 35 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\CatalogCard\Index.cshtml"
                 Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n");
#nullable restore
#line 36 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\CatalogCard\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    
    function showCard(obj) {
        let name = obj.name;
        axios.post(`https://localhost:5001/CatalogCard/Card?name=${name}`)
        .then(function (response) {
            window.location.href = response.request.responseURL;
        })
        .catch(function (error) {
            alert(error.response.data);
        });
    }
   </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Expending_Card.Models.CardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
