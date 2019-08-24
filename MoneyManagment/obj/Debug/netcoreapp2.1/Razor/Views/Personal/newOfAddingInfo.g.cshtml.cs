#pragma checksum "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\newOfAddingInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91176d045c4e5b6fdbebb79c318cf35e0462b6e1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91176d045c4e5b6fdbebb79c318cf35e0462b6e1", @"/Views/Personal/newOfAddingInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"602b7bc3c5f241e994f20c9b202d4ef38afddaa3", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_newOfAddingInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1371, true);
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
        top:25%;
        left:50%;
        background-color:#ccf2ff;
        transform: translate(-50%, -50%);
        border-radius: 20px;
        min-width:40%;
        min-height:20%;
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
        width:10%;
");
            WriteLiteral(@"        background-color:#ccf2ff;
        margin:10px 5px 10px 5px;
        font-size:1.1em;
        color:#00004d;
    }

    div#box div{
        text-align:center;
    }
    div#box p{
        font-size:1.2em;
        color:#00004d;
    }

    .blur{
        filter: blur(8px);
        pointer-events: none;
    }
</style>

");
            EndContext();
#line 73 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\newOfAddingInfo.cshtml"
 using (Html.BeginForm("NewItem", "Personal", FormMethod.Post, new { onsubmit = "return IsLegalForm()" }))
{

#line default
#line hidden
            BeginContext(1482, 970, true);
            WriteLiteral(@"<div class=""formDiv"">
    <div class=""box-hidde"" id=""box"">
        <div>
            <p>Please enter your date</p>
            <input type=""number"" id=""day"" placeholder=""Day"" />/<input type=""number"" id=""month"" placeholder=""Month"" min=""1"" max=""12"" maxlength=""2"" />/<input type=""number"" id=""year"" placeholder=""Year"" maxlength=""4"" /><br />
            <input type=""button"" class=""btn btn-primary"" style=""font-size:1em"" value=""Add"" onclick=""updateDate()"" />
            <input type=""button"" class=""btn btn-primary"" style=""font-size:1em"" value=""Cancel"" onclick=""document.getElementById('box').classList.remove('box-show'); document.getElementById('formTable').classList.remove('blur')"" />
        </div>
    </div>
    <table id=""formTable"" class=""table"" style=""background-color:white"">
        <tr>
            <td><span>Date:</span></td>
            <td>
                <input type=""text"" onfocus=""OpenDateBox(this)"" class=""form-control"" id=""date"" name=""date""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2452, "\"", 2496, 1);
#line 88 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\newOfAddingInfo.cshtml"
WriteAttributeValue("", 2460, DateTime.Now.ToString("dd/MM/yyyy"), 2460, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2497, 9418, true);
            WriteLiteral(@" />
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
        <tr>
            <td>Further information:</td>
            <td><textarea class=""form-control"" ");
            WriteLiteral(@"rows=""4"" cols=""50"" name=""furtherInformation""></textarea></td>
        </tr>
        <tr>
            <td><input type=""submit"" class=""btn btn-primary"" value=""submit"" /></td>
        </tr>
    </table>
</div>
    <script>
        var test = document.getElementById(""expender"");
        ShowCorrectSelect(test);

        function changeTheField(){
            let dateText = document.getElementById(""date"").value;
            let dateField = document.getElementById(""date"");
            let day = dateText.slice(0, dateText.indexOf('/'));
            dateText = dateText.slice(day.length + 1, dateText.length);
            let month = dateText.slice(0, dateText.indexOf('/'));
            dateText = dateText.slice(month.length + 1);
            let year = dateText;
            dateField.value = year + ""-"" + month + ""-"" + day;
            dateField.type = ""date"";
        }

        function OpenDateBox(element) {
            document.getElementById(""box"").classList.add('box-show');
            doc");
            WriteLiteral(@"ument.getElementById(""formTable"").classList.add(""blur"");
            let dateInForm = document.getElementById(""date"").value;
            document.getElementById(""day"").value = dateInForm.slice(0, dateInForm.indexOf('/'));
            dateInForm = dateInForm.slice(document.getElementById(""day"").value.length + 1, dateInForm.length);
            document.getElementById(""month"").value = dateInForm.slice(0, dateInForm.indexOf('/'));
            dateInForm = dateInForm.slice(document.getElementById(""month"").value.length + 1,dateInForm.length);
            document.getElementById(""year"").value = dateInForm;
        }

        function updateDate(){
            let day = document.getElementById(""day"");
            let month = document.getElementById(""month"");
            let year = document.getElementById(""year"");
            let date = year.value + ""-"" + month.value + ""-"" + day.value;
            let dateOfDate = new Date(date); 
            if (day.value < 1 || day.value > 31 || dateOfDate.getDate() ");
            WriteLiteral(@"!= day.value) {
                day.setAttribute(""style"", ""background-color: red"");
            }
            else {
                day.removeAttribute(""style"");
            }
              if (month.value < 1 || month.value > 12) {
                month.setAttribute(""style"", ""background-color: red"");
            }
            else {
                month.removeAttribute(""style"");
            }
            if (year.value.length != 4) {
                year.setAttribute(""style"", ""background-color: red"");
            }
            else {
                year.removeAttribute(""style"");
            }
            if (day.getAttribute('style') === null && month.getAttribute('style') === null && year.getAttribute('style') === null) {
                if (dateOfDate <= new Date()) {
                    if (month.value.length !== 2) month.value = correctDateNember(month.value);
                    if (day.value.length !== 2) day.value = correctDateNember(day.value);
                    let updated");
            WriteLiteral(@"Date = day.value + ""/"" + month.value + ""/"" + year.value;
                    document.getElementById(""date"").value = updatedDate;
                    document.getElementById(""box"").classList.remove(""box-show"");
                    document.getElementById(""formTable"").classList.remove(""blur"")
                }
                else {
                    day.setAttribute(""style"", ""background-color: red"");
                    month.setAttribute(""style"", ""background-color: red"");
                    year.setAttribute(""style"", ""background-color: red"");
                }
            }

            
        }

        function correctDateNember(number){
            let correctNumber = """"; 
            number = """" + number;
            for (let i = 0; i < number.length; i++) {
                 if (number[i] !== ""0"") correctNumber = """" + correctNumber + number[i];
            }

            if (correctNumber.length < 2) {
                correctNumber = ""0"" + correctNumber;
            }
      ");
            WriteLiteral(@"      return correctNumber;
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
        function IsLegalForm() {
            if (document.getElementById(""req"") === null) {
                changeTheField();
               ");
            WriteLiteral(@" return true;
            }
                
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
            tableRow.removeChild(element);

      ");
            WriteLiteral(@"      var textInput = document.createElement(""input"");
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

            var breake = document.createElement(""br"");
   ");
            WriteLiteral(@"         breake.setAttribute(""id"", ""removeThis"");

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
            par.appendChild(document.createText");
            WriteLiteral("Node(\"add\"));\r\n            par.setAttribute(\"style\", \"display:inline\");\r\n            par.setAttribute(\"onclick\", \"AddToList(this)\");\r\n\r\n            tableRow.appendChild(par);\r\n        }\r\n    </script>\r\n");
            EndContext();
#line 307 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\newOfAddingInfo.cshtml"
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
