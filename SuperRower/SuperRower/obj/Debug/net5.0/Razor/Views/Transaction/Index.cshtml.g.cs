#pragma checksum "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Transaction\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f332b1072644a597083e94d73e86cd96322b241"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_Index), @"mvc.1.0.view", @"/Views/Transaction/Index.cshtml")]
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
#line 1 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\_ViewImports.cshtml"
using SuperRower;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\_ViewImports.cshtml"
using SuperRower.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f332b1072644a597083e94d73e86cd96322b241", @"/Views/Transaction/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5813c3b0880ca79122ec1b9406f2a38b180c4bf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SuperRowerDB.Transaction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Transaction\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista transakcji</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f332b1072644a597083e94d73e86cd96322b2414014", async() => {
                WriteLiteral("Wynajmij rower!");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
               Numer trensakcji
            </th>
            <th>
               Numer Klienta
            </th>
            <th>
               Numer roweru cena
            </th>
            <th>
               Numer roweru typ
            </th>
            <th>
              Data wynajęcia
            </th>
            <th>
              Data oddania
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 38 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Transaction\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Transaction\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransactionID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Transaction\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerIF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Transaction\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RowerPriceIF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Transaction\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RowerRentIF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Transaction\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Transaction\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Transaction\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.TransactionID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 60 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Transaction\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.TransactionID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 61 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Transaction\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.TransactionID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Transaction\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SuperRowerDB.Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
