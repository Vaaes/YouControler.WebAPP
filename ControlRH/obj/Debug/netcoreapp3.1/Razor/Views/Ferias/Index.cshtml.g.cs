#pragma checksum "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf91fc5b5e5cc3a78d0398991e4d81a589f81824"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ferias_Index), @"mvc.1.0.view", @"/Views/Ferias/Index.cshtml")]
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
#line 1 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\_ViewImports.cshtml"
using ControlRH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\_ViewImports.cshtml"
using ControlRH.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf91fc5b5e5cc3a78d0398991e4d81a589f81824", @"/Views/Ferias/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26c600f2a0ca1047f9dc6b137b3f013d4540face", @"/Views/_ViewImports.cshtml")]
    public class Views_Ferias_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FeriasViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("maxlength", new global::Microsoft.AspNetCore.Html.HtmlString("10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ferias", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetFerias", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml"
  
    ViewData["Title"] = "Ferias";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf91fc5b5e5cc3a78d0398991e4d81a589f818245882", async() => {
                WriteLiteral(@"
            <div class=""card"">
                <div class=""card-header"">
                    Filtros
                </div>
                <div class=""card-body"">
                    <div class=""row g-2"">
                        <div class=""col-md"">
                            <label>Data Início</label>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bf91fc5b5e5cc3a78d0398991e4d81a589f818246491", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 17 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Data_Inicio);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md\">\r\n                            <label>Data Final</label>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bf91fc5b5e5cc3a78d0398991e4d81a589f818248638", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 21 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Data_Final);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                <div class=""card-footer"">
                    <button type=""submit"" id=""btn-filtra"" class=""btn btn-sm btn-primary float-right"">Filtrar</button>
                    <button type=""button"" id=""btn-insert"" class=""btn btn-sm btn-success float-right btn-margin"">Incluir</button>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


        <br />
        <hr />
        <br />

        <div class=""table-responsive"">
            <table id=""grid"" class=""table table-striped table-bordered"" style=""width:100%"">
                <thead>
                    <tr>
                        <th>Colaborador</th>
                        <th>Férias Inicio</th>
                        <th>Férias Final</th>
                        <th>Aprovação</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 49 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml"
                     foreach (var item in Model.Itens)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 52 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml"
                           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 53 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml"
                           Write(item.Data_Inicio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 54 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml"
                           Write(item.Data_Final);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 55 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml"
                             if ((bool)@item.Aprovado)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Aprovado</td>\r\n");
#nullable restore
#line 58 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Ainda não Aprovado</td>\r\n");
#nullable restore
#line 62 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"td-th-icon-size nosort text-center\">\r\n                                <a class=\"btn-edit\" data-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2623, "\"", 2698, 8);
            WriteAttributeValue("", 2633, "OpenUpdateModal(", 2633, 16, true);
#nullable restore
#line 64 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml"
WriteAttributeValue("", 2649, item.Id, 2649, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2657, ",\'", 2657, 2, true);
#nullable restore
#line 64 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml"
WriteAttributeValue("", 2659, item.Data_Inicio, 2659, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2676, "\',", 2676, 2, true);
            WriteAttributeValue(" ", 2678, "\'", 2679, 2, true);
#nullable restore
#line 64 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml"
WriteAttributeValue("", 2680, item.Data_Final, 2680, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2696, "\')", 2696, 2, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Editar Férias\"><i class=\"fas fa-edit td-icon text-success\"></i></a>\r\n                                <a class=\"btn-excluir\" data-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2873, "\"", 2950, 9);
            WriteAttributeValue("", 2883, "DeleteFeriasData(", 2883, 17, true);
#nullable restore
#line 65 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml"
WriteAttributeValue("", 2900, item.Id, 2900, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2908, ",", 2908, 1, true);
            WriteAttributeValue(" ", 2909, "\'", 2910, 2, true);
#nullable restore
#line 65 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml"
WriteAttributeValue("", 2911, item.Data_Inicio, 2911, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2928, "\',", 2928, 2, true);
            WriteAttributeValue(" ", 2930, "\'", 2931, 2, true);
#nullable restore
#line 65 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml"
WriteAttributeValue("", 2932, item.Data_Final, 2932, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2948, "\')", 2948, 2, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Excluir solicitação de Férias\"><i class=\"fas fa-trash td-icon text-danger\"></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 68 "C:\Users\Cliente\source\repos\TCC\Aplicação\ControlRH\ControlRH\Views\Ferias\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>


        <div class=""modal"" id=""modal-insert"">
            <div class=""modal-dialog modal-dialog-centered"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h4 class=""modal-title"">Inserir</h4>
                        <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""row g-2"">
                            <div class=""col-md"">
                                <label>Data Início<span class=""text-danger"">*</span></label>
                                <input type=""text"" class=""form-control placeholder"" onchange=""OnChangeValidation(this)"" autocomplete=""off"" id=""data-inicio-insert"" maxlength=""10"">
                            </div>

                            <div class=""col-md"">
                                <label>Data Final<span class");
            WriteLiteral(@"=""text-danger"">*</span></label>
                                <input type=""text"" class=""form-control placeholder"" onchange=""OnChangeValidation(this)"" autocomplete=""off"" id=""data-final-insert"" maxlength=""10"">
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-danger"" id=""btn-inserir-cancelar"" data-dismiss=""modal"">Cancelar</button>
                        <button type=""button"" class=""btn btn-success"" id=""btn-salvar-perfil"" onclick=""InsertFeriasData();"">Salvar</button>
                    </div>
                </div>
            </div>
        </div>

        <div class=""modal"" id=""modal-update"">
            <div class=""modal-dialog modal-dialog-centered"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h4 class=""modal-title"">Alterar</h4>
                        <button type=""b");
            WriteLiteral(@"utton"" class=""close"" data-dismiss=""modal"">&times;</button>
                    </div>
                    <div class=""modal-body"">
                        <input hidden id=""id-update"" />
                        <div class=""row g-2"">
                            <div class=""col-md"">
                                <label>Data Início<span class=""text-danger"">*</span></label>
                                <input type=""text"" class=""form-control placeholder"" onchange=""OnChangeValidation(this)"" autocomplete=""off"" id=""data-inicio-update"" placeholder=""dd/MM/aaaa"">
                            </div>

                            <div class=""col-md"">
                                <label>Data Final<span class=""text-danger"">*</span></label>
                                <input type=""text"" class=""form-control placeholder"" onchange=""OnChangeValidation(this)"" autocomplete=""off"" id=""data-final-update"" placeholder=""dd/MM/aaaa"">
                            </div>
                        </div>
              ");
            WriteLiteral(@"      </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Cancelar</button>
                        <button type=""button"" class=""btn btn-success"" id=""btn-editar-perfil"" onclick=""UpdateFeriasData();"">Salvar</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<script type=""text/javascript"">
    $(document).ready(function () {
        $('#grid').DataTable({
            ""pageLength"": 100
        });

        $('.placeholder').mask(""00/00/0000"", { placeholder: ""__/__/____"" });

        $(""#btn-filtra"").hide();
        $(""#btn-insert"").hide();
        $("".btn-edit"").hide();
        $("".btn-excluir"").hide();

        HasPermission(5);
    });

    $(""#btn-insert"").click(function () {
        $('#modal-insert').modal('show');
    });

    function OpenUpdateModal(Id, dataInicio, dataFinal) {
        $('#modal-update').modal('show');
");
            WriteLiteral(@"        $(""#id-update"").val(Id);
        $('#data-inicio-update').val(dataInicio);
        $('#data-final-update').val(dataFinal);
    }

    function ValidateBeforeInsert() {
        var model = {
            Data_Inicio: $('#data-inicio-insert'),
            Data_Final: $('#data-final-insert')
        }

        var valida = true

        $.each(model, function (i, item) {
            if (item.val() == """") {
                item.css(""border-color"", ""red"")
                valida = false
            }
        })

        return valida;
    }

    function ValidateBeforeUpdate() {
        var model = {
            Data_Inicio: $('#data-inicio-update'),
            Data_Final: $('#data-final-update')
        }

        var valida = true

        $.each(model, function (i, item) {
            if (item.val() == """") {
                item.css(""border-color"", ""red"")
                valida = false
            }
        })

        return valida;
    }


    function OnChange");
            WriteLiteral(@"Validation(campo) {
        if ($(campo).val() != """") {
            $(campo).css(""border-color"", """")
        }
    }

    function InsertFeriasData() {
        var model = {
            Data_Inicio: $('#data-inicio-insert').val(),
            Data_Final: $('#data-final-insert').val(),
            Aprovado: 0
        }
        if (ValidateBeforeInsert()) {
            AjaxHelper('POST', '/Ferias/CreateFerias', model, function (result) {
                if (result) {
                    configureSweetSuccess(""Férias inseridas com Sucesso"", ""/Ferias/Index"")
                }
                else {
                    configureSweetError('error');
                }
            })
        }
    }

    function UpdateFeriasData() {
        var model = {
            Id: $(""#id-update"").val(),
            Data_Inicio: $('#data-inicio-update').val(),
            Data_Final: $('#data-final-update').val()
        };

        if (ValidateBeforeUpdate()) {
            AjaxHelper('PUT', '/Fe");
            WriteLiteral(@"rias/UpdateFerias', model, function (result) {
                if (result) {
                    configureSweetSuccess(""Férias alteradas com Sucesso"", ""/Ferias/Index"")
                }
                else {
                    configureSweetError('error');
                }
            })
        }
    }

    function DeleteFeriasAjax(id) {
        var model = {
            Id: id,
        };
        AjaxHelper('DELETE', '/Ferias/DeleteFerias', model, function (result) {
            if (result) {
                configureSweetSuccess(""Férias deletadas com sucesso!"", ""/Ferias/Index"")
            }
            else {
                configureSweetError('error');
            }
        })
    }

    function DeleteFeriasData(id, dataInicio, dataFinal) {
        Swal.fire({
            title: ""Férias"",
            text: ""Tem certeza que deseja remover as férias com inicio em: "" + dataInicio + "" e final em: "" + dataFinal + ""?"",
            icon: 'warning',
            showCancelButto");
            WriteLiteral(@"n: true,
            confirmButtonColor: '#28a745',
            cancelButtonColor: '#dc3545',
            confirmButtonText: 'Sim, deletar!'
        }).then((result) => {
            if (result.isConfirmed) {
                DeleteFeriasAjax(id)
            }
        })
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FeriasViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
