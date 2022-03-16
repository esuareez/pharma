#pragma checksum "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "755973363eba0ac053271ed553265f8717d5324d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"755973363eba0ac053271ed553265f8717d5324d", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e11600858a43af43b7d20394f2e1e2b193cff7a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pharma.Models.Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("boxed-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Producto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/layout.cshtml";
	


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- hero area -->
	<div class=""hero-area"" style = ""background-image: url(/img/supply-bg.jpg)"">
		<div class=""container"">
			<div class=""row"">
				<div class=""col-lg-9 offset-lg-2 text-center"">
					<div class=""hero-text"">
						<div class=""hero-text-tablecell"">
							<p class=""subtitle"">Más que una farmacia</p>
							<h1>Tu salud es nuestra prioridad</h1>
							<div class=""hero-btns"">
								");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "755973363eba0ac053271ed553265f8717d5324d6220", async() => {
                WriteLiteral("Productos");
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
								<a href=""#"" class=""bordered-btn"">Contáctanos</a>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
	<!-- end hero area -->

	<!-- shop banner -->
	<section class=""shop-banner"">
    	<div class=""container"">
        	<h3>Cuídate del <span class=""orange-text"">COVID...</span></h3>
            <div class=""sale-percent""><span>Ayúdate a ti y a los tuyos.<br>Haz uso de la mascarilla en lugares públicos.</span><span></span></div>
           
        </div>
    </section>
	<!-- end shop banner -->

	<!-- features list section 
	<div class=""list-section pt-80 pb-80"">
		<div class=""container"">
			<div class=""row"">
				<div class=""col-lg-4 col-md-6 mb-4 mb-lg-0"">
					<div class=""list-box d-flex align-items-center"">
						<div class=""list-icon"">
							<i class=""fas fa-shipping-fast""></i>
						</div>
						<div class=""content"">
							<h3>Envio gratis</h3>
							<p>Desde los 0$</p>
						</div>
					</div>
				</div>
				<div class=""col-lg-4 col-md-");
            WriteLiteral(@"6 mb-4 mb-lg-0"">
					<div class=""list-box d-flex align-items-center"">
						<div class=""list-icon"">
							<i class=""fas fa-phone-volume""></i>
						</div>
						<div class=""content"">
							<h3>24/7 Support</h3>
							<p>Get support all day</p>
						</div>
					</div>
				</div>
				<div class=""col-lg-4 col-md-6"">
					<div class=""list-box d-flex justify-content-start align-items-center"">
						<div class=""list-icon"">
							<i class=""fas fa-sync""></i>
						</div>
						<div class=""content"">
							<h3>Refund</h3>
							<p>Get refund within 3 days!</p>
						</div>
					</div>
				</div>
			</div>

		</div>
	</div>-->
	<!-- end features list section -->

	<!-- product section -->
	<div class=""product-section mt-150 mb-150"">
		<div class=""container"">
			<div class=""row"">
				<div class=""col-lg-8 offset-lg-2 text-center"">
					<div class=""section-title"">	
						<h3><span class=""orange-text"">Nuestros</span> Productos</h3>
					</div>
				</div>
			</div>

			<div clas");
            WriteLiteral("s=\"row\">\r\n");
#nullable restore
#line 95 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Cliente\Index.cshtml"
             if (Model.Count() > 0)
            {
				

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Cliente\Index.cshtml"
                 foreach(var item in Model.Take(3))
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Cliente\Index.cshtml"
                     if(item.Estado == 1)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"col-lg-4 col-md-6 text-center\">\r\n\t\t\t\t\t\t<div class=\"single-product-item\">\r\n\t\t\t\t\t\t\t<div class=\"product-image\">\r\n\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 2950, "\"", 3009, 2);
            WriteAttributeValue("", 2956, "data:image/*;base64,", 2956, 20, true);
#nullable restore
#line 104 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 2976, Convert.ToBase64String(item.Img), 2976, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200px\"");
            BeginWriteAttribute("alt", " alt=\"", 3025, "\"", 3031, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<h3>");
#nullable restore
#line 106 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Cliente\Index.cshtml"
                           Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t\t\t\t\t\t<p class=\"product-price\">RD$ ");
#nullable restore
#line 107 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Cliente\Index.cshtml"
                                                    Write(item.PrecioVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 108 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Cliente\Index.cshtml"
                             if(item.Laboratorio != null)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<p class=\"product-price\">");
#nullable restore
#line 110 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Cliente\Index.cshtml"
                                                    Write(item.Laboratorio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 111 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Cliente\Index.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "755973363eba0ac053271ed553265f8717d5324d13302", async() => {
                WriteLiteral("<i class=\"fas fa-shopping-cart\"></i> Añadir al carrito");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Cliente\Index.cshtml"
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
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 115 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Cliente\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Cliente\Index.cshtml"
                     
					
				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Users\eliam\OneDrive - Pontificia Universidad Católica Madre y Maestra\PUCMM ENE-ABR2022\pharma\Pharma\Pharma\Views\Cliente\Index.cshtml"
                 
			}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			
			</div>
		</div>
	</div>
	<!-- end product section -->

	<section class=""shop-banner"" style = ""background-image: url(/img/unete.jpg)"">
    	<div class=""container"">
        	<h3>¡ÚNETE a nuestra <span class=""orange-text"">FAMILIA!</span></h3>
            <div class=""sale-percent""><span>Forma parte de nosotros.<br>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "755973363eba0ac053271ed553265f8717d5324d17059", async() => {
                WriteLiteral("Clic aquí.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</span><span></span></div>
           
        </div>
    </section>

	<!-- cart banner section 
	<section class=""cart-banner pt-100 pb-100"">
    	<div class=""container"">
        	<div class=""row clearfix"">
            	Image Column
            	<div class=""image-column col-lg-6"">
                	<div class=""image"">
                    	<div class=""price-box"">
                        	<div class=""inner-price"">
                                <span class=""price"">
                                    <strong>30%</strong> <br> off per kg
                                </span>
                            </div>
                        </div>
                    	<img src=""assets/img/a.jpg"" alt="""">
                    </div>
                </div>
                Content Column
                <div class=""content-column col-lg-6"">
					<h3><span class=""orange-text"">Deal</span> of the month</h3>
                    <h4>Hikan Strwaberry</h4>
                    <div class=""text"">Quisquam m");
            WriteLiteral(@"inus maiores repudiandae nobis, minima saepe id, fugit ullam similique! Beatae, minima quisquam molestias facere ea. Perspiciatis unde omnis iste natus error sit voluptatem accusant</div>
                    Countdown Timer
                    <div class=""time-counter""><div class=""time-countdown clearfix"" data-countdown=""2020/2/01""><div class=""counter-column""><div class=""inner""><span class=""count"">00</span>Days</div></div> <div class=""counter-column""><div class=""inner""><span class=""count"">00</span>Hours</div></div>  <div class=""counter-column""><div class=""inner""><span class=""count"">00</span>Mins</div></div>  <div class=""counter-column""><div class=""inner""><span class=""count"">00</span>Secs</div></div></div></div>
                	<a href=""cart.html"" class=""cart-btn mt-3""><i class=""fas fa-shopping-cart""></i> Add to Cart</a>
                </div>
            </div>
        </div>
    </section>
     end cart banner section -->

	<!-- testimonail-section 
	<div class=""testimonail-section mt-150 mb-150""");
            WriteLiteral(@">
		<div class=""container"">
			<div class=""row"">
				<div class=""col-lg-10 offset-lg-1 text-center"">
					<div class=""testimonial-sliders"">
						<div class=""single-testimonial-slider"">
							<div class=""client-avater"">
								<img src=""assets/img/avaters/avatar1.png"" alt="""">
							</div>
							<div class=""client-meta"">
								<h3>Saira Hakim <span>Local shop owner</span></h3>
								<p class=""testimonial-body"">
									"" Sed ut perspiciatis unde omnis iste natus error veritatis et  quasi architecto beatae vitae dict eaque ipsa quae ab illo inventore Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium ""
								</p>
								<div class=""last-icon"">
									<i class=""fas fa-quote-right""></i>
								</div>
							</div>
						</div>
						<div class=""single-testimonial-slider"">
							<div class=""client-avater"">
								<img src=""assets/img/avaters/avatar2.png"" alt="""">
							</div>
							<div class=""client-meta"">
								<h3>David Niph <span>Local shop ow");
            WriteLiteral(@"ner</span></h3>
								<p class=""testimonial-body"">
									"" Sed ut perspiciatis unde omnis iste natus error veritatis et  quasi architecto beatae vitae dict eaque ipsa quae ab illo inventore Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium ""
								</p>
								<div class=""last-icon"">
									<i class=""fas fa-quote-right""></i>
								</div>
							</div>
						</div>
						<div class=""single-testimonial-slider"">
							<div class=""client-avater"">
								<img src=""assets/img/avaters/avatar3.png"" alt="""">
							</div>
							<div class=""client-meta"">
								<h3>Jacob Sikim <span>Local shop owner</span></h3>
								<p class=""testimonial-body"">
									"" Sed ut perspiciatis unde omnis iste natus error veritatis et  quasi architecto beatae vitae dict eaque ipsa quae ab illo inventore Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium ""
								</p>
								<div class=""last-icon"">
									<i class=""fas fa-quote-right""></i>
								</d");
            WriteLiteral(@"iv>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
	end testimonail-section -->
	
	<!-- advertisement section 
	<div class=""abt-section mb-150"">
		<div class=""container"">
			<div class=""row"">
				<div class=""col-lg-6 col-md-12"">
					<div class=""abt-bg"">
						<a href=""https://www.youtube.com/watch?v=DBLlFWYcIGQ"" class=""video-play-btn popup-youtube""><i class=""fas fa-play""></i></a>
					</div>
				</div>
				<div class=""col-lg-6 col-md-12"">
					<div class=""abt-text"">
						<p class=""top-sub"">Since Year 1999</p>
						<h2>We are <span class=""orange-text"">Fruitkha</span></h2>
						<p>Etiam vulputate ut augue vel sodales. In sollicitudin neque et massa porttitor vestibulum ac vel nisi. Vestibulum placerat eget dolor sit amet posuere. In ut dolor aliquet, aliquet sapien sed, interdum velit. Nam eu molestie lorem.</p>
						<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sapiente facilis illo repellat veritatis minus, et labore minima mollitia qui");
            WriteLiteral(@" ducimus.</p>
						<a href=""about.html"" class=""boxed-btn mt-4"">know more</a>
					</div>
				</div>
			</div>
		</div>
	</div>
	 end advertisement section -->
	
	

	<!-- latest news 
	<div class=""latest-news pt-150 pb-150"">
		<div class=""container"">

			<div class=""row"">
				<div class=""col-lg-8 offset-lg-2 text-center"">
					<div class=""section-title"">	
						<h3><span class=""orange-text"">Our</span> News</h3>
						<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aliquid, fuga quas itaque eveniet beatae optio.</p>
					</div>
				</div>
			</div>

			<div class=""row"">
				<div class=""col-lg-4 col-md-6"">
					<div class=""single-latest-news"">
						<a href=""single-news.html""><div class=""latest-news-bg news-bg-1""></div></a>
						<div class=""news-text-box"">
							<h3><a href=""single-news.html"">You will vainly look for fruit on it in autumn.</a></h3>
							<p class=""blog-meta"">
								<span class=""author""><i class=""fas fa-user""></i> Admin</span>
								<span class");
            WriteLiteral(@"=""date""><i class=""fas fa-calendar""></i> 27 December, 2019</span>
							</p>
							<p class=""excerpt"">Vivamus lacus enim, pulvinar vel nulla sed, scelerisque rhoncus nisi. Praesent vitae mattis nunc, egestas viverra eros.</p>
							<a href=""single-news.html"" class=""read-more-btn"">read more <i class=""fas fa-angle-right""></i></a>
						</div>
					</div>
				</div>
				<div class=""col-lg-4 col-md-6"">
					<div class=""single-latest-news"">
						<a href=""single-news.html""><div class=""latest-news-bg news-bg-2""></div></a>
						<div class=""news-text-box"">
							<h3><a href=""single-news.html"">A man's worth has its season, like tomato.</a></h3>
							<p class=""blog-meta"">
								<span class=""author""><i class=""fas fa-user""></i> Admin</span>
								<span class=""date""><i class=""fas fa-calendar""></i> 27 December, 2019</span>
							</p>
							<p class=""excerpt"">Vivamus lacus enim, pulvinar vel nulla sed, scelerisque rhoncus nisi. Praesent vitae mattis nunc, egestas viverra eros.</p>
							<a href");
            WriteLiteral(@"=""single-news.html"" class=""read-more-btn"">read more <i class=""fas fa-angle-right""></i></a>
						</div>
					</div>
				</div>
				<div class=""col-lg-4 col-md-6 offset-md-3 offset-lg-0"">
					<div class=""single-latest-news"">
						<a href=""single-news.html""><div class=""latest-news-bg news-bg-3""></div></a>
						<div class=""news-text-box"">
							<h3><a href=""single-news.html"">Good thoughts bear good fresh juicy fruit.</a></h3>
							<p class=""blog-meta"">
								<span class=""author""><i class=""fas fa-user""></i> Admin</span>
								<span class=""date""><i class=""fas fa-calendar""></i> 27 December, 2019</span>
							</p>
							<p class=""excerpt"">Vivamus lacus enim, pulvinar vel nulla sed, scelerisque rhoncus nisi. Praesent vitae mattis nunc, egestas viverra eros.</p>
							<a href=""single-news.html"" class=""read-more-btn"">read more <i class=""fas fa-angle-right""></i></a>
						</div>
					</div>
				</div>
			</div>
			<div class=""row"">
				<div class=""col-lg-12 text-center"">
					<a href=""n");
            WriteLiteral(@"ews.html"" class=""boxed-btn"">More News</a>
				</div>
			</div>
		</div>
	</div>
	 end latest news -->

	<!-- logo carousel 
	<div class=""logo-carousel-section"">
		<div class=""container"">
			<div class=""row"">
				<div class=""col-lg-12"">
					<div class=""logo-carousel-inner"">
						<div class=""single-logo-item"">
							<img src=""assets/img/company-logos/1.png"" alt="""">
						</div>
						<div class=""single-logo-item"">
							<img src=""assets/img/company-logos/2.png"" alt="""">
						</div>
						<div class=""single-logo-item"">
							<img src=""assets/img/company-logos/3.png"" alt="""">
						</div>
						<div class=""single-logo-item"">
							<img src=""assets/img/company-logos/4.png"" alt="""">
						</div>
						<div class=""single-logo-item"">
							<img src=""assets/img/company-logos/5.png"" alt="""">
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>-->
	<!-- end logo carousel -->

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pharma.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
