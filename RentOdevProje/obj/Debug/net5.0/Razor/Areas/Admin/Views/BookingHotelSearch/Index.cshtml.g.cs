#pragma checksum "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "18fc25c0aa42cb00b63ed620dac3639d4cc910049180df289b13aca3e06eef96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BookingHotelSearch_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/BookingHotelSearch/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"18fc25c0aa42cb00b63ed620dac3639d4cc910049180df289b13aca3e06eef96", @"/Areas/Admin/Views/BookingHotelSearch/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d952c45957dfef900416ee80707ee0da1e3ff411231f576e29b6f76ee1c320a1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_BookingHotelSearch_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingHotelSearchViewModel.Result>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;
    double score;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Booking Otel Rezervasyon Sayfası</h1>

<h3>Arama Yapual Şehir Paris/Fransa</h3>

<table class=""table table-striped"">
    <tr>
        <th>#</th>
        <th>Otel Adı</th>
        <th>Otel Skoru</th>
        <th>Otel Puanı</th>
        <th>Detaylar</th>
    </tr>
");
#nullable restore
#line 21 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 25 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 26 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
           Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 27 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
              
                score = double.Parse(item.reviewScore.ToString()) / 10;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 30 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
           Write(score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 31 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
           Write(item.reviewScoreWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td><a href=\"#\" class=\"btn btn-outline-dark\">Detay</a> </td>\n        </tr>\n");
#nullable restore
#line 34 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingHotelSearchViewModel.Result>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591