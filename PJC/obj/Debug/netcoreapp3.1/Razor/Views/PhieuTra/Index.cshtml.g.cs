#pragma checksum "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a63c07a167149cbe84371f4ef2b13905057c739b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhieuTra_Index), @"mvc.1.0.view", @"/Views/PhieuTra/Index.cshtml")]
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
#line 1 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\_ViewImports.cshtml"
using PJC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\_ViewImports.cshtml"
using PJC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a63c07a167149cbe84371f4ef2b13905057c739b", @"/Views/PhieuTra/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01766513dca41114e40f89b458a8a274af3bbe90", @"/Views/_ViewImports.cshtml")]
    public class Views_PhieuTra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PJC.Models.CTPM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/PhieuTra/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/PhieuTra/Detail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\nsetTimeout(function () {\r\n            $(\'#msgAlert\').fadeOut(\'slow\');\r\n        }, 2000);</script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""container-fluid"">
    <h1 class=""mt-4"">Danh sách phiếu trả</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/Home"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Danh sách phiếu trả</li>
    </ol>
    <div class=""card mb-12"">
    <div class=""card-header"">
        <div class=""row"">
            <div class=""col-md-6 col-xs-12"">
                <a class=""btn btn-success"" href=""/PhieuTra/TraSach"">Trả sách</a>
            </div>
        </div>
    </div>
    <div class=""card-body"">

        <div class=""card mb-4"">
            <div class=""card-header""><i class=""fas fa-table mr-1""></i>Phiếu trả</div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <div class=""row"">
");
#nullable restore
#line 35 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                                 if (ViewBag.SuccessMsg != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                                        ");
#nullable restore
#line 38 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                                   Write(ViewBag.SuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>");
#nullable restore
#line 39 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <tr>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 43 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 46 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 49 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.NgayTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 52 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.TinhTrangSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 55 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.TinhTrangTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 58 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 61 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 64 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.TienPhat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th></th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 71 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 75 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 78 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 81 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.NgayTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 84 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TinhTrangSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 87 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TinhTrangTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 90 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 93 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 96 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TienPhat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a63c07a167149cbe84371f4ef2b13905057c739b13652", async() => {
                WriteLiteral("\r\n                                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4728, "\"", 4746, 1);
#nullable restore
#line 100 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
WriteAttributeValue("", 4736, item.MaPM, 4736, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n                                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4826, "\"", 4846, 1);
#nullable restore
#line 101 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
WriteAttributeValue("", 4834, item.MaSach, 4834, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"masach\" />\r\n                                            <input type=\"submit\" value=\"Sửa\" class=\"btn btn-outline-success\" />\r\n                                        ");
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
            WriteLiteral("\r\n\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a63c07a167149cbe84371f4ef2b13905057c739b16648", async() => {
                WriteLiteral("\r\n                                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5267, "\"", 5285, 1);
#nullable restore
#line 108 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
WriteAttributeValue("", 5275, item.MaPM, 5275, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n                                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5365, "\"", 5385, 1);
#nullable restore
#line 109 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
WriteAttributeValue("", 5373, item.MaSach, 5373, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"masach\" />\r\n                                            <input type=\"submit\" value=\"Chi tiết\" class=\"btn btn-outline-warning\" />\r\n                                        ");
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
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 114 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\PhieuTra\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PJC.Models.CTPM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
