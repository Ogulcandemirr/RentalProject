#pragma checksum "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Views\Admin\PartialSideBar.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "41ca194615793e475421b21c28f398508682ec35d932501da562cc56368d1653"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PartialSideBar), @"mvc.1.0.view", @"/Views/Admin/PartialSideBar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"41ca194615793e475421b21c28f398508682ec35d932501da562cc56368d1653", @"/Views/Admin/PartialSideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0d4f03ef24d3b5020a755c6146807463a8e3062e8f9ab0281b0b1b2d2aa11b3a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_PartialSideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<ul class=""menu-inner py-1"">
    <!-- Dashboard -->
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-home-circle""></i>
            <div data-i18n=""Analytics"">Dashboard</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Admin/Comment/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-comment""></i>
            <div data-i18n=""Analytics"">Yorumlar</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Admin/Car/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-car""></i>
            <div data-i18n=""Analytics"">Araçlar</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Admin/User/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-face""></i>
            <div data-i18n=""Analytics"">Müşteriler</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Admin/ContactUs/Index""");
            WriteLiteral(@" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-message-alt""></i>
            <div data-i18n=""Analytics"">Mesajlar</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Admin/Guide/Index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-help-circle""></i>
            <div data-i18n=""Analytics"">Rehberler</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Excel/Index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-report""></i>
            <div data-i18n=""Analytics"">Raporlar</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Admin/Mail/Index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx-mail-send""></i>
            <div data-i18n=""Analytics"">Mail Gönder</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-ghost""></i>
            <div data-i18n=""Analytics""");
            WriteLiteral(@">Öne Çıkanlar</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-navigation  ""></i>
            <div data-i18n=""Analytics"">Referanslar</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-abacus""></i>
            <div data-i18n=""Analytics"">Alt Hakkında</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-restaurant""></i>
            <div data-i18n=""Analytics"">Rezervasyonlar</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-mail-send""></i>
            <div data-i18n=""Analytics"">Mail Listesi</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            WriteLiteral(@"
            <i class=""menu-icon tf-icons bx bx-bookmark-alt""></i>
            <div data-i18n=""Analytics"">Öne Çıkanlar 2</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-key""></i>
            <div data-i18n=""Analytics"">Şifre İşlemleri</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Admin/Role/Index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-thermometer""></i>
            <div data-i18n=""Analytics"">Rol İşlemleri</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-exit""></i>
            <div data-i18n=""Analytics"">Çıkış Yap</div>
        </a>
    </li>
</ul>");
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