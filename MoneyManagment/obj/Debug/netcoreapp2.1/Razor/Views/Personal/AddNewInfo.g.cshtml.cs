#pragma checksum "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\AddNewInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da41b1d41e9bb670523bb01e41fb08e59dca554f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_AddNewInfo), @"mvc.1.0.view", @"/Views/Personal/AddNewInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Personal/AddNewInfo.cshtml", typeof(AspNetCore.Views_Personal_AddNewInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da41b1d41e9bb670523bb01e41fb08e59dca554f", @"/Views/Personal/AddNewInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"602b7bc3c5f241e994f20c9b202d4ef38afddaa3", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_AddNewInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\AddNewInfo.cshtml"
  
    List<ResonsForExpenderAndIncome> expenders = ViewBag.Expender;
    List<ResonsForExpenderAndIncome> incomes = ViewBag.Income;
    DateTime t = DateTime.Now;

#line default
#line hidden
            BeginContext(171, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\AddNewInfo.cshtml"
 using (Html.BeginForm("NewItem", "Personal"))
{


#line default
#line hidden
            BeginContext(226, 53, true);
            WriteLiteral("    <span>Date:</span> <input type=\"date\" name=\"date\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 279, "\"", 323, 1);
#line 10 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\AddNewInfo.cshtml"
WriteAttributeValue("", 287, DateTime.Now.ToString("yyyy-MM-dd"), 287, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("max", " max=\"", 324, "\"", 366, 1);
#line 10 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\AddNewInfo.cshtml"
WriteAttributeValue("", 330, DateTime.Now.ToString("yyyy-MM-dd"), 330, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(367, 17, true);
            WriteLiteral(" /><br /><br />\r\n");
            EndContext();
            BeginContext(388, 228, true);
            WriteLiteral("    <span>Expender or Income ?</span><br />\r\n    <input type=\"radio\" name=\"expenderOrIncome\" value=\"expender\" checked=\"checked\" onclick=\"ShowCorrectSelect(this)\" /><span>Expender</span>\r\n    <select name=\"type\" id=\"expenders\">\r\n");
            EndContext();
#line 16 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\AddNewInfo.cshtml"
             foreach (ResonsForExpenderAndIncome expender in expenders)
            {

#line default
#line hidden
            BeginContext(704, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(720, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "688e162730fe46fcaa817601bc89f054", async() => {
                BeginContext(729, 18, false);
#line 18 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\AddNewInfo.cshtml"
                   Write(expender.TheReason);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(756, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\AddNewInfo.cshtml"
            }

#line default
#line hidden
            BeginContext(773, 224, true);
            WriteLiteral("            \r\n        </select><br />\r\n    <input type=\"radio\" name=\"expenderOrIncome\" value=\"income\" onclick=\"ShowCorrectSelect(this)\" /><span>Income</span>\r\n    <select name=\"type\" id=\"incomes\" style=\"visibility:hidden\">\r\n");
            EndContext();
#line 24 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\AddNewInfo.cshtml"
             foreach(ResonsForExpenderAndIncome income in incomes)
            {

#line default
#line hidden
            BeginContext(1080, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1096, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64215fe2dced4a35a0396f3e772a65ed", async() => {
                BeginContext(1105, 16, false);
#line 26 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\AddNewInfo.cshtml"
                   Write(income.TheReason);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1130, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 27 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\AddNewInfo.cshtml"
            }

#line default
#line hidden
            BeginContext(1147, 37, true);
            WriteLiteral("        </select><br />\r\n    <br />\r\n");
            EndContext();
            BeginContext(1199, 240, true);
            WriteLiteral("    <br /><br />\r\n    <span>sum:  </span> <input type=\"number\" name=\"sum\" />\r\n    <br /><br />\r\n    <span>Further Information:  </span><input type=\"text\" name=\"furtherInformation\" /><br /><br />\r\n    <input type=\"submit\" value=\"submit\" />\r\n");
            EndContext();
            BeginContext(1443, 551, true);
            WriteLiteral(@"    <script>
    var expenders = document.getElementById(""expenders"");
    var incomes = document.getElementById(""incomes"");

        function ShowCorrectSelect(element) {
            if (element.value === ""expender"") {
                expenders.style.visibility = ""visible"";
                incomes.style.visibility = ""hidden"";
            }
            if (element.value === ""income"") {
                incomes.style.visibility = ""visible"";
                expenders.style.visibility = ""hidden"";
            }
        }
    </script>
");
            EndContext();
#line 55 "C:\Users\97252\source\repos\MoneyManagment\MoneyManagment\Views\Personal\AddNewInfo.cshtml"
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
