#pragma checksum "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\ContactUs\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d0905ba114337e8908d28d0a1d1032c9a64ee3c0bbea55dffd860d1b4b7e3b8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ContactUs_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ContactUs/Index.cshtml")]
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
#line 1 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\_ViewImports.cshtml"
using RentOdevProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\_ViewImports.cshtml"
using RentOdevProje.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\_ViewImports.cshtml"
using RentOdevProje.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\_ViewImports.cshtml"
using RentOdevProje.CQRS.Results.CarResult;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\_ViewImports.cshtml"
using RentOdevProje.CQRS.Commands.CarCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\_ViewImports.cshtml"
using RentOdevProje.CQRS.Results.GuideResult;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\_ViewImports.cshtml"
using RentOdevProje.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d0905ba114337e8908d28d0a1d1032c9a64ee3c0bbea55dffd860d1b4b7e3b8d", @"/Areas/Admin/Views/ContactUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d952c45957dfef900416ee80707ee0da1e3ff411231f576e29b6f76ee1c320a1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ContactUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContactUs>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\ContactUs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Bize Ulaşın Mesajları</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Gönderen</th>\r\n        <th>Konu</th>\r\n        <th>Tarih</th>\r\n        <th>Sil</th>\r\n        <th>Mesajı Aç</th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\ContactUs\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <th>");
#nullable restore
#line 23 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\ContactUs\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\ContactUs\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\ContactUs\Index.cshtml"
           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\ContactUs\Index.cshtml"
           Write(item.MessageDate.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-dark\">Mesajı Aç</a></td>\r\n        </tr>\n");
#nullable restore
#line 30 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\ContactUs\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContactUs>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
