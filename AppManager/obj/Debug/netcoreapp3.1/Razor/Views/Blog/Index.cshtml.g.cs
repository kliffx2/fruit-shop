#pragma checksum "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "88ef384b1bb9c2525d7c3808d47ff239a6540e8e4ce0d1ffb449f1f98c6f4ca8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#nullable restore
#line 1 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\_ViewImports.cshtml"
using AppManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\_ViewImports.cshtml"
using AppManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"88ef384b1bb9c2525d7c3808d47ff239a6540e8e4ce0d1ffb449f1f98c6f4ca8", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de8103f38a5831600a3508d91138ce990842ce0d7860f640b03386e9e398fedd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Blog";
    int pageCount = (int)ViewBag.pageCount;
    int pageNumber = (int)ViewBag.pageNumber;
    int pageSize = (int)ViewBag.pageSize;
    int stt = pageSize * pageNumber - (pageSize - 1);
    var arg = ViewBag.arg;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""breadcrumb-section set-bg"" data-setbg=""/img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb__text"">
                    <h2>Blog</h2>
                    <div class=""breadcrumb__option"">
                        <a href=""/Home/Index"">Home</a>
                        <span>Blog</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Breadcrumb Section End -->

<!-- Blog Section Begin -->
<section class=""blog spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-5"">
                <div class=""blog__sidebar"">
                    <div class=""blog__sidebar__item"">
                        <h4>Categories</h4>
                        <ul id=""blog-category"">
                            <li><a href=""#"">All</a></li>
                            <li><a href=""#"">Beauty (20)</a></li>
        ");
            WriteLiteral(@"                    <li><a href=""#"">Food (5)</a></li>
                            <li><a href=""#"">Life Style (9)</a></li>
                            <li><a href=""#"">Travel (10)</a></li>
                        </ul>
                    </div>
                    <div class=""blog__sidebar__item"">
                        <h4>Recent News</h4>
                        <div class=""blog__sidebar__recent"" id=""recent-news"">
                            <a href=""#"" class=""blog__sidebar__recent__item"">
                                <div class=""blog__sidebar__recent__item__pic"">
                                    <img src=""img/blog/sidebar/sr-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1922, "\"", 1928, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""blog__sidebar__recent__item__text"">
                                    <h6>09 Kinds Of Vegetables<br /> Protect The Liver</h6>
                                    <span>MAR 05, 2019</span>
                                </div>
                            </a>
                            <a href=""#"" class=""blog__sidebar__recent__item"">
                                <div class=""blog__sidebar__recent__item__pic"">
                                    <img src=""img/blog/sidebar/sr-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2504, "\"", 2510, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""blog__sidebar__recent__item__text"">
                                    <h6>Tips You To Balance<br /> Nutrition Meal Day</h6>
                                    <span>MAR 05, 2019</span>
                                </div>
                            </a>
                            <a href=""#"" class=""blog__sidebar__recent__item"">
                                <div class=""blog__sidebar__recent__item__pic"">
                                    <img src=""img/blog/sidebar/sr-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3084, "\"", 3090, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""blog__sidebar__recent__item__text"">
                                    <h6>4 Principles Help You Lose <br />Weight With Vegetables</h6>
                                    <span>MAR 05, 2019</span>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class=""blog__sidebar__item"">
                        <h4>Search By</h4>
                        <div class=""blog__sidebar__item__tags"" id=""tags"">
                            <a href=""#"">Apple</a>
                            <a href=""#"">Beauty</a>
                            <a href=""#"">Vegetables</a>
                            <a href=""#"">Fruit</a>
                            <a href=""#"">Healthy Food</a>
                            <a href=""#"">Lifestyle</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class");
            WriteLiteral("=\"col-lg-8 col-md-7\">\n                <div class=\"row\">\n");
#nullable restore
#line 90 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
                      
                        foreach(var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                             <div class=\"col-lg-6 col-md-6 col-sm-6\">\n                                <div class=\"blog__item\">\n                                    <div class=\"blog__item__pic\">\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 4508, "\"", 4538, 1);
#nullable restore
#line 96 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
WriteAttributeValue("", 4514, item.PostAvatarFilePath, 4514, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4539, "\"", 4545, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 360px; height: 260px"">
                                    </div>
                                    <div class=""blog__item__text"">
                                        <ul>
                                            <li><i class=""fa fa-calendar-o""></i> ");
#nullable restore
#line 100 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
                                                                            Write(item.CreatedDate.ToString("MMM d, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                            <li><i class=\"fa fa-comment-o\"></i> 5</li>\n                                        </ul>\n                                        <h5><a");
            BeginWriteAttribute("href", " href=\"", 5046, "\"", 5081, 2);
            WriteAttributeValue("", 5053, "/BlogDetail/Post?id=", 5053, 20, true);
#nullable restore
#line 103 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
WriteAttributeValue("", 5073, item.Id, 5073, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 103 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
                                                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\n                                        <p>");
#nullable restore
#line 104 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
                                      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 5211, "\"", 5246, 2);
            WriteAttributeValue("", 5218, "/BlogDetail/Post?id=", 5218, 20, true);
#nullable restore
#line 105 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
WriteAttributeValue("", 5238, item.Id, 5238, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"blog__btn\">READ MORE <span class=\"arrow_right\"></span></a>\n                                    </div>\n                                </div>\n                            </div>\n");
#nullable restore
#line 109 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-12\">\n                        <div class=\"product__pagination\">\n                            <a");
            BeginWriteAttribute("href", " href=\"", 5611, "\"", 5676, 4);
            WriteAttributeValue("", 5618, "/Blog/Index?arg=", 5618, 16, true);
#nullable restore
#line 113 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
WriteAttributeValue("", 5634, arg, 5634, 4, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5638, "&&pageNumber=", 5638, 13, true);
#nullable restore
#line 113 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
WriteAttributeValue("", 5651, Math.Max(pageNumber-1,1), 5651, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-long-arrow-left\"></i></a>\n");
#nullable restore
#line 114 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
                              
                                for (int i = 1; i <= pageCount; ++i)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 5892, "\"", 5934, 4);
            WriteAttributeValue("", 5899, "/Blog/Index?arg=", 5899, 16, true);
#nullable restore
#line 117 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
WriteAttributeValue("", 5915, arg, 5915, 4, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5919, "&&pageNumber=", 5919, 13, true);
#nullable restore
#line 117 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
WriteAttributeValue("", 5932, i, 5932, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 117 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 118 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 6037, "\"", 6110, 4);
            WriteAttributeValue("", 6044, "/Blog/Index?arg=", 6044, 16, true);
#nullable restore
#line 120 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
WriteAttributeValue("", 6060, arg, 6060, 4, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6064, "&&pageNumber=", 6064, 13, true);
#nullable restore
#line 120 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\Blog\Index.cshtml"
WriteAttributeValue("", 6077, Math.Min(pageNumber+1,pageCount), 6077, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-long-arrow-right\"></i></a>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>\n<!-- Blog Section End -->\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        // category của blog
        $.ajax({
            url: ""/Blog/GetCategoryBlog"",
            type: ""GET"",
            dataType: ""json"",
            beforeSend: function(){},
            success: function(data){
                $('#blog-category').html('');
                $('#blog-category').append('<li><a href=""/Blog/Index"">All</a></li>');
                data.forEach(function (item,index){
                    let row = `<li><a href=""/Blog/Index?arg=${item.id}"">${item.name} (${item.postQuantity})</a></li>`;
                    $('#blog-category').append(row);
                })
                console.log( $('#blog-category').html())
            },
            error: function(){},
            complete: function(){}
        });

        // tin tức mới nhất
        $.ajax({
            url: ""/Blog/GetRecentNews"",
            type: ""GET"",
            dataType: ""json"",
            beforeSend: function(){},
            success: function(data){
                $('#recent-news').html('');
     ");
                WriteLiteral(@"           data.forEach(function (item,index){
                    var words = item.title.split("" "");
                    var a = """", b = """";
                    for (let i = 0; i < parseInt((words.length+1)/2); ++i){
                        a += words[i].charAt(0).toUpperCase() + words[i].substring(1) + "" "";
                    }
                    for (let i = parseInt((words.length+1)/2); i < words.length; ++i){
                        b += words[i].charAt(0).toUpperCase() + words[i].substring(1) + "" "";
                    }
                    let date = new Intl.DateTimeFormat('en-GB', { dateStyle: 'full'}).format(new Date(Date.parse(item.createdDate)));
                    let row = `<a href=""/BlogDetail/Post?id=${item.id}"" class=""blog__sidebar__recent__item"">
                                    <div class=""blog__sidebar__recent__item__pic"">
                                        <img src=""${item.postAvatarFilePath}"" style=""width:70px; height:70px;"" alt="""">
                                    </div>
 ");
                WriteLiteral(@"                                   <div class=""blog__sidebar__recent__item__text"">
                                        <h6>${a}<br /> ${b}</h6>
                                        <span>${date}</span>
                                    </div>
                                </a>`;
                    $('#recent-news').append(row);
                });
            },
            error: function(){},
            complete: function(){}
        });

        // tags
        $.ajax({
            url: ""/Blog/GetAllTags"",
            type: ""GET"",
            dataType: ""json"",
            beforeSend: function(){},
            success: function(data){
                $('#tags').html('');
                data.forEach(function (item,index){
                    let row = `<a href=""/Blog/Index?arg=${item.slug}"">${item.name}</a>`;
                    $('#tags').append(row);
                })
            },
            error: function(){},
            complete: function(){}
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
