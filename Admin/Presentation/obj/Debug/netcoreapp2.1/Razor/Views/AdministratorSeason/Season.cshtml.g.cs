#pragma checksum "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cfa9682b075816d9acfef7b94152bb35bb7cf36"
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
#line 1 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\_ViewImports.cshtml"
using Presentation;

#line default
#line hidden
#line 2 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\_ViewImports.cshtml"
using Presentation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cfa9682b075816d9acfef7b94152bb35bb7cf36", @"/Views/AdministratorSeason/Season.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca7828e27a152be4cd8b1f2c1fa15ad084747ea", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministratorSeason_Season : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Presentation.Models.TypeRoomModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/AdministratorSeason/insert"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
  
    List<SeasonModel> seasonlist = ViewBag.season;
    List<TypeRoomModel> typeroomlist = ViewBag.type;

#line default
#line hidden
            BeginContext(161, 70, true);
            WriteLiteral("<div class=\"container\">\r\n    <br />\r\n\r\n    <div class=\"row\">\r\n        ");
            EndContext();
            BeginContext(231, 2585, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cebe1c0f09244e19b02cd5554a0f6185", async() => {
                BeginContext(288, 512, true);
                WriteLiteral(@"
            <div class=""col-6"">
                <div>
                    <h5 class=""text-center""> Temporadas y Ofertas Especiales </h5>
                    <div>
                        <div>
                            <br />

                            <div class=""form-group "">
                                <label for=""typeroomS"">Tipo de habitación:</label>
                                <select class=""form-control"" id=""description"" name=""description"">
                                    ");
                EndContext();
                BeginContext(800, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e544a1d54534a31af49385e6a2d6e64", async() => {
                    BeginContext(818, 23, true);
                    WriteLiteral("-Seleccione una opción-");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(850, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 22 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                     foreach (var typeroom in Model)
                                    {

#line default
#line hidden
                BeginContext(961, 40, true);
                WriteLiteral("                                        ");
                EndContext();
                BeginContext(1001, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38f105f8efc54347ba4de13bed180bc8", async() => {
                    BeginContext(1040, 20, false);
#line 24 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                                                         Write(typeroom.description);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 24 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                           WriteLiteral(typeroom.description);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1069, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 25 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                    }

#line default
#line hidden
                BeginContext(1110, 1699, true);
                WriteLiteral(@"                                </select>
                            </div>

                            <br />

                        </div>
                    </div>
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
                        <h5 class");
                WriteLiteral(@"=""text-center"">Porcentaje de la Temporada o Oferta </h5>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2816, 629, true);
            WriteLiteral(@"
        <div class=""col-6"">
            <table class=""table table-striped table-bordered table-sm"" id=""tableSeason"" name=""tableSeason"">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Tipo de Habitación</th>
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
#line 79 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                     for (int i = 0; i < seasonlist.Count(); i++)
                    {

#line default
#line hidden
            BeginContext(3535, 30, true);
            WriteLiteral("                        <tr>\r\n");
            EndContext();
#line 82 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                             for (int j = 0; j < typeroomlist.Count(); j++)
                            {
                                if (@seasonlist[i].idtyperoom == @typeroomlist[j].id)
                                {

#line default
#line hidden
            BeginContext(3795, 51, true);
            WriteLiteral("                                    <td class=\"id\">");
            EndContext();
            BeginContext(3847, 16, false);
#line 86 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                              Write(seasonlist[i].id);

#line default
#line hidden
            EndContext();
            BeginContext(3863, 60, true);
            WriteLiteral("</td>\r\n                                    <td class=\"desc\">");
            EndContext();
            BeginContext(3924, 27, false);
#line 87 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                                Write(typeroomlist[j].description);

#line default
#line hidden
            EndContext();
            BeginContext(3951, 62, true);
            WriteLiteral("</td>\r\n                                    <td class=\"datein\">");
            EndContext();
            BeginContext(4014, 29, false);
#line 88 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                                  Write(seasonlist[i].dateinputseason);

#line default
#line hidden
            EndContext();
            BeginContext(4043, 63, true);
            WriteLiteral("</td>\r\n                                    <td class=\"dateout\">");
            EndContext();
            BeginContext(4107, 30, false);
#line 89 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                                   Write(seasonlist[i].dateoutputseason);

#line default
#line hidden
            EndContext();
            BeginContext(4137, 63, true);
            WriteLiteral("</td>\r\n                                    <td class=\"descrip\">");
            EndContext();
            BeginContext(4201, 25, false);
#line 90 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                                   Write(seasonlist[i].description);

#line default
#line hidden
            EndContext();
            BeginContext(4226, 62, true);
            WriteLiteral("</td>\r\n                                    <td class=\"percer\">");
            EndContext();
            BeginContext(4289, 26, false);
#line 91 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                                  Write(seasonlist[i].percentation);

#line default
#line hidden
            EndContext();
            BeginContext(4315, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 92 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                     if (@seasonlist[i].state == 1)
                                    {

#line default
#line hidden
            BeginContext(4430, 82, true);
            WriteLiteral("                                        <td><input type=\"checkbox\" checked></td>\r\n");
            EndContext();
#line 95 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(4632, 74, true);
            WriteLiteral("                                        <td><input type=\"checkbox\"></td>\r\n");
            EndContext();
#line 99 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4745, 103, true);
            WriteLiteral("                                    <td href=\"#\" id=\"deleteSeason\" class=\"deleteSeason\">Eliminar</td>\r\n");
            EndContext();
#line 101 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"


                                }
                            }

#line default
#line hidden
            BeginContext(4918, 33, true);
            WriteLiteral("\r\n                        </tr>\r\n");
            EndContext();
#line 107 "E:\Documentos\GitHub\proyectohona\Admin\Presentation\Views\AdministratorSeason\Season.cshtml"
                    }

#line default
#line hidden
            BeginContext(4974, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(5075, 1560, true);
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
