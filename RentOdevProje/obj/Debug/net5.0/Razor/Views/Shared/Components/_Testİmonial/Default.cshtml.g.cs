#pragma checksum "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Views\Shared\Components\_Testİmonial\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9cd88ee20d035df2f6422e7054cb54c7825160000ef163d184758d48b07db392"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__Testİmonial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_Testİmonial/Default.cshtml")]
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
#line 1 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Views\Shared\Components\_Testİmonial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9cd88ee20d035df2f6422e7054cb54c7825160000ef163d184758d48b07db392", @"/Views/Shared/Components/_Testİmonial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0d4f03ef24d3b5020a755c6146807463a8e3062e8f9ab0281b0b1b2d2aa11b3a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__Testİmonial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testİmonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<section class=""w3l-clients"" id=""clients"">

    <div class=""cusrtomer-layout py-5"">
        <div class=""container py-lg-4 py-md-3 pb-lg-0"">
            <div class=""heading text-center mx-auto"">
                <h6 class=""sub-title text-center"">Düşüncüleriniz Bizim İçin Değerli</h6>
                <h3 class=""hny-title mb-md-5 mb-4"">Müşterilerimiz Bizim İçin Ne Dediler</h3>
            </div>

            <div class=""testimonial-width"">
                <div id=""owl-demo1"" class=""owl-two owl-carousel owl-theme"">
");
#nullable restore
#line 16 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Views\Shared\Components\_Testİmonial\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""item"">
                            <div class=""testimonial-content"">
                                <div class=""testimonial"">
                                    <blockquote>
                                        <span class=""fa fa-quote-left"" aria-hidden=""true""></span>
                                        ");
#nullable restore
#line 23 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Views\Shared\Components\_Testİmonial\Default.cshtml"
                                   Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </blockquote>\r\n                                    <div class=\"testi-des\">\r\n                                        <div class=\"peopl align-self\">\r\n                                            <h3><b><i>");
#nullable restore
#line 27 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Views\Shared\Components\_Testİmonial\Default.cshtml"
                                                 Write(item.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</i></b></h3>
                                            <p class=""indentity"">Example City</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 34 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Views\Shared\Components\_Testİmonial\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testİmonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
