#pragma checksum "C:\Users\Cristian Asenjo\source\repos\Mantencion\Views\Control\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ebb00cb2c58eb8bd463e4c0d0173619b9e36b0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Control_Index), @"mvc.1.0.view", @"/Views/Control/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Control/Index.cshtml", typeof(AspNetCore.Views_Control_Index))]
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
#line 1 "C:\Users\Cristian Asenjo\source\repos\Mantencion\Views\_ViewImports.cshtml"
using Mantencion;

#line default
#line hidden
#line 2 "C:\Users\Cristian Asenjo\source\repos\Mantencion\Views\_ViewImports.cshtml"
using Mantencion.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ebb00cb2c58eb8bd463e4c0d0173619b9e36b0e", @"/Views/Control/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d3a2a12a58c7627d23488912a669ac19a9c2fce", @"/Views/_ViewImports.cshtml")]
    public class Views_Control_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AjaxForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Datos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Cristian Asenjo\source\repos\Mantencion\Views\Control\Index.cshtml"
  
    Layout = "_Tareas";
    string fecha = System.DateTime.Now.ToString("yyyy-MM-dd");

#line default
#line hidden
            BeginContext(98, 1063, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"" style=""margin-top:10px;"">
        <div id=""ErrorAlert"" class=""alert alert-danger"" style=""display:none"" role=""alert"">
            No contiene controles el día seleccionado!
        </div>
        <div id=""ErrorEdit"" class=""alert alert-danger"" style=""display:none"" role=""alert"">
            Ocurrio un error al editar el control!
        </div>
        <div id=""ExitoAlert"" class=""alert alert-success"" style=""display:none"" role=""alert"">
            Controles encontrados con exito!
        </div>
        <div id=""ExitoEdit"" class=""alert alert-success"" style=""display:none"" role=""alert"">
            Control modificado con exito!
        </div>
        <div id=""ExitoCreate"" class=""alert alert-success"" style=""display:none"" role=""alert"">
            Control creado con exito!
        </div>
    </div>
</div>

<div class=""mt-5"" style=""background:#fff;border-radius:10px;"">
    <h1 class=""text-center"" style=""font-family: 'Passion One', cursive;
    font-siz");
            WriteLiteral("e: 35px;\">CONSUMO AGUA Y GAS</h1>\r\n    ");
            EndContext();
            BeginContext(1161, 1073, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d74860d1899549278e612f60c572d7f8", async() => {
                BeginContext(1181, 149, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label for=\"fecha\">Seleccionar Fecha:</label>\r\n            <input type=\"date\" name=\"fecha\" id=\"fecha\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1330, "\"", 1344, 1);
#line 33 "C:\Users\Cristian Asenjo\source\repos\Mantencion\Views\Control\Index.cshtml"
WriteAttributeValue("", 1338, fecha, 1338, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1345, 218, true);
                WriteLiteral(" class=\"form-control\" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"turno\">Seleccionar Turno:</label>\r\n            <select class=\"form-control\" name=\"turno\" id=\"turno\">\r\n                ");
                EndContext();
                BeginContext(1563, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e96da0cdaec47809657114e22187fb3", async() => {
                    BeginContext(1581, 5, true);
                    WriteLiteral("NOCHE");
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
                BeginContext(1595, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1613, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dda3adff35294c46bde2a36bc52ae440", async() => {
                    BeginContext(1631, 3, true);
                    WriteLiteral("DÍA");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1643, 226, true);
                WriteLiteral("\r\n            </select>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"turno\">Tipo Consumo:</label>\r\n            <select class=\"form-control\" name=\"tipo_consumo\" id=\"tipo_consumo\">\r\n                ");
                EndContext();
                BeginContext(1869, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d58673a5843e426591ef11b4de9fe95a", async() => {
                    BeginContext(1887, 4, true);
                    WriteLiteral("AGUA");
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
                BeginContext(1900, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1918, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "013ecf16c1834cfba5c94571fdee5ee2", async() => {
                    BeginContext(1936, 3, true);
                    WriteLiteral("GAS");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1948, 279, true);
                WriteLiteral(@"
            </select>
        </div>
        <div class=""form-group"">
            <button type=""submit"" id=""SubmitBtn"" class=""btn btn-primary"" style=""float:right;margin-bottom:20px;""><i class=""fas fa-search"" style=""font-size:20px;""></i> Buscar</button>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2234, 31, true);
            WriteLiteral("\r\n\r\n    <div id=\"bd\">\r\n        ");
            EndContext();
            BeginContext(2265, 24, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2cf6d613de664dc98054d5bbc11f15b8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2289, 520, true);
            WriteLiteral(@"
    </div>
</div>

<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
        </div>
    </div>
</div>

<div class=""modal fade"" id=""myModalCreate"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2826, 207, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n\r\n        $(function () {\r\n            $(\"#AjaxForm\").submit(function (e) {\r\n                e.preventDefault();\r\n\r\n                $.ajax({\r\n                    url: \"");
                EndContext();
                BeginContext(3034, 30, false);
#line 81 "C:\Users\Cristian Asenjo\source\repos\Mantencion\Views\Control\Index.cshtml"
                     Write(Url.Action("Datos", "Control"));

#line default
#line hidden
                EndContext();
                BeginContext(3064, 1305, true);
                WriteLiteral(@""", // Url
                    data: {
                            // Datos / Parámetros
                        Fecha: $(""#fecha"").val(),
                        Turno: $(""#turno"").val(),
                        Tipo_Consumo: $(""#tipo_consumo"").val()
                    },
                    type: ""post""  // Verbo HTTP
                })
                // Se ejecuta si todo fue bien.
                .done(function (result) {
                    if (result != null) {

                        // Actualiza el resultado HTML
                        $(""#bd"").html(result);

                        // Un pequeño esfecto especial ;)
                        $(""#database .row"").first().hide();
                        $(""#database .row"").first().slideToggle(""fast"");
                    }
                })
                // Se ejecuta si se produjo un error.
                .fail(function (xhr, status, error) {
                    // Mostramos un mensaje de error.
                    $(""#Error");
                WriteLiteral(@"Alert"").show(""slow"").delay(3000).hide(""slow"");
                })
                // Hacer algo siempre, haya sido exitosa o no.
                .always(function () {
                    $(""#bd"").html(result);
                });
            });
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(4370, 1, true);
            WriteLiteral(" ");
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
