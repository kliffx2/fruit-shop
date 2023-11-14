#pragma checksum "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6501695b1606ea543d0f4369ac72f95a93202aae1f300474217ac59b60e835da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_AddOrUpdate), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/AddOrUpdate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6501695b1606ea543d0f4369ac72f95a93202aae1f300474217ac59b60e835da", @"/Areas/Admin/Views/Blog/AddOrUpdate.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Blog_AddOrUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Dashboard";
    string error = TempData["error"] as string;
    string alert = TempData["alert"] as string;
    int categoryId = Model != null ? Model.CategoryId : -1;

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
        <li><a href=""#"">Blog</a></li>
        <li class=""active"">Quản lý bài viết</li>
    </ol>
</section>

<section class=""content"">
    <div class=""row"">
    <div class=""col-md-3"">
        <div class=""box box-primary"">
            <div class=""box-body box-profile"" id=""author-info"">
                
            </div>
        </div>
    </div>
    <!-- /.col -->
    <div class=""col-md-9"">
        <div class=""box box-primary"">
            <form method=""post"" action=""/Admin/Blog/AddOrUpdate"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Quản lý bài viết</h3>
                </div>
                <div class=""box-body"">
");
#nullable restore
#line 37 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
                          
                            if (alert != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"callout callout-success\">\n                                   <p>");
#nullable restore
#line 41 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
                                 Write(alert);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                </div>\n");
#nullable restore
#line 43 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"text\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 1469, "\"", 1509, 1);
#nullable restore
#line 45 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
WriteAttributeValue("", 1477, Model == null ? 0 : @Model.Id, 1477, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\n                        <input type=\"text\" name=\"avatarId\" id=\"image-file-id\"");
            BeginWriteAttribute("value", " value=\"", 1598, "\"", 1644, 1);
#nullable restore
#line 46 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
WriteAttributeValue("", 1606, Model == null ? 0 : @Model.AvatarId, 1606, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\n                        <input type=\"text\" name=\"avatar\" id=\"image-file-path\"");
            BeginWriteAttribute("value", " value=\"", 1733, "\"", 1778, 1);
#nullable restore
#line 47 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
WriteAttributeValue("", 1741, Model == null ? "" : @Model.Avatar, 1741, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\n                        <input type=\"text\" name=\"status\" id=\"post-status\"");
            BeginWriteAttribute("value", " value=\"", 1863, "\"", 1907, 1);
#nullable restore
#line 48 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
WriteAttributeValue("", 1871, Model == null ? 0 : @Model.Status, 1871, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\n                        <input type=\"text\" name=\"categoryId\" id=\"category-id\"");
            BeginWriteAttribute("value", " value=\"", 1996, "\"", 2044, 1);
#nullable restore
#line 49 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
WriteAttributeValue("", 2004, Model == null ? 0 : @Model.CategoryId, 2004, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\n                        <input type=\"text\" name=\"status\" id=\"post-status\"");
            BeginWriteAttribute("value", " value=\"", 2129, "\"", 2173, 1);
#nullable restore
#line 50 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
WriteAttributeValue("", 2137, Model == null ? 0 : @Model.Status, 2137, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\n                        <div class=\"form-group\">\n                            <label for=\"exampleInputFile\">Title</label>\n                            <input class=\"form-control\" placeholder=\"Tiêu đề:\"");
            BeginWriteAttribute("value", " value=\"", 2384, "\"", 2427, 1);
#nullable restore
#line 53 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
WriteAttributeValue("", 2392, Model == null ? "" : Model.Title, 2392, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"title\">\n                        </div>\n                        <div class=\"form-group\">\n                            <label for=\"exampleInputFile\">Description</label>\n                            <input class=\"form-control\" placeholder=\"Description:\"");
            BeginWriteAttribute("value", " value=\"", 2683, "\"", 2732, 1);
#nullable restore
#line 57 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
WriteAttributeValue("", 2691, Model == null ? "" : Model.Description, 2691, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"description\">\n                        </div>\n                        <div class=\"form-group\">\n                            <textarea id=\"txt-content\" class=\"form-control\" style=\"height: 300px\" name=\"content\"");
            BeginWriteAttribute("value", " value=\"", 2946, "\"", 2999, 1);
#nullable restore
#line 60 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
WriteAttributeValue("", 2954, Html.Raw(Model == null ? "" : Model.Content), 2954, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></textarea>
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputFile"">Category</label>
                            <select class=""form-control select2"" id=""category-blog"" style=""width: 100%;"">
                            </select>
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputFile"">Tags</label><br />
");
#nullable restore
#line 69 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
                              
                                var tags = "";
                                if (Model != null)
                                {
                                    foreach(var tag in Model.Tag)
                                    {
                                        tags += tag + ",";
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"text\" class=\"form-control\" placeholder=\"Tags:\"");
            BeginWriteAttribute("value", " value=\"", 3984, "\"", 3997, 1);
#nullable restore
#line 79 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
WriteAttributeValue("", 3992, tags, 3992, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""tag"" id=""tags-input"" data-role=""tagsinput"">
                        </div>
                        <div class=""form-group"">
                              <label for=""exampleInputFile"">Ảnh đại diện</label>
                              <div class=""col-md-12 text-center"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 4316, "\"", 4374, 1);
#nullable restore
#line 84 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
WriteAttributeValue("", 4322, Model != null ? Model.Avatar : "/img/default.jpg", 4322, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""image-upload"" class=""rounded mx-auto d-block"" style=""width: 256px"" />
                                </div>
                              <input type=""file"" id=""image-upload"" name=""fileUpload"">
                              <p class=""help-block"">Chọn ảnh đại diện cho bài viết</p>
                        </div>
                </div>
                <!-- /.box-body -->
                <div class=""box-footer"">
                    <div class=""pull-right"">
                        <button type=""submit"" class=""btn btn-default btnsubmit"" name=""save""><i class=""fa fa-pencil""></i> Lưu bản nháp</button>
                        <button type=""submit"" class=""btn btn-primary btnsubmit"" name=""submit""><i class=""fa fa-envelope-o""></i> Gửi đi</button>
                    </div>
                </div>

            </form>
        <!-- /.box-footer -->
        </div>
        <!-- /. box -->
    </div>
    <!-- /.col -->
    </div>
    <!-- /.row -->
</section>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        ClassicEditor
            .create( document.querySelector( '#txt-content' ) )
            .catch( error => {
                console.error( error );
            } );

        $('#tags-input').tagsinput();

        $(document).on('click', '.btnsubmit', function() {
            btn = $(this).attr('name');
            if (btn == ""submit""){
                $('#post-status').val(0);
            }
            else {
                $('#post-status').val(1);
            }
        });

        $(document).on('change', 'input[name=""fileUpload""]', function() {
            let files = $(this).prop(""files"");
            let formData = new FormData();
            formData.append(""file"", files[0]);
            $.ajax({
                url: ""/admin/blog/uploadfile"",
                type: ""POST"",
                data: formData,
                contentType: false,
                processData: false,
                beforeSend: () => {

                },
                success: res => {
                ");
                WriteLiteral(@"    console.log(res);
                    $('#image-upload').attr('src', res.fileInfo.filePath);
                    $('#image-file-path').val(res.fileInfo.filePath);
                    $('#image-file-id').val(res.fileInfo.id);
                },
                error: error => {
                    console.log(error);
                }
            })
        });

        $.ajax({
            url: ""/Admin/Blog/AuthorInfo"",
            type: ""GET"",
            dataType: ""json"",
            beforeSend: function(){},
            success: function(data){
                console.log(data);
                let html = `<img class=""profile-user-img img-responsive img-circle"" src=""${data.avatar}"" style=""width: 100px; height:100px"" alt=""User profile picture"">
                            <h3 class=""profile-username text-center"">${data.authorName}</h3>
                            <p class=""text-muted text-center"">${data.authorRole}</p>`
                $('#author-info').append(html);                
            },
     ");
                WriteLiteral(@"       error: function(){
                console.log(""error!"");
            },
            complete: function(){}
        });


        $.ajax({
            url: ""/Blog/GetCategoryBlog"",
            type: ""GET"",
            dataType: ""json"",
            beforeSend: function(){},
            success: function(data){
                console.log(data);
                data.forEach(function(item,index){
                    let html = `<option value=""${item.id}"">${item.name}</option>`;
                    if (item.id == """);
#nullable restore
#line 181 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
                               Write(categoryId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"){\n                        html = `<option value=\"${item.id}\" selected>${item.name}</option>`;\n                    }\n                    $(\'#category-blog\').append(html);      \n                });    \n                $(\"#category-blog\").val(\"");
#nullable restore
#line 186 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Blog\AddOrUpdate.cshtml"
                                    Write(categoryId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""");      
            },
            error: function(){
                console.log(""error!"");
            },
            complete: function(){}
        });

        $('#category-blog').on('change', function(){
            $('#category-id').val($(""#category-blog"").val());
        });
        
        //$(document).ready(function (){
        //    CKFinder.setupCKEditor();
        //    var editor = CKEDITOR.replace('txt-content', {
        //        customConfig: '/admin/plugins/ckeditor/config.js',          
        //    });
        //});

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
