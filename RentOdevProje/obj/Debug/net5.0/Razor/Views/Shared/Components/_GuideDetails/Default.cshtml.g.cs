#pragma checksum "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Views\Shared\Components\_GuideDetails\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "acd63d0805c5ccf3d793a35a1f57ab371c6060644dbf07e10da51914a125ec59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__GuideDetails_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_GuideDetails/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Views\_ViewImports.cshtml"
using RentOdevProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Views\_ViewImports.cshtml"
using RentOdevProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"acd63d0805c5ccf3d793a35a1f57ab371c6060644dbf07e10da51914a125ec59", @"/Views/Shared/Components/_GuideDetails/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0d4f03ef24d3b5020a755c6146807463a8e3062e8f9ab0281b0b1b2d2aa11b3a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__GuideDetails_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Guide>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"author-card mt-5\">\r\n    <div class=\"row align-items-center\">\r\n        <div class=\"col-sm-3 col-6\">\r\n            <div>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 186, "\"", 204, 1);
#nullable restore
#line 6 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Views\Shared\Components\_GuideDetails\Default.cshtml"
WriteAttributeValue("", 192, Model.Image, 192, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 205, "\"", 211, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded-circle img-fluid\">\r\n            </div>\r\n        </div>\r\n        <div class=\"col-sm-9 mt-sm-0 mt-3\">\r\n            <h3 class=\"mb-3 title\">");
#nullable restore
#line 10 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Views\Shared\Components\_GuideDetails\Default.cshtml"
                              Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            <p>
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Provident, sed et excepturi.
                Distinctio fugit odit? Fugit ipsam. Lorem ipsum dolor sit.
            </p>
            <ul class=""author-icons mt-4"">
                <li>
                    <a class=""facebook"" href=""#url"">
                        <span class=""fa fa-facebook""
                              aria-hidden=""true""></span>
                    </a>
                </li>
                <li>
                    <a class=""twitter"" href=""#url"">
                        <span class=""fa fa-twitter""
                              aria-hidden=""true""></span>
                    </a>
                </li>
                <li>
                    <a class=""google"" href=""#url"">
                        <span class=""fa fa-google-plus""
                              aria-hidden=""true""></span>
                    </a>
                </li>
                <li>
                    <a clas");
            WriteLiteral(@"s=""linkedin"" href=""#url"">
                        <span class=""fa fa-linkedin""
                              aria-hidden=""true""></span>
                    </a>
                </li>
                <li>
                    <a class=""github"" href=""#url"">
                        <span class=""fa fa-github""
                              aria-hidden=""true""></span>
                    </a>
                </li>
                <li>
                    <a class=""dribbble"" href=""#url"">
                        <span class=""fa fa-dribbble""
                              aria-hidden=""true""></span>
                    </a>
                </li>
            </ul>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Guide> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
