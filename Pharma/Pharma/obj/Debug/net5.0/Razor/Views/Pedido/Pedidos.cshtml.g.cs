#pragma checksum "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bef470dcc0625909b314d9e5a0f5dfb80858e68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Pedidos), @"mvc.1.0.view", @"/Views/Pedido/Pedidos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bef470dcc0625909b314d9e5a0f5dfb80858e68", @"/Views/Pedido/Pedidos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc6616431488ca0794a6c8a8b136eaf17ca79c17", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pedido_Pedidos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pharma.Models.Pedido>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Complete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "View", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/css-emp/vendors/simple-datatables/simple-datatables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
  
    ViewData["Title"] = "Pedidos";
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
                                <h3>Pedidos</h3>
                            </div>
                            
                        </div>
                    </div>
");
#nullable restore
#line 17 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
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
                                        <th>ID Pedido</th>
                                        <th>Cliente</th>
                                        <th>Estado</th>
                                        <th>Acciones</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 32 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                     foreach (var item in Model)
                                    {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                     if(item.Estado != 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                                <td>");
#nullable restore
#line 37 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                               Write(item.IdPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 38 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                               Write(item.IdClienteNavigation.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 38 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                                                                Write(item.IdClienteNavigation.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 39 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                                 if(item.Estado == 2)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td><span class=\"badge bg-warning\">En proceso</span></td>\r\n");
#nullable restore
#line 42 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                                 if(item.Estado == 3)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td><span class=\"badge bg-success\">Entregada</span></td>\r\n");
#nullable restore
#line 46 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                                 if(item.Estado == 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td><span class=\"badge bg-danger\">Cancelada</span></td>\r\n");
#nullable restore
#line 50 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>\r\n");
#nullable restore
#line 52 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                                 if(item.Estado != 3 && item.Estado != 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bef470dcc0625909b314d9e5a0f5dfb80858e6810935", async() => {
                WriteLiteral("<i class=\"fa-solid fa-check\"></i>");
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
#line 54 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                                                                                                              WriteLiteral(item.IdPedido);

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
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bef470dcc0625909b314d9e5a0f5dfb80858e6813549", async() => {
                WriteLiteral("<i class=\"fa-solid fa-eye\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                                                                                                       WriteLiteral(item.IdPedido);

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
            WriteLiteral("\r\n                                                     <a class=\"btn btn-danger\" data-bs-toggle=\"modal\" data-bs-target=\"#danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3263, "\"", 3293, 3);
            WriteAttributeValue("", 3273, "pass(", 3273, 5, true);
#nullable restore
#line 56 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
WriteAttributeValue("", 3278, item.IdPedido, 3278, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3292, ")", 3292, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-trash-can\"></i></a> \r\n");
#nullable restore
#line 57 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                                 if(item.Estado == 3 || item.Estado == 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bef470dcc0625909b314d9e5a0f5dfb80858e6817387", async() => {
                WriteLiteral("<i class=\"fa-solid fa-eye\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                                                                                                       WriteLiteral(item.IdPedido);

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
            WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                \r\n                                                </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 65 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                                     
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class=""modal-danger me-1 mb-1 d-inline-block"">

                    <!--Danger theme Modal -->
                    <div class=""modal fade text-left"" id=""danger"" tabindex=""-1""
                        role=""dialog"" aria-labelledby=""myModalLabel120""
                        aria-hidden=""true"">
                        <div class=""modal-dialog modal-dialog-centered modal-dialog-scrollable""
                            role=""document"">
                            <div class=""modal-content"">
                            <div class=""modal-header bg-danger"">
                                <h5 class=""modal-title white"" id=""myModalLabel120"">
                                    Alerta
                                </h5>
                                <button type=""button"" class=""close""
                                    data-bs-dismiss=""modal""");
            WriteLiteral(@" aria-label=""Close"">
                                    <i data-feather=""x""></i>
                                </button>
                            </div>
                            <div class=""modal-body"">
                                ¿Estás seguro de cancelar este pedido?
                            </div>
                            <input hidden id=""id"">
                            <div class=""modal-footer"">
                                <button type=""button""
                                    class=""btn btn-light-secondary""
                                    data-bs-dismiss=""modal"">
                                    <i class=""bx bx-x d-block d-sm-none""></i>
                                    <span class=""d-none d-sm-block"">Cancelar</span>
                                </button>
                                <a  onclick=""remove()"" class=""btn btn-danger ml-1""
                                    data-bs-dismiss=""modal"">
                                    <i class=""bx bx-");
            WriteLiteral(@"check d-block d-sm-none""></i>
                                    <span class=""d-none d-sm-block"">Aceptar</span>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                </section>
");
#nullable restore
#line 110 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
        
           }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br><p>No existen registros de algun pedido.</p>\r\n");
#nullable restore
#line 113 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
</div>
        
    <script>
            function pass(id) {
                $('#id').val(id);
            }

            function remove(){
                console.log(""funciono"");
                var id = $('#id').val();
                var url = '");
#nullable restore
#line 125 "C:\Users\eliam\OneDrive\Desktop\pharma\Pharma\Pharma\Views\Pedido\Pedidos.cshtml"
                      Write(Url.Action("RemovePd", "Pedido"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
                $.ajax({
                    type: ""POST"",
                    url: url,
                    data: { id: id},
                    success: function () {
                        console.log(""me tiene jalto"");
                        location.reload();
                    }
                })
            }
        </script>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bef470dcc0625909b314d9e5a0f5dfb80858e6824699", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pharma.Models.Pedido>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
