#pragma checksum "C:\Users\Bryan\Desktop\Dev\C#\Proyectos\FalconSystem\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Proveedor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2140ff6f3a71bec969a6e02a4b63849e08e6beda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FalconInventorySystem.App.Frontend.Pages.Pages_Proveedor), @"mvc.1.0.razor-page", @"/Pages/Proveedor.cshtml")]
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
#line 1 "C:\Users\Bryan\Desktop\Dev\C#\Proyectos\FalconSystem\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\_ViewImports.cshtml"
using FalconInventorySystem.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2140ff6f3a71bec969a6e02a4b63849e08e6beda", @"/Pages/Proveedor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c284d041bf7e2a67c4dcd8122a3bcdd82b896f5f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Proveedor : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
            WriteLiteral(@"


<h1>Proveedores</h1>

<div class=""container text-right"">
    <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModalCenter"">
        Crear Proveedor
    </button>
</div>


<table class=""table table-responsive table-bordered "">
    <thead class=""text-center"">
        <tr class=""titulo"">
            <th>Nit</th>
            <th>Nombre proveedor</th>
            <th>Direccion</th>
            <th>Telefono</th>
            <th>Correo</th>
            <th>Fecha Creacion</th>
            <th>Fecha Actualizacion</th>
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
            <td></td>
            <td></td>
            <td class=""text-center"">
                <i class=""far fa-edit fa-2x""></i> <i class=""fas fa-trash-alt fa-2");
            WriteLiteral(@"x""></i>     
           </td>
        </tr>
        <tr>
            <td>123141351</td>
            <td>Daniel</td>
            <td>Cr.32 No 32-45</td>
            <td>3135759143</td>
            <td>verdde3991@gmail.com</td>
            <td></td>
            <td></td>
            <td class= ""text-center"">
                <i class=""far fa-edit fa-2x""></i> <i class=""fas fa-trash-alt fa-2x""></i>
            </td>
        </tr>
        <tr>
            <td>123141351</td>
            <td>Daniel</td>
            <td>Cr.32 No 32-45</td>
            <td>3135759143</td>
            <td>verdde3991@gmail.com</td>
            <td></td>
            <td></td>
            <td class= ""text-center"">
            <i class=""far fa-edit fa-2x""></i> <i class=""fas fa-trash-alt fa-2x""></i>
            </td>
        </tr>
    </tbody>
</table>

<nav aria-label=""Page navigation example"">
    <ul class=""pagination"">
        <li class=""page-item"">
            <a class=""page-link"" href=""#"" aria-label=""Pr");
            WriteLiteral(@"evious"">
                <span aria-hidden=""true"">&laquo;</span>
                <span class=""sr-only"">Previous</span>
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
<div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
  <div class=""modal-dialog modal-dialog-centered"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLongTitle"">Crear Proveedor</h5>
        <button type=""butt");
            WriteLiteral("on\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n          <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n      </div>\r\n      <div class=\"modal-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2140ff6f3a71bec969a6e02a4b63849e08e6beda6763", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <label for=""id"">ID</label>
                <input type=""number"" class=""form-control"" id=""id""  placeholder=""ID"">
            </div>
            <div class=""form-group"">
                <label for=""razon_social"">Razón Social</label>
                <input type=""text"" class=""form-control"" id=""razon_social""  placeholder=""Razón Social"">
            </div>
            <div class=""form-group"">
                <label for=""nit"">NIT</label>
                <input type=""text"" class=""form-control"" id=""nit""  placeholder=""NIT"">
            </div>
            <div class=""form-group"">
                <label for=""direccion"">Direccion</label>
                <input type=""text"" class=""form-control"" id=""direccion""  placeholder=""Direccion"">
            </div>
            <div class=""form-group"">
                <label for=""phone"">Telefono</label>
                <input type=""tel"" class=""form-control"" id=""phone""  placeholder=""Telefono"">
            </div>
 ");
                WriteLiteral("           <div class=\"form-group\">\r\n                <label for=\"email\">Email</label>\r\n                <input type=\"tel\" class=\"form-control\" id=\"email\"  placeholder=\"Email\">\r\n            </div>\r\n        ");
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
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-primary"">Save changes</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProveedorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProveedorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProveedorModel>)PageContext?.ViewData;
        public ProveedorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
