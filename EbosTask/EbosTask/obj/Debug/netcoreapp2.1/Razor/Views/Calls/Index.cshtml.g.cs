#pragma checksum "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Calls\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f94eac9908fa82e105f07ce464b050a922a08597"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calls_Index), @"mvc.1.0.view", @"/Views/Calls/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calls/Index.cshtml", typeof(AspNetCore.Views_Calls_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f94eac9908fa82e105f07ce464b050a922a08597", @"/Views/Calls/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d88fd65005ff165546bef87d293dd23a5390cdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Calls_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Calls", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Calls\Index.cshtml"
  
    ViewData["Title"] = "GetManageCalls";

#line default
#line hidden
            BeginContext(52, 100, true);
            WriteLiteral("<script src=\"https://ajax.aspnetcdn.com/ajax/jquery/jquery-3.3.1.min.js\"></script>\r\n<br/>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(152, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f94eac9908fa82e105f07ce464b050a922a085974605", async() => {
                BeginContext(222, 15, true);
                WriteLiteral("Create New Call");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(241, 3307, true);
            WriteLiteral(@"
</p>

<div class=""row"">
    <div class=""col-sm-12"">
        <table class=""table table-bordered table-striped table-responsive table-hover"" id=""tblCalls"">
            <thead class=""bg-primary"">
                <tr>
                    <th scope=""col"">Sr No</th>
                    <th scope=""col"">Number</th>
                    <th scope=""col"">Date Of Call</th>
                    <th scope=""col"">Time Of Call</th>
                    <th scope=""col"">Subject</th>
                    <th scope=""col"">Description</th>
                    <th scope=""col"">Action</th>
                </tr>
            </thead>
        </table>
    </div>
</div>

<script type=""text/javascript"">

    $(document).ready(function () {
        bindCallsDatatable();
    });

    function bindCallsDatatable() {
        datatable = $('#tblCalls')
            .DataTable({
                ""sAjaxSource"": ""/Calls/GetCallsData"",
                ""bProcessing"": true,
                ""language"": {
                   ");
            WriteLiteral(@" ""emptyTable"": ""No record found."",
                    ""processing"":
                        '<i class=""fa fa-spinner fa-spin fa-3x fa-fw"" style=""color:#2a2b2b;""></i><span class=""sr-only"">Loading...</span> '
                },
                ""columns"": [
                    {
                        data: 'SrNo',
                        render: function (data, type, row, meta) {
                            return meta.row + meta.settings._iDisplayStart + 1;
                        }
                    },
                    {
                        ""data"": ""customerno"",
                        ""autoWidth"": true,
                        ""searchable"": true
                    },

                            {
                                ""data"": ""dateofCall"",
                                ""autoWidth"": true,
                                ""searchable"": true,
                                ""render"": function (data) {
                                    var date = new Date(data);
 ");
            WriteLiteral(@"                                   var month = date.getMonth() + 1;
                                    return date.getDate() + ""/"" + (month.toString().length > 1 ? month : ""0"" + month) + ""/"" + date.getFullYear();
                                }
                            },
                            {
                                ""data"": ""timeofCall"",
                                ""autoWidth"": true,
                                ""searchable"": true,

                    },
                    {
                                ""data"": ""subject"",
                                ""autoWidth"": true,
                                ""searchable"": true
                    },
                    {
                        ""data"": ""description"",
                        ""autoWidth"": true,
                        ""searchable"": true
                    },
                            {
                                ""title"": ""Actions"",
                                ""data"": ""callid"",
   ");
            WriteLiteral("                             \"searchable\": false,\r\n                                \"sortable\": false,\r\n                                \"render\": function (data, type, full, meta) {\r\n                                    return \'<a href=\"");
            EndContext();
            BeginContext(3549, 27, false);
#line 90 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Calls\Index.cshtml"
                                                Write(Url.Action("Edit", "Calls"));

#line default
#line hidden
            EndContext();
            BeginContext(3576, 468, true);
            WriteLiteral(@"?id=' + data + '"" class=""btn btn-success""><i class=""glyphicon glyphicon-pencil""></i></a> &nbsp; <a class=""btn btn-danger"" onclick=""DeleteRow(' + data + ')""><i class=""glyphicon glyphicon-trash""></i></a>';
                                }
                            }

                ]
            });
    }
    function DeleteRow(id) {
    if (confirm(""Are You sure to delete this record..?"")) {
        $.ajax({
           type: 'POST',
           url: '");
            EndContext();
            BeginContext(4045, 29, false);
#line 101 "E:\Dot Net Practices\My Projects\EbosTask\EbosTask\EbosTask\Views\Calls\Index.cshtml"
            Write(Url.Action("Delete", "Calls"));

#line default
#line hidden
            EndContext();
            BeginContext(4074, 424, true);
            WriteLiteral(@"',
           data: { id: id },
           datatype: 'json',
            success: function (response) {
                if (response == ""success"") {

                    alert(""Data Deleted successfully.."");
                    window.location.reload();
                }
            },
            error: function (msg) {
                alert(msg.responseText);
            }
       });
    }
}
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591