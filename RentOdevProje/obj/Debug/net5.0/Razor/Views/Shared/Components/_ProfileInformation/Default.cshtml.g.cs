#pragma checksum "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Views\Shared\Components\_ProfileInformation\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3a66254a1fe930bfd30c74ddfeaca3b97c87cb4956e499682a503506f524d0ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__ProfileInformation_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_ProfileInformation/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3a66254a1fe930bfd30c74ddfeaca3b97c87cb4956e499682a503506f524d0ee", @"/Views/Shared/Components/_ProfileInformation/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0d4f03ef24d3b5020a755c6146807463a8e3062e8f9ab0281b0b1b2d2aa11b3a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__ProfileInformation_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-12 col-xl-4"">
    <div class=""card h-100"">
        <div class=""card-header pb-0 p-3"">
            <div class=""row"">
                <div class=""col-md-8 d-flex align-items-center"">
                    <h6 class=""mb-0"">Profil Bilgileri</h6>
                </div>
                <div class=""col-md-4 text-end"">
                    <a href=""/Member/Profile/Index"">
                        <i class=""fas fa-user-edit text-secondary text-sm"" data-bs-toggle=""tooltip"" data-bs-placement=""top"" title=""Edit Profile""></i>
                    </a>
                </div>
            </div>
        </div>
        <div class=""card-body p-3"">
            <p class=""text-sm"">
               Üye paneline hoşgeldiniz, sol tarafta bulunan menüler üzerinden geçmiş rezervasyonlarınızı,aktif rezervasyonlarınız,onaylanmayan rezervasyonlarınızı ve iletişim detaylarını görebilirsiniz.
            </p>
            <hr class=""horizontal gray-light my-4"">
            <ul class=""list-group"">
               ");
            WriteLiteral(" <li class=\"list-group-item border-0 ps-0 pt-0 text-sm\"><strong class=\"text-dark\">Ad Soyad:</strong> &nbsp; ");
#nullable restore
#line 21 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Views\Shared\Components\_ProfileInformation\Default.cshtml"
                                                                                                                      Write(ViewBag.memberName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item border-0 ps-0 text-sm\"><strong class=\"text-dark\">Telefon:</strong> &nbsp; ");
#nullable restore
#line 22 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Views\Shared\Components\_ProfileInformation\Default.cshtml"
                                                                                                                Write(ViewBag.memberPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item border-0 ps-0 text-sm\"><strong class=\"text-dark\">E-mail:</strong> &nbsp; ");
#nullable restore
#line 23 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Views\Shared\Components\_ProfileInformation\Default.cshtml"
                                                                                                               Write(ViewBag.memberMail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                <li class=""list-group-item border-0 ps-0 text-sm""><strong class=""text-dark"">Konum:</strong> &nbsp; Türkiye</li>
                <li class=""list-group-item border-0 ps-0 pb-0"">
                    <strong class=""text-dark text-sm"">Sosyal Medya:</strong> &nbsp;
                    <a class=""btn btn-facebook btn-simple mb-0 ps-1 pe-2 py-0"" href=""https://www.aytucar.com"">
                        <i class=""fab fa-facebook fa-lg""></i>
                    </a>
                    <a class=""btn btn-twitter btn-simple mb-0 ps-1 pe-2 py-0"" href=""javascript:;"">
                        <i class=""fab fa-twitter fa-lg""></i>
                    </a>
                    <a class=""btn btn-instagram btn-simple mb-0 ps-1 pe-2 py-0"" href=""javascript:;"">
                        <i class=""fab fa-instagram fa-lg""></i>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
