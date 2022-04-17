#pragma checksum "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Empleado\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fbe577f0f7e7e1380ffdded9a865466c979d399"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Create), @"mvc.1.0.view", @"/Views/Empleado/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fbe577f0f7e7e1380ffdded9a865466c979d399", @"/Views/Empleado/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc6616431488ca0794a6c8a8b136eaf17ca79c17", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Empleado_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pharma.Models.Empleado>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Farmacéutico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Administrador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PUCMM\ENEABR2022\ISoftware\pharma\Pharma\Pharma\Views\Empleado\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/layoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-heading"">
                    <div class=""page-title"">
                        <div class=""row"">
                            <div class=""col-12 col-md-6 order-md-1 order-last"">
                                <h3>Crear Empleado</h3>
                                <p class=""text-subtitle text-muted"">Añade toda la información importante de tus empleados.</p>
                            </div>
                            <div class=""col-12 col-md-6 order-md-2 order-first"">
                                <nav aria-label=""breadcrumb"" class=""breadcrumb-header float-start float-lg-end"">
                                    <ol class=""breadcrumb"">
                                        <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
                                        <li class=""breadcrumb-item""><a href=""#"">Empleados</a></li>
                                        <li class=""breadcrumb-item active"" aria-current=""page"">Crear empleado</li>
                                    </ol>
  ");
            WriteLiteral(@"                              </nav>
                                
                            </div>
                        </div>
                    </div>

                    <br>

                    <!-- COPIAR DESDE AQUI -->
                    
                    <section class=""section"">
                        <div class=""card"">
                            <div class=""card-header"">
                                <h4 class=""card-title"">Datos del empleado</h4>
                            </div>
                        </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fbe577f0f7e7e1380ffdded9a865466c979d3996517", async() => {
                WriteLiteral(@"
                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""form-group"">
                                            <label for=""basicInput"">Nombre</label>
                                            <small class=""text-muted"">ej.<i>María José</i></small>
                                            <input required type=""text"" class=""form-control"" id=""basicInput"" name=""Nombre"">
                                        </div>

                                        <div class=""form-group"">
                                            <label for=""basicInput"">Apellido</label>
                                            <small class=""text-muted"">ej.<i>Torres Sainz</i></small>
                                            <input required type=""text"" class=""form-control"" id=""basicInput"" name=""Apellido"">
                                        </div>

                  ");
                WriteLiteral(@"                      <div class=""form-group"">
                                            <label for=""basicInput"">Cedula</label>
                                            <small class=""text-muted"">ej.<i>402000000xx</i></small>
                                            <input required type=""text"" class=""form-control"" id=""basicInput"" name=""Cedula"">
                                        </div>
    
                                        <div class=""form-group"">
                                            <label for=""helpInputTop"">Correo</label>
                                            <small class=""text-muted"">eg.<i>someone@example.com</i></small>
                                            <input required type=""email"" class=""form-control"" id=""helpInputTop"" name=""Correo"">
                                        </div>
    
                                        <div class=""form-group"">
                                            <label for=""helperText"">Contraseña</label>
                             ");
                WriteLiteral(@"               <input required type=""password"" id=""helperText"" class=""form-control"" name=""Password"">
                                        </div>

                                        <div class=""col-md-6 mb-4"">
                                            <label for=""helperText"">Rol</label>
                                            <div class=""form-group"">
                                                <select class=""choices form-select"" name=""Puesto"">
                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fbe577f0f7e7e1380ffdded9a865466c979d3999493", async() => {
                    WriteLiteral("Farmacéutico");
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
                WriteLiteral("\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fbe577f0f7e7e1380ffdded9a865466c979d39910772", async() => {
                    WriteLiteral("Administrador");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                </select>
                                            </div>
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""helperText"">Telefono</label>
                                            <input required type=""tel"" id=""helperText"" class=""form-control"" name=""Telefono"">
                                        </div>
                                        <br>
                                        <button type=""submit"" class=""btn btn-primary"" last-child>Crear empleado</button>
                                </div>
                            </div>
                        </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </section>\n\n                    </div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pharma.Models.Empleado> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
