#pragma checksum "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Rower\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4915b951ab5ccae5e63bd5b1b3a0a47c4aa45cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rower_Index), @"mvc.1.0.view", @"/Views/Rower/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4915b951ab5ccae5e63bd5b1b3a0a47c4aa45cc", @"/Views/Rower/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e40304806cc059981beed6ef0cde447a6f3415b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Rower_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SuperRowerDB.RowerRent>>
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
#line 3 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Rower\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4915b951ab5ccae5e63bd5b1b3a0a47c4aa45cc3753", async() => {
                WriteLiteral("Create New");
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
               RowerRentID
            </th>
            <th>
                Model
            </th>
            <th>
               Producent
            </th>
            <th>
                Country
            </th>
            <th>
                Year
            </th>
            <th>
               Type
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 38 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Rower\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Rower\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RowerRentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Rower\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Rower\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Producent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Rower\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Rower\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Rower\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Rower\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.RowerRentID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 60 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Rower\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new {  id=item.RowerRentID  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 61 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Rower\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {  id=item.RowerRentID  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Rower\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SuperRowerDB.RowerRent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
