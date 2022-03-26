#pragma checksum "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Cliente\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b120d8763b2566c781f878de11a1485676c2027"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Shop), @"mvc.1.0.view", @"/Views/Cliente/Shop.cshtml")]
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
#line 1 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\_ViewImports.cshtml"
using Pharma;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\_ViewImports.cshtml"
using Pharma.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b120d8763b2566c781f878de11a1485676c2027", @"/Views/Cliente/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc6616431488ca0794a6c8a8b136eaf17ca79c17", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cliente_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pharma.Models.Producto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Producto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Cliente\Shop.cshtml"
  
    ViewData["Title"] = "Shop";
    Layout = "~/Views/Shared/layout.cshtml";

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
						<p>De la mejor calidad</p>
						<h1>Productos</h1>
					</div>
				</div>
			</div>
		</div>
	</div>
	<!-- end breadcrumb section -->

	<!-- products -->
	<div class=""product-section mt-150 mb-150"">
		<div class=""container"">

");
            WriteLiteral("\t\t\t<div class=\"row product-lists\">\n");
#nullable restore
#line 39 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Cliente\Shop.cshtml"
             if (Model.Count() > 0)
            {
				

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Cliente\Shop.cshtml"
                 foreach(var item in Model)
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Cliente\Shop.cshtml"
                     if(item.Estado == 1)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"col-lg-4 col-md-6 text-center\">\n\t\t\t\t\t\t<div class=\"single-product-item\">\n\t\t\t\t\t\t\t<div class=\"product-image\">\n\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 1370, "\"", 1429, 2);
            WriteAttributeValue("", 1376, "data:image/*;base64,", 1376, 20, true);
#nullable restore
#line 48 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Cliente\Shop.cshtml"
WriteAttributeValue("", 1396, Convert.ToBase64String(item.Img), 1396, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200px\"");
            BeginWriteAttribute("alt", " alt=\"", 1445, "\"", 1451, 0);
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t<h3>");
#nullable restore
#line 50 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Cliente\Shop.cshtml"
                           Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\t\t\t\t\t\t\t<p class=\"product-price\">RD$ ");
#nullable restore
#line 51 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Cliente\Shop.cshtml"
                                                    Write(item.PrecioVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 52 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Cliente\Shop.cshtml"
                             if(item.Laboratorio != null)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<p class=\"product-price\">");
#nullable restore
#line 54 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Cliente\Shop.cshtml"
                                                    Write(item.Laboratorio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 55 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Cliente\Shop.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b120d8763b2566c781f878de11a1485676c20277695", async() => {
                WriteLiteral("<i class=\"fas fa-shopping-cart\"></i> Añadir al carrito");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Cliente\Shop.cshtml"
                                                                                                WriteLiteral(item.Id);

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
            WriteLiteral("\n\t\t\t\t\t\t</div>\n\t\t\t\t\t\t</div>\n");
#nullable restore
#line 59 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Cliente\Shop.cshtml"
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Cliente\Shop.cshtml"
                     
					
				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Cliente\Shop.cshtml"
                 
			}
			else
			{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"				<!-- error section -->
				<div class=""full-height-section error-section"">
					<div class=""full-height-tablecell"">
						<div class=""container"">
							<div class=""row"">
								<div class=""col-lg-8 offset-lg-2 text-center"">
									<div class=""error-text"">
										<i class=""far fa-sad-cry""></i>
										<h1>Oops! Not Found.</h1>
										<p>The page you requested for is not found.</p>
										<a href=""index.html"" class=""boxed-btn"">Back to Home</a>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
				<!-- end error section -->
");
#nullable restore
#line 83 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Cliente\Shop.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\n\t\t\t</div>\n\t\t\t</div>\n");
            WriteLiteral("\t<!-- end products -->\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pharma.Models.Producto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
