#pragma checksum "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d043e042776d65bf7c65324e89abc8093eb518f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Index), @"mvc.1.0.view", @"/Views/Personal/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Personal/Index.cshtml", typeof(AspNetCore.Views_Personal_Index))]
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
#line 1 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\_ViewImports.cshtml"
using MoneyManagment;

#line default
#line hidden
#line 2 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\_ViewImports.cshtml"
using MoneyManagment.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d043e042776d65bf7c65324e89abc8093eb518f2", @"/Views/Personal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"602b7bc3c5f241e994f20c9b202d4ef38afddaa3", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\Index.cshtml"
   
    List<UserInfo> listOfAll = ViewBag.listOfAll;

#line default
#line hidden
            BeginContext(59, 351, true);
            WriteLiteral(@"<style>
    tr:hover {
    background-color: antiquewhite;
    }
    tr:hover.warning{
        background-color:red;
        color:white;
        font-weight:bold;
        
    }

    tr:hover.warning a{
        cursor: pointer;
    }

    table{
        cursor:default;
    }
</style>

<table style=""width:100%;"" class=""table"" >
");
            EndContext();
#line 25 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\Index.cshtml"
     foreach (UserInfo info in listOfAll)
    {

#line default
#line hidden
            BeginContext(460, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(491, 30, false);
#line 28 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\Index.cshtml"
           Write(info.Date.ToString("dd/MM/yy"));

#line default
#line hidden
            EndContext();
            BeginContext(521, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(545, 8, false);
#line 29 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\Index.cshtml"
           Write(info.Sum);

#line default
#line hidden
            EndContext();
            BeginContext(553, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(577, 21, false);
#line 30 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\Index.cshtml"
           Write(info.ExpenderOrIncome);

#line default
#line hidden
            EndContext();
            BeginContext(598, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(622, 9, false);
#line 31 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\Index.cshtml"
           Write(info.Type);

#line default
#line hidden
            EndContext();
            BeginContext(631, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(655, 23, false);
#line 32 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\Index.cshtml"
           Write(info.FurtherInformation);

#line default
#line hidden
            EndContext();
            BeginContext(678, 193, true);
            WriteLiteral("</td>\r\n            <td onmouseover=\"TurnToWarning(this)\" onmouseout=\"OffWarning(this)\"><a onclick=\"DeleteFromUserInfo(this)\">Click To Delete</a></td>\r\n            <td style=\"visibility:hidden\">");
            EndContext();
            BeginContext(872, 11, false);
#line 34 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\Index.cshtml"
                                     Write(info.InfoID);

#line default
#line hidden
            EndContext();
            BeginContext(883, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 36 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(912, 501, true);
            WriteLiteral(@"</table>

<script>
    function DeleteFromUserInfo(element) {
        var infoId = element.nextSibling.nextSibling.innerHTML;
        location.replace(""/Personal/DeleteFromUserrInfo?infoId="" + infoId);
    }

    function TurnToWarning(element) {
        var newStyle = element.parentNode;
        newStyle.setAttribute(""class"", ""warning"");
    }

    function OffWarning(element) {
        var newStyle = element.parentNode;
        newStyle.removeAttribute(""class"");
    }
</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
