#pragma checksum "C:\Users\Hp\Desktop\ASMEAP2\ASMNhom\StudentManager\Views\Grades\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7a76cbdfc30fc4381e3d37aad61581dbaa4b2c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grades_Details), @"mvc.1.0.view", @"/Views/Grades/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grades/Details.cshtml", typeof(AspNetCore.Views_Grades_Details))]
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
#line 1 "C:\Users\Hp\Desktop\ASMEAP2\ASMNhom\StudentManager\Views\_ViewImports.cshtml"
using StudentManager;

#line default
#line hidden
#line 2 "C:\Users\Hp\Desktop\ASMEAP2\ASMNhom\StudentManager\Views\_ViewImports.cshtml"
using StudentManager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7a76cbdfc30fc4381e3d37aad61581dbaa4b2c0", @"/Views/Grades/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac888811f5a84fb1adbce488f4184df3fb738ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Grades_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManager.Models.Grade>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Hp\Desktop\ASMEAP2\ASMNhom\StudentManager\Views\Grades\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(81, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Grade</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(201, 45, false);
#line 14 "C:\Users\Hp\Desktop\ASMEAP2\ASMNhom\StudentManager\Views\Grades\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GradeName));

#line default
#line hidden
            EndContext();
            BeginContext(246, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(290, 41, false);
#line 17 "C:\Users\Hp\Desktop\ASMEAP2\ASMNhom\StudentManager\Views\Grades\Details.cshtml"
       Write(Html.DisplayFor(model => model.GradeName));

#line default
#line hidden
            EndContext();
            BeginContext(331, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(375, 45, false);
#line 20 "C:\Users\Hp\Desktop\ASMEAP2\ASMNhom\StudentManager\Views\Grades\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(420, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(464, 41, false);
#line 23 "C:\Users\Hp\Desktop\ASMEAP2\ASMNhom\StudentManager\Views\Grades\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(505, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(549, 42, false);
#line 26 "C:\Users\Hp\Desktop\ASMEAP2\ASMNhom\StudentManager\Views\Grades\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(591, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(635, 38, false);
#line 29 "C:\Users\Hp\Desktop\ASMEAP2\ASMNhom\StudentManager\Views\Grades\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(673, 53, true);
            WriteLiteral("\r\n        </dd>\r\n        \r\n    </dl>\r\n</div>\r\n<div>\r\n");
            EndContext();
#line 35 "C:\Users\Hp\Desktop\ASMEAP2\ASMNhom\StudentManager\Views\Grades\Details.cshtml"
     foreach (var su in Model.SubjectGrades)
    {

#line default
#line hidden
            BeginContext(779, 25, true);
            WriteLiteral("        <p>\r\n            ");
            EndContext();
            BeginContext(805, 12, false);
#line 38 "C:\Users\Hp\Desktop\ASMEAP2\ASMNhom\StudentManager\Views\Grades\Details.cshtml"
       Write(su.SubjectId);

#line default
#line hidden
            EndContext();
            BeginContext(817, 16, true);
            WriteLiteral("\r\n        </p>\r\n");
            EndContext();
#line 40 "C:\Users\Hp\Desktop\ASMEAP2\ASMNhom\StudentManager\Views\Grades\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(840, 15, true);
            WriteLiteral("    Sinh vien\r\n");
            EndContext();
#line 42 "C:\Users\Hp\Desktop\ASMEAP2\ASMNhom\StudentManager\Views\Grades\Details.cshtml"
     foreach (var su in Model.GradeStudents)
    {

#line default
#line hidden
            BeginContext(908, 25, true);
            WriteLiteral("        <p>\r\n            ");
            EndContext();
            BeginContext(934, 12, false);
#line 45 "C:\Users\Hp\Desktop\ASMEAP2\ASMNhom\StudentManager\Views\Grades\Details.cshtml"
       Write(su.AccountId);

#line default
#line hidden
            EndContext();
            BeginContext(946, 16, true);
            WriteLiteral("\r\n        </p>\r\n");
            EndContext();
#line 47 "C:\Users\Hp\Desktop\ASMEAP2\ASMNhom\StudentManager\Views\Grades\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(969, 19, true);
            WriteLiteral("</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(988, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b271d458219420b89a32d40fc5866de", async() => {
                BeginContext(1034, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\Hp\Desktop\ASMEAP2\ASMNhom\StudentManager\Views\Grades\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1042, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1050, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7545ab61a9c34a28a92c8208daf73a16", async() => {
                BeginContext(1072, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1088, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentManager.Models.Grade> Html { get; private set; }
    }
}
#pragma warning restore 1591
