#pragma checksum "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "35cf3cce91dfc28f84c19ec9ed9e6b1e87b19e7b4fb14d897915e849d3f7cc1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_ListProduct), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/ListProduct.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"35cf3cce91dfc28f84c19ec9ed9e6b1e87b19e7b4fb14d897915e849d3f7cc1a", @"/Areas/Admin/Views/Product/ListProduct.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Product_ListProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Dashboard";
    int pageCount = (int)ViewBag.pageCount;
    int pageNumber = (int)ViewBag.pageNumber;
    int pageSize = (int)ViewBag.pageSize;
    int stt = pageSize * pageNumber - (pageSize - 1);
    string name = ViewBag.name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""content-header"">
<h1>
    &nbsp;
</h1>
<ol class=""breadcrumb"">
    <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
    <li><a href=""#"">Sản phẩm</a></li>
    <li class=""active"">Danh sách sản phẩm</li>
</ol>
</section>

<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                <h3 class=""box-title"">Danh sách sản phẩm</h3>

                <div class=""box-tools"">
                    <div class=""input-group input-group-sm"" style=""width: 150px;"">
                        <input type=""text"" name=""name"" class=""form-control pull-right"" id=""input-search"" placeholder=""Search""");
            BeginWriteAttribute("value", " value=\"", 1052, "\"", 1065, 1);
#nullable restore
#line 33 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 1060, name, 1060, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""input-group-btn"">
                            <a href=""###""><button class=""btn btn-default"" id=""form-search""><i class=""fa fa-search""></i></button></a>
                        </div>
                        <input type=""number"" name=""pageNumber"" id=""txtPageNumber"" value=""1"" hidden/>
                    </div>
                </div>
                <!-- /.box-header -->
                <div class=""box-body table-responsive no-padding"">
                    <table class=""table table-hover"">
                        <thead>
                            <tr>
                               <th>STT</th>
                               <th>Tên sản phẩm</th>
                               <th>Giá bán</th>
                               <th>Giá gốc</th>
                               <th>Số lượng</th>
                               <th>Trọng lượng</th>
                               <th>Ảnh đại diện</th>
                               <th>Thao tác</th>
                            </tr>");
            WriteLiteral("\n                        </thead>\n                        <tbody>\n");
#nullable restore
#line 56 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                              
                                foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                     <tr>\n                                        <td>");
#nullable restore
#line 60 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                       Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 61 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 62 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 63 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                       Write(item.OldPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 64 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 65 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                       Write(item.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 65 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                                    Write(item.Unit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td><img");
            BeginWriteAttribute("src", " src=\"", 2747, "\"", 2765, 1);
#nullable restore
#line 66 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 2753, item.Avatar, 2753, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:128px\"></td>\n                                        <td>\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2884, "\"", 2936, 2);
            WriteAttributeValue("", 2891, "/Admin/Product/AddDiscount?productId=", 2891, 37, true);
#nullable restore
#line 68 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 2928, item.Id, 2928, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-primary\" style=\"color: white\">Thêm mã giảm giá</a>\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3062, "\"", 3104, 2);
            WriteAttributeValue("", 3069, "/Admin/Product/AddImage?id=", 3069, 27, true);
#nullable restore
#line 69 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 3096, item.Id, 3096, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-info\" style=\"color: white\">Thêm ảnh</a>\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3219, "\"", 3264, 2);
            WriteAttributeValue("", 3226, "/Admin/Product/AddOrUpdate?id=", 3226, 30, true);
#nullable restore
#line 70 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 3256, item.Id, 3256, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-warning\" style=\"color: white\">Sửa</a>\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3377, "\"", 3417, 2);
            WriteAttributeValue("", 3384, "/Admin/Product/Delete?id=", 3384, 25, true);
#nullable restore
#line 71 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 3409, item.Id, 3409, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-danger\" style=\"color: white\">Xóa</a>\n                                        </td>\n                                    </tr>\n");
#nullable restore
#line 74 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                    stt++;
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
                <!-- /.box-body -->
                <div class=""box-footer clearfix"">
                    <ul class=""pagination pagination-sm no-margin pull-right"">
                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3958, "\"", 4040, 4);
            WriteAttributeValue("", 3965, "/Admin/Product/ListProduct?name=", 3965, 32, true);
#nullable restore
#line 83 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 3997, name, 3997, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4002, "&&pageNumber=", 4002, 13, true);
#nullable restore
#line 83 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 4015, Math.Max(pageNumber-1,1), 4015, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&laquo;</a></li>\n");
#nullable restore
#line 84 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                         for (int i = 1; i <= pageCount; ++i)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 4181, "\"", 4240, 4);
            WriteAttributeValue("", 4188, "/Admin/Product/ListProduct?name=", 4188, 32, true);
#nullable restore
#line 86 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 4220, name, 4220, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4225, "&&pageNumber=", 4225, 13, true);
#nullable restore
#line 86 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 4238, i, 4238, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 86 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                                                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 87 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a");
            BeginWriteAttribute("href", " href=\"", 4310, "\"", 4400, 4);
            WriteAttributeValue("", 4317, "/Admin/Product/ListProduct?name=", 4317, 32, true);
#nullable restore
#line 88 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 4349, name, 4349, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4354, "&&pageNumber=", 4354, 13, true);
#nullable restore
#line 88 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Product\ListProduct.cshtml"
WriteAttributeValue("", 4367, Math.Min(pageNumber+1,pageCount), 4367, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&raquo;</a></li>\n                    </ul>\n                </div>\n            </div>\n        <!-- /.box -->\n        </div>\n    </div>\n</section>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('#form-search').on('click', function(){
            let link = ""/Admin/Product/ListProduct?name="" + $('#input-search').val();
            $(""a[href='###']"").attr('href', link);
            $('#form-search')[0].click();
        })
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
