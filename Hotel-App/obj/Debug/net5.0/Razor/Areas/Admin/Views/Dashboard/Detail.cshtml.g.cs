#pragma checksum "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\Dashboard\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "193504bba1ff719633d8d6d73aa4543f6a51359b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Detail.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel_App.Areas.Admin.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel_App.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"193504bba1ff719633d8d6d73aa4543f6a51359b", @"/Areas/Admin/Views/Dashboard/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"021a67ad48072506d6349a23f38c00c21b944550", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:500px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("hotel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\Dashboard\Detail.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"fs-1 text-center\">");
#nullable restore
#line 6 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\Dashboard\Detail.cshtml"
                        Write(Model.Hotel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "193504bba1ff719633d8d6d73aa4543f6a51359b5314", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 167, "~/img/HOTEL/", 167, 12, true);
#nullable restore
#line 8 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\Dashboard\Detail.cshtml"
AddHtmlAttributeValue("", 179, Model.Hotel.Image, 179, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<table style=""margin:auto;"" class=""table table-bordered border-primary mb-4"">
    <thead>
        <tr>
            <th scope=""col"">Name</th>
            <th scope=""col"">Description</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>");
#nullable restore
#line 20 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\Dashboard\Detail.cshtml"
           Write(Model.Hotel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\Dashboard\Detail.cshtml"
           Write(Model.Hotel.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
        </tr>
    </tbody>
</table>

<h3 class=""text-center text-danger"">Hotel Rooms:</h3>

<table style=""margin:auto;"" class=""table table-bordered border-primary mb-4"">
    <thead>
        <tr>
            <th scope=""col"">Image</th>
            <th scope=""col"">Room Type</th>
            <th scope=""col"">Adult</th>
            <th scope=""col"">Children</th>
            <th scope=""col"">Square</th>
            <th scope=""col"">Price</th>
            <th scope=""col"">Description</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 41 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\Dashboard\Detail.cshtml"
         foreach (var room in Model.Rooms)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n");
#nullable restore
#line 45 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\Dashboard\Detail.cshtml"
                 foreach (var image in room.RoomImages)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "193504bba1ff719633d8d6d73aa4543f6a51359b8975", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1339, "~/img/", 1339, 6, true);
#nullable restore
#line 47 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\Dashboard\Detail.cshtml"
AddHtmlAttributeValue("", 1345, image.ImageName, 1345, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\Dashboard\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\Dashboard\Detail.cshtml"
               Write(room.RoomType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\Dashboard\Detail.cshtml"
               Write(room.NumberOfAdult);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\Dashboard\Detail.cshtml"
               Write(room.NumberOfChildren);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 53 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\Dashboard\Detail.cshtml"
               Write(room.Square);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 54 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\Dashboard\Detail.cshtml"
               Write(room.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 55 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\Dashboard\Detail.cshtml"
               Write(room.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Areas\Admin\Views\Dashboard\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n\r\n<link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\">\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
