#pragma checksum "C:\Users\danie\Documents\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4e0934e0146f851538d48681b5b674529eb2365"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdministratorSeason_Season), @"mvc.1.0.view", @"/Views/AdministratorSeason/Season.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdministratorSeason/Season.cshtml", typeof(AspNetCore.Views_AdministratorSeason_Season))]
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
#line 1 "C:\Users\danie\Documents\GitHub\proyectohona\Admin\Presentation\Views\_ViewImports.cshtml"
using Presentation;

#line default
#line hidden
#line 2 "C:\Users\danie\Documents\GitHub\proyectohona\Admin\Presentation\Views\_ViewImports.cshtml"
using Presentation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4e0934e0146f851538d48681b5b674529eb2365", @"/Views/AdministratorSeason/Season.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca7828e27a152be4cd8b1f2c1fa15ad084747ea", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministratorSeason_Season : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Presentation.Models.TypeRoomModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/AdministratorSeason/insert"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\danie\Documents\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
  
    List<SeasonModel> seasonlist = ViewBag.season;
    List<TypeRoomModel> typeroomlist = ViewBag.type;

#line default
#line hidden
            BeginContext(161, 70, true);
            WriteLiteral("<div class=\"container\">\r\n    <br />\r\n\r\n    <div class=\"row\">\r\n        ");
            EndContext();
            BeginContext(231, 1728, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbb04c75ec2d44a5ae9923b9a9e271fe", async() => {
                BeginContext(288, 1664, true);
                WriteLiteral(@"
            <div class=""col-6"">
                <div>
                    <h5 class=""text-center""> Temporadas y Ofertas Especiales </h5>

                    <div>
                        <label for=""arrivaldate"">Fecha de Inicio</label>
                        <input type=""date"" class=""form-control"" id=""dateinputseason"" name=""dateinputseason"" onchange=""datechange()"" required>
                        <div class=""valid-feedback"">
                            Fecha selecionada
                        </div>
                    </div>
                    <div>
                        <label for=""departuredate"">Fecha Fin </label>
                        <input type=""date"" class=""form-control"" id=""dateoutputseason"" name=""dateoutputseason"" required>
                        <div class=""valid-feedback"">
                            Fecha selecionada
                        </div>
                    </div>
                    <div>
                        <h5 class=""text-center"">Porcentaje de la Tem");
                WriteLiteral(@"porada o Oferta </h5>
                        <input type=""text"" id=""percentation"" name=""percentation""><br><br>
                    </div>
                    <div>
                        <h5 class=""text-center"">Descripción de la Temporada o Oferta </h5>
                        <textarea id=""descriptionText"" name=""descriptionText"" rows=""8"" cols=""50""></textarea>
                    </div>
                    <div>
                        <br />
                        <button id=""descriptionB"" type=""submit"" class=""btn-group"">Guardar</button>

                    </div>
                </div>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1959, 578, true);
            WriteLiteral(@"
        <div class=""col-6"">
            <table class=""table table-striped table-bordered table-sm"" id=""tableSeason"" name=""tableSeason"">
                <thead>
                    <tr>
                        <th>ID</th>

                        <th>Fecha de Inicion</th>
                        <th>Fecha fin</th>
                        <th>Descripción</th>
                        <th>Porcentaje</th>
                        <th>Estado</th>
                        <th>Acción</th>

                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 61 "C:\Users\danie\Documents\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                     for (int i = 0; i < seasonlist.Count(); i++)
                    {

#line default
#line hidden
            BeginContext(2627, 77, true);
            WriteLiteral("                        <tr>\r\n\r\n\r\n                            <td class=\"id\">");
            EndContext();
            BeginContext(2705, 16, false);
#line 66 "C:\Users\danie\Documents\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                      Write(seasonlist[i].id);

#line default
#line hidden
            EndContext();
            BeginContext(2721, 56, true);
            WriteLiteral("</td>\r\n\r\n                            <td class=\"datein\">");
            EndContext();
            BeginContext(2778, 29, false);
#line 68 "C:\Users\danie\Documents\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                          Write(seasonlist[i].dateinputseason);

#line default
#line hidden
            EndContext();
            BeginContext(2807, 55, true);
            WriteLiteral("</td>\r\n                            <td class=\"dateout\">");
            EndContext();
            BeginContext(2863, 30, false);
#line 69 "C:\Users\danie\Documents\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                           Write(seasonlist[i].dateoutputseason);

#line default
#line hidden
            EndContext();
            BeginContext(2893, 55, true);
            WriteLiteral("</td>\r\n                            <td class=\"descrip\">");
            EndContext();
            BeginContext(2949, 25, false);
#line 70 "C:\Users\danie\Documents\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                           Write(seasonlist[i].description);

#line default
#line hidden
            EndContext();
            BeginContext(2974, 54, true);
            WriteLiteral("</td>\r\n                            <td class=\"percer\">");
            EndContext();
            BeginContext(3029, 26, false);
#line 71 "C:\Users\danie\Documents\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                          Write(seasonlist[i].percentation);

#line default
#line hidden
            EndContext();
            BeginContext(3055, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 72 "C:\Users\danie\Documents\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                             if (@seasonlist[i].state == 1)
                            {

#line default
#line hidden
            BeginContext(3154, 74, true);
            WriteLiteral("                                <td><input type=\"checkbox\" checked></td>\r\n");
            EndContext();
#line 75 "C:\Users\danie\Documents\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3324, 66, true);
            WriteLiteral("                                <td><input type=\"checkbox\"></td>\r\n");
            EndContext();
#line 79 "C:\Users\danie\Documents\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                            }

#line default
#line hidden
            BeginContext(3421, 132, true);
            WriteLiteral("                            <td href=\"#\" id=\"deleteSeason\" class=\"deleteSeason\">Eliminar</td>\r\n\r\n\r\n\r\n                        </tr>\r\n");
            EndContext();
#line 85 "C:\Users\danie\Documents\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                    }

#line default
#line hidden
            BeginContext(3576, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3677, 1560, true);
                WriteLiteral(@"
    <script>
        window.onload = function () {
            // creamos los eventos para cada elemento con la clase ""boton""
            let elementsDelete = document.getElementsByClassName(""deleteSeason"");
            if (elementsDelete != null) {
                for (let i = 0; i < elementsDelete.length; i++) {
                    // cada vez que se haga clic sobre cualquier de los elementos,
                    // ejecutamos la función obtenerValores()
                    elementsDelete[i].addEventListener(""click"", deleteValues);
                }
            }

        }
        function deleteValues(e) {
            var id = """";

            // vamos al elemento padre (<tr>) y buscamos todos los elementos < td >
            // que contenga el elemento padre
            var elementosTD = e.srcElement.parentElement.getElementsByTagName(""td"");
            // obtenemos cada uno de los valores y los ponemos en la variable ""valores""
            id = elementosTD[0].innerHTML;

         ");
                WriteLiteral(@"   $.ajax({
                url: ""/AdministratorSeason/DeleteSeason"",
                data: { 'id': id },
                type: 'GET',

            });

        }

        $(document).on(""click"", "".deleteSeason"", function () {
            event.preventDefault();
            if (window.confirm(""¿Desea eliminar?"")) {
                $(this).closest('#tableSeason tr').remove();
            }
        });
        $(document).ready(function () {
            $('#tableSeason').DataTable();
        });


    </script>
");
                EndContext();
            }
            );
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
