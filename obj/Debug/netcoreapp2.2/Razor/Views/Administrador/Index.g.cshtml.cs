#pragma checksum "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d6b7f4607e863dfae5b4107aa55ef94969d717e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Index), @"mvc.1.0.view", @"/Views/Administrador/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Index.cshtml", typeof(AspNetCore.Views_Administrador_Index))]
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
#line 2 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
using RoletopMVC.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d6b7f4607e863dfae5b4107aa55ef94969d717e", @"/Views/Administrador/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fcde6f443f8ee695eebee3c09673a46bc68798b", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoletopMVC.ViewModel.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 310, true);
            WriteLiteral(@"    <main>
        <div class=""espaco""></div>
        <h2>Dashboard</h2>
        <section id=""status-pedidos"">
            <h3>Status dos pedidos</h3>
            <div id=""painel"">
                <div class=""box-status-pedidos aprovados"">
                    <h4>Aprovados</h4>
                    <p>");
            EndContext();
            BeginContext(384, 22, false);
#line 11 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
                  Write(Model.PedidosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(406, 153, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"box-status-pedidos pendentes\">\r\n                    <h4>Pendentes</h4>\r\n                    <p>");
            EndContext();
            BeginContext(560, 22, false);
#line 15 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
                  Write(Model.PedidosPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(582, 155, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"box-status-pedidos reprovados\">\r\n                    <h4>Reprovados</h4>\r\n                    <p>");
            EndContext();
            BeginContext(738, 23, false);
#line 19 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
                  Write(Model.PedidosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(761, 1073, true);
            WriteLiteral(@"</p>
                </div>
            </div>
        </section>

        <section id=""lista-pedidos"">
            <h3>Lista de pedidos</h3>
            <table>
                <thead>
                    <tr>
                        <th rowspan=""2"">ID</th>
                        <th rowspan=""2"">Nome do Evento</th>
                        <th rowspan=""2"">Email do Cliente</th>
                        <th rowspan=""2"">Tipo de Evento</th>
                        <th rowspan=""2"">Planos</th>
                        <th rowspan=""2"">Data do Evento</th>
                        <th rowspan=""2"">Situação</th>
                        <th rowspan=""2"">PrecoTotal</th>

                        <th colspan=""2"" rowspan=""2"">Aprovar</th>
                    </tr>
                    <tr>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <td colspan=""10"">
     ");
            WriteLiteral("                       <p>Pedidos atualizados em ");
            EndContext();
            BeginContext(1835, 12, false);
#line 48 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
                                                 Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(1847, 115, true);
            WriteLiteral("</p>\r\n                        </td>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 53 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
                     foreach(var pedido in Model.Pedidos )
                    {

#line default
#line hidden
            BeginContext(2045, 63, true);
            WriteLiteral("                        <tr>\r\n                            <td>#");
            EndContext();
            BeginContext(2109, 9, false);
#line 56 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
                            Write(pedido.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2118, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2158, 17, false);
#line 57 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
                           Write(pedido.NomeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2175, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2215, 20, false);
#line 58 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
                           Write(pedido.Cliente.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2235, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2275, 14, false);
#line 59 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
                           Write(pedido.Eventos);

#line default
#line hidden
            EndContext();
            BeginContext(2289, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2329, 13, false);
#line 60 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
                           Write(pedido.Planos);

#line default
#line hidden
            EndContext();
            BeginContext(2342, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2382, 36, false);
#line 61 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
                           Write(pedido.DataEvento.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2418, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 62 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
                              

                            switch (pedido.Status)
                            {
                                case (uint) StatusPedido.APROVADO:

#line default
#line hidden
            BeginContext(2610, 147, true);
            WriteLiteral("                                <td class=\"aprovado\">\r\n                                    <p>Aprovado</p>\r\n                                </td>\r\n");
            EndContext();
#line 70 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
                                break;

                                case (uint) StatusPedido.REPROVADO:

#line default
#line hidden
            BeginContext(2868, 149, true);
            WriteLiteral("                                <td class=\"reprovado\">\r\n                                    <p>Reprovado</p>\r\n                                </td>\r\n");
            EndContext();
#line 76 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
                                break;

                                case (uint) StatusPedido.PENDENTE:

#line default
#line hidden
            BeginContext(3127, 147, true);
            WriteLiteral("                                <td class=\"pendente\">\r\n                                    <p>Pendente</p>\r\n                                </td>\r\n");
            EndContext();
#line 82 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
                                break;
                            
                            }
                        

#line default
#line hidden
            BeginContext(3402, 34, true);
            WriteLiteral("                            <td>R$");
            EndContext();
            BeginContext(3437, 17, false);
#line 86 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
                             Write(pedido.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(3454, 127, true);
            WriteLiteral(",00</td>\r\n                                \r\n                            <div class=\"green\">\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 3581, "\'", 3651, 1);
#line 89 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
WriteAttributeValue("", 3588, Url.Action("Aprovar", "CadastroEvento", new {id = @pedido.Id}), 3588, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3652, 187, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\r\n                            </div>\r\n                            \r\n                            <div class=\"red\">\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 3839, "\'", 3910, 1);
#line 93 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
WriteAttributeValue("", 3846, Url.Action("Reprovar", "CadastroEvento", new {id = @pedido.Id}), 3846, 64, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3911, 107, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\r\n                            </div>\r\n                        </tr>\r\n");
            EndContext();
#line 96 "C:\Users\51519136897\Documents\RoletopMVC\Views\Administrador\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4041, 81, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </section>\r\n\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoletopMVC.ViewModel.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
