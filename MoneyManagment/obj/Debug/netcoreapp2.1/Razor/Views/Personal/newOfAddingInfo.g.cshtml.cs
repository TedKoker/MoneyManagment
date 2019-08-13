#pragma checksum "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\newOfAddingInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5e11c2f63b3e976ed289c3d41e3409f8496edb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_newOfAddingInfo), @"mvc.1.0.view", @"/Views/Personal/newOfAddingInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Personal/newOfAddingInfo.cshtml", typeof(AspNetCore.Views_Personal_newOfAddingInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5e11c2f63b3e976ed289c3d41e3409f8496edb3", @"/Views/Personal/newOfAddingInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"602b7bc3c5f241e994f20c9b202d4ef38afddaa3", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_newOfAddingInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 177, true);
            WriteLiteral("<script src=\"https://code.jquery.com/jquery-3.4.1.min.js\"\r\n        integrity=\"sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=\"\r\n        crossorigin=\"anonymous\"></script>\r\n\r\n");
            EndContext();
#line 5 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\newOfAddingInfo.cshtml"
 using (Html.BeginForm("NewItem", "Personal", FormMethod.Post, new { onsubmit = "return IsLegalForm()" }))
{

#line default
#line hidden
            BeginContext(288, 123, true);
            WriteLiteral("<table>\r\n    <tr>\r\n        <td><span>Date:</span></td>\r\n        <td><input onblur=\"CheckThis(this)\" type=\"date\" name=\"date\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 411, "\"", 455, 1);
#line 10 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\newOfAddingInfo.cshtml"
WriteAttributeValue("", 419, DateTime.Now.ToString("yyyy-MM-dd"), 419, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("max", " max=\"", 456, "\"", 498, 1);
#line 10 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\newOfAddingInfo.cshtml"
WriteAttributeValue("", 462, DateTime.Now.ToString("yyyy-MM-dd"), 462, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(499, 4695, true);
            WriteLiteral(@" /></td>
    </tr>
    <tr>
        <td>Expender or Income ?</td>
        <td><input id=""expender"" type=""radio"" name=""expenderOrIncome"" value=""expender"" checked=""checked"" onclick=""ShowCorrectSelect(this)"" />
        Expender
        <br />
            <input type=""radio"" name=""expenderOrIncome"" value=""income"" onclick=""ShowCorrectSelect(this)"" />
            Income
        </td>
    </tr>
    <tr>
        <td>Please select a reason</td>
        <td><select id=""type"" name=""type""></select>
        <p style=""display:inline"" onclick=""AddToList(this)""> add</p></td>
    </tr> 
    <tr>
        <td>Sum: </td>
        <td><input onblur=""CheckThis(this)"" type=""number"" name=""sum"" value=""100"" /></td>
    </tr>
    <tr>
        <td>Further information:</td>
        <td><textarea rows=""4"" cols=""50"" name=""furtherInformation""></textarea></td>
    </tr>
    <tr>
        <td><input type=""submit"" value=""submit"" /></td>
    </tr>
</table>
    <script>
        var test = document.getElementById(""expen");
            WriteLiteral(@"der"");
        ShowCorrectSelect(test);
        
        function ShowCorrectSelect(element) {
            $(""#type"").empty();
            let urlLink;
            if (element.value == ""expender"")
                urlLink = ""/Personal/ExpenderList"";
            else
                urlLink = ""/Personal/IncomeList""
            $.ajax({
                url: urlLink,
                cache: false,
                success: function (res) {
                    console.log(res);
                    $.each(res, function (i, value) {
                        $(""#type"").append(new Option(value.theReason, value.theReason));
                    });
                },
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    alert(""Status: "" + textStatus); alert(""Error: "" + errorThrown);
                }
            });

        }
    function IsLegalForm() {
        if (document.getElementById(""req"") === null)
            return true;
        else
        ");
            WriteLiteral(@"    return false;
        }

    function CheckThis(element) {
        if (element.value === null || element.value === """") {
            if (element.parentElement.lastChild === element) {
                let text = document.createTextNode(""* This field is required"");
                let par = document.createElement(""p"");
                par.setAttribute(""id"", ""req"");
                par.appendChild(text);
                element.parentElement.appendChild(par);
            }
            }
            else {
                let par = element.parentElement.lastChild;
                if(par.id===""req"")
                    element.parentElement.removeChild(par);
            }

        }
    function AddToList(element) {
        var tableRow = element.parentNode;
        tableRow.removeChild(element);

        var textInput = document.createElement(""input"");
        textInput.setAttribute(""type"", ""text"");
        textInput.setAttribute(""id"", ""removeThis"");

        var addButton = docume");
            WriteLiteral(@"nt.createElement(""p"");
        addButton.appendChild(document.createTextNode(""add to list""));
        addButton.setAttribute(""style"", ""display:inline"");
        addButton.setAttribute(""onclick"", ""SendToDatabase(this)"");
        addButton.setAttribute(""id"", ""removeThis"");

        var deleteButton = document.createElement(""p"");
        deleteButton.appendChild(document.createTextNode(""<--""));
        deleteButton.setAttribute(""style"", ""display:inline"");
        deleteButton.setAttribute(""onclick"", ""Minimize(this)"");
        deleteButton.setAttribute(""id"", ""removeThis"");

        tableRow.appendChild(textInput);
        tableRow.appendChild(addButton);
        tableRow.appendChild(deleteButton);
    }

    function SendToDatabase(element) {
        var reson = element.previousSibling.value;
        var expenderOrIncome;
        if (document.getElementById(""expender"").checked)
            expenderOrIncome = ""expender"";
        else
            expenderOrIncome = ""income"";
        location");
            WriteLiteral(@".replace(""/Personal/AddToReasonsList?reson="" + reson+""&&expenderOrIncome=""+expenderOrIncome);
    }

    function Minimize(element) {
        var tableRow = element.parentNode;
        while (document.getElementById(""removeThis"") !== null)
            tableRow.removeChild(document.getElementById(""removeThis""));

        var par = document.createElement(""p"");
        par.appendChild(document.createTextNode(""add""));
        par.setAttribute(""style"", ""display:inline"");
        par.setAttribute(""onclick"", ""AddToList(this)"");

        tableRow.appendChild(par);
    }
    </script>
");
            EndContext();
#line 136 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\newOfAddingInfo.cshtml"
}

#line default
#line hidden
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
