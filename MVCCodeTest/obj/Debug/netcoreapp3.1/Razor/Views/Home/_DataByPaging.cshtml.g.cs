#pragma checksum "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\Home\_DataByPaging.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcc45dc7b826859eb6fb5b1ed8000f64b64e8ec5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__DataByPaging), @"mvc.1.0.view", @"/Views/Home/_DataByPaging.cshtml")]
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
#line 1 "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\_ViewImports.cshtml"
using MVCCodeTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\_ViewImports.cshtml"
using MVCCodeTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcc45dc7b826859eb6fb5b1ed8000f64b64e8ec5", @"/Views/Home/_DataByPaging.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b75fb8a8f232017bf91b50ff70a741563d7202bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__DataByPaging : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcCodeTestLib.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n");
#nullable restore
#line 4 "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\Home\_DataByPaging.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p></p>\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        #\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 14 "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\Home\_DataByPaging.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 17 "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\Home\_DataByPaging.cshtml"
                   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\Home\_DataByPaging.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 26 "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\Home\_DataByPaging.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 29 "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\Home\_DataByPaging.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 32 "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\Home\_DataByPaging.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 35 "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\Home\_DataByPaging.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 38 "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\Home\_DataByPaging.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p></p>\r\n        <div class=\"container\"\r\n             style=\"color:red; font-size:xx-large;\">\r\n            User NOT Found!\r\n        </div>\r\n        <p></p>\r\n");
#nullable restore
#line 47 "C:\Users\ankit_2\Desktop\Interview-Code\mvc-test-code\MVCCodeTest\Views\Home\_DataByPaging.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcCodeTestLib.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
