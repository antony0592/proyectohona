#pragma checksum "C:\Users\danie\Documents\GitHub\proyectohona\Presentation\Views\About\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64ce0bef0457133415194ca07615319e2d7d44ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Home), @"mvc.1.0.view", @"/Views/About/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/About/Home.cshtml", typeof(AspNetCore.Views_About_Home))]
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
#line 1 "C:\Users\danie\Documents\GitHub\proyectohona\Presentation\Views\_ViewImports.cshtml"
using Presentation;

#line default
#line hidden
#line 2 "C:\Users\danie\Documents\GitHub\proyectohona\Presentation\Views\_ViewImports.cshtml"
using Presentation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64ce0bef0457133415194ca07615319e2d7d44ed", @"/Views/About/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca7828e27a152be4cd8b1f2c1fa15ad084747ea", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Galeria/img_01.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\danie\Documents\GitHub\proyectohona\Presentation\Views\About\Home.cshtml"
  
    List<ContentPageModel> contentPage = (List<ContentPageModel>)ViewBag.contentPage;    
    HotelModel hotel = (HotelModel)ViewBag.hotel;

#line default
#line hidden
            BeginContext(149, 185, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"w-75\">\r\n            <br />\r\n            <h5> Sobre Nosotros</h5>           \r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(335, 13, false);
#line 12 "C:\Users\danie\Documents\GitHub\proyectohona\Presentation\Views\About\Home.cshtml"
               Write(hotel.aboutus);

#line default
#line hidden
            EndContext();
            BeginContext(348, 291, true);
            WriteLiteral(@"
                </p>
            
        </div>
    </div>
    <div class=""col-12"">
        <div class=""container"">
            <h5>Galería</h5>
            <div class=""row w-75"">
                <div class=""col-6"">
                    <div class=""img"">
                        ");
            EndContext();
            BeginContext(639, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ddc04f1ba0474bcdbca2a6cee58414a0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(698, 179, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-6\">\r\n                    <div class=\"container\">\r\n                        <div class=\"row\">\r\n");
            EndContext();
#line 29 "C:\Users\danie\Documents\GitHub\proyectohona\Presentation\Views\About\Home.cshtml"
                             foreach (ContentPageModel content in contentPage)
                            {

#line default
#line hidden
            BeginContext(988, 154, true);
            WriteLiteral("                                <div class=\"col-4\">\r\n\r\n                                    <div class=\"img\">\r\n                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1142, "\"", 1165, 1);
#line 34 "C:\Users\danie\Documents\GitHub\proyectohona\Presentation\Views\About\Home.cshtml"
WriteAttributeValue("", 1148, content.urlimage, 1148, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1166, 107, true);
            WriteLiteral(" class=\"img-fluid\">\r\n                                    </div>\r\n\r\n                                </div>\r\n");
            EndContext();
#line 38 "C:\Users\danie\Documents\GitHub\proyectohona\Presentation\Views\About\Home.cshtml"

                            }

#line default
#line hidden
            BeginContext(1306, 140, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
