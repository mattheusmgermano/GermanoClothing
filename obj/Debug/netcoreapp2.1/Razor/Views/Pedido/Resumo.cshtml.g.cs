#pragma checksum "C:\Users\mattheus.martins\source\repos\GermanoClothing\GermanoClothing\Views\Pedido\Resumo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c9be1b12be9c38024e4e6e7f36a6a39cccb2f64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Resumo), @"mvc.1.0.view", @"/Views/Pedido/Resumo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Resumo.cshtml", typeof(AspNetCore.Views_Pedido_Resumo))]
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
#line 1 "C:\Users\mattheus.martins\source\repos\GermanoClothing\GermanoClothing\Views\_ViewImports.cshtml"
using GermanoClothing;

#line default
#line hidden
#line 2 "C:\Users\mattheus.martins\source\repos\GermanoClothing\GermanoClothing\Views\_ViewImports.cshtml"
using GermanoClothing.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c9be1b12be9c38024e4e6e7f36a6a39cccb2f64", @"/Views/Pedido/Resumo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d9a0ad1b0d89b8dd96f9d4930e2cd9a32338230", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Resumo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pedido>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\mattheus.martins\source\repos\GermanoClothing\GermanoClothing\Views\Pedido\Resumo.cshtml"
   ViewData["Title"] = "Order resume"; 

#line default
#line hidden
            BeginContext(56, 182, true);
            WriteLiteral("\n<h3>Order resume:</h3>\n\n<div class=\"panel panel-default\">\n    <div class=\"panel-body\">\n        <div class=\"row\">\n            <div class=\"col-md-12\">\n                <h3>Order Num.: ");
            EndContext();
            BeginContext(240, 8, false);
#line 10 "C:\Users\mattheus.martins\source\repos\GermanoClothing\GermanoClothing\Views\Pedido\Resumo.cshtml"
                            Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(249, 782, true);
            WriteLiteral(@"</h3>
            </div>
        </div>
        <hr />
        <div class=""row"">
            <div class=""col-md-3"">
                <h3>Your info</h3>
                <div>Power Guido</div>
                <div>(11) 1234-5678</div>
            </div>
            <div class=""col-md-3"">
                power-guido@hotmail.com
            </div>
            <div class=""col-md-6"">
                <h3>Delivery address</h3>
                <div>The Cupboard under the Stairs 4 Privet Drive, Little Whinging, Surrey</div>
            </div>
        </div>
        <hr />
        <div class=""row"">
            <div class=""col-md-10"">
                <h3>Item</h3>
            </div>
            <div class=""col-md-2"">
                <h3>Quantity</h3>
            </div>
        </div>
");
            EndContext();
#line 37 "C:\Users\mattheus.martins\source\repos\GermanoClothing\GermanoClothing\Views\Pedido\Resumo.cshtml"
         foreach (var item in Model.Itens)
        {

#line default
#line hidden
            BeginContext(1086, 83, true);
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-md-10\">\n                <div>");
            EndContext();
            BeginContext(1170, 17, false);
#line 41 "C:\Users\mattheus.martins\source\repos\GermanoClothing\GermanoClothing\Views\Pedido\Resumo.cshtml"
                Write(item.Produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1187, 101, true);
            WriteLiteral("</div>\n            </div>\n            <div class=\"col-md-2\">\n                <div class=\"pull-right\">");
            EndContext();
            BeginContext(1289, 15, false);
#line 44 "C:\Users\mattheus.martins\source\repos\GermanoClothing\GermanoClothing\Views\Pedido\Resumo.cshtml"
                                   Write(item.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(1304, 42, true);
            WriteLiteral("</div>\n            </div>\n        </div>\r\n");
            EndContext();
#line 47 "C:\Users\mattheus.martins\source\repos\GermanoClothing\GermanoClothing\Views\Pedido\Resumo.cshtml"
        }

#line default
#line hidden
            BeginContext(1356, 18, true);
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591