#pragma checksum "C:\Users\Esma\Desktop\GitHub Project\CarRent\CarRent\CarRent\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5999f0ffab38ccfc727f092ad2c28f91fe15f9de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
#line 1 "C:\Users\Esma\Desktop\GitHub Project\CarRent\CarRent\CarRent\Views\_ViewImports.cshtml"
using CarRent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Esma\Desktop\GitHub Project\CarRent\CarRent\CarRent\Views\_ViewImports.cshtml"
using CarRent.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Esma\Desktop\GitHub Project\CarRent\CarRent\CarRent\Views\_ViewImports.cshtml"
using CarRent.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Esma\Desktop\GitHub Project\CarRent\CarRent\CarRent\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5999f0ffab38ccfc727f092ad2c28f91fe15f9de", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57cbb60c25339e0f2b892fb747de4f6c4839f741", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BioSMediaVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-md-6 text-center text-lg-left mb-2 mb-lg-0\">\r\n    <div class=\"d-inline-flex align-items-center\">\r\n        <p class=\"text-body pr-3\"><i class=\"fa fa-phone-alt mr-2\"></i>+");
#nullable restore
#line 5 "C:\Users\Esma\Desktop\GitHub Project\CarRent\CarRent\CarRent\Views\Shared\Components\Header\Default.cshtml"
                                                                  Write(Model.Bio.HeaderPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <span class=\"text-body\">|</span>\r\n        <p class=\"text-body px-3\"><i class=\"fa fa-envelope mr-2\"></i>");
#nullable restore
#line 7 "C:\Users\Esma\Desktop\GitHub Project\CarRent\CarRent\CarRent\Views\Shared\Components\Header\Default.cshtml"
                                                                Write(Model.Bio.HeaderEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"col-md-6 text-center text-lg-right\">\r\n    <div class=\"d-inline-flex align-items-center\">\r\n\r\n        <a class=\"text-body px-3\"");
            BeginWriteAttribute("href", " href=\"", 531, "\"", 569, 1);
#nullable restore
#line 13 "C:\Users\Esma\Desktop\GitHub Project\CarRent\CarRent\CarRent\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 538, Model.SocialMedia.FacebookLink, 538, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i class=\"fab fa-facebook-f\"></i>\r\n        </a>\r\n\r\n        <a class=\"text-body px-3\"");
            BeginWriteAttribute("href", " href=\"", 669, "\"", 707, 1);
#nullable restore
#line 17 "C:\Users\Esma\Desktop\GitHub Project\CarRent\CarRent\CarRent\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 676, Model.SocialMedia.InstgramLink, 676, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i class=\"fab fa-instagram\"></i>\r\n        </a>      \r\n      \r\n        <a class=\"text-body px-3\"");
            BeginWriteAttribute("href", " href=\"", 818, "\"", 855, 1);
#nullable restore
#line 21 "C:\Users\Esma\Desktop\GitHub Project\CarRent\CarRent\CarRent\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 825, Model.SocialMedia.TvitterLink, 825, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i class=\"fab fa-twitter\"></i>\r\n        </a>\r\n\r\n        <a class=\"text-body pl-3\"");
            BeginWriteAttribute("href", " href=\"", 952, "\"", 988, 1);
#nullable restore
#line 25 "C:\Users\Esma\Desktop\GitHub Project\CarRent\CarRent\CarRent\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 959, Model.SocialMedia.YoutbeLink, 959, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i class=\"fab fa-youtube\"></i>\r\n        </a>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BioSMediaVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
