#pragma checksum "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\Role\UserList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3860226d499cdee1c154570de26a43103cd69d48372cdcc57e463c25c339d7c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Role_UserList), @"mvc.1.0.view", @"/Areas/Admin/Views/Role/UserList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3860226d499cdee1c154570de26a43103cd69d48372cdcc57e463c25c339d7c2", @"/Areas/Admin/Views/Role/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d952c45957dfef900416ee80707ee0da1e3ff411231f576e29b6f76ee1c320a1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Role_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\Role\UserList.cshtml"
  
    ViewData["Title"] = "UserList";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kullanıcı Listesi</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Kullanıcı Adı</th>\r\n        <th>Rol Ata</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\Role\UserList.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\Role\UserList.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 376, "\"", 414, 2);
            WriteAttributeValue("", 383, "/Admin/Role/AssignRole/", 383, 23, true);
#nullable restore
#line 18 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\Role\UserList.cshtml"
WriteAttributeValue("", 406, item.Id, 406, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Rol Ata</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 20 "C:\Users\OĞULCAN DEMİR\Desktop\RentOdevProje\RentOdevProje\Areas\Admin\Views\Role\UserList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
