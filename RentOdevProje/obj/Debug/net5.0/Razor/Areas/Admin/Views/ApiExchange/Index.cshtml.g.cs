#pragma checksum "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\ApiExchange\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8fb3ae344e70576814e3b0a7728798ed10ba0199ab25ec36ab31d18a9ba816d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ApiExchange_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ApiExchange/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"8fb3ae344e70576814e3b0a7728798ed10ba0199ab25ec36ab31d18a9ba816d4", @"/Areas/Admin/Views/ApiExchange/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d952c45957dfef900416ee80707ee0da1e3ff411231f576e29b6f76ee1c320a1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ApiExchange_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingExchangeViewModel2.Exchange_Rates>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\ApiExchange\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Booking Api Kur Bilgileri</h1>\r\n\r\n<br />\r\n\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>Kur Adı</th>\r\n        <th>Kur Oranı</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\ApiExchange\Index.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 20 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\ApiExchange\Index.cshtml"
           Write(item.currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 21 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\ApiExchange\Index.cshtml"
           Write(item.exchange_rate_buy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n");
#nullable restore
#line 23 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\ApiExchange\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingExchangeViewModel2.Exchange_Rates>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
