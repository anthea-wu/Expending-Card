#pragma checksum "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\Details\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cc166982ec15587a4340b62563a42837ef5fbb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Details_Edit), @"mvc.1.0.view", @"/Views/Details/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc166982ec15587a4340b62563a42837ef5fbb8", @"/Views/Details/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f62cca8ba3e715d2fd7b760ce6785b65277a337", @"/Views/_ViewImports.cshtml")]
    public class Views_Details_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Expending_Card.Models.ExpendingViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "order-asc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "order-desc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "card-asc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "card-desc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "date-asc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "date-desc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "price-asc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "price-desc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\Details\Edit.cshtml"
  
    ViewBag.Title = "編輯記帳明細";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <h2>全部記帳明細</h2>\r\n    </div>\r\n    <div class=\"col-12\">\r\n        <div class=\"col-6 input-group\">\r\n            <select class=\"custom-select\" id=\"sort-list\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cc166982ec15587a4340b62563a42837ef5fbb86568", async() => {
                WriteLiteral("選擇明細排列方式");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cc166982ec15587a4340b62563a42837ef5fbb87855", async() => {
                WriteLiteral("Detail Order (ASC)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cc166982ec15587a4340b62563a42837ef5fbb89042", async() => {
                WriteLiteral("Detail Order (DESC)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cc166982ec15587a4340b62563a42837ef5fbb810230", async() => {
                WriteLiteral("Card order (ASC)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cc166982ec15587a4340b62563a42837ef5fbb811416", async() => {
                WriteLiteral("Card order (DESC)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cc166982ec15587a4340b62563a42837ef5fbb812603", async() => {
                WriteLiteral("Date (ASC)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cc166982ec15587a4340b62563a42837ef5fbb813783", async() => {
                WriteLiteral("Date (DESC)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cc166982ec15587a4340b62563a42837ef5fbb814964", async() => {
                WriteLiteral("Price (ASC)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cc166982ec15587a4340b62563a42837ef5fbb816145", async() => {
                WriteLiteral("Price (DESC)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </select>
            <div class=""input-group-append"">
                <button class=""btn btn-outline-secondary"" type=""button"" onclick=""sortDetails();"">Sort Details</button>
            </div>
        </div>
    </div>
</div>

<div class=""row mt-4"">
    <table class=""table"">
        <thead class=""thead-light"">
        <tr>
            <th scope=""col"">Order</th>
            <th scope=""col"">Date</th>
            <th scope=""col"" colspan=""2"">Details</th>
            <th scope=""col"">Price</th>
            <th scope=""col"">Card</th>
            <th scope=""col""></th>
        </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 45 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\Details\Edit.cshtml"
         foreach (var item in @Model.DetailViewModel.Details)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td name=\"order\" class=\"align-middle detail-order text-center\">");
#nullable restore
#line 48 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\Details\Edit.cshtml"
                                                                          Write(item.Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 49 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\Details\Edit.cshtml"
                                    Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"2\" class=\"align-middle\">");
#nullable restore
#line 50 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\Details\Edit.cshtml"
                                                Write(item.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 51 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\Details\Edit.cshtml"
                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"align-middle\">");
#nullable restore
#line 52 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\Details\Edit.cshtml"
                                    Write(item.Card.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button type=\"button\" class=\"btn btn-light\" onclick=\"deleteDetail(this);\">Delete</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\Details\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n        <tr>\r\n            <td id=\"order\" class=\"align-middle justify-content-center\">\r\n                <input disabled type=\"text\" class=\"form-control col-lg-10\" name=\"order\"");
            BeginWriteAttribute("value", " value=\"", 2371, "\"", 2403, 1);
#nullable restore
#line 61 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\Details\Edit.cshtml"
WriteAttributeValue("", 2379, ViewBag.DetailNextOrder, 2379, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            </td>
            <td class=""align-middle"">
                <input type=""text"" class=""form-control col-lg-10"" name=""date"" placeholder=""時間"">
            </td>
            <td colspan=""2"" class=""align-middle"">
                <input type=""text"" class=""form-control col-lg-10"" name=""detail"" placeholder=""明細"">
            </td>
            <td class=""align-middle"">
                <input type=""text"" class=""form-control col-lg-10"" name=""price"" placeholder=""價格"">
            </td>
            <td class=""align-middle"">
                <input type=""text"" class=""form-control col-lg-10"" name=""card"" placeholder=""卡片"">
            </td>
            <td class=""align-middle"">
                <button type=""button"" class=""btn btn-light"" onclick=""createDetail(this);"">Create</button>
            </td>
        </tr>
        
        <tr>
            <td id=""order"" class=""align-middle text-center"">
                <select class=""form-control col-lg-10"" name=""order"" id=""update-order"">
");
#nullable restore
#line 83 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\Details\Edit.cshtml"
                      
                        foreach (var item in Model.DetailViewModel.Details)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cc166982ec15587a4340b62563a42837ef5fbb822339", async() => {
#nullable restore
#line 86 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\Details\Edit.cshtml"
                                                   Write(item.Order);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\Details\Edit.cshtml"
                               WriteLiteral(item.Order);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\d0509\Documents\GitHub\Expending-Card\Expending-Card\Views\Details\Edit.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
            </td>
            <td class=""align-middle"">
                <input type=""text"" class=""form-control col-lg-10"" name=""date"" placeholder=""時間"">
            </td>
            <td colspan=""2"" class=""align-middle"">
                <input type=""text"" class=""form-control col-lg-10"" name=""detail"" placeholder=""明細"">
            </td>
            <td class=""align-middle"">
                <input type=""text"" class=""form-control col-lg-10"" name=""price"" placeholder=""價格"">
            </td>
            <td class=""align-middle"">
                <input type=""text"" class=""form-control col-lg-10"" name=""card"" placeholder=""卡片"">
            </td>
            <td class=""align-middle"">
                <button type=""button"" class=""btn btn-light"" onclick=""updateDetail(this);"">Update</button>
            </td>
        </tr>
        </tbody>
    </table>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cc166982ec15587a4340b62563a42837ef5fbb825467", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://unpkg.com/axios/dist/axios.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-b5kHyXgcpbZJO/tY9Ul7kGkf1S0CWuKcCD38l8YkeH8z8QjE0GmW1gYU5S9FOnJ0"" crossorigin=""anonymous""></script>

    <script>
    function sortDetails() {
        let sort = $(""#sort-list"").val();
        let data = new URLSearchParams();
        data.append(""data"", sort);
        axios.post(""https://localhost:5001/Details/SortDetails"", data)
        .then(() => {location.reload();})
        .catch(error => alert(error.response.data))
    }
    
    function postEdit(url,data){
        axios.post(url, data)
        .then(function (res){
            alert(res.data)
            window.location.href  = ""https://localhost:5001/Details/Edit""
        })
        .catch(function (error){
            alert(error.response.data)
        })
    }
    
    function updateDetail(obj) {
        let tr = $(obj).closest(""tr"")");
                WriteLiteral(@";
        let data = new URLSearchParams();
        
        let order = $(""#update-order"").val();
        
        data.append(""order"", order);
        data.append(""date"", getInputData(tr, 'date'));
        data.append(""detail"", getInputData(tr, 'detail'));
        data.append(""price"", getInputData(tr, 'price'));
        data.append(""card"", getInputData(tr, 'card'));
        
        postEdit(""https://localhost:5001/Details/Update"", data)
    }
    
    function createDetail(obj) {
        let tr = $(obj).closest(""tr"");
        let data = new URLSearchParams();
        
        data.append(""order"", getInputData(tr, 'order'));
        data.append(""date"", getInputData(tr, 'date'));
        data.append(""detail"", getInputData(tr, 'detail'));
        data.append(""price"", getInputData(tr, 'price'));
        data.append(""card"", getInputData(tr, 'card'));
        
        postEdit(""https://localhost:5001/Details/Add"", data)
    }
    
    function deleteDetail(obj) {
        let order = $");
                WriteLiteral(@"(obj).closest(""tr"").find("".detail-order"").text();
        let data = new URLSearchParams();
        
        data.append(""order"",order)
        postEdit(""https://localhost:5001/Details/Delete"", data)
    }
    
    function getInputData(html, name) {
        return html.find(`input[name='${name}']`).val()
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Expending_Card.Models.ExpendingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
