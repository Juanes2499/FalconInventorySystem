#pragma checksum "C:\Users\Bryan\Desktop\Dev\C#\Proyectos\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Producto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "010602ef226367accb439c7ae24474ed0f4ad306"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FalconInventorySystem.App.Frontend.Pages.Pages_Producto), @"mvc.1.0.razor-page", @"/Pages/Producto.cshtml")]
namespace FalconInventorySystem.App.Frontend.Pages
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
#line 1 "C:\Users\Bryan\Desktop\Dev\C#\Proyectos\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\_ViewImports.cshtml"
using FalconInventorySystem.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"010602ef226367accb439c7ae24474ed0f4ad306", @"/Pages/Producto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c284d041bf7e2a67c4dcd8122a3bcdd82b896f5f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Producto : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"container-search\">\r\n    <a class=\"back\" href=\"Dashboard\">\r\n        <img class=\"img_back\" src=\"https://img.icons8.com/ios-filled/50/000000/back.png\" />Productos\r\n    </a>\r\n    \r\n        <div class=\"demo\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "010602ef226367accb439c7ae24474ed0f4ad3063864", async() => {
                WriteLiteral("\r\n                <div class=\"input-group\">\r\n                    <input class=\"form-control form-text\" maxlength=\"80\" placeholder=\"Buscar\" size=\"15\" type=\"text\" />\r\n\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""button-search"">
            <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModalCenter"">
                Crear Producto
            </button>
        </div>
    
</div>


<table class=""table table-responsive table-bordered "">
    <thead class=""text-center"">
        <tr class=""titulo"">
            
            <th>Nombre Producto</th>
            <th>Valor</th>
            <th>Fecha vencimiento</th>
            <th>Marca</th>
            <th>Categoria</th>
            <th>Acciones</th>
        </tr>
    </thead>
    <tbody class=""text-center"">
        <tr>
            <td>123141351</td>
            <td>Daniel</td>
            <td>Cr.32 No 32-45</td>
            <td>3135759143</td>
            <td>verdde3991@gmail.com</td>
            
            <td class=""text-center"">
                <i class=""far fa-edit fa-2x""></i> <i class=""fas fa-trash-alt fa-2x""></i>
            </td>
        </tr>
        <tr");
            WriteLiteral(@">
            <td>123141351</td>
            <td>Daniel</td>
            <td>Cr.32 No 32-45</td>
            <td>3135759143</td>
            <td>verdde3991@gmail.com</td>
            
            <td class=""text-center"">
                <i class=""far fa-edit fa-2x""></i> <i class=""fas fa-trash-alt fa-2x""></i>
            </td>
        </tr>
        <tr>
           <td>123141351</td>
            <td>Daniel</td>
            <td>Cr.32 No 32-45</td>
            <td>3135759143</td>
            <td>verdde3991@gmail.com</td>
            
            <td class=""text-center"">
                <i class=""far fa-edit fa-2x""></i> <i class=""fas fa-trash-alt fa-2x""></i>
            </td>
        </tr>
    </tbody>
</table>

<nav aria-label=""Page navigation example"">
    <ul class=""pagination"">
        <li class=""page-item"">
            <a class=""page-link"" href=""#"" aria-label=""Previous"">
                <span aria-hidden=""true"">&laquo;</span>
                <span class=""sr-only"">Previous</span>");
            WriteLiteral(@"
            </a>
        </li>
        <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
        <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
        <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
        <li class=""page-item"">
            <a class=""page-link"" href=""#"" aria-label=""Next"">
                <span aria-hidden=""true"">&raquo;</span>
                <span class=""sr-only"">Next</span>
            </a>
        </li>
    </ul>
</nav>

<!-- Modal -->
<div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle""
    aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Crear Proveedor</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span ar");
            WriteLiteral("ia-hidden=\"true\">&times;</span>\r\n                </button>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "010602ef226367accb439c7ae24474ed0f4ad3068823", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""Nombre_Producto"">Nombre Productor</label>
                        <input type=""text"" class=""form-control"" id=""nombre_producto"" placeholder=""Nombre Productor"">
                    </div>
                    <div class=""form-group"">
                        <label for=""Valor"">Valor</label>
                        <input type=""text"" class=""form-control"" id=""valor"" placeholder=""Valor"">
                    </div>
                    <div class=""form-group"">
                        <label for=""Fecha_vencimiento"">Fecha vencimiento</label>
                        <input type=""text"" class=""form-control"" id=""fecha_ven"" placeholder=""Direccion"">
                    </div>
                    <div class=""form-group"">
                        <label for=""Marca"">Marca</label>
                        <input type=""tex"" class=""form-control"" id=""marca"" placeholder=""Marca"">
                    </div>
                    <div class=""f");
                WriteLiteral("orm-group\">\r\n                        <label for=\"categoria\">Categoria</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"categoria\" placeholder=\"categoria\">\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" class=""btn btn-primary"">Crear proveedor</button>
            </div>
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductoModel>)PageContext?.ViewData;
        public ProductoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
