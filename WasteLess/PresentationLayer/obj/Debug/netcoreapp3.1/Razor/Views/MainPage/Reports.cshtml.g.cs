#pragma checksum "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aa07c9e7b49463ee7ff20ea42a89d97f6656bc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MainPage_Reports), @"mvc.1.0.view", @"/Views/MainPage/Reports.cshtml")]
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
#line 1 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\_ViewImports.cshtml"
using PresentationLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\_ViewImports.cshtml"
using PresentationLayer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aa07c9e7b49463ee7ff20ea42a89d97f6656bc8", @"/Views/MainPage/Reports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30be6e8d357e7570361a44c6f59cbfc77c09d358", @"/Views/_ViewImports.cshtml")]
    public class Views_MainPage_Reports : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessLayer.Managers.Reports.FullReport>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Donate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
  
    ViewData["Title"] = "Reports";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
Write(ViewData["username"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Reports</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aa07c9e7b49463ee7ff20ea42a89d97f6656bc83831", async() => {
                WriteLiteral("Donate exces");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
                               WriteLiteral(ViewData["username"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n\r\n<font size=\"3\">Weekly items</font>\r\n<br />\r\n<font size=\"3\">Total number of wasted items: </font> <font size=\"3\" color=\"red\"> ");
#nullable restore
#line 15 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
                                                                            Write(Model.wr.quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</font>\r\n<br />\r\n<font size=\"3\">Total number of wasted calories: </font> <font size=\"3\" color=\"red\"> ");
#nullable restore
#line 17 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
                                                                               Write(Model.wr.calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</font>\r\n<br />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
           Write(Html.DisplayNameFor(model => model.wr.foodItemList[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
           Write(Html.DisplayNameFor(model => model.wr.foodItemList[0].Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
           Write(Html.DisplayNameFor(model => model.wr.foodItemList[0].Calories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
           Write(Html.DisplayNameFor(model => model.wr.foodItemList[0].PurchaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
           Write(Html.DisplayNameFor(model => model.wr.foodItemList[0].ExpDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
           Write(Html.DisplayNameFor(model => model.wr.foodItemList[0].ConsDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 44 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
         foreach (var item in Model.wr.foodItemList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
               Write(Html.DisplayFor(modelItem => item.Calories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
               Write(Html.DisplayFor(modelItem => item.PurchaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExpDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
               Write(Html.DisplayFor(modelItem => item.ConsDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 66 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<font size=\"3\">Monthly items</font>\r\n<br />\r\n<font size=\"3\">Total number of wasted items: </font> <font size=\"3\" color=\"red\"> ");
#nullable restore
#line 72 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
                                                                            Write(Model.mr.quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</font>\r\n<br />\r\n<font size=\"3\">Total number of wasted calories: </font> <font size=\"3\" color=\"red\"> ");
#nullable restore
#line 74 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
                                                                               Write(Model.mr.calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</font>\r\n<br />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 80 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
           Write(Html.DisplayNameFor(model => model.mr.foodItemList[0].Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 83 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
           Write(Html.DisplayNameFor(model => model.mr.foodItemList[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 86 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
           Write(Html.DisplayNameFor(model => model.mr.foodItemList[0].Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 89 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
           Write(Html.DisplayNameFor(model => model.mr.foodItemList[0].Calories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 92 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
           Write(Html.DisplayNameFor(model => model.mr.foodItemList[0].PurchaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 95 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
           Write(Html.DisplayNameFor(model => model.mr.foodItemList[0].ExpDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 98 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
           Write(Html.DisplayNameFor(model => model.mr.foodItemList[0].ConsDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 101 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
           Write(Html.DisplayNameFor(model => model.mr.foodItemList[0].User_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 107 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
         foreach (var item in Model.mr.foodItemList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 111 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 114 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 117 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 120 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
               Write(Html.DisplayFor(modelItem => item.Calories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 123 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
               Write(Html.DisplayFor(modelItem => item.PurchaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 126 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExpDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 129 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
               Write(Html.DisplayFor(modelItem => item.ConsDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 132 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
               Write(Html.DisplayFor(modelItem => item.User_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 135 "C:\SD\Tema2\WasteLess\PresentationLayer\Views\MainPage\Reports.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusinessLayer.Managers.Reports.FullReport> Html { get; private set; }
    }
}
#pragma warning restore 1591
