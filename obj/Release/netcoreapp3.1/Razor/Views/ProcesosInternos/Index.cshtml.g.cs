#pragma checksum "C:\Workspace\OpplusBSC\Views\ProcesosInternos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bf121561e77ec209b5dc716fc74ba71d100b846"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProcesosInternos_Index), @"mvc.1.0.view", @"/Views/ProcesosInternos/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bf121561e77ec209b5dc716fc74ba71d100b846", @"/Views/ProcesosInternos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcd4374776d457b5dd6e1e24d719763cd07f6802", @"/Views/_ViewImports.cshtml")]
    public class Views_ProcesosInternos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OpplusBSC.Models.Entities.TB_DATA_PROC_INT>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/FormatoKPI.JPG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Workspace\OpplusBSC\Views\ProcesosInternos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<script type=\"text/javascript\">\r\n\r\n    var vDia = \'");
#nullable restore
#line 10 "C:\Workspace\OpplusBSC\Views\ProcesosInternos\Index.cshtml"
           Write(ViewBag.DAY);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var vMes = \'");
#nullable restore
#line 11 "C:\Workspace\OpplusBSC\Views\ProcesosInternos\Index.cshtml"
           Write(ViewBag.MES);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var vAnio = \'");
#nullable restore
#line 12 "C:\Workspace\OpplusBSC\Views\ProcesosInternos\Index.cshtml"
            Write(ViewBag.YEAR);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n\r\n    var indi = \'");
#nullable restore
#line 14 "C:\Workspace\OpplusBSC\Views\ProcesosInternos\Index.cshtml"
           Write(ViewBag.indicador);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

    window.onload = load;

    function load() {
        console.log(indi);
        //$('#selectMes').val(vMes);
        //$('#selectAnio').val(vAno);

        //checkIndicadoresFinancieros(vMes,vAno);
    }

    function FileDuplicado() {

        var inputTxtFile = $(""#txtArchivo""); //busco la cajita de texto que captura el nombre de archivo
        var itemFormFile = inputTxtFile[0].files; //busco la propiedad files para luego acceder al nombre
        var fileDup = itemFormFile[0].name; // accedo al nombre del archivo

        //console.log(inputTxtFile);
        //console.log(itemFormFile);
        //console.log(fileDup);

         var url = ""/ProcesosInternos/ComprobarArchivoDuplicado"";
            var data = { ""fileuploaded"": fileDup };
            var dataType = ""json"";

            $.ajax({
                type: ""POST"",
                url: url,
                data: data,
                success: function (response) {
                    //console.log(response);
 ");
            WriteLiteral(@"                   if (response >= 1) {                       

                        Swal.fire({
                        title: '¿El archivo ' + fileDup +  ' ya se ha cargado, desea volver a cargarlo ?',
                              showDenyButton: true,
                              showCancelButton: true,
                              confirmButtonText: `Si`,
                              denyButtonText: `Don't save`,
                            }).then((result) => {
                              /* Read more about isConfirmed, isDenied below */
                                if (result.isConfirmed) {

                                    //Swal.fire('Ahora presione: Cargar Archivo', '', 'success')
                                    uploadDataExcel();

                              } else if (result.isDenied) {
                                    Swal.fire('Changes are not saved', '', 'info')
                                }
                              })
                    }
  ");
            WriteLiteral(@"                  else {
                            
                        //console.log(""NO"");
                        
                    }
                },
                dataType: dataType
            });
    };



    function uploadDataExcel() {

        console.log(""hola"");

       var fileUpload = $(""#txtArchivo"").get(0);
       var files = fileUpload.files;

        var data = new FormData();

        for (var i = 0; i < files.length; i++) {
            data.append(files[i].name, files[i]); }   
        

        //console.log(""-----------------"");  

        $.ajax({
            type: ""POST"",
            url: ""/ProcesosInternos/cargarArchivoExcel?indicador="" + indi + ""&vMes="" + vMes + ""&vAnio="" + vAnio,                
            data: data,
            contentType: false,
            processData: false,
            success: function (jres) {

                console.log(jres);

                if (jres.errorMsg == ""OK"") {
                    
         ");
            WriteLiteral(@"           $('#txtArchivo').val("""");                    

                    Swal.fire(jres.errorMsg, jres.msg, 'success')

                }
                else if (jres.msg == ""El tipo de dato o el formato de alguna(s) columna(s) no es válido, por favor revisar el Excel."") {

                    $('#txtArchivo').val("""");        

                    Swal.fire(jres.errorMsg , 'Se cargaron algunos registros pero se detuvo ya que ' + jres.msg, 'warning')                    

                } else if (jres.msg == ""El archivo selecionado no es un documento Excel.Verifique que la extención del documento sea .XLS o .XLSX"")
                {

                    $('#txtArchivo').val("""");        

                    Swal.fire('ERROR', jres.msg, 'warning')

                }else if (jres.msg == ""Error al insertar "")
                {

                    $('#txtArchivo').val("""");        

                    Swal.fire('ERROR', jres.msg, 'warning')
                }
                ///----");
            WriteLiteral(@"---------
            },
        });
        return false;

    }



</script>

<br />

<div class=""row"">

    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">

        <div class=""form-element-list"">
            <div class=""curved-inner-pro"">
                <div class=""curved-ctn"">
                    <h2>Dashboard / Balanced Scorecard / Cargar información para ");
#nullable restore
#line 150 "C:\Workspace\OpplusBSC\Views\ProcesosInternos\Index.cshtml"
                                                                            Write(ViewBag.perspectiva);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <p>Su archivo unicamente con las extensiones  <strong>.XLS o .XLSX </strong> </p>
                </div>
            </div>

            <div class=""row"">

                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                    <div class=""sale-statistic-inner notika-shadow mg-tb-30"">
                        <div class=""curved-inner-pro"">
                            <div class=""curved-ctn"">
                                <h2>Formato Excel de KPIS</h2>
                                <p>Por favor coloque los encabezados exactamente iguales, además no dejar campos en blanco ni los campos de numeros con letras y/o símbolos </p>
                            </div>
                        </div>

                        <div class=""blog-img"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6bf121561e77ec209b5dc716fc74ba71d100b84610414", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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

                <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                    <div class=""nk-int-mk sl-dp-mn"">
                        <h2>Usuario</h2>
                    </div>
                    <div class=""form-group ic-cmp-int"">
                        <div class=""contact-list"">
                            <div class=""form-group"">
                                <input class=""form-control"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 6162, "\"", 6183, 1);
#nullable restore
#line 180 "C:\Workspace\OpplusBSC\Views\ProcesosInternos\Index.cshtml"
WriteAttributeValue("", 6170, ViewBag.user, 6170, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""txtUsuario"" readonly />
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-4 col-sm-4 col-xs-12"">
                    <div class=""nk-int-mk sl-dp-mn"">
                        <h2>Archivo</h2>
                    </div>
                    <div class=""form-group ic-cmp-int"">
                        <div class=""contact-list"">
                            <div class=""form-group"">
                                <input type=""file"" id=""txtArchivo"" onchange=""FileDuplicado();"" />
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-lg-3 col-md-6 col-sm-6 col-xs-12"">
                    <div class=""nk-int-mk sl-dp-mn"">
                        <h2 style=""color:white"">_</h2>
                    </div>
                    <div class=""btn-list"">

                        <button class=""btn b");
            WriteLiteral("tn-info notika-btn-info waves-effect\" onclick=\"uploadDataExcel();\">Cargar Archivo</button>\r\n                        \r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OpplusBSC.Models.Entities.TB_DATA_PROC_INT> Html { get; private set; }
    }
}
#pragma warning restore 1591
