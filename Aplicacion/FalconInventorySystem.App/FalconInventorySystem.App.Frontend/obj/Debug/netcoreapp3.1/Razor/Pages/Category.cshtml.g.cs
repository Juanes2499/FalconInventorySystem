#pragma checksum "C:\Users\juane\OneDrive\Mision TIC 2021\Ciclo 3\Desarrollo de Software\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "437eb1327090e85de6effac6824ddeb5042bfc27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FalconInventorySystem.App.Frontend.Pages.Pages_Category), @"mvc.1.0.razor-page", @"/Pages/Category.cshtml")]
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
#line 1 "C:\Users\juane\OneDrive\Mision TIC 2021\Ciclo 3\Desarrollo de Software\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\_ViewImports.cshtml"
using FalconInventorySystem.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"437eb1327090e85de6effac6824ddeb5042bfc27", @"/Pages/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c284d041bf7e2a67c4dcd8122a3bcdd82b896f5f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Category : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/CategoryEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/CategoryDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Nombre categoría"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container my-5"">
    <div class=""d-flex justify-content-between"">
        <a class=""back-dashboard"" href=""Dashboard"">
            <img src=""https://img.icons8.com/ios-filled/50/000000/back.png"" />
            Categorías
        </a>
        <button type=""button"" class=""btn btn-primary crear"" data-toggle=""modal"" data-target=""#Crear"">
            Crear Categoría
        </button>
        </div>
    </div>


<!--

    <div>
        <table class=""table table-responsive-xl"">
            <thead class=""header-tabla"">
                <tr>
                    <th class=""header-tabla-titulo"">Nombre marca</th>
                    <th class=""header-tabla-titulo"">Fecha Creacion</th>
                    <th class=""header-tabla-titulo"">Fecha Actualizacion</th>
                    <th class=""header-tabla-titulo"">Acciones</th>
                </tr>
            </thead>
            <tbody class=""table-body"">
");
#nullable restore
#line 30 "C:\Users\juane\OneDrive\Mision TIC 2021\Ciclo 3\Desarrollo de Software\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Category.cshtml"
                 foreach (var category in Model.CategoryList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\juane\OneDrive\Mision TIC 2021\Ciclo 3\Desarrollo de Software\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Category.cshtml"
                       Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\juane\OneDrive\Mision TIC 2021\Ciclo 3\Desarrollo de Software\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Category.cshtml"
                       Write(category.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\juane\OneDrive\Mision TIC 2021\Ciclo 3\Desarrollo de Software\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Category.cshtml"
                       Write(category.ModificationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "437eb1327090e85de6effac6824ddeb5042bfc278843", async() => {
                WriteLiteral("\r\n                                <i class=\"far fa-edit fa-2x\"></i>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\juane\OneDrive\Mision TIC 2021\Ciclo 3\Desarrollo de Software\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Category.cshtml"
                                                                  WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "437eb1327090e85de6effac6824ddeb5042bfc2711285", async() => {
                WriteLiteral("\r\n                                <i class=\"fas fa-trash-alt fa-2x\"></i>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\juane\OneDrive\Mision TIC 2021\Ciclo 3\Desarrollo de Software\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Category.cshtml"
                                                                    WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 45 "C:\Users\juane\OneDrive\Mision TIC 2021\Ciclo 3\Desarrollo de Software\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Category.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

-->

<!-- Modal -->
<div class=""modal fade"" id=""Crear"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle""
     aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Crear Categoría</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "437eb1327090e85de6effac6824ddeb5042bfc2714833", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label for=\"razon_social\">Nombre categoría</label>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "437eb1327090e85de6effac6824ddeb5042bfc2715246", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 68 "C:\Users\juane\OneDrive\Mision TIC 2021\Ciclo 3\Desarrollo de Software\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Category.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Category.CategoryName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
                        <button type=""submit"" class=""btn btn-primary"">Crear Categoría</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<!-- Nueva tabla-->
<div class=""container-table"">
    <table id=""example"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
        <thead class=""first-column-table"">
            <tr style=""text-center"">
                <th class=""color-texto"">Nombre marca</th>
                <th class=""color-texto"">Fecha Creacion</th>
                <th class=""color-texto"">Fecha Actualizacion</th>
                <th class=""color-texto"" style=""text-align:center;width:100px;"">Acciones</th>
            </tr>
        </thead>
          <tbody class=""table-body"">
");
#nullable restore
#line 93 "C:\Users\juane\OneDrive\Mision TIC 2021\Ciclo 3\Desarrollo de Software\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Category.cshtml"
                 foreach (var category in Model.CategoryList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 96 "C:\Users\juane\OneDrive\Mision TIC 2021\Ciclo 3\Desarrollo de Software\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Category.cshtml"
                   Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 97 "C:\Users\juane\OneDrive\Mision TIC 2021\Ciclo 3\Desarrollo de Software\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Category.cshtml"
                   Write(category.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 98 "C:\Users\juane\OneDrive\Mision TIC 2021\Ciclo 3\Desarrollo de Software\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Category.cshtml"
                   Write(category.ModificationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "437eb1327090e85de6effac6824ddeb5042bfc2721056", async() => {
                WriteLiteral("\r\n                            <i class=\"far fa-edit fa-1x\"></i>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\juane\OneDrive\Mision TIC 2021\Ciclo 3\Desarrollo de Software\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Category.cshtml"
                                                                                      WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "437eb1327090e85de6effac6824ddeb5042bfc2723591", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-trash-alt fa-1x\"></i>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "C:\Users\juane\OneDrive\Mision TIC 2021\Ciclo 3\Desarrollo de Software\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Category.cshtml"
                                                                                       WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 108 "C:\Users\juane\OneDrive\Mision TIC 2021\Ciclo 3\Desarrollo de Software\FalconInventorySystem\Aplicacion\FalconInventorySystem.App\FalconInventorySystem.App.Frontend\Pages\Category.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FalnconInventorySystem.App.Frontend.Pages.CategoryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FalnconInventorySystem.App.Frontend.Pages.CategoryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FalnconInventorySystem.App.Frontend.Pages.CategoryModel>)PageContext?.ViewData;
        public FalnconInventorySystem.App.Frontend.Pages.CategoryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
