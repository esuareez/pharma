#pragma checksum "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Producto\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f42a12695caa95b017e87ab5696b2993fabbbcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Products), @"mvc.1.0.view", @"/Views/Producto/Products.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f42a12695caa95b017e87ab5696b2993fabbbcf", @"/Views/Producto/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e11600858a43af43b7d20394f2e1e2b193cff7a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pharma.Models.Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Producto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/css-emp/vendors/simple-datatables/simple-datatables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Producto\Products.cshtml"
  
    ViewData["Title"] = "Products";
    Layout = "~/Views/Shared/layoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""main-content container-fluid"">
                <div class=""page-heading"">
                    <div class=""page-title"">
                        <div class=""row"">
                            <div class=""col-12 col-md-6 order-md-1 order-last"">
                                <h3>Productos</h3>
                                <p class=""text-subtitle text-muted"">Ver, modificar, eliminar productos.</p>
                                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f42a12695caa95b017e87ab5696b2993fabbbcf5887", async() => {
                WriteLiteral("Crear producto");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""col-12 col-md-6 order-md-2 order-first"">
                                <nav aria-label=""breadcrumb"" class=""breadcrumb-header float-start float-lg-end"">
                                    <ol class=""breadcrumb"">
                                        <li class=""breadcrumb-item""><a href=""index.html"">Dashboard</a></li>
                                        <li class=""breadcrumb-item active"" aria-current=""page"">Products</li>
                                    </ol>
                                </nav>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 26 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Producto\Products.cshtml"
                 if (Model.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <section class=""section"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <table class=""table table-striped"" id=""table1"">
                                <thead>
                                    <tr>
                                        <th>Nombre</th>
                                        <th>Tipo</th>
                                        <th>Precio</th>
                                        <th>Cantidad</th>
                                        <th>Acciones</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 42 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Producto\Products.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                                <td>");
#nullable restore
#line 45 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Producto\Products.cshtml"
                                               Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 46 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Producto\Products.cshtml"
                                               Write(item.TipoProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 47 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Producto\Products.cshtml"
                                               Write(item.PrecioVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 48 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Producto\Products.cshtml"
                                               Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f42a12695caa95b017e87ab5696b2993fabbbcf11147", async() => {
                WriteLiteral("<i class=\"fa-solid fa-pen-to-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Producto\Products.cshtml"
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
            WriteLiteral("\r\n                                                    <a class=\"btn btn-danger\" ><i class=\"fa-solid fa-trash-can\"></i></a>\r\n                                                </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 54 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Producto\Products.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n\r\n                </section>\r\n");
#nullable restore
#line 61 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Producto\Products.cshtml"
        
           }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>No existen registros de productos.</p>\r\n");
#nullable restore
#line 64 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Producto\Products.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n</div>\r\n        \r\n    \r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f42a12695caa95b017e87ab5696b2993fabbbcf15160", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <script>\r\n            // Simple Datatable\r\n            let table1 = document.querySelector(\'#table1\');\r\n            let dataTable = new simpleDatatables.DataTable(table1);\r\n        </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pharma.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
