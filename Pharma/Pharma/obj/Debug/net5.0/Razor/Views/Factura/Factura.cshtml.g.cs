#pragma checksum "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd1386a9bbde5f89270f053aea445b999c48b3d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Factura_Factura), @"mvc.1.0.view", @"/Views/Factura/Factura.cshtml")]
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
#line 1 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\_ViewImports.cshtml"
using Pharma;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\_ViewImports.cshtml"
using Pharma.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd1386a9bbde5f89270f053aea445b999c48b3d0", @"/Views/Factura/Factura.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc6616431488ca0794a6c8a8b136eaf17ca79c17", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Factura_Factura : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pharma.Models.PedidoProducto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("boxed-btn black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Factura", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addFactura", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml"
  
	ViewData["Title"] = "Cart";
	Layout = "~/Views/Shared/layout.cshtml";
	double total = 0;
	double itbis = 0;
	itbis = ViewBag.itbis;
	total = ViewBag.Total;
	int idp = ViewBag.IdP;
	double subtotal = total - itbis;


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
						<p>La mejor calidad</p>
						<h1>Carrito</h1>
					</div>
				</div>
			</div>
		</div>
	</div>
	<!-- end breadcrumb section -->

	<!-- cart -->
");
#nullable restore
#line 31 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml"
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
#line 52 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml"
                                 foreach (var item in Model)
								{
									

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml"
                                     if(item.IdpedidoNavigation.IdCliente == int.Parse(Context.Request.Cookies["userId"]) && item.IdpedidoNavigation.Estado == 1)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<tr class=\"table-body-row\">\r\n\t\t\t\t\t\t\t\t\t\t<td class=\"product-remove\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd1386a9bbde5f89270f053aea445b999c48b3d07099", async() => {
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
#line 57 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml"
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
            BeginWriteAttribute("src", " src=\"", 1766, "\"", 1846, 2);
            WriteAttributeValue("", 1772, "data:image/*;base64,", 1772, 20, true);
#nullable restore
#line 58 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml"
WriteAttributeValue("", 1792, Convert.ToBase64String(item.IdproductoNavigation.Img), 1792, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"60px\"");
            BeginWriteAttribute("alt", " alt=\"", 1860, "\"", 1866, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n\t\t\t\t\t\t\t\t\t\t<td class=\"product-name\">");
#nullable restore
#line 59 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml"
                                                            Write(item.IdproductoNavigation.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td class=\"product-price\">RD$ ");
#nullable restore
#line 60 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml"
                                                                 Write(item.IdproductoNavigation.PrecioVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td class=\"product-quantity\">");
#nullable restore
#line 61 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml"
                                                                Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td class=\"product-total\">");
#nullable restore
#line 62 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml"
                                                             Write(item.IdproductoNavigation.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 64 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml"
									}

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml"
                                     
									
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
#line 88 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml"
                                       Write(subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr class=\"total-data\">\r\n\t\t\t\t\t\t\t\t\t<td><strong>ITBIS: </strong></td>\r\n\t\t\t\t\t\t\t\t\t<td>RD$ ");
#nullable restore
#line 92 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml"
                                       Write(itbis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t<tr class=\"total-data\">\r\n\t\t\t\t\t\t\t\t\t<td><strong>Total: </strong></td>\r\n\t\t\t\t\t\t\t\t\t<td>RD$ ");
#nullable restore
#line 96 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml"
                                       Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
								</tr>
								<tr>
									<td><strong>Tipo de pago: </strong>
									<div class=""form-check"">
                                        <div class=""custom-control custom-checkbox"">
                                            <input type=""checkbox""
                                                class=""form-check-input form-check-success"" checked
                                                name=""customCheck"" id=""customColorCheck3"">
                                            <label class=""form-check-label"" 
                                                for=""customColorCheck3"" >Efectivo</label>
										</div>
									</div>
									</td>
								</tr>
							</tbody>
						</table>
");
            WriteLiteral("\t\t\t\t\t\t<div class=\"cart-buttons\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd1386a9bbde5f89270f053aea445b999c48b3d014547", async() => {
                WriteLiteral("Completar pedido");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idp", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml"
                                                                                                          WriteLiteral(idp);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idp"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idp", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idp"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n");
            WriteLiteral("\t\t\t\t\t</div>\r\n\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 127 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Factura\Factura.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pharma.Models.PedidoProducto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
