#pragma checksum "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74653a9c7f0a6b4061d9369049aee655be4ee4cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CallSummary), @"mvc.1.0.view", @"/Views/Shared/_CallSummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CallSummary.cshtml", typeof(AspNetCore.Views_Shared__CallSummary))]
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
#line 1 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\_ViewImports.cshtml"
using EbosTask;

#line default
#line hidden
#line 2 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\_ViewImports.cshtml"
using EbosTask.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74653a9c7f0a6b4061d9369049aee655be4ee4cb", @"/Views/Shared/_CallSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d88fd65005ff165546bef87d293dd23a5390cdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CallSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EbosTask.Models.CallsModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(91, 104, true);
            WriteLiteral("\r\n<table class=\"table\" id=\"tblCustomers\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(196, 42, false);
#line 11 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
           Write(Html.DisplayNameFor(model => model.Callid));

#line default
#line hidden
            EndContext();
            BeginContext(238, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(294, 46, false);
#line 14 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(340, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(396, 46, false);
#line 17 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
           Write(Html.DisplayNameFor(model => model.Customerno));

#line default
#line hidden
            EndContext();
            BeginContext(442, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(498, 46, false);
#line 20 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
           Write(Html.DisplayNameFor(model => model.DateofCall));

#line default
#line hidden
            EndContext();
            BeginContext(544, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(600, 46, false);
#line 23 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
           Write(Html.DisplayNameFor(model => model.TimeofCall));

#line default
#line hidden
            EndContext();
            BeginContext(646, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(702, 43, false);
#line 26 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
           Write(Html.DisplayNameFor(model => model.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(745, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(801, 47, false);
#line 29 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(848, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(983, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1044, 41, false);
#line 39 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
               Write(Html.DisplayFor(modelItem => item.Callid));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1153, 45, false);
#line 42 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1266, 45, false);
#line 45 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
               Write(Html.DisplayFor(modelItem => item.Customerno));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1379, 45, false);
#line 48 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateofCall));

#line default
#line hidden
            EndContext();
            BeginContext(1424, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1492, 45, false);
#line 51 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
               Write(Html.DisplayFor(modelItem => item.TimeofCall));

#line default
#line hidden
            EndContext();
            BeginContext(1537, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1605, 42, false);
#line 54 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
               Write(Html.DisplayFor(modelItem => item.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(1647, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1715, 46, false);
#line 57 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1761, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1829, 65, false);
#line 60 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1894, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1919, 71, false);
#line 61 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
               Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1990, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2015, 69, false);
#line 62 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2084, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 65 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Shared\_CallSummary.cshtml"
        }

#line default
#line hidden
            BeginContext(2139, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EbosTask.Models.CallsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
