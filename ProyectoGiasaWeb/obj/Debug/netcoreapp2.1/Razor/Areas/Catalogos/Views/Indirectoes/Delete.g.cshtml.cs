#pragma checksum "C:\Users\CoordinacionTI\source\repos\ProyectoGiasaWeb\ProyectoGiasaWeb\Areas\Catalogos\Views\Indirectoes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "419720ca10387e26dead20ea08011838a63e5087"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Catalogos_Views_Indirectoes_Delete), @"mvc.1.0.view", @"/Areas/Catalogos/Views/Indirectoes/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Catalogos/Views/Indirectoes/Delete.cshtml", typeof(AspNetCore.Areas_Catalogos_Views_Indirectoes_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"419720ca10387e26dead20ea08011838a63e5087", @"/Areas/Catalogos/Views/Indirectoes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Catalogos/Views/_ViewImports.cshtml")]
    public class Areas_Catalogos_Views_Indirectoes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProyectoGiasaWeb.Models.Indirecto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\CoordinacionTI\source\repos\ProyectoGiasaWeb\ProyectoGiasaWeb\Areas\Catalogos\Views\Indirectoes\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_LayoutPrincipal.cshtml";

#line default
#line hidden
            BeginContext(142, 188, true);
            WriteLiteral("\r\n<h2>Eliminar Un Indirecto</h2>\r\n\r\n<h4>¿Estas Seguro De Eliminar Este Registro?</h4>\r\n<div>\r\n    <h4>Indirecto</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(331, 41, false);
#line 16 "C:\Users\CoordinacionTI\source\repos\ProyectoGiasaWeb\ProyectoGiasaWeb\Areas\Catalogos\Views\Indirectoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.horas));

#line default
#line hidden
            EndContext();
            BeginContext(372, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(416, 37, false);
#line 19 "C:\Users\CoordinacionTI\source\repos\ProyectoGiasaWeb\ProyectoGiasaWeb\Areas\Catalogos\Views\Indirectoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.horas));

#line default
#line hidden
            EndContext();
            BeginContext(453, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(497, 43, false);
#line 22 "C:\Users\CoordinacionTI\source\repos\ProyectoGiasaWeb\ProyectoGiasaWeb\Areas\Catalogos\Views\Indirectoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.minutos));

#line default
#line hidden
            EndContext();
            BeginContext(540, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(584, 39, false);
#line 25 "C:\Users\CoordinacionTI\source\repos\ProyectoGiasaWeb\ProyectoGiasaWeb\Areas\Catalogos\Views\Indirectoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.minutos));

#line default
#line hidden
            EndContext();
            BeginContext(623, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(667, 43, false);
#line 28 "C:\Users\CoordinacionTI\source\repos\ProyectoGiasaWeb\ProyectoGiasaWeb\Areas\Catalogos\Views\Indirectoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.importe));

#line default
#line hidden
            EndContext();
            BeginContext(710, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(754, 39, false);
#line 31 "C:\Users\CoordinacionTI\source\repos\ProyectoGiasaWeb\ProyectoGiasaWeb\Areas\Catalogos\Views\Indirectoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.importe));

#line default
#line hidden
            EndContext();
            BeginContext(793, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(837, 45, false);
#line 34 "C:\Users\CoordinacionTI\source\repos\ProyectoGiasaWeb\ProyectoGiasaWeb\Areas\Catalogos\Views\Indirectoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.subtotalP));

#line default
#line hidden
            EndContext();
            BeginContext(882, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(926, 41, false);
#line 37 "C:\Users\CoordinacionTI\source\repos\ProyectoGiasaWeb\ProyectoGiasaWeb\Areas\Catalogos\Views\Indirectoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.subtotalP));

#line default
#line hidden
            EndContext();
            BeginContext(967, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1011, 43, false);
#line 40 "C:\Users\CoordinacionTI\source\repos\ProyectoGiasaWeb\ProyectoGiasaWeb\Areas\Catalogos\Views\Indirectoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.insumoV));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1098, 39, false);
#line 43 "C:\Users\CoordinacionTI\source\repos\ProyectoGiasaWeb\ProyectoGiasaWeb\Areas\Catalogos\Views\Indirectoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.insumoV));

#line default
#line hidden
            EndContext();
            BeginContext(1137, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1181, 45, false);
#line 46 "C:\Users\CoordinacionTI\source\repos\ProyectoGiasaWeb\ProyectoGiasaWeb\Areas\Catalogos\Views\Indirectoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.materialV));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1270, 41, false);
#line 49 "C:\Users\CoordinacionTI\source\repos\ProyectoGiasaWeb\ProyectoGiasaWeb\Areas\Catalogos\Views\Indirectoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.materialV));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1355, 45, false);
#line 52 "C:\Users\CoordinacionTI\source\repos\ProyectoGiasaWeb\ProyectoGiasaWeb\Areas\Catalogos\Views\Indirectoes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.subtotalV));

#line default
#line hidden
            EndContext();
            BeginContext(1400, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1444, 41, false);
#line 55 "C:\Users\CoordinacionTI\source\repos\ProyectoGiasaWeb\ProyectoGiasaWeb\Areas\Catalogos\Views\Indirectoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.subtotalV));

#line default
#line hidden
            EndContext();
            BeginContext(1485, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1523, 250, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2948323995f8497091286322d264a793", async() => {
                BeginContext(1549, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1559, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "41090bafaef04c16872dfb78c8cd8616", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 60 "C:\Users\CoordinacionTI\source\repos\ProyectoGiasaWeb\ProyectoGiasaWeb\Areas\Catalogos\Views\Indirectoes\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.idIndirecto);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1604, 87, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-danger\" /> | |\r\n        ");
                EndContext();
                BeginContext(1691, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32fd69dcf25c423fa7dbde85a843062e", async() => {
                    BeginContext(1737, 19, true);
                    WriteLiteral("Regresar A La Lista");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
                EndContext();
                BeginContext(1760, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1773, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoGiasaWeb.Models.Indirecto> Html { get; private set; }
    }
}
#pragma warning restore 1591
