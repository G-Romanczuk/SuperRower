#pragma checksum "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\RowerPrice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4f79749fc483b2ed9904561fe1a07028ab982b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RowerPrice_Index), @"mvc.1.0.view", @"/Views/RowerPrice/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4f79749fc483b2ed9904561fe1a07028ab982b3", @"/Views/RowerPrice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5813c3b0880ca79122ec1b9406f2a38b180c4bf1", @"/Views/_ViewImports.cshtml")]
    public class Views_RowerPrice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SuperRowerDB.RowerPrice>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\RowerPrice\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Tabela cen rowerów</h1>

<p>
   
</p>
<table class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th>
                Numer typu roweru
            </th>
            <th>
                Cena za dzień
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 26 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\RowerPrice\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\RowerPrice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RowerPriceID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\RowerPrice\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\RowerPrice\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.RowerPriceID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 36 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\RowerPrice\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {  id=item.RowerPriceID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\RowerPrice\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SuperRowerDB.RowerPrice>> Html { get; private set; }
    }
}
#pragma warning restore 1591
