#pragma checksum "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\newOfAddingInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90d762d06fd115c98c950f0ed970918c2175d01a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90d762d06fd115c98c950f0ed970918c2175d01a", @"/Views/Personal/newOfAddingInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"602b7bc3c5f241e994f20c9b202d4ef38afddaa3", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_newOfAddingInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 997, true);
            WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.4.1.min.js""
            integrity=""sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=""
            crossorigin=""anonymous""></script>

<style>
    body {
        background-color: #ccf2ff;
        cursor: default;
    }
    .box-hidde{
        display:none;
        position:fixed;
        z-index:1;
        top:0;
        left:0;
        background-color:navajowhite;
    }

    .box-show{
        display:block;
        
    }
    .formDiv {
        margin-top: 70px;
    }

    p.req {
        color: red;
    }

    input[type=""date""],
    input[type=""number""],
    input[type=""submit""],
    input[type=""text""]{
        font-size: 1em;
    }

    #type {
        font-size: 1em;
    }

    textarea.form-control {
        font-size: 1em;
    }

    div#box input[type=""number""]{
        width:50px;
        background-color:antiquewhite;
        margin:10px 5px 10px 5px;
    }
</style>

");
            EndContext();
#line 54 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\newOfAddingInfo.cshtml"
 using (Html.BeginForm("NewItem", "Personal", FormMethod.Post, new { onsubmit = "return IsLegalForm()" }))
{

#line default
#line hidden
            BeginContext(1108, 688, true);
            WriteLiteral(@"    <div class=""formDiv"">
    <div class=""box-hidde"" id=""box"">
        <input type=""number"" id=""day"" placeholder=""Day""/>/<input type=""number"" id=""month"" placeholder=""Month"" min=""1"" max=""12"" maxlength=""2"" />/<input type=""number"" id=""year"" placeholder=""Year"" maxlength=""4"" /><br />
        <input type=""button"" value=""Add"" onclick=""updateDate()""/>
    </div>
        <table class=""table"" style=""background-color:white"">
            <tr>
                <td><span>Date:</span></td>
                <!--enter the fool calender-->
                <td>
                    
                    <input type=""text"" onfocus=""OpenDateBox(this)"" class=""form-control"" id=""date"" name=""date""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1796, "\"", 1840, 1);
#line 67 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\newOfAddingInfo.cshtml"
WriteAttributeValue("", 1804, DateTime.Now.ToString("dd/MM/yyyy"), 1804, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1841, 6387, true);
            WriteLiteral(@"/>              
                </td>
            </tr>
            <tr>
                <td>Expender or Income ?</td>
                <td>
                    <input id=""expender"" type=""radio"" name=""expenderOrIncome"" value=""expender"" checked=""checked"" onclick=""ShowCorrectSelect(this)"" />
                    Expender<br />
                    <input type=""radio"" name=""expenderOrIncome"" value=""income"" onclick=""ShowCorrectSelect(this)"" />
                    Income
                </td>
            </tr>
            <tr>
                <td>Please select a reason</td>
                <td>
                    <select id=""type"" name=""type"" class=""browser-default custom-select""></select>
                    <p style=""display:inline"" onclick=""AddToList(this)""> add</p>
                </td>
            </tr>
            <tr>
                <td>Sum: </td>
                <td><input class=""form-control"" onblur=""CheckThis(this)"" type=""number"" name=""sum"" value=""100"" /></td>
            </tr>
   ");
            WriteLiteral(@"         <tr>
                <td>Further information:</td>
                <td><textarea class=""form-control"" rows=""4"" cols=""50"" name=""furtherInformation""></textarea></td>
            </tr>
            <tr>
                <td><input type=""submit"" class=""btn btn-primary"" value=""submit"" /></td>
            </tr>
        </table>
    </div>
    <script>
        var test = document.getElementById(""expender"");
        ShowCorrectSelect(test);

        function OpenDateBox(element) {
            document.getElementById(""box"").classList.add('box-show');
        }
        //run all the check in the function
        function updateDate(){
            let day = document.getElementById(""day"").value;
            let month = document.getElementById(""month"").value;
            let year = document.getElementById(""year"").value;
            let date = day + ""/"" + month + ""/"" + year;
            let dateOfDate = new Date(date);
            if (dateOfDate.getDay() !== NaN) {
                if (day < 1");
            WriteLiteral(@" || day > 31) { }
                if (month < 1 || month > 12) { }
                if (year.length != 4) {}
            }
            
        }
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
        function IsLegalForm() {");
            WriteLiteral(@"
            if (document.getElementById(""req"") === null)
                return true;
            else
                return false;
        }

        function CheckThis(element) {
            if (element.value === null || element.value === """") {
                if (element.parentElement.lastChild === element) {
                    let text = document.createTextNode(""* This field is required"");
                    let par = document.createElement(""p"");
                    par.setAttribute(""id"", ""req"");
                    par.setAttribute(""class"", ""req"");

                    par.appendChild(text);
                    element.parentElement.appendChild(par);
                }
            }
            else {
                let par = element.parentElement.lastChild;
                if (par.id === ""req"")
                    element.parentElement.removeChild(par);
            }

        }
        function AddToList(element) {
            var tableRow = element.parentNode;
           ");
            WriteLiteral(@" tableRow.removeChild(element);

            var textInput = document.createElement(""input"");
            textInput.setAttribute(""type"", ""text"");
            textInput.setAttribute(""class"", ""form-control"");
            textInput.setAttribute(""placeholder"", ""Enter the new reson"");
            textInput.setAttribute(""id"", ""removeThis"");

            var addButton = document.createElement(""p"");
            addButton.appendChild(document.createTextNode(""add to list""));
            addButton.setAttribute(""style"", ""display:inline"");
            addButton.setAttribute(""onclick"", ""SendToDatabase(this)"");
            addButton.setAttribute(""id"", ""removeThis"");

            var deleteButton = document.createElement(""p"");
            deleteButton.appendChild(document.createTextNode(""Undo""));
            deleteButton.setAttribute(""style"", ""display:inline"");
            deleteButton.setAttribute(""onclick"", ""Minimize(this)"");
            deleteButton.setAttribute(""id"", ""removeThis"");

            var br");
            WriteLiteral(@"eake = document.createElement(""br"");
            breake.setAttribute(""id"", ""removeThis"");

            tableRow.appendChild(textInput);
            tableRow.appendChild(addButton);
            tableRow.appendChild(breake);
            tableRow.appendChild(deleteButton);
        }

        function SendToDatabase(element) {
            var reson = element.previousSibling.value;
            var expenderOrIncome;
            if (document.getElementById(""expender"").checked)
                expenderOrIncome = ""expender"";
            else
                expenderOrIncome = ""income"";
            location.replace(""/Personal/AddToReasonsList?reson="" + reson + ""&&expenderOrIncome="" + expenderOrIncome);
        }

        function Minimize(element) {
            var tableRow = element.parentNode;
            while (document.getElementById(""removeThis"") !== null)
                tableRow.removeChild(document.getElementById(""removeThis""));

            var par = document.createElement(""p"");
      ");
            WriteLiteral("      par.appendChild(document.createTextNode(\"add\"));\r\n            par.setAttribute(\"style\", \"display:inline\");\r\n            par.setAttribute(\"onclick\", \"AddToList(this)\");\r\n\r\n            tableRow.appendChild(par);\r\n        }\r\n    </script>\r\n");
            EndContext();
#line 222 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\newOfAddingInfo.cshtml"
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
