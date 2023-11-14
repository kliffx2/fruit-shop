#pragma checksum "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\File\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "68c20b6232be458306fac434da78ac130eb51398094b088b622e3561f52a7bb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_File_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/File/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"68c20b6232be458306fac434da78ac130eb51398094b088b622e3561f52a7bb6", @"/Areas/Admin/Views/File/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_File_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\File\Index.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Quản lý file</h2>\n<div>\n    <p>Chọn file</p>\n    <input type=\"File\" name=\"fileUpload\"/>\n</div>\n<div class=\"row\">\n    <div class=\"col-md-3\">\n        <img src=\"/img/default.jpg\" id=\"image-upload\" class=\"w-100\" style=\"width: 100%\"/>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).on('change', 'input[name=""fileUpload""]', function() {
            let files = $(this).prop(""files"");
            let formData = new FormData();
            formData.append(""file"", files[0]);
            $.ajax({
                url: ""/admin/file/uploadfile"",
                type: ""POST"",
                data: formData,
                contentType: false,
                processData: false,
                beforeSend: () => {

                },
                success: res => {
                    if (res.status == 'success'){
                        $('#image-upload').attr('src', res.fileInfo.filePath);
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
