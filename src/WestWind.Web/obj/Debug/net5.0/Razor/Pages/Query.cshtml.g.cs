#pragma checksum "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae10445b213339be64425e858c5836b34cdf2c65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WestWindWeb.Pages.Pages_Query), @"mvc.1.0.razor-page", @"/Pages/Query.cshtml")]
namespace WestWindWeb.Pages
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
#line 1 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\_ViewImports.cshtml"
using WestWindWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae10445b213339be64425e858c5836b34cdf2c65", @"/Pages/Query.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb3f8a4f1562209b788c73dbb25dd79b2acbb03", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Query : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>ButtonPressed=<span>");
#nullable restore
#line 5 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                  Write(Model.ButtonPressed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n\r\n<h5>Query Page</h5>\r\n\r\n");
#nullable restore
#line 9 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
 if(!string.IsNullOrEmpty(Model.ErrorMessage))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"color:red; font-weight: bold;\">");
#nullable restore
#line 11 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                                        Write(Model.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
 if(!string.IsNullOrEmpty(Model.SuccessMessage))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"color:green; font-weight: bold;\">");
#nullable restore
#line 16 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                                          Write(Model.SuccessMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 17 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae10445b213339be64425e858c5836b34cdf2c655577", async() => {
                WriteLiteral("\r\n    <div>\r\n        <i>Partial Product Name</i>\r\n        <input type=\"search\" placeholder=\"Partial Name/ID\" id=\"PartialProductName\" \r\n            name=\"partialProductName\"");
                BeginWriteAttribute("value", " value=\"", 580, "\"", 613, 1);
#nullable restore
#line 23 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
WriteAttributeValue("", 588, Model.PartialProductName, 588, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <button type=\"submit\" formaction=\"/Query\" \r\n            name=\"buttonPressed\" value=\"SearchByPartialProductName\">Search</button>\r\n        <span>The Partial Product Name search string is ");
#nullable restore
#line 26 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                                                   Write(Model.PartialProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n    </div>\r\n    <div>\r\n        <i>Categoies</i>\r\n        <select name=\"selectedCategoryId\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae10445b213339be64425e858c5836b34cdf2c657024", async() => {
                    WriteLiteral("select ...");
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
                WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
             foreach (var item in Model.SelectListOfCatagories)
            {
                    if (Model.SelectedCategoryId == item.CategoryId)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae10445b213339be64425e858c5836b34cdf2c658645", async() => {
#nullable restore
#line 36 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                                                             Write(item.CategoryName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                           WriteLiteral(item.CategoryId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae10445b213339be64425e858c5836b34cdf2c6511159", async() => {
#nullable restore
#line 40 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                                                    Write(item.CategoryName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                           WriteLiteral(item.CategoryId);

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
#line 41 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                    }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>  \r\n        <button type=\"submit\" formaction=\"/Query\" name=\"buttonPressed\" value=\"SearchByCategory\">Search</button>\r\n        <span>The selected Category Id is ");
#nullable restore
#line 45 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
                                     Write(Model.SelectedCategoryId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n    </div>\r\n    <button type=\"submit\" formaction=\"/Crud\">Add New Product</button>\r\n");
#nullable restore
#line 48 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
     if(Model.SearchedProducts != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <table>
        <thead>
            <tr>
                <th>Action</th>
                <th>ProductName</th>
                <th>QuantityPerUnit</th>
                <th>UnitPrice</th>
                <th>Discontinued</th>
                
            </tr>
        </thead>
");
#nullable restore
#line 61 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
         if(Model.SearchedProducts.Count == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr><td colspan=\"6\"><i>There are no Products available.</i></td></tr>\r\n");
#nullable restore
#line 64 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
         foreach(var item in Model.SearchedProducts)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td><button type=\"submit\" name=\"productId\" formaction=\"/Crud\"");
                BeginWriteAttribute("value", " value=\"", 2401, "\"", 2424, 1);
#nullable restore
#line 68 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
WriteAttributeValue("", 2409, item.ProductId, 2409, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Edit</button></td>\r\n                <td>");
#nullable restore
#line 69 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
               Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 70 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
               Write(item.QuantityPerUnit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 71 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
               Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td><input type=\"checkbox\" disabled");
                BeginWriteAttribute("checked", " checked=\"", 2631, "\"", 2659, 1);
#nullable restore
#line 72 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
WriteAttributeValue("", 2641, item.Discontinued, 2641, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></input></td>\r\n            </tr>\r\n");
#nullable restore
#line 74 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n");
#nullable restore
#line 76 "C:\CPSC1517\Repos\dotnetcore5-demos-westwind\src\WestWind.Web\Pages\Query.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n    \r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.QueryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.QueryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.QueryModel>)PageContext?.ViewData;
        public MyApp.Namespace.QueryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
