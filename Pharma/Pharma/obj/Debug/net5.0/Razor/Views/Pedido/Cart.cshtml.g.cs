#pragma checksum "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bb648e2726c1a80f2784017191c9aec49f6a9ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Cart), @"mvc.1.0.view", @"/Views/Pedido/Cart.cshtml")]
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
#line 1 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\_ViewImports.cshtml"
using Pharma;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\_ViewImports.cshtml"
using Pharma.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb648e2726c1a80f2784017191c9aec49f6a9ee", @"/Views/Pedido/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e11600858a43af43b7d20394f2e1e2b193cff7a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pharma.Models.PedidoProducto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("boxed-btn black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"
  
	ViewData["Title"] = "Cart";
	Layout = "~/Views/Shared/layout.cshtml";
	double total = 0;
	int[] pedido;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- breadcrumb-section -->
	<div class=""breadcrumb-section breadcrumb-bg"">
		<div class=""container"">
			<div class=""row"">
				<div class=""col-lg-8 offset-lg-2 text-center"">
					<div class=""breadcrumb-text"">
						<p>Fresh and Organic</p>
						<h1>Cart</h1>
					</div>
				</div>
			</div>
		</div>
	</div>
	<!-- end breadcrumb section -->

	<!-- cart -->
");
#nullable restore
#line 25 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	<div class=""cart-section mt-150 mb-150"">
		<div class=""container"">

			<div class=""row"">
				<div class=""col-lg-8 col-md-12"">
					<div class=""cart-table-wrap"">

						<table class=""cart-table"">
							<thead class=""cart-table-head"">
								<tr class=""table-head-row"">
									<th class=""product-remove""></th>
									<th class=""product-image"">Imagen</th>
									<th class=""product-name"">Nombre</th>
									<th class=""product-price"">Precio</th>
									<th class=""product-quantity"">Cantidad</th>
									<th class=""product-total"">Disponibilidad</th>
								</tr>
							</thead>
							<tbody>
");
#nullable restore
#line 46 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"
                                 foreach (var item in Model)
								{
									

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"
                                     if(item.IdpedidoNavigation.IdCliente == int.Parse(Context.Request.Cookies["userId"]))
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<tr class=\"table-body-row\">\r\n\t\t\t\t\t\t\t\t\t\t<td class=\"product-remove\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bb648e2726c1a80f2784017191c9aec49f6a9ee7272", async() => {
                WriteLiteral("<i class=\"far fa-window-close\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"
                                                                                                                    WriteLiteral(item.IdproductoNavigation.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td class=\"product-image\"><img");
            BeginWriteAttribute("src", " src=\"", 1607, "\"", 1687, 2);
            WriteAttributeValue("", 1613, "data:image/*;base64,", 1613, 20, true);
#nullable restore
#line 52 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"
WriteAttributeValue("", 1633, Convert.ToBase64String(item.IdproductoNavigation.Img), 1633, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"60px\"");
            BeginWriteAttribute("alt", " alt=\"", 1701, "\"", 1707, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n\t\t\t\t\t\t\t\t\t\t<td class=\"product-name\">");
#nullable restore
#line 53 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"
                                                            Write(item.IdproductoNavigation.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td class=\"product-price\">");
#nullable restore
#line 54 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"
                                                             Write(item.IdproductoNavigation.PrecioVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td class=\"product-quantity\"><input id=\"cantidad\" name=\"cantidad[]\" type=\"number\" min=\"1\"");
            BeginWriteAttribute("max", " max=", 1971, "", 2011, 1);
#nullable restore
#line 55 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"
WriteAttributeValue("", 1976, item.IdproductoNavigation.Cantidad, 1976, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=", 2011, "", 2032, 1);
#nullable restore
#line 55 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"
WriteAttributeValue("", 2018, item.Cantidad, 2018, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n\t\t\t\t\t\t\t\t\t\t<td class=\"product-total\">");
#nullable restore
#line 56 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"
                                                             Write(item.IdproductoNavigation.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t\t\t<input hidden name=\"idproducto[]\"");
            BeginWriteAttribute("value", " value=\"", 2178, "\"", 2202, 1);
#nullable restore
#line 58 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"
WriteAttributeValue("", 2186, item.Idproducto, 2186, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n");
#nullable restore
#line 59 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"
									}
									
									

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"
                                                                                                            
								}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"								
							</tbody>
						</table>

					</div>
				</div>

				<div class=""col-lg-4"">
					<div class=""total-section"">
						<table class=""total-table"">
							<thead class=""total-table-head"">
								<tr class=""table-total-row"">
									<th>Total</th>
									<th>Price</th>
								</tr>
							</thead>
							<tbody>
								<tr class=""total-data"">
									<td><strong>Subtotal: </strong></td>
									<td>RD$ ");
#nullable restore
#line 82 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"
                                       Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr class=\"total-data\">\r\n\t\t\t\t\t\t\t\t\t<td><strong>Shipping: </strong></td>\r\n\t\t\t\t\t\t\t\t\t<td>RD$ 0</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr class=\"total-data\">\r\n\t\t\t\t\t\t\t\t\t<td><strong>Total: </strong></td>\r\n\t\t\t\t\t\t\t\t\t<td>RD$ ");
#nullable restore
#line 90 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"
                                       Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t<div class=\"cart-buttons\">\r\n\t\t\t\t\t\t\t<a onclick=\"Update()\" class=\"boxed-btn\">Update Cart</a>\r\n\t\t\t\t\t\t\t<a href=\"checkout.html\" class=\"boxed-btn black\">Check Out</a>\r\n\t\t\t\t\t\t\t<br>\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bb648e2726c1a80f2784017191c9aec49f6a9ee15624", async() => {
                WriteLiteral("Seguir comprando");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 106 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<script>\r\n    var Update = function () {\r\n\t\tconsole.log(\"funciono\");\r\n\t\tvar cant = $(\'input[name^=\"cantidad[]\"]\'); \r\n\t\tvar idproducto = $(\'input[name^=\"idproducto[]\"]\');\r\n         var url = \'");
#nullable restore
#line 117 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Pedido\Cart.cshtml"
               Write(Url.Action("Update", "Pedido"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $.ajax({
            type: ""POST"",
            url: url,
            data: { cantidad: cant, idproducto: idproducto },
            success: function (result) {
                console.log(""funciono"");
            }
        })
    }
</script>
<!-- end cart -->

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pharma.Models.PedidoProducto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
