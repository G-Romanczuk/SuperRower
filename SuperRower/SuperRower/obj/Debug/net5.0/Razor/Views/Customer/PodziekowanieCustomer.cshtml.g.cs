#pragma checksum "C:\Users\gxbir\Desktop\SuperRower\SuperRower\SuperRower\SuperRower\Views\Customer\PodziekowanieCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49a4f462fadf0210b9d640762b67f8e6147d4b96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_PodziekowanieCustomer), @"mvc.1.0.view", @"/Views/Customer/PodziekowanieCustomer.cshtml")]
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
#line 1 "C:\Users\gxbir\Desktop\SuperRower\SuperRower\SuperRower\SuperRower\Views\_ViewImports.cshtml"
using SuperRower;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gxbir\Desktop\SuperRower\SuperRower\SuperRower\SuperRower\Views\_ViewImports.cshtml"
using SuperRower.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gxbir\Desktop\SuperRower\SuperRower\SuperRower\SuperRower\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49a4f462fadf0210b9d640762b67f8e6147d4b96", @"/Views/Customer/PodziekowanieCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5813c3b0880ca79122ec1b9406f2a38b180c4bf1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_PodziekowanieCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SuperRowerDB.Customer>
    #nullable disable
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
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49a4f462fadf0210b9d640762b67f8e6147d4b963648", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49a4f462fadf0210b9d640762b67f8e6147d4b964707", async() => {
                WriteLiteral("\r\n    <h1>Potwierdzenie przyj??cia wiadomo??ci kontaktowej</h1>\r\n    <div>\r\n        <h3>\r\n            Dzi??kujemy za dodanie nowego klienta! <br />\r\n            Tw??j numer Klienta to ");
#nullable restore
#line 19 "C:\Users\gxbir\Desktop\SuperRower\SuperRower\SuperRower\SuperRower\Views\Customer\PodziekowanieCustomer.cshtml"
                             Write(Model.CustomerID);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n        </h3>\r\n        <p>\r\n            Sprawd?? czy podane przez Ciebie dane s?? prawid??owe!<br />\r\n            Imi??: ");
#nullable restore
#line 23 "C:\Users\gxbir\Desktop\SuperRower\SuperRower\SuperRower\SuperRower\Views\Customer\PodziekowanieCustomer.cshtml"
             Write(Model.NameCustomer);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            Nazwisko: ");
#nullable restore
#line 24 "C:\Users\gxbir\Desktop\SuperRower\SuperRower\SuperRower\SuperRower\Views\Customer\PodziekowanieCustomer.cshtml"
                 Write(Model.LastNameCustomer);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            nr.tel: ");
#nullable restore
#line 25 "C:\Users\gxbir\Desktop\SuperRower\SuperRower\SuperRower\SuperRower\Views\Customer\PodziekowanieCustomer.cshtml"
               Write(Model.TelCustomer);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            Miasto: ");
#nullable restore
#line 26 "C:\Users\gxbir\Desktop\SuperRower\SuperRower\SuperRower\SuperRower\Views\Customer\PodziekowanieCustomer.cshtml"
               Write(Model.CityAdressCustomer);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            Adres: ul.");
#nullable restore
#line 27 "C:\Users\gxbir\Desktop\SuperRower\SuperRower\SuperRower\SuperRower\Views\Customer\PodziekowanieCustomer.cshtml"
                 Write(Model.StreetAdressCustomer);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 27 "C:\Users\gxbir\Desktop\SuperRower\SuperRower\SuperRower\SuperRower\Views\Customer\PodziekowanieCustomer.cshtml"
                                             Write(Model.BuildingAdressCustomer);

#line default
#line hidden
#nullable disable
                WriteLiteral("/");
#nullable restore
#line 27 "C:\Users\gxbir\Desktop\SuperRower\SuperRower\SuperRower\SuperRower\Views\Customer\PodziekowanieCustomer.cshtml"
                                                                           Write(Model.ApartmentAdressCustomer);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n            Kod Pocztowy: ");
#nullable restore
#line 28 "C:\Users\gxbir\Desktop\SuperRower\SuperRower\SuperRower\SuperRower\Views\Customer\PodziekowanieCustomer.cshtml"
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
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SuperRowerDB.Customer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
