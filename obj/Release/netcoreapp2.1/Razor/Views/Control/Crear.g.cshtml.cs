#pragma checksum "C:\Users\Cristian Asenjo\source\repos\Mantencion\Views\Control\Crear.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81e728c32ae8c14756ca6b32388ddabc1c5cc43d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Control_Crear), @"mvc.1.0.view", @"/Views/Control/Crear.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Control/Crear.cshtml", typeof(AspNetCore.Views_Control_Crear))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e728c32ae8c14756ca6b32388ddabc1c5cc43d", @"/Views/Control/Crear.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d3a2a12a58c7627d23488912a669ac19a9c2fce", @"/Views/_ViewImports.cshtml")]
    public class Views_Control_Crear : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AjaxCrear"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Cristian Asenjo\source\repos\Mantencion\Views\Control\Crear.cshtml"
  
    Layout = null;
    string fecha = System.DateTime.Now.ToString("yyyy-MM-dd");

#line default
#line hidden
            BeginContext(91, 216, true);
            WriteLiteral("\r\n<div class=\"modal-header\">\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n        <span aria-hidden=\"true\">&times;</span>\r\n    </button>\r\n</div>\r\n\r\n<div class=\"modal-body\">\r\n    ");
            EndContext();
            BeginContext(307, 1428, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0128f7a1348b4828b5232ad88fdd2333", async() => {
                BeginContext(328, 129, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label\">Fecha Consumo</label>\r\n            <input id=\"fecha\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 457, "\"", 471, 1);
#line 16 "C:\Users\Cristian Asenjo\source\repos\Mantencion\Views\Control\Crear.cshtml"
WriteAttributeValue("", 465, fecha, 465, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(472, 217, true);
                WriteLiteral(" type=\"date\" class=\"form-control\" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label\">Turno</label>\r\n            <select id=\"id_turno\" class=\"form-control\">\r\n                ");
                EndContext();
                BeginContext(689, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "876c7bb44577438b8b68f68eccb72988", async() => {
                    BeginContext(707, 5, true);
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
                BeginContext(721, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(739, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c53099350c44b9e957fccad28fb98a2", async() => {
                    BeginContext(757, 3, true);
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
                BeginContext(769, 218, true);
                WriteLiteral("\r\n            </select>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label\">Tipo Consumo</label>\r\n            <select id=\"id_tipo_consumo\" class=\"form-control\">\r\n                ");
                EndContext();
                BeginContext(987, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7ced59259e04d80aa55496e83a37410", async() => {
                    BeginContext(1005, 4, true);
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
                BeginContext(1018, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1036, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20db75d2c6fc49e0b03217268e934a85", async() => {
                    BeginContext(1054, 3, true);
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
                BeginContext(1066, 662, true);
                WriteLiteral(@"
            </select>
        </div>
        <div class=""form-group"">
            <label class=""control-label"">Consumo m³ (Entrada)</label>
            <input id=""consumo_entrada"" class=""form-control"" type=""text"" />
        </div>
        <div class=""form-group"">
            <label class=""control-label"">Consumo m³ (Salida)</label>
            <input id=""consumo_salida"" class=""form-control"" type=""text""/>
        </div>
        <div class=""modal-footer"">
            <button type=""submit"" id=""SubmitCrear"" class=""btn btn-primary"" style=""float:right;""><i class=""far fa-save"" style=""font-size:20px;""></i> Crear Consumo</button>
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
            BeginContext(1735, 325, true);
            WriteLiteral(@"
</div>

<script type=""text/javascript"">
        $(function () {
            $(""#AjaxCrear"").submit(function (e) {
                e.preventDefault();

                // Deshabilitamos el botón de Submit
                $(""#SubmitCrear"").prop(""disabled"", true);
                $.ajax({
                    url: """);
            EndContext();
            BeginContext(2061, 30, false);
#line 54 "C:\Users\Cristian Asenjo\source\repos\Mantencion\Views\Control\Crear.cshtml"
                     Write(Url.Action("Crear", "Control"));

#line default
#line hidden
            EndContext();
            BeginContext(2091, 2139, true);
            WriteLiteral(@""", // Url
                    data: {
                            // Datos / Parámetros
                        fecha: $(""#fecha"").val(),
                        id_turno: $(""#id_turno"").val(),
                        id_tipo_consumo: $(""#id_tipo_consumo"").val(),
                        consumo_entrada: $(""#consumo_entrada"").val(),
                        consumo_salida: $(""#consumo_salida"").val(),
                        consumo_total: $(""#consumo_total"").val()
                    },
                    type: ""post""  // Verbo HTTP
                })
                // Se ejecuta si todo fue bien.
                .done(function (result) {
                    if (result != null) {
                        $(""#bd"").html(result);

                        // Un pequeño esfecto especial ;)
                        $(""#database .row"").first().hide();
                        $(""#database .row"").first().slideToggle(""fast"");
                        // Habilitamos el botón de Submit
                 ");
            WriteLiteral(@"       $(""#SubmitCrear"").prop(""disabled"", false);
                        $('#myModalCreate').modal('hide')
                        // Mostramos un mensaje de éxito.
                        $(""#ExitoCreate"").show(""slow"").delay(3000).hide(""slow"");
                        $(""#id_turno"").val("""");
                        $(""#id_tipo_consumo"").val("""");
                        $(""#consumo_entrada"").val("""");
                        $(""#consumo_salida"").val("""");
                        $(""#consumo_total"").val("""");
                    }
                })
                // Se ejecuta si se produjo un error.
                .fail(function (xhr, status, error) {
                    // Mostramos un mensaje de error.
                    $(""#ErrorCreate"").show(""slow"").delay(3000).hide(""slow"");

                    // Habilitamos el botón de Submit
                    $(""#SubmitCrear"").prop(""disabled"", false);
                })
                // Hacer algo siempre, haya sido exitosa o no.
            ");
            WriteLiteral("    .always(function () {\r\n                });\r\n            });\r\n        });\r\n</script>\r\n\r\n");
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
