#pragma checksum "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef6628a480f9683e46036006885b4e97b967403a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_DocGia_Index), @"mvc.1.0.view", @"/Areas/User/Views/DocGia/Index.cshtml")]
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
#nullable restore
#line 1 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\_ViewImports.cshtml"
using PJC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\_ViewImports.cshtml"
using PJC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6628a480f9683e46036006885b4e97b967403a", @"/Areas/User/Views/DocGia/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01766513dca41114e40f89b458a8a274af3bbe90", @"/Areas/User/_ViewImports.cshtml")]
    public class Areas_User_Views_DocGia_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PJC.Models.DocGia>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/DocGia/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/DocGia/Detail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/DocGia/Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/User/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\nsetTimeout(function () {\r\n            $(\'#msgAlert\').fadeOut(\'slow\');\r\n        }, 2000);</script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""container-fluid"">
    <h1 class=""mt-4"">Danh sách độc giả</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/User/Home"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Danh sách độc giả</li>
    </ol>
    <div class=""card mb-12"">
        <div class=""card-header"">
            <div class=""row"">
                <div class=""col-md-6 col-xs-12"">
                    <a class=""btn btn-success"" href=""/User/DocGia/Create"">Tạo mới</a>
                </div>
            </div>
        </div>

        <div class=""card-body"">
            <div class=""row"">
");
#nullable restore
#line 30 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
                 if (ViewBag.SuccessMsg != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                        ");
#nullable restore
#line 33 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
                   Write(ViewBag.SuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>");
#nullable restore
#line 34 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""card mb-4"">
                <div class=""card-header""><i class=""fas fa-table mr-1""></i>Phiếu mượn</div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                            <thead>
                                <tr>
                                    <th>
                                        ");
#nullable restore
#line 44 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.MaDG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 47 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TenDG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 50 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 53 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 56 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 59 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.MatSach));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </th>
                                    <th></th>
                                    <th></th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 67 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 71 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.MaDG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 74 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.TenDG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 77 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 80 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 83 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.GioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 86 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.MatSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef6628a480f9683e46036006885b4e97b967403a12843", async() => {
                WriteLiteral("\r\n                                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4248, "\"", 4266, 1);
#nullable restore
#line 90 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
WriteAttributeValue("", 4256, item.MaDG, 4256, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n\r\n                                                <input type=\"submit\" value=\"Sửa\" class=\"btn btn-outline-success\" />\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef6628a480f9683e46036006885b4e97b967403a15423", async() => {
                WriteLiteral("\r\n                                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4712, "\"", 4730, 1);
#nullable restore
#line 98 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
WriteAttributeValue("", 4720, item.MaDG, 4720, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n\r\n                                                <input type=\"submit\" value=\"Chi tiết\" class=\"btn btn-outline-warning\" />\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef6628a480f9683e46036006885b4e97b967403a18004", async() => {
                WriteLiteral("\r\n                                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5179, "\"", 5197, 1);
#nullable restore
#line 105 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
WriteAttributeValue("", 5187, item.MaDG, 5187, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n\r\n                                                <input type=\"submit\" value=\"Xóa\" class=\"btn btn-outline-danger\" />\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 111 "D:\Bao Cao Do An\Framework đồ án\PJC\Areas\User\Views\DocGia\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n\r\n                    </div>\r\n                </div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PJC.Models.DocGia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
