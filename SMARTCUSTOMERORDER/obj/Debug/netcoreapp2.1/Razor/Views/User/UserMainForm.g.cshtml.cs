#pragma checksum "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\UserMainForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f461de9f80a20e5eafd8364687f3a13b8d95574e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserMainForm), @"mvc.1.0.view", @"/Views/User/UserMainForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/UserMainForm.cshtml", typeof(AspNetCore.Views_User_UserMainForm))]
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
#line 1 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\_ViewImports.cshtml"
using SMARTCUSTOMERORDER;

#line default
#line hidden
#line 1 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\UserMainForm.cshtml"
using SMARTCUSTOMERORDER.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f461de9f80a20e5eafd8364687f3a13b8d95574e", @"/Views/User/UserMainForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"febab4ed3629aaee5888805a374a280079e25dbf", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserMainForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserContactDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/DataTables-1.10.18/css/dataTables.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/DataTables-1.10.18/js/jquery.dataTables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/DataTables-1.10.18/js/dataTables.bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\UserMainForm.cshtml"
  
    ViewData["Title"] = "UserMainForm";

#line default
#line hidden
            BeginContext(110, 84, true);
            WriteLiteral("\r\n<h2>UserMainForm</h2>\r\n<div id=\"divUserMainForm\">\r\n    <div id=\"divUserContact\">\r\n");
            EndContext();
#line 10 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\UserMainForm.cshtml"
           await Html.RenderPartialAsync("UserContact", Model);

#line default
#line hidden
            BeginContext(260, 40, true);
            WriteLiteral("    </div>\r\n    <div id=\"divUserList\">\r\n");
            EndContext();
#line 13 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\UserMainForm.cshtml"
           await Html.RenderPartialAsync("UserList", Model);

#line default
#line hidden
            BeginContext(363, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(402, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(408, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "282b0259612548eab0fd4472d0511840", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(498, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(504, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "847143e2bd9c486d8056c0fdf3722a69", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(576, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(582, 79, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ece6fb487e354afba7512e0a17908654", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(661, 1413, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(document).ready(function () {
            $('#TblUserList').DataTable();
            Submit();
        });

        function Submit() {
            $('#btnSubmit').click(function () {

                if ($(""#UserDataxml_Name"").val() == """") {
                    alert(""Name Must be Filled Out"");
                    return false;
                }
                if ($(""#UserDataxml_Surname"").val() == """") {
                    alert(""Surname Must be Filled Out"");
                    return false;
                }
                if ($(""#UserDataxml_Gender"").val() == """") {
                    alert(""Gender Must be Filled Out"");
                    return false;
                }
                if ($(""#UserDataxml_Email"").val() == """") {
                    alert(""Email Must be Filled Out"");
                    return false;
                }

                var SN = $('#UserDataxml_SNo').val();
                var FName = $('#UserDat");
                WriteLiteral(@"axml_Name').val();
                var SName = $('#UserDataxml_Surname').val();
                var gen = $('#UserDataxml_Gender').val();
                var EM = $('#UserDataxml_Email').val();

                var Userxml = { SNo: SN, Name: FName, Surname: SName, Gender: gen, Email: EM }
                console.log(Userxml);

                $.ajax({
                    url: '");
                EndContext();
                BeginContext(2075, 32, false);
#line 58 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\UserMainForm.cshtml"
                     Write(Url.Action("UserContact","User"));

#line default
#line hidden
                EndContext();
                BeginContext(2107, 548, true);
                WriteLiteral(@"',
                    data: Userxml,
                    success: function (resp) {
                        console.log(resp);
                        $('#divUserList').html(resp);
                        $('#TblUserList').DataTable();
                        $(""#Myform"")[0].reset()
                    },
                    error: function () {
                        alert(""failed"");
                    }
                });
            });
        }

        function Edit(SNo) {
            $.ajax({
                url: '");
                EndContext();
                BeginContext(2656, 25, false);
#line 75 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\UserMainForm.cshtml"
                 Write(Url.Action("Edit","User"));

#line default
#line hidden
                EndContext();
                BeginContext(2681, 430, true);
                WriteLiteral(@"',
                data: { SN: SNo },
                success: function (resp) {
                    console.log(resp);
                    $('#divUserContact').html(resp);
                    Submit();
                },
                error: function () {
                    alert(""failed"");
                }
            });
        }

        function Delete(SNo) {
            $.ajax({
                url: '");
                EndContext();
                BeginContext(3112, 27, false);
#line 90 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\UserMainForm.cshtml"
                 Write(Url.Action("Delete","User"));

#line default
#line hidden
                EndContext();
                BeginContext(3139, 455, true);
                WriteLiteral(@"',
                data: { SNo: SNo },

                success: function (resp) {
                    alert(""Are you Sure You Want to Delete"");
                    console.log(resp);

                    $('#divUserList').html(resp);
                    $('#TblUserList').DataTable();

                },
                error: function () {
                    alert(""failed"");
                }
            });
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(3597, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserContactDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
