#pragma checksum "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1b2f619d7589fceccdd8a323b25884ead096f29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThongKe_Index1), @"mvc.1.0.view", @"/Views/ThongKe/Index1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1b2f619d7589fceccdd8a323b25884ead096f29", @"/Views/ThongKe/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01766513dca41114e40f89b458a8a274af3bbe90", @"/Views/_ViewImports.cshtml")]
    public class Views_ThongKe_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PJC.Models.Sach>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1 class=""mt-4"">Thống Kê</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/Home"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Thống kê</li>
    </ol>
    <div class=""row mtbox"">
        <div class=""col-md-2 col-sm-2 col-md-offset-1 box0"">
            <div class=""box1"">
                <a href=""/ThongKe/Index1"">
                    <img src=""https://img.icons8.com/carbon-copy/64/000000/book.png"" />
                </a>
                <h3></h3>
            </div>
            <p>Có ");
#nullable restore
#line 22 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
             Write(ViewBag.SoLuongSach);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" sách trong thư viện!</p>
        </div>

        <div class=""col-md-2 col-sm-2 box0"">
            <div class=""box1"">
                <a href=""/ThongKe/Index2"">
                    <img src=""https://img.icons8.com/dusk/64/000000/reading.png"" />
                </a>
                <h3></h3>
            </div>
            <p>Có ");
#nullable restore
#line 32 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
             Write(ViewBag.SoLuongDocGia);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" độc giả!</p>
        </div>
        <div class=""col-md-2 col-sm-2 box0"">
            <div class=""box1"">
                <a href=""/ThongKe/Index3"">
                    <img src=""https://img.icons8.com/dusk/64/000000/borrow-book.png"" />
                </a>
                <h3</h3>
            </div>
            <p>Có ");
#nullable restore
#line 41 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
             Write(ViewBag.SoLuongPhieuMuon);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" phiếu mượn!</p>
        </div>
        <div class=""col-md-2 col-sm-2 box0"">
            <div class=""box1"">
                <a href=""/ThongKe/Index4"">
                    <img src=""https://img.icons8.com/dusk/64/000000/return-book.png"" />
                </a>

                <h3</h3>
            </div>
            <p>Có ");
#nullable restore
#line 51 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
             Write(ViewBag.SoLuongPhieuTra);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" phiếu trả!</p>
        </div>
        <div class=""col-md-2 col-sm-2 box0"">
            <div class=""box1"">
                <a href=""/ThongKe/Index5"">
                    <img src=""https://img.icons8.com/wired/64/000000/return-book.png"" />
                </a>
                <h3</h3>
            </div>
            <p>Có ");
#nullable restore
#line 60 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
             Write(ViewBag.SoLuongPhieuChuaTra);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" phiếu chưa trả!</p>
        </div>
        <div class=""col-md-2 col-sm-2 box0"">
            <div class=""box1"">
                <a href=""/ThongKe/Index6"">
                    <img src=""https://img.icons8.com/wired/64/000000/return-book.png"" />
                </a>
                <h3</h3>
            </div>
            <p>Doanh thu tiền phạt($):");
#nullable restore
#line 69 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                                 Write(ViewBag.DoanhThu);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
    </div>

    <div class=""card mb-4"">
        <div class=""card-header""><i class=""fas fa-table mr-1""></i>Sách</div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>
                                ");
#nullable restore
#line 81 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                           Write(Html.DisplayNameFor(model => model.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 84 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                           Write(Html.DisplayNameFor(model => model.TenSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 87 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                           Write(Html.DisplayNameFor(model => model.TenTG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 90 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                           Write(Html.DisplayNameFor(model => model.NhaXB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 93 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                           Write(Html.DisplayNameFor(model => model.TheLoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 96 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                           Write(Html.DisplayNameFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 99 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                           Write(Html.DisplayNameFor(model => model.GiaTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th> ");
#nullable restore
#line 101 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                            Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 106 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 110 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 113 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TenSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 116 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TenTG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 119 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                               Write(Html.DisplayFor(modelItem => item.NhaXB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 122 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TheLoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 125 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                               Write(Html.DisplayFor(modelItem => item.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 128 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                               Write(Html.DisplayFor(modelItem => item.GiaTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 5409, "\"", 5429, 1);
#nullable restore
#line 131 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
WriteAttributeValue("", 5415, item.ImageUrl, 5415, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px;height:120px;\" class=\"imageCell\" />\r\n                                </td>\r\n\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 136 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index1.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PJC.Models.Sach>> Html { get; private set; }
    }
}
#pragma warning restore 1591
