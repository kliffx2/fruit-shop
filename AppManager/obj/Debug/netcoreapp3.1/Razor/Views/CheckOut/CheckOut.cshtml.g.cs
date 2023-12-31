#pragma checksum "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9639268c3dd9a0ee1dc2efb4b650ec3b0d943825f82fff0bac606dc07791f017"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CheckOut_CheckOut), @"mvc.1.0.view", @"/Views/CheckOut/CheckOut.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9639268c3dd9a0ee1dc2efb4b650ec3b0d943825f82fff0bac606dc07791f017", @"/Views/CheckOut/CheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de8103f38a5831600a3508d91138ce990842ce0d7860f640b03386e9e398fedd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CheckOut_CheckOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/CheckOut/CheckOut"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
  
    ViewData["Title"] = "Thanh Toán";
    var total = 0;
    string error = TempData["error"] as string;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""breadcrumb-section set-bg"" data-setbg=""/img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb__text"">
                    <h2>Checkout</h2>
                    <div class=""breadcrumb__option"">
                        <a href=""./index.html"">Home</a>
                        <span>Checkout</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Breadcrumb Section End -->

<!-- Checkout Section Begin -->
<section class=""checkout spad"">
    <div class=""container"">
        <div class=""checkout__form"">
            <h4>Billing Details</h4>
");
#nullable restore
#line 29 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
              
                if (error != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-danger\" role=\"alert\">\n                      ");
#nullable restore
#line 33 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
                 Write(error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n");
#nullable restore
#line 35 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9639268c3dd9a0ee1dc2efb4b650ec3b0d943825f82fff0bac606dc07791f0175855", async() => {
                WriteLiteral(@"
                <div class=""row"">
                    <input type=""text"" name=""id"" id=""addressid"" value=""0"" hidden/>
                    <div class=""col-lg-8 col-md-6"">
                        <ol id=""address"">

                        </ol>
                        <div class=""col-md-12"" id=""address-form"" style=""display: none"">
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""checkout__input"">
                                        <p>First Name<span>*</span></p>
                                        <input type=""text"" name=""FirstName"">
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""checkout__input"">
                                        <p>Last Name<span>*</span></p>
                                        <input type=""text"" name=""lastname"">
                           ");
                WriteLiteral(@"         </div>
                                </div>
                            </div>
                            <div class=""checkout__input"">
                                <p>Address<span>*</span></p>
                                <input type=""text"" name=""address"" placeholder=""Street Address"" class=""checkout__input__add"">
                            </div>
                            <div class=""checkout__input"">
                                <p>Town/City<span>*</span></p>
                                <input type=""text"" name=""city"">
                            </div>
                            <div class=""checkout__input"">
                                <p>Country/State<span>*</span></p>
                                <input type=""text"" name=""country"">
                            </div>
                            <div class=""checkout__input"">
                                <p>Postcode / ZIP<span>*</span></p>
                                <input type=""text"" name=""postcode"">
              ");
                WriteLiteral(@"              </div>
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""checkout__input"">
                                        <p>Phone<span>*</span></p>
                                        <input type=""text"" name=""phone"">
                                    </div>
                                </div>
                            </div>
                            <div class=""checkout__input"">
                                <p>Order notes<span>*</span></p>
                                <input type=""text""
                                    placeholder=""Notes about your order, e.g. special notes for delivery."">
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""checkout__order"">
                            <h4>Your Order</h4>
                            <div class=""checkout__");
                WriteLiteral("order__products\">Products <span>Total</span></div>\n                            <ul>\n");
#nullable restore
#line 95 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
                                  
                                    foreach (var item in Model)
                                    {
                                         var price = item.Price * item.Quantity;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                         <li>");
#nullable restore
#line 99 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span>");
#nullable restore
#line 99 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
                                                         Write(price.ToString("0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</span></li>\n");
#nullable restore
#line 100 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
                                         total += price;
                                    }
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </ul>\n                            <div class=\"checkout__order__subtotal\">Subtotal <span>");
#nullable restore
#line 104 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
                                                                             Write(total.ToString("0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</span></div>\n                            <div class=\"checkout__order__total\">Total <span>");
#nullable restore
#line 105 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
                                                                       Write(total.ToString("0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</span></div>\n");
#nullable restore
#line 106 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
                              
                                if (Model.Count == 0)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                       <button type=\"submit\" class=\"site-btn\" disabled>PLACE ORDER</button>    \n");
#nullable restore
#line 110 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <button type=\"submit\" class=\"site-btn\">PLACE ORDER</button>\n");
#nullable restore
#line 114 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                    </div>
                    <div class=""col-lg-8 col-md-6"" id=""address-form"" style=""display: none"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <div class=""checkout__input"">
                                    <p>First Name<span>*</span></p>
                                    <input type=""text"" name=""FirstName"">
                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""checkout__input"">
                                    <p>Last Name<span>*</span></p>
                                    <input type=""text"" name=""lastname"">
                                </div>
                            </div>
                        </div>
                        <div class=""checkout__input"">
                            <p>Address<span>*</span></p>
                            <input t");
                WriteLiteral(@"ype=""text"" name=""address"" placeholder=""Street Address"" class=""checkout__input__add"">
                        </div>
                        <div class=""checkout__input"">
                            <p>Town/City<span>*</span></p>
                            <input type=""text"" name=""city"">
                        </div>
                        <div class=""checkout__input"">
                            <p>Country/State<span>*</span></p>
                            <input type=""text"" name=""country"">
                        </div>
                        <div class=""checkout__input"">
                            <p>Postcode / ZIP<span>*</span></p>
                            <input type=""text"" name=""postcode"">
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <div class=""checkout__input"">
                                    <p>Phone<span>*</span></p>
                                    <input type=""text"" name=""p");
                WriteLiteral(@"hone"">
                                </div>
                            </div>
                        </div>
                        <div class=""checkout__input"">
                            <p>Order notes<span>*</span></p>
                            <input type=""text""
                                placeholder=""Notes about your order, e.g. special notes for delivery."">
                        </div>
                    </div>
                    
                </div>
            ");
            }
            );
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
            WriteLiteral(@"
            <!--
            <form action=""/CheckOut/CheckOut"" method=""post"" style=""display:none"">
                <div class=""row"">
                    <div class=""col-lg-8 col-md-6"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <div class=""checkout__input"">
                                    <p>First Name<span>*</span></p>
                                    <input type=""text"" name=""FirstName"">
                                </div>
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""checkout__input"">
                                    <p>Last Name<span>*</span></p>
                                    <input type=""text"" name=""lastname"">
                                </div>
                            </div>
                        </div>
                        <div class=""checkout__input"">
                            <p>Address<span>*</span></p>
");
            WriteLiteral(@"                            <input type=""text"" name=""address"" placeholder=""Street Address"" class=""checkout__input__add"">
                        </div>
                        <div class=""checkout__input"">
                            <p>Town/City<span>*</span></p>
                            <input type=""text"" name=""city"">
                        </div>
                        <div class=""checkout__input"">
                            <p>Country/State<span>*</span></p>
                            <input type=""text"" name=""country"">
                        </div>
                        <div class=""checkout__input"">
                            <p>Postcode / ZIP<span>*</span></p>
                            <input type=""text"" name=""postcode"">
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <div class=""checkout__input"">
                                    <p>Phone<span>*</span></p>
                          ");
            WriteLiteral(@"          <input type=""text"" name=""phone"">
                                </div>
                            </div>
                        </div>
                        <div class=""checkout__input"">
                            <p>Order notes<span>*</span></p>
                            <input type=""text""
                                placeholder=""Notes about your order, e.g. special notes for delivery."">
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""checkout__order"">
                            <h4>Your Order</h4>
                            <div class=""checkout__order__products"">Products <span>Total</span></div>
                            <ul>
");
#nullable restore
#line 219 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
                                  
                                    foreach (var item in Model)
                                    {
                                         var price = item.Price * item.Quantity;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                         <li>");
#nullable restore
#line 223 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 223 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
                                                         Write(price.ToString("0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></li>\n");
#nullable restore
#line 224 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
                                         total += price;
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\n                            <div class=\"checkout__order__subtotal\">Subtotal <span>");
#nullable restore
#line 228 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
                                                                             Write(total.ToString("0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></div>\n                            <div class=\"checkout__order__total\">Total <span>");
#nullable restore
#line 229 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Views\CheckOut\CheckOut.cshtml"
                                                                       Write(total.ToString("0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VNĐ</span></div>
                            <button type=""submit"" class=""site-btn"">PLACE ORDER</button>
                        </div>
                    </div>
                </div>
            </form>
            -->
        </div>
    </div>
</section>
<!-- Checkout Section End -->

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        // address
        $.ajax({
            url: ""/CheckOut/GetAddress"",
            type: ""GET"",
            dataType: ""json"",
            beforeSend: function(){},
            success: function(data){
                if (data != """"){
                    $('#address').prepend(`<li style=""list-style-type: none"">
                                                <input type=""radio"" id=""0"" class=""address"" name=""check-address"">
                                                <label for=""0"">
                                                    Khác
                                                </label>
                                            </li>`);
                    data.forEach(function (item,index){
                        let row = `<li style=""list-style-type: none"">
                                        <input type=""radio"" id=""${item.id}"" class=""address"" name=""check-address"">
                                        <label for=""${item.id}""> 
                                         ");
                WriteLiteral(@"   Họ tên: ${item.firstName} ${item.lastName}
                                            <br>Địa chỉ: ${item.address}, ${item.city}, ${item.country}
                                            <br>Postcode: ${item.postcode}
                                            <br>Số điện thoại: ${item.phone}
                                        </label>
                                    </li>
                                    <hr>`;
                        $('#address').prepend(row);
                    });
                }
                else {
                    $(""#address-form"").css(""display"", ""inline-block"");
                }
            },
            error: function(){},
            complete: function(){}
        });

        $(document).ready(function(){
            $(document).on('click', '.address', function(){
                if ($(this).attr('id') == ""0""){
                    $(""#address-form"").css(""display"", ""block"");
                }
                else {
                    $(""#address-for");
                WriteLiteral("m\").css(\"display\", \"none\");\n                }\n                console.log($(this).attr(\'id\'))\n                $(\"#addressid\").val($(this).attr(\'id\'));\n            })\n        });\n    </script>\n");
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
