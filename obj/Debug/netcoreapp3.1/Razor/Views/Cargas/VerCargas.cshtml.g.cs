#pragma checksum "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9694afcdfb0dfe71856fbde774d8681ace7a651"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cargas_VerCargas), @"mvc.1.0.view", @"/Views/Cargas/VerCargas.cshtml")]
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
#line 1 "C:\Workspace\OpplusBSC\Views\_ViewImports.cshtml"
using OpplusBSC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Workspace\OpplusBSC\Views\_ViewImports.cshtml"
using OpplusBSC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9694afcdfb0dfe71856fbde774d8681ace7a651", @"/Views/Cargas/VerCargas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcd4374776d457b5dd6e1e24d719763cd07f6802", @"/Views/_ViewImports.cshtml")]
    public class Views_Cargas_VerCargas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OpplusBSC.Models.Entities.TB_HISTORIAL_CARGAS>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Main", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm waves-effect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VerCargas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
  
    ViewData["Title"] = "VerCargas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9694afcdfb0dfe71856fbde774d8681ace7a6515134", async() => {
                WriteLiteral(@"

    <div class=""row"">

        <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">

            <div class=""form-element-list"">
                <div class=""curved-inner-pro"">
                    <div class=""curved-ctn"">
                        <h2>Data / Archivos / </h2>
                    </div>
                </div>

                <div class=""row"">

                    <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                        <div class=""nk-int-mk sl-dp-mn"">
                            <h2>Fecha de Carga</h2>
                        </div>
                        <div class=""form-group ic-cmp-int"">
                            <div class=""form-ic-cmp"">
                                <i class=""notika-icon notika-calendar""></i>
                            </div>
");
#nullable restore
#line 32 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                              
                                string fecha_ingreso = ViewBag.fecha_hoy;

                                if (fecha_ingreso.Equals("0001-01-01"))
                                {
                                    fecha_ingreso = DateTime.Today.ToString("yyyy-MM-dd");
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"nk-int-st\">\r\n                                <input name=\"fecCarga\"");
                BeginWriteAttribute("value", " value=\"", 1474, "\"", 1496, 1);
#nullable restore
#line 42 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
WriteAttributeValue("", 1482, fecha_ingreso, 1482, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                                       type=""text"" class=""form-control"" data-mask=""9999/99/99"" placeholder=""yyyy/mm/dd"">
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-1 col-sm-1 col-xs-12"">
                        <div class=""nk-int-mk sl-dp-mn"">
                            <h2>Nombre de Archivo</h2>
                        </div>
                        <div class=""nk-int-st"">
                            <input type=""text"" name=""nombre"" class=""form-control"">
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                        <div class=""nk-int-mk sl-dp-mn"">
                            <h2 style=""color:white"">_</h2>
                        </div>
                        <div class=""btn-list"">
                            <button type=""submit"" class=""btn btn-info notika-btn-info waves-effect"">Filtrar</button>
 ");
                WriteLiteral("                           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9694afcdfb0dfe71856fbde774d8681ace7a6518363", async() => {
                    WriteLiteral("Ir al Dashboard");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                    </div>

                </div>

            </div>
        </div>
    </div>

    <br />

    <div class=""row"">

        <div class=""data-table-area"">

            <div class=""row"">

                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                    <div class=""data-table-list"">
                        <div class=""basic-tb-hd"">
                            <h2> Archivos Cargados - Tabla de Resultados</h2>
                            <p>A continuacion de muestran los resultados</p>
                        </div>
                        <div class=""table-responsive"">
                            <table id=""data-table-basic"" class=""table table-striped"">
                                <thead>
                                    <tr>
                                        <th>
                                            #
                                        </th>
                                        <th");
                WriteLiteral(">\r\n                                            ");
#nullable restore
#line 95 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                       Write(Html.DisplayNameFor(model => model.indicador));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 98 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                       Write(Html.DisplayNameFor(model => model.estado));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 101 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                       Write(Html.DisplayNameFor(model => model.archivo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 104 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                       Write(Html.DisplayNameFor(model => model.usuario));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 107 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                       Write(Html.DisplayNameFor(model => model.fecha));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 112 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                       int contador = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 116 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                           Write(contador);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 118 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.indicador));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </td>\r\n");
#nullable restore
#line 120 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                             if (item.estado == "CARGADO")
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <td>\r\n                                                    <button class=\"btn btn-success notika-btn-success waves-effect\" disabled=\"disabled\">");
#nullable restore
#line 123 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                                                                                                                   Write(Html.DisplayFor(modelItem => item.estado));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                                                </td>\r\n");
#nullable restore
#line 125 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <td>\r\n                                                    <button class=\"btn btn-danger notika-btn-danger waves-effect\" disabled=\"disabled\">");
#nullable restore
#line 129 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                                                                                                                 Write(Html.DisplayFor(modelItem => item.estado));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                                                </td>\r\n");
#nullable restore
#line 131 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td>\r\n                                                ");
#nullable restore
#line 133 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.archivo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 136 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.usuario));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 139 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.fecha));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 142 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                        contador = contador + 1;
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </tbody>
                                <tfoot>
                                    <tr>
                                        <th>
                                            #
                                        </th>
                                        <th>
                                            ");
#nullable restore
#line 151 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                       Write(Html.DisplayNameFor(model => model.indicador));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 154 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                       Write(Html.DisplayNameFor(model => model.estado));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 157 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                       Write(Html.DisplayNameFor(model => model.archivo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 160 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                       Write(Html.DisplayNameFor(model => model.usuario));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 163 "C:\Workspace\OpplusBSC\Views\Cargas\VerCargas.cshtml"
                                       Write(Html.DisplayNameFor(model => model.fecha));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </th>
                                    </tr>
                                </tfoot>
                            </table>
                        </div>
                    </div>
                </div>
            </div>

        </div>

    </div>

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OpplusBSC.Models.Entities.TB_HISTORIAL_CARGAS>> Html { get; private set; }
    }
}
#pragma warning restore 1591