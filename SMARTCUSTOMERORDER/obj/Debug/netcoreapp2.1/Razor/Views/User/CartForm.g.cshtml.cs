#pragma checksum "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\CartForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95fc7e7ed51fc70fde9c69367ca9211d9f5ffec4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_CartForm), @"mvc.1.0.view", @"/Views/User/CartForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/CartForm.cshtml", typeof(AspNetCore.Views_User_CartForm))]
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
#line 1 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\CartForm.cshtml"
using SMARTCUSTOMERORDER.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95fc7e7ed51fc70fde9c69367ca9211d9f5ffec4", @"/Views/User/CartForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"febab4ed3629aaee5888805a374a280079e25dbf", @"/Views/_ViewImports.cshtml")]
    public class Views_User_CartForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserContactDetails>
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
#line 3 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\CartForm.cshtml"
  
    ViewData["Title"] = "CartForm";

#line default
#line hidden
            BeginContext(106, 639, true);
            WriteLiteral(@"<div class=""panel panel-primary"" id=""divCartForm"">
    <div class=""panel-heading"">
        Cart List
    </div>
    <div class=""panel-body"">
        <div>
            <table class=""table table-striped table-bordered"" id=""Mytable"">
                <thead>
                    <tr>                       
                        <td>Productid</td>
                        <td>Title</td>
                        <td>Price</td>
                        <td>Quantity</td>
                        <td>Images</td>
                        <td>Remove</td>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 24 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\CartForm.cshtml"
                     foreach (var items in Model.CartsList)
                    {

#line default
#line hidden
            BeginContext(829, 74, true);
            WriteLiteral("                        <tr>\r\n                            <td class=\"Pid\">");
            EndContext();
            BeginContext(904, 15, false);
#line 27 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\CartForm.cshtml"
                                       Write(items.Productid);

#line default
#line hidden
            EndContext();
            BeginContext(919, 48, true);
            WriteLiteral("</td>\r\n                            <td id=\"Tit\">");
            EndContext();
            BeginContext(968, 11, false);
#line 28 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\CartForm.cshtml"
                                    Write(items.Title);

#line default
#line hidden
            EndContext();
            BeginContext(979, 48, true);
            WriteLiteral("</td>\r\n                            <td id=\"Pri\">");
            EndContext();
            BeginContext(1028, 11, false);
#line 29 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\CartForm.cshtml"
                                    Write(items.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1039, 48, true);
            WriteLiteral("</td>\r\n                            <td id=\"Qty\">");
            EndContext();
            BeginContext(1088, 19, false);
#line 30 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\CartForm.cshtml"
                                    Write(items.TotalQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(1107, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
#line 32 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\CartForm.cshtml"
                                  
                                    var base64 = Convert.ToBase64String(items.Images);
                                    var imgsrc = string.Format("data:image/jpg;base64,{0}", base64);
                                

#line default
#line hidden
            BeginContext(1409, 45, true);
            WriteLiteral("                                <img id=\"Img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1454, "\"", 1467, 1);
#line 36 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\CartForm.cshtml"
WriteAttributeValue("", 1460, imgsrc, 1460, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1468, 135, true);
            WriteLiteral(" width=\"200\" height=\"100\" />\r\n                            </td>\r\n\r\n                            <td>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1603, "\"", 1637, 3);
            WriteAttributeValue("", 1613, "Remove(", 1613, 7, true);
#line 40 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\CartForm.cshtml"
WriteAttributeValue("", 1620, items.Productid, 1620, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 1636, ")", 1636, 1, true);
            EndWriteAttribute();
            BeginContext(1638, 79, true);
            WriteLiteral(">Remove</a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 43 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\CartForm.cshtml"
                    }

#line default
#line hidden
            BeginContext(1740, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1841, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1847, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ff94b0af45a4b4695e3a2cea03e8553", async() => {
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
                BeginContext(1937, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1943, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f369138f7944403a88ab666b67cd6db5", async() => {
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
                BeginContext(2015, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2021, 79, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "883518d231354f5e931b739a5104b16c", async() => {
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
                BeginContext(2100, 215, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            $(\'#Mytable\').DataTable();\r\n        });\r\n        function Remove(Productid) {\r\n            $.ajax({\r\n                url: \'");
                EndContext();
                BeginContext(2316, 27, false);
#line 59 "D:\PROJECTS\SMARTCUSTOMERORDER\SMARTCUSTOMERORDER\Views\User\CartForm.cshtml"
                 Write(Url.Action("Remove","User"));

#line default
#line hidden
                EndContext();
                BeginContext(2343, 465, true);
                WriteLiteral(@"',
                data: { Productid: Productid },

                success: function (resp) {
                    console.log(resp);
                    alert(""Are u Sure u want to delete the items"");
                    $('#divCartForm').html(resp);
                    $('#Mytable').DataTable();
                },
                error: function () {
                    alert(""Failed"");
                }
            });
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(2811, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
