#pragma checksum "F:\6 семестр\экзамены\5_ПИС\задачи\26\WebApplication1\WebApplication1\Views\Home\Any.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12a3b3e31925531f6165811c5a4de5956f95eef6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Any), @"mvc.1.0.view", @"/Views/Home/Any.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Any.cshtml", typeof(AspNetCore.Views_Home_Any))]
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
#line 1 "F:\6 семестр\экзамены\5_ПИС\задачи\26\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "F:\6 семестр\экзамены\5_ПИС\задачи\26\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12a3b3e31925531f6165811c5a4de5956f95eef6", @"/Views/Home/Any.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Any : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\6 семестр\экзамены\5_ПИС\задачи\26\WebApplication1\WebApplication1\Views\Home\Any.cshtml"
   
    ViewData["Title"] = "ViewData. Hello from Natasha";
    ViewBag.Tit = "ViewBag. Hello from Natasha";

#line default
#line hidden
            BeginContext(115, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(123, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7775759f5b594116970a7470ebfe0488", async() => {
                BeginContext(129, 51, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title></title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(187, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(189, 179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9473883140f4d818a4fcd3a09dcc4c6", async() => {
                BeginContext(195, 36, true);
                WriteLiteral("\r\n    <h2>Home/V1/Any</h2>\r\n    <h3>");
                EndContext();
                BeginContext(232, 17, false);
#line 12 "F:\6 семестр\экзамены\5_ПИС\задачи\26\WebApplication1\WebApplication1\Views\Home\Any.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(249, 15, true);
                WriteLiteral("</h3>\r\n    <h3>");
                EndContext();
                BeginContext(265, 19, false);
#line 13 "F:\6 семестр\экзамены\5_ПИС\задачи\26\WebApplication1\WebApplication1\Views\Home\Any.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
                EndContext();
                BeginContext(284, 30, true);
                WriteLiteral("</h3>\r\n    <h3></h3>\r\n    <h3>");
                EndContext();
                BeginContext(315, 12, false);
#line 15 "F:\6 семестр\экзамены\5_ПИС\задачи\26\WebApplication1\WebApplication1\Views\Home\Any.cshtml"
   Write(ViewBag.Mess);

#line default
#line hidden
                EndContext();
                BeginContext(327, 15, true);
                WriteLiteral("</h3>\r\n    <h3>");
                EndContext();
                BeginContext(343, 11, false);
#line 16 "F:\6 семестр\экзамены\5_ПИС\задачи\26\WebApplication1\WebApplication1\Views\Home\Any.cshtml"
   Write(ViewBag.Tit);

#line default
#line hidden
                EndContext();
                BeginContext(354, 7, true);
                WriteLiteral("</h3>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(368, 9, true);
            WriteLiteral("\r\n</html>");
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
