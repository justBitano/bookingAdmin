#pragma checksum "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1c1158eecfb4321a999296ce449d756d3bbb4b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Reservations_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Reservations/Index.cshtml")]
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
#line 1 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\_ViewImports.cshtml"
using ReservationRestaurantAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\_ViewImports.cshtml"
using ReservationRestaurantAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1c1158eecfb4321a999296ce449d756d3bbb4b7", @"/Areas/Admin/Views/Reservations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0e554417c8c77bada32b4f8f5ef1789f3dd69e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Reservations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReservationRestaurantAdmin.Models.Reservation>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary m-r-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger  m-r-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info  m-r-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <div class=\"header-sub-title\">\r\n        <nav class=\"breadcrumb breadcrumb-dash\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1c1158eecfb4321a999296ce449d756d3bbb4b77138", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <span class=\"breadcrumb-item active\">Quản lý Reservation</span>\r\n        </nav>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"table-responsive\">\r\n    <h1>\r\n        Quản lý Booking Await\r\n    </h1>\r\n");
            WriteLiteral(@"    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th scope=""col"">ID</th>
                <th scope=""col"">Phone - Name</th>
                <th scope=""col"">Date</th>
                <th scope=""col"">Start Time</th>
                <th scope=""col"">End Time</th>
                <th scope=""col"">Number Guest</th>
                <th scope=""col"">Description</th>
                <th scope=""col"">Price </th>
                <th scope=""col"">Discount </th>
                <th scope=""col"">Phone Guest </th>
                <th scope=""col"">Feedback  </th>
                <th scope=""col"">Status </th>
                <th scope=""col"">#</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 43 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
             if (Model != null)
            {
                foreach (var item in Model)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                     if(item.Status.Equals(false))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 50 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td> ");
#nullable restore
#line 51 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                            Write(item.IdNavigation.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 51 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                                                       Write(item.IdNavigation.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 52 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                           Write(item.Date.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 53 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                           Write(item.StartTime.Value.ToString("hh:mm:ss tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 54 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                           Write(item.EndTime.Value.ToString("hh:mm:ss tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 55 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                            Write(item.NumGuest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 56 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 57 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 58 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                            Write(item.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 59 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                            Write(item.PhoneGuest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 61 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                                 if (item.Feedback == null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>Chưa có feedback</p>\r\n");
#nullable restore
#line 64 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p style=\"color:blue\"> ");
#nullable restore
#line 67 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                                                      Write(item.Feedback);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 68 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                <p style=\"color:red\">Pending</p>\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1c1158eecfb4321a999296ce449d756d3bbb4b715914", async() => {
                WriteLiteral("Confirm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n");
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1c1158eecfb4321a999296ce449d756d3bbb4b718308", async() => {
                WriteLiteral("Reject");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 79 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                     
                   
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n<div class=\"table-responsive\">\r\n    <h1>\r\n        Quản lý Booking\r\n    </h1>\r\n");
            WriteLiteral(@"    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th scope=""col"">ID</th>
                <th scope=""col"">Phone - Name</th>
                <th scope=""col"">Date</th>
                <th scope=""col"">Start Time</th>
                <th scope=""col"">End Time</th>
                <th scope=""col"">Number Guest</th>
                <th scope=""col"">Description</th>
                <th scope=""col"">Price </th>
                <th scope=""col"">Discount </th>
                <th scope=""col"">Phone Guest </th>
                <th scope=""col"">Feedback </th>
                <th scope=""col"">Status </th>
                <th scope=""col"">#</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 114 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
             if (Model != null)
            {
                foreach (var item in Model)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                     if (item.Status.Equals(true))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 121 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td> ");
#nullable restore
#line 122 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                            Write(item.IdNavigation.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 122 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                                                       Write(item.IdNavigation.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 123 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                           Write(item.Date.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 124 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                           Write(item.StartTime.Value.ToString("hh:mm:ss tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 125 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                           Write(item.EndTime.Value.ToString("hh:mm:ss tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 126 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                            Write(item.NumGuest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 127 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 128 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 129 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                            Write(item.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 130 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                            Write(item.PhoneGuest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 132 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                                 if (item.Feedback == null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>Chưa có feedback</p>\r\n");
#nullable restore
#line 135 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                               Write(item.Feedback);

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                                                  
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                <p style=\"color:green\">Approved</p>\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1c1158eecfb4321a999296ce449d756d3bbb4b728214", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 145 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1c1158eecfb4321a999296ce449d756d3bbb4b730576", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 146 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1c1158eecfb4321a999296ce449d756d3bbb4b732942", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 147 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                               \r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 151 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "D:\ReservationRestaurant\ReservationRestaurantAdmin\ReservationRestaurantAdmin\Areas\Admin\Views\Reservations\Index.cshtml"
                     

                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReservationRestaurantAdmin.Models.Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591