#pragma checksum "C:\Users\51519136897\Documents\RoletopMVC\Views\CadastroEvento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "014f07e902d2dfea8d83fb6349583227e09c16af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CadastroEvento_Index), @"mvc.1.0.view", @"/Views/CadastroEvento/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CadastroEvento/Index.cshtml", typeof(AspNetCore.Views_CadastroEvento_Index))]
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
#line 1 "C:\Users\51519136897\Documents\RoletopMVC\Views\_ViewImports.cshtml"
using RoletopMVC;

#line default
#line hidden
#line 2 "C:\Users\51519136897\Documents\RoletopMVC\Views\_ViewImports.cshtml"
using RoletopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"014f07e902d2dfea8d83fb6349583227e09c16af", @"/Views/CadastroEvento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fcde6f443f8ee695eebee3c09673a46bc68798b", @"/Views/_ViewImports.cshtml")]
    public class Views_CadastroEvento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoletopMVC.ViewModel.PedidoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("box-CaixaEvento"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 83, true);
            WriteLiteral("<main>\r\n    \r\n    <div class=\"espaco\"></div>\r\n    <h2>Cadastro do Evento</h2>\r\n    ");
            EndContext();
            BeginContext(128, 2012, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "014f07e902d2dfea8d83fb6349583227e09c16af4541", async() => {
                BeginContext(221, 425, true);
                WriteLiteral(@"
    <div>
            <label for=""nome_evento"">Nome do Evento</label>
            <div class=""campo"">
                <div>
            <input id=""nome_evento"" type=""text"" maxlength=""20"" minlength=""3"" name=""nome_evento"" required />
        </div>
    </div>

    <div>
        <label for=""email"">E-mail</label>
            <div class=""campo"">
                <div>
                <input id=""email"" type=""email""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 646, "\"", 674, 1);
#line 19 "C:\Users\51519136897\Documents\RoletopMVC\Views\CadastroEvento\Index.cshtml"
WriteAttributeValue("", 654, Model.Cliente.Email, 654, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(675, 268, true);
                WriteLiteral(@" name=""email"" required />
            </div>
    </div>

    <div>
        <label for=""eventos"">Tipo de Evento</label>
            <div class=""field"">
                <div>
                    <select id=""eventos"" name=""eventos"" required>
                    ");
                EndContext();
                BeginContext(943, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "014f07e902d2dfea8d83fb6349583227e09c16af6064", async() => {
                    BeginContext(977, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(995, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 30 "C:\Users\51519136897\Documents\RoletopMVC\Views\CadastroEvento\Index.cshtml"
                     foreach(var evento in @Model.Eventos)
                    {

#line default
#line hidden
                BeginContext(1082, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1106, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "014f07e902d2dfea8d83fb6349583227e09c16af8518", async() => {
                    BeginContext(1140, 17, false);
#line 32 "C:\Users\51519136897\Documents\RoletopMVC\Views\CadastroEvento\Index.cshtml"
                                                    Write(evento.NomeEvento);

#line default
#line hidden
                    EndContext();
                    BeginContext(1157, 7, true);
                    WriteLiteral(" por R$");
                    EndContext();
                    BeginContext(1165, 12, false);
#line 32 "C:\Users\51519136897\Documents\RoletopMVC\Views\CadastroEvento\Index.cshtml"
                                                                             Write(evento.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(1177, 4, true);
                    WriteLiteral(",00 ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 32 "C:\Users\51519136897\Documents\RoletopMVC\Views\CadastroEvento\Index.cshtml"
                          WriteLiteral(evento.NomeEvento);

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
                BeginContext(1190, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 33 "C:\Users\51519136897\Documents\RoletopMVC\Views\CadastroEvento\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1215, 265, true);
                WriteLiteral(@"                </select>
            </div>
        </div>

        <div>
        <label for=""planos"">Planos</label>
            <div class=""field"">
                <div>
                    <select id=""planos"" name=""planos"" required>
                    ");
                EndContext();
                BeginContext(1480, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "014f07e902d2dfea8d83fb6349583227e09c16af11659", async() => {
                    BeginContext(1515, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1533, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 45 "C:\Users\51519136897\Documents\RoletopMVC\Views\CadastroEvento\Index.cshtml"
                     foreach (var produto in Model.Produtos)
                    {

#line default
#line hidden
                BeginContext(1622, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1646, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "014f07e902d2dfea8d83fb6349583227e09c16af14118", async() => {
                    BeginContext(1675, 12, false);
#line 47 "C:\Users\51519136897\Documents\RoletopMVC\Views\CadastroEvento\Index.cshtml"
                                               Write(produto.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(1687, 7, true);
                    WriteLiteral(" por R$");
                    EndContext();
                    BeginContext(1695, 13, false);
#line 47 "C:\Users\51519136897\Documents\RoletopMVC\Views\CadastroEvento\Index.cshtml"
                                                                   Write(produto.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(1708, 4, true);
                    WriteLiteral(",00 ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 47 "C:\Users\51519136897\Documents\RoletopMVC\Views\CadastroEvento\Index.cshtml"
                          WriteLiteral(produto.Nome);

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
                BeginContext(1721, 3, true);
                WriteLiteral(" \r\n");
                EndContext();
#line 48 "C:\Users\51519136897\Documents\RoletopMVC\Views\CadastroEvento\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1747, 386, true);
                WriteLiteral(@"                </select>
            </div>
        </div>

        <div class=""dataevento"">
            <label for=""dataevento"">Data do Evento</label>
            <br/>
            <input type=""date"" id=""dataevento"" name=""dataevento"" required>
        </div>

        <div>
            <input class=""center"" type=""submit"" value=""Confirmar Evento"">
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
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 6 "C:\Users\51519136897\Documents\RoletopMVC\Views\CadastroEvento\Index.cshtml"
AddHtmlAttributeValue("", 177, Url.Action("Registrar", "CadastroEvento"), 177, 42, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2140, 21, true);
            WriteLiteral("\r\n\r\n        \r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoletopMVC.ViewModel.PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
