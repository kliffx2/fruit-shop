#pragma checksum "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8d27e076221d26cf52bdff5149abcb668be23f81ead2ae9b854c130ad8f311be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"8d27e076221d26cf52bdff5149abcb668be23f81ead2ae9b854c130ad8f311be", @"/Areas/Admin/Views/Home/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    int pageCount = (int)ViewBag.pageCount;
    int pageNumber = (int)ViewBag.pageNumber;
    int pageSize = (int)ViewBag.pageSize;
    int stt = pageSize * pageNumber - (pageSize - 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""content-header"">
    <h1>
        Trang chủ
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard active""></i> Home</a></li>
        <li><a href=""#"" class=""active"">Báo cáo</a></li>
    </ol>
</section>

<section class=""content"">
    <div class=""row"">
        <div class=""col-md-8"">
            <div class=""box box-info"">
                <div class=""box-header with-border"">
                  <h3 class=""box-title"">Thống kế danh mục sản phẩm mua theo năm</h3>
                  <div class=""box-tools"">
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse""><i class=""fa fa-minus""></i>
                    </button>
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></button>
                  </div>
                </div>
                <div class=""box-body"">
                  <div class=""chart"">
                    <canvas id=""lineChart"" style=""height:180px""></canvas>
 ");
            WriteLiteral(@"                 </div>
                </div>
                <!-- /.box-body -->
              </div>
            <!-- /.box-body -->
        </div>
        <div class=""col-md-4"">
            <div class=""box box-info"">
            <div class=""box-header with-border"">
              <h3 class=""box-title"">Thống kê theo tháng</h3>
              <div class=""box-tools pull-right"">
                <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse""><i class=""fa fa-minus""></i>
                </button>
                <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></button>
              </div>
            </div>
            <!-- /.box-header -->
            <div class=""box-body"">
              <div class=""row"">
                <div class=""col-md-8"">
                  <div class=""chart-responsive"">
                    <canvas id=""pieChart"" height=""223""></canvas>
                  </div>
                  <!-- ./chart-responsive -->
                </");
            WriteLiteral(@"div>
                <!-- /.col -->
                <div class=""col-md-4"">
                  <ul class=""chart-legend clearfix"" id='pie-chart'>
                  </ul>
                </div>
                <!-- /.col -->
              </div>
              <!-- /.row -->
            </div>
            <!-- /.footer -->
          </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-7"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Danh sách đơn hàng</h3>
                </div>
            <!-- /.box-header -->
            <div class=""box-body"">
                <table id=""example2"" class=""table table-bordered table-hover"">
                <thead>
                <tr>
                    <th>STT</th>
                    <th>Tình trạng</th>
                    <th>Tổng tiền</th>
                    <th>Người mua</th>
                    <th>Ngày mua</th>
                    <th>Thao tác</th>
                </tr>
      ");
            WriteLiteral("          </thead>\n                <tbody>\n");
#nullable restore
#line 94 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                      
                        foreach (var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr role=\"row\" class=\"odd\">\n                                <td class=\"sorting_1\">");
#nullable restore
#line 97 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                                                 Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>\n");
#nullable restore
#line 99 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                                      
                                        switch (item.OrderStatus)
                                        {
                                            case 0:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"label label-warning\">Pending</span>\n");
#nullable restore
#line 104 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                                                break;
                                            case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"label label-warning\">Processing</span>\n");
#nullable restore
#line 107 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                                                break;
                                            case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"label label-success\">Shipped</span>\n");
#nullable restore
#line 110 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                                                break;
                                            case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"label label-danger\">Delivered</span>\n");
#nullable restore
#line 113 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                                                break;
                                            default:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"label label-warning\">Pending</span>\n");
#nullable restore
#line 116 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                                                break;
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\n                                <td>");
#nullable restore
#line 120 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                               Write(item.TotalPrice.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\n                                <td>\n");
#nullable restore
#line 122 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                                      
                                        if (item.Account == null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span style=\"color:\t#bfc4c4\">Ẩn danh</span>\n");
#nullable restore
#line 125 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                                        }
                                        else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 127 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                                             Write(item.Account);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 128 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\n                                <td>");
#nullable restore
#line 131 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                               Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5726, "\"", 5782, 2);
            WriteAttributeValue("", 5733, "/Admin/ShopOrder/OrderDetail?id=", 5733, 32, true);
#nullable restore
#line 133 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 5765, item.ShopOrderId, 5765, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-info\" style=\"color: white\">Chi tiết</a>\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5889, "\"", 5940, 2);
            WriteAttributeValue("", 5896, "/Admin/ShopOrder/Delete?id=", 5896, 27, true);
#nullable restore
#line 134 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 5923, item.ShopOrderId, 5923, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-danger\" style=\"color: white\">Xóa</a>\n                                </td>\n                            </tr>\n");
#nullable restore
#line 137 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                            stt++;
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n                </table>\n            </div>\n            <div class=\"box-footer clearfix\">\n                <ul class=\"pagination pagination-sm no-margin pull-right\">\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 6377, "\"", 6438, 2);
            WriteAttributeValue("", 6384, "/Admin/Home/Index?pageNumber=", 6384, 29, true);
#nullable restore
#line 145 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 6413, Math.Max(pageNumber-1,1), 6413, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&laquo;</a></li>\n");
#nullable restore
#line 146 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                     for (int i = 1; i <= pageCount; ++i)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a");
            BeginWriteAttribute("href", " href=\"", 6567, "\"", 6605, 2);
            WriteAttributeValue("", 6574, "/Admin/Home/Index?pageNumber=", 6574, 29, true);
#nullable restore
#line 148 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 6603, i, 6603, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 148 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 149 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a");
            BeginWriteAttribute("href", " href=\"", 6667, "\"", 6736, 2);
            WriteAttributeValue("", 6674, "/Admin/Home/Index?pageNumber=", 6674, 29, true);
#nullable restore
#line 150 "D:\Subjects\PMMNM\BanTraiCay\AppManager\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 6703, Math.Min(pageNumber+1,pageCount), 6703, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&raquo;</a></li>\n                </ul>\n            </div>\n            <!-- /.box-body -->\n            </div>\n            <!-- /.box -->\n        </div>\n        <!-- /.col -->\n");
            WriteLiteral("    </div>\n</section>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        // line chart

        $.ajax({
            url: ""/Admin/Report/AnnuallyCategoryReport"",
            type: ""GET"",
            dataType: ""json"",
            beforeSend: function(){},
            success: function(data){
                console.log(data + ""123"");
                let r = 0, g = 0, b = 0, r1 = 50;
                var chartData = [];
                let rgb = [""#f56954"", ""#00a65a"", ""#f39c12"", ""#00c0ef"", ""#3c8dbc"", ""#605ca8"", ""#ff851b"", ""#D81B60"", ""#111111"", ""#d2d6de"", ""#001F3F""]
                data.forEach(function(item,index){
                    chartData.push({
                          label: item.category,
                          fillColor: rgb[index],
                          strokeColor: rgb[index],
                          pointColor: rgb[index],
                          pointStrokeColor: rgb[index],
                          pointHighlightFill: rgb[index],
                          pointHighlightStroke: rgb[index],
                          data: item.month
  ");
                WriteLiteral(@"                  });
                    if (index == rgb.Length) return;
                })
                var lineChartCanvas = $(""#lineChart"").get(0).getContext(""2d"");
                var lineChart = new Chart(lineChartCanvas);

                var lineChartData = {
                  labels: [""January"", ""February"", ""March"", ""April"", ""May"", ""June"", ""July"", ""August"", ""September"", ""November"", ""December""],
                  datasets: chartData, 
                };

                var lineChartOptions = {
                  //Boolean - If we should show the scale at all
                  showScale: true,
                  //Boolean - Whether grid lines are shown across the chart
                  scaleShowGridLines: false,
                  //String - Colour of the grid lines
                  scaleGridLineColor: ""rgba(125, 202, 194, 1)"",
                  //Number - Width of the grid lines
                  scaleGridLineWidth: 1,
                  //Boolean - Whether to show horizontal lines (except X axis)
");
                WriteLiteral(@"                  scaleShowHorizontalLines: true,
                  //Boolean - Whether to show vertical lines (except Y axis)
                  scaleShowVerticalLines: true,
                  //Boolean - Whether the line is curved between points
                  bezierCurve: true,
                  //Number - Tension of the bezier curve between points
                  bezierCurveTension: 0.3,
                  //Boolean - Whether to show a dot for each point
                  pointDot: false,
                  //Number - Radius of each point dot in pixels
                  pointDotRadius: 4,
                  //Number - Pixel width of point dot stroke
                  pointDotStrokeWidth: 1,
                  //Number - amount extra to add to the radius to cater for hit detection outside the drawn point
                  pointHitDetectionRadius: 20,
                  //Boolean - Whether to show a stroke for datasets
                  datasetStroke: true,
                  //Number - Pixel width of dataset");
                WriteLiteral(@" stroke
                  datasetStrokeWidth: 2,
                  //Boolean - Whether to fill the dataset with a color
                  datasetFill: true,
                  //String - A legend template
                  legendTemplate: ""<ul class=\""<%=name.toLowerCase()%>-legend\""><% for (var i=0; i<datasets.length; i++){%><li><span style=\""background-color:<%=datasets[i].lineColor%>\""></span><%if(datasets[i].label){%><%=datasets[i].label%><%}%></li><%}%></ul>"",
                  //Boolean - whether to maintain the starting aspect ratio or not when responsive, if set to false, will take up entire container
                  maintainAspectRatio: true,
                  //Boolean - whether to make the chart responsive to window resizing
                  responsive: true
                };
                
                lineChartOptions.datasetFill = false;
                lineChart.Line(lineChartData, lineChartOptions);
            },
            error: function(){
                console.log(""error!"");
  ");
                WriteLiteral(@"          },
            complete: function(){}
        });

        // pie-chart
        // ajax sẽ chạy sau cùng sau khi các script chạy xong, nên phải nhét code vẽ pie vào success để nó xử lý khi đã có kết quả
        // nếu để ngoài thì chart vẽ rồi data mới được lôi ra

        $.ajax({
            url: ""/Admin/Report/MonthlyCategoryReport"",
            type: ""GET"",
            dataType: ""json"",
            beforeSend: function(){},
            success: function(data){
                console.log(data + ""123"");
                let color = ['red', 'green', 'yellow', 'aqua', 'light-blue', 'purple'];
                let rgb = [""#f56954"", ""#00a65a"", ""#f39c12"", ""#00c0ef"", ""#3c8dbc"", ""#605ca8"", ""#d2d6de""]
                let total = 0, currentsum = 0;
                var PieData = [];
                data.forEach(function(item,index){
                    total += item.quantity;
                });
                data.forEach(function(item,index){
                    let html = `<li><i class=""fa fa-circle-o te");
                WriteLiteral(@"xt-${color[index]}""></i>&nbsp;${item.name}</li>`;
                    PieData.push({
                                    value: item.quantity,
                                    color: rgb[index],
                                    highlight: rgb[index],
                                    label: item.name
                                  });
                    
                    currentsum += item.quantity;
                    $('#pie-chart').append(html);  
                    if (index == color.Length - 1){
                        $('#pie-chart').append(`<li><i class=""fa fa-circle-o text-gray}""></i>Khác</li>`);
                        PieData.push({
                                        value: total - currentsum,
                                        color: rgb[6],
                                        highlight: rgb[6],
                                        label: ""Khác""
                                      });
                        return;
                    }
                });

     ");
                WriteLiteral(@"           var pieChartCanvas = $(""#pieChart"").get(0).getContext(""2d"");
                var pieChart = new Chart(pieChartCanvas);
                var pieOptions = {
                  //Boolean - Whether we should show a stroke on each segment
                  segmentShowStroke: true,
                  //String - The colour of each segment stroke
                  segmentStrokeColor: ""#fff"",
                  //Number - The width of each segment stroke
                  segmentStrokeWidth: 2,
                  //Number - The percentage of the chart that we cut out of the middle
                  percentageInnerCutout: 50, // This is 0 for Pie charts
                  //Number - Amount of animation steps
                  animationSteps: 100,
                  //String - Animation easing effect
                  animationEasing: ""easeOutBounce"",
                  //Boolean - Whether we animate the rotation of the Doughnut
                  animateRotate: true,
                  //Boolean - Whether we animate s");
                WriteLiteral(@"caling the Doughnut from the centre
                  animateScale: false,
                  //Boolean - whether to make the chart responsive to window resizing
                  responsive: true,
                  // Boolean - whether to maintain the starting aspect ratio or not when responsive, if set to false, will take up entire container
                  maintainAspectRatio: true,
                  //String - A legend template
                  legendTemplate: ""<ul class=\""<%=name.toLowerCase()%>-legend\""><% for (var i=0; i<segments.length; i++){%><li><span style=\""background-color:<%=segments[i].fillColor%>\""></span><%if(segments[i].label){%><%=segments[i].label%><%}%></li><%}%></ul>""
                };
                //Create pie or douhnut chart
                // You can switch between pie and douhnut using the method below.
                pieChart.Doughnut(PieData, pieOptions);
            },
            error: function(){
                console.log(""error!"");
            },
            complete");
                WriteLiteral(@": function(){}
        });

        $.ajax({
            url: ""/Admin/Home/GetNewUser"",
            type: ""GET"",
            dataType: ""json"",
            beforeSend: function(){},
            success: function(data){
                $('#users-list').html('');
                data.forEach(function(item,index){
                    console.log(data);
                    $('#users-list').append(`<li>
                                              <img src=""${item.avatarPath}"" style=""width: 106px; height:106px"" alt=""User Image"">
                                              <a class=""users-list-name"" href=""/Admin/Account/UserProfile?account=${item.account}"">${item.firstName} ${item.lastName}</a>
                                              <span class=""users-list-date"">${item.role.charAt(0).toUpperCase() + item.role.slice(1)}</span>
                                            </li>`);
                })
            }
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
