#pragma checksum "E:\Documentos\GitHub\proyectohona\Presentation\Views\Rates\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36b9c3f6f539c8abe36738c8932ce2962fec4edb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rates_Home), @"mvc.1.0.view", @"/Views/Rates/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rates/Home.cshtml", typeof(AspNetCore.Views_Rates_Home))]
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
#line 1 "E:\Documentos\GitHub\proyectohona\Presentation\Views\_ViewImports.cshtml"
using Presentation;

#line default
#line hidden
#line 2 "E:\Documentos\GitHub\proyectohona\Presentation\Views\_ViewImports.cshtml"
using Presentation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b9c3f6f539c8abe36738c8932ce2962fec4edb", @"/Views/Rates/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca7828e27a152be4cd8b1f2c1fa15ad084747ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Rates_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Presentation.Models.TypeRoomModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 111, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n    <br />\r\n    <h5 class=\"titulopagina\"> Tarifas </h5>\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 9 "E:\Documentos\GitHub\proyectohona\Presentation\Views\Rates\Home.cshtml"
         foreach (var content in Model)
        {

#line default
#line hidden
            BeginContext(211, 94, true);
            WriteLiteral("            <div class=\"col-4\">\r\n\r\n                <div class=\"img\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 305, "\"", 328, 1);
#line 14 "E:\Documentos\GitHub\proyectohona\Presentation\Views\Rates\Home.cshtml"
WriteAttributeValue("", 311, content.urlimage, 311, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(329, 120, true);
            WriteLiteral(" class=\"img-fluid\">\r\n                </div>\r\n            </div>\r\n            <div class=\"col-8\">\r\n\r\n                <h6>");
            EndContext();
            BeginContext(450, 19, false);
#line 19 "E:\Documentos\GitHub\proyectohona\Presentation\Views\Rates\Home.cshtml"
               Write(content.description);

#line default
#line hidden
            EndContext();
            BeginContext(469, 48, true);
            WriteLiteral("</h6>\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(518, 27, false);
#line 21 "E:\Documentos\GitHub\proyectohona\Presentation\Views\Rates\Home.cshtml"
               Write(content.descriptiontyperoom);

#line default
#line hidden
            EndContext();
            BeginContext(545, 95, true);
            WriteLiteral(" \r\n                </p>\r\n                <ul>\r\n                    <li>Cantidad de personas es ");
            EndContext();
            BeginContext(641, 22, false);
#line 24 "E:\Documentos\GitHub\proyectohona\Presentation\Views\Rates\Home.cshtml"
                                           Write(content.quantityperson);

#line default
#line hidden
            EndContext();
            BeginContext(663, 51, true);
            WriteLiteral(" </li>\r\n                    <li>Número de camas es ");
            EndContext();
            BeginContext(715, 19, false);
#line 25 "E:\Documentos\GitHub\proyectohona\Presentation\Views\Rates\Home.cshtml"
                                      Write(content.quantitybed);

#line default
#line hidden
            EndContext();
            BeginContext(734, 39, true);
            WriteLiteral(" </li>\r\n                    <li>Precio ");
            EndContext();
            BeginContext(774, 14, false);
#line 26 "E:\Documentos\GitHub\proyectohona\Presentation\Views\Rates\Home.cshtml"
                          Write(content.amount);

#line default
#line hidden
            EndContext();
            BeginContext(788, 50, true);
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n");
            EndContext();
#line 29 "E:\Documentos\GitHub\proyectohona\Presentation\Views\Rates\Home.cshtml"
        }

#line default
#line hidden
            BeginContext(849, 36, true);
            WriteLiteral("    </div>\r\n    <br />\r\n    \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Presentation.Models.TypeRoomModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
