#pragma checksum "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\Cargo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aba3d29bd0bf9de9f9f25b9abf8147c4f3eb54c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cargo_Index), @"mvc.1.0.view", @"/Views/Cargo/Index.cshtml")]
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
#line 1 "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\_ViewImports.cshtml"
using ControlRH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\_ViewImports.cshtml"
using ControlRH.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba3d29bd0bf9de9f9f25b9abf8147c4f3eb54c5", @"/Views/Cargo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26c600f2a0ca1047f9dc6b137b3f013d4540face", @"/Views/_ViewImports.cshtml")]
    public class Views_Cargo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CargoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cargo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetCargo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\Cargo\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aba3d29bd0bf9de9f9f25b9abf8147c4f3eb54c55339", async() => {
                WriteLiteral(@"
            <div class=""card"">
                <div class=""card-header"">
                    Filtros
                </div>
                <div class=""card-body"">
                    <div class=""row g-2"">
                        <div class=""col-md"">
                            <label>Nome do Cargo</label>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aba3d29bd0bf9de9f9f25b9abf8147c4f3eb54c55950", async() => {
                    WriteLiteral("\r\n                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aba3d29bd0bf9de9f9f25b9abf8147c4f3eb54c56250", async() => {
                        WriteLiteral("-- SELECIONE --");
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
                    WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\Cargo\Index.cshtml"
                                 foreach (var item in Model.ItensToSelect)
                                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aba3d29bd0bf9de9f9f25b9abf8147c4f3eb54c57913", async() => {
#nullable restore
#line 21 "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\Cargo\Index.cshtml"
                                                                Write(item.Nome_Cargo);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\Cargo\Index.cshtml"
                                       WriteLiteral(item.Nome_Cargo);

#line default
#line hidden
#nullable disable
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
                    WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\Cargo\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 17 "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\Cargo\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Nome_Cargo);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
            WriteLiteral(@"

        <br />
        <hr />
        <br />

        <table id=""grid"" class=""table table-striped table-bordered"" style=""width:100%"">
            <thead>
                <tr>
                    <th>Cargo</th>
                    <th>Descrição</th>
                    <th class=""nosort""></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 47 "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\Cargo\Index.cshtml"
                 foreach (var item in Model.Itens)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\Cargo\Index.cshtml"
                       Write(item.Nome_Cargo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\Cargo\Index.cshtml"
                       Write(item.Descricao_Cargo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"td-th-icon-size nosort text-center\">\r\n                            <a class=\"btn-edit\" data-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2086, "\"", 2165, 8);
            WriteAttributeValue("", 2096, "OpenUpdateModal(", 2096, 16, true);
#nullable restore
#line 53 "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\Cargo\Index.cshtml"
WriteAttributeValue("", 2112, item.ID, 2112, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2120, ",\'", 2120, 2, true);
#nullable restore
#line 53 "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\Cargo\Index.cshtml"
WriteAttributeValue("", 2122, item.Nome_Cargo, 2122, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2138, "\',", 2138, 2, true);
            WriteAttributeValue(" ", 2140, "\'", 2141, 2, true);
#nullable restore
#line 53 "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\Cargo\Index.cshtml"
WriteAttributeValue("", 2142, item.Descricao_Cargo, 2142, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2163, "\')", 2163, 2, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Editar cargo\"><i class=\"fas fa-edit td-icon text-success\"></i></a>\r\n                            <a class=\"btn-excluir\" data-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2335, "\"", 2390, 6);
            WriteAttributeValue("", 2345, "DeleteCargoData(", 2345, 16, true);
#nullable restore
#line 54 "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\Cargo\Index.cshtml"
WriteAttributeValue("", 2361, item.ID, 2361, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2369, ",", 2369, 1, true);
            WriteAttributeValue(" ", 2370, "\'", 2371, 2, true);
#nullable restore
#line 54 "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\Cargo\Index.cshtml"
WriteAttributeValue("", 2372, item.Nome_Cargo, 2372, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2388, "\')", 2388, 2, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Excluir cargo\"><i class=\"fas fa-trash td-icon text-danger\"></i></a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Cliente\source\repos\_YouController\Aplicação\ControlRH\ControlRH\Views\Cargo\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>

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
                                <label>Nome do Cargo</label>
                                <input type=""text"" class=""form-control"" autocomplete=""off"" id=""nome-cargo-insert"">
                            </div>
                        </div>

                        <div class=""row g-2"">
                            <div class=""col-md"">
                                <label>Descrição do Cargo</label>
                                <tex");
            WriteLiteral(@"tarea type=""text"" class=""form-control"" autocomplete=""off"" id=""descricao-cargo-insert""></textarea>
                            </div>
                        </div>

                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-danger"" id=""btn-inserir-cancelar"" data-dismiss=""modal"">Cancelar</button>
                        <button type=""button"" class=""btn btn-success"" id=""btn-salvar-perfil"" onclick=""InsertCargoData();"">Salvar</button>
                    </div>
                </div>
            </div>
        </div>

        <div class=""modal"" id=""modal-update"">
            <div class=""modal-dialog modal-dialog-centered"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h4 class=""modal-title"">Alterar</h4>
                        <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                    </div>
                    <div");
            WriteLiteral(@" class=""modal-body"">
                        <input hidden id=""id-update"" />
                        <div class=""row g-2"">
                            <div class=""col-md"">
                                <label>Nome do Cargo</label>
                                <input type=""text"" class=""form-control"" autocomplete=""off"" id=""nome-cargo-update"">
                            </div>
                        </div>
                        <div class=""row g-2"">
                            <div class=""col-md"">
                                <label>Descrição do Cargo</label>
                                <textarea type=""text"" class=""form-control"" autocomplete=""off"" id=""descricao-cargo-update""></textarea>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Cancelar</button>
                        <button type=""button"" clas");
            WriteLiteral(@"s=""btn btn-success"" id=""btn-editar-perfil"" onclick=""UpdateCargoData();"">Salvar</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<script type=""text/javascript"">
    $(document).ready(function () {
        $('#grid').DataTable();

        $(""#btn-filtra"").hide();
        $(""#btn-insert"").hide();
        $("".btn-edit"").hide();
        $("".btn-excluir"").hide();

        HasPermission(3);
    });

    $(""#btn-insert"").click(function () {
        $('#modal-insert').modal('show');
    });

    function OpenUpdateModal(Id, NomeCargo, DescCargo) {
        $('#modal-update').modal('show');
        $(""#id-update"").val(Id);
        $('#nome-cargo-update').val(NomeCargo);
        $('#descricao-cargo-update').val(DescCargo);
    }

    function InsertCargoData() {
        var model = {
            Nome_Cargo: $('#nome-cargo-insert').val(),
            Descricao_Cargo: $('#descricao-cargo-insert').val()
        }
        Aja");
            WriteLiteral(@"xHelper('POST', '/Cargo/CreateCargo', model, function (result) {
            if (result) {
                configureSweetSuccess(""Cargo inserido com Sucesso"", ""/Cargo/Index"")
            }
            else {
                configureSweetError('error');
            }
        })
    }

    function UpdateCargoData() {
        var model = {
            ID: $(""#id-update"").val(),
            Nome_Cargo: $('#nome-cargo-update').val(),
            Descricao_Cargo: $('#descricao-cargo-update').val()
        };

        AjaxHelper('PUT', '/Cargo/UpdateCargo', model, function (result) {
            if (result) {
                configureSweetSuccess(""Férias alteradas com Sucesso"", ""/Cargo/Index"")
            }
            else {
                configureSweetError('error');
            }
        })
    }

    function DeleteCargoAjax(id) {
        var model = {
            Id: id,
        };
        AjaxHelper('DELETE', '/Cargo/DeleteCargo', model, function (result) {
            if (r");
            WriteLiteral(@"esult) {
                configureSweetSuccess(""Férias deletadas com sucesso!"", ""/Cargo/Index"")
            }
            else {
                configureSweetError('error');
            }
        })
    }

    function DeleteCargoData(id, NomeCargo) {
        Swal.fire({
            title: NomeCargo,
            text: ""Tem certeza que deseja remover o Cargo "" + NomeCargo + ""?"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#28a745',
            cancelButtonColor: '#dc3545',
            confirmButtonText: 'Sim, deletar!'
        }).then((result) => {
            if (result.isConfirmed) {
                DeleteCargoAjax(id)
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CargoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
