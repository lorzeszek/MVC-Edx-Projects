#pragma checksum "C:\Users\Kasztan\Documents\MVC Edx Projects\TestPostman\Views\Game\Created.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9e3838b6d28053bc2df8e6740137181c16c1f0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Created), @"mvc.1.0.view", @"/Views/Game/Created.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Game/Created.cshtml", typeof(AspNetCore.Views_Game_Created))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9e3838b6d28053bc2df8e6740137181c16c1f0b", @"/Views/Game/Created.cshtml")]
    public class Views_Game_Created : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestPostman.Models.Game>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 12, true);
            WriteLiteral("<html>\r\n    ");
            EndContext();
            BeginContext(44, 286, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9e3838b6d28053bc2df8e6740137181c16c1f0b2765", async() => {
                BeginContext(50, 44, true);
                WriteLiteral("\r\n        <h2>TestPostman</h2>\r\n        <h1>");
                EndContext();
                BeginContext(95, 21, false);
#line 5 "C:\Users\Kasztan\Documents\MVC Edx Projects\TestPostman\Views\Game\Created.cshtml"
       Write(Model.City.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(116, 19, true);
                WriteLiteral("</h1>\r\n        <h1>");
                EndContext();
                BeginContext(136, 29, false);
#line 6 "C:\Users\Kasztan\Documents\MVC Edx Projects\TestPostman\Views\Game\Created.cshtml"
       Write(Model.Player1.Name.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(165, 19, true);
                WriteLiteral("</h1>\r\n        <h1>");
                EndContext();
                BeginContext(185, 29, false);
#line 7 "C:\Users\Kasztan\Documents\MVC Edx Projects\TestPostman\Views\Game\Created.cshtml"
       Write(Model.Player1.Rank.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(214, 19, true);
                WriteLiteral("</h1>\r\n        <h1>");
                EndContext();
                BeginContext(234, 29, false);
#line 8 "C:\Users\Kasztan\Documents\MVC Edx Projects\TestPostman\Views\Game\Created.cshtml"
       Write(Model.Player2.Name.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(263, 19, true);
                WriteLiteral("</h1>\r\n        <h1>");
                EndContext();
                BeginContext(283, 29, false);
#line 9 "C:\Users\Kasztan\Documents\MVC Edx Projects\TestPostman\Views\Game\Created.cshtml"
       Write(Model.Player2.Rank.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(312, 11, true);
                WriteLiteral("</h1>\r\n    ");
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
            BeginContext(330, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestPostman.Models.Game> Html { get; private set; }
    }
}
#pragma warning restore 1591