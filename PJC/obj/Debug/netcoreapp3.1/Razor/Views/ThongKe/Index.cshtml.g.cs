#pragma checksum "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "176a782d1d8464168fa0f8e159c21fa03efbee4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThongKe_Index), @"mvc.1.0.view", @"/Views/ThongKe/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"176a782d1d8464168fa0f8e159c21fa03efbee4a", @"/Views/ThongKe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01766513dca41114e40f89b458a8a274af3bbe90", @"/Views/_ViewImports.cshtml")]
    public class Views_ThongKe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index.cshtml"
  
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
#line 21 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index.cshtml"
             Write(ViewBag.SoLuongSach);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" đầu sách!</p>
        </div>

        <div class=""col-md-2 col-sm-2 box0"">
            <div class=""box1"">
                <a  href=""/ThongKe/Index2"">
                    <img src=""https://img.icons8.com/dusk/64/000000/reading.png"" />
                </a>                
                <h3></h3>
            </div>
            <p>Có ");
#nullable restore
#line 31 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index.cshtml"
             Write(ViewBag.SoLuongDocGia);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" độc giả!</p>
        </div>
        <div class=""col-md-2 col-sm-2 box0"">
            <div class=""box1"">
                <a  href=""/ThongKe/Index3"">
                    <img src=""https://img.icons8.com/dusk/64/000000/borrow-book.png"" />
                </a>                
                <h3</h3>
            </div>
            <p>Có ");
#nullable restore
#line 40 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index.cshtml"
             Write(ViewBag.SoLuongPhieuMuon);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" phiếu mượn!</p>
        </div>
        <div class=""col-md-2 col-sm-2 box0"">
            <div class=""box1"">
                <a  href=""/ThongKe/Index4"">
                    <img src=""https://img.icons8.com/dusk/64/000000/return-book.png"" />
                </a>
               
                <h3</h3>
            </div>
            <p>Có ");
#nullable restore
#line 50 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index.cshtml"
             Write(ViewBag.SoLuongPhieuTra);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" phiếu trả!</p>
        </div>
        <div class=""col-md-2 col-sm-2 box0"">
            <div class=""box1"">
                <a  href=""/ThongKe/Index5"">
                    <img src=""https://img.icons8.com/wired/64/000000/return-book.png"" />
                </a>              
                <h3</h3>
            </div>
            <p>Có ");
#nullable restore
#line 59 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index.cshtml"
             Write(ViewBag.SoLuongPhieuChuaTra);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" phiếu chưa trả!</p>
        </div>
        <div class=""col-md-2 col-sm-2 box0"">
            <div class=""box1"">
                <a  href=""/ThongKe/Index6"">
                    <img src=""https://img.icons8.com/wired/64/000000/return-book.png"" />
                </a>             
                <h3</h3>
            </div>
            <p>Doanh thu tiền phạt($):");
#nullable restore
#line 68 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index.cshtml"
                                 Write(ViewBag.DoanhThu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
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
