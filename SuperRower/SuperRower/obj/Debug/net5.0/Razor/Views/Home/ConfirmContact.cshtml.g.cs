#pragma checksum "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Home\ConfirmContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "619505bd729beac0bdf268417773683128db4b79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ConfirmContact), @"mvc.1.0.view", @"/Views/Home/ConfirmContact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"619505bd729beac0bdf268417773683128db4b79", @"/Views/Home/ConfirmContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e40304806cc059981beed6ef0cde447a6f3415b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ConfirmContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SuperRower.Models.Contact>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Home\ConfirmContact.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "619505bd729beac0bdf268417773683128db4b793574", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "619505bd729beac0bdf268417773683128db4b794633", async() => {
                WriteLiteral("\r\n    <h1>Potwierdzenie przyjęcia wiadomości kontaktowej</h1>\r\n    <div>\r\n        <h3>\r\n            Dziękujemy za wypożyczenie roweru ");
#nullable restore
#line 18 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Home\ConfirmContact.cshtml"
                                         Write(Model.Model);

#line default
#line hidden
#nullable disable
                WriteLiteral(" na czas <br />\r\n            <b>od</b> ");
#nullable restore
#line 19 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Home\ConfirmContact.cshtml"
                 Write(Model.StartDate);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <b>do</b> ");
#nullable restore
#line 19 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Home\ConfirmContact.cshtml"
                                            Write(Model.StartDate);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n        </h3>\r\n        <p>\r\n           Sprawdź czy podane przez Ciebie dane są prawidłowe!<br />\r\n            Imię: ");
#nullable restore
#line 23 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Home\ConfirmContact.cshtml"
             Write(Model.NameCustomer);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            Nazwisko: ");
#nullable restore
#line 24 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Home\ConfirmContact.cshtml"
                 Write(Model.LastNameCustomer);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            nr.tel: ");
#nullable restore
#line 25 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Home\ConfirmContact.cshtml"
               Write(Model.TelCustomer);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            Miasto: ");
#nullable restore
#line 26 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Home\ConfirmContact.cshtml"
               Write(Model.CityAdressCustomer);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            Adres: ul.");
#nullable restore
#line 27 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Home\ConfirmContact.cshtml"
                 Write(Model.StreetAdressCustomer);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 27 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Home\ConfirmContact.cshtml"
                                             Write(Model.BuildingAdressCustomer);

#line default
#line hidden
#nullable disable
                WriteLiteral("/");
#nullable restore
#line 27 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Home\ConfirmContact.cshtml"
                                                                           Write(Model.ApartmentAdressCustomer);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n            Kod Pocztowy: ");
#nullable restore
#line 28 "C:\Users\gxbir\Desktop\Nowy folder\SuperRower\SuperRower\SuperRower\Views\Home\ConfirmContact.cshtml"
                     Write(Model.KodCustomer);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n        </p>\r\n\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SuperRower.Models.Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591
