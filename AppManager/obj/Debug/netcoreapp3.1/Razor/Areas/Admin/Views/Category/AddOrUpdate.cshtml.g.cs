#pragma checksum "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Category\AddOrUpdate.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7ea6a526b7c06db281ee6c96954bb5a09ad7c649395f6ffcb5c92f0466bf5c5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_AddOrUpdate), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/AddOrUpdate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7ea6a526b7c06db281ee6c96954bb5a09ad7c649395f6ffcb5c92f0466bf5c5b", @"/Areas/Admin/Views/Category/AddOrUpdate.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_AddOrUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Category\AddOrUpdate.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Dashboard";
    string error = TempData["error"] as string;

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
        <li><a href=""#"">Danh mục</a></li>
        <li class=""active"">Quản lý danh mục</li>
    </ol>
</section>

<section class=""content"">
    <div class=""box box-info"">
        <div class=""box-header with-border container"" style=""width:80%"">
            <h3 class=""box-title"">&nbsp;&nbsp;&nbsp; Quản lý danh mục</h3>
        </div>
        <!-- /.box-header -->
        <!-- form start -->
        <div class=""container"" style=""width:80%"">
            <form role=""form"" action=""/Admin/Category/AddOrUpdate"" method=""post"">
                <div class=""box-body"">
                    <div class=""form-group"">
                        <input type=""number"" name=""id""");
            BeginWriteAttribute("value", " value=\"", 975, "\"", 1014, 1);
#nullable restore
#line 29 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Category\AddOrUpdate.cshtml"
WriteAttributeValue("", 983, Model.Id == 0 ? 0 : Model.Id, 983, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden>\n                        <input type=\"text\" name=\"filepath\"");
            BeginWriteAttribute("value", " value=\"", 1082, "\"", 1128, 1);
#nullable restore
#line 30 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Category\AddOrUpdate.cshtml"
WriteAttributeValue("", 1090, Model.Id == 0 ? "" : Model.FilePath, 1090, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"file-path\" hidden>\n                        <input type=\"text\" name=\"fileid\"");
            BeginWriteAttribute("value", " value=\"", 1209, "\"", 1253, 1);
#nullable restore
#line 31 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Category\AddOrUpdate.cshtml"
WriteAttributeValue("", 1217, Model.Id == 0 ? "" : Model.FileId, 1217, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"file-id\" hidden>\n                    </div>\n                    <div class=\"form-group\">\n                        <label for=\"exampleInputEmail1\">Tên danh mục</label>\n                        <input type=\"text\" class=\"form-control\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 1500, "\"", 1542, 1);
#nullable restore
#line 35 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Category\AddOrUpdate.cshtml"
WriteAttributeValue("", 1508, Model.Id == 0 ? "" : Model.Name, 1508, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    </div>\n                    <div class=\"form-group\">\n                        <label for=\"exampleInputFile\">Upload ảnh</label>\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1718, "\"", 1778, 1);
#nullable restore
#line 39 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Category\AddOrUpdate.cshtml"
WriteAttributeValue("", 1724, Model.Id == 0 ? "/img/default.jpg" : Model.FilePath, 1724, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""image-upload"" class=""rounded mx-auto d-block"" style=""width: 100%"" />
                        <input type=""file"" name=""fileUpload"" id=""exampleInputFile"">
                        <i class=""help-block"">Upload ảnh đại diện của danh mục</i>
                    </div>
                </div>
                <!-- /.box-body -->
                <div class=""box-footer"">
                    <button type=""submit"" class=""btn btn-info pull-right"">Xác nhận</button>
                </div>
            </form>
        </div>
    </div>
</section>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).on('change', 'input[name=""fileUpload""]', function() {
            let files = $(this).prop(""files"");
            let formData = new FormData();
            formData.append(""file"", files[0]);
            $.ajax({
                url: ""/Admin/Category/UploadFile"",
                type: ""POST"",
                data: formData,
                contentType: false,
                processData: false,
                success: res => {
                    if (res.status == 'success'){
                        $('#image-upload').attr('src', res.fileInfo.filePath);
                        $('#file-path').val(res.fileInfo.filePath);
                        $('#file-id').val(res.fileInfo.id);
                    }
                    else {
                        alert(""Error!"");
                    }
                },
                error: error => {
                    console.log(error);
                }
            })
        });
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