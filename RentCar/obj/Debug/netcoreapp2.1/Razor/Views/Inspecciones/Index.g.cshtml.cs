#pragma checksum "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "062b936fedd6e37a9518b90055c1361ad59178cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inspecciones_Index), @"mvc.1.0.view", @"/Views/Inspecciones/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inspecciones/Index.cshtml", typeof(AspNetCore.Views_Inspecciones_Index))]
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
#line 1 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\_ViewImports.cshtml"
using RentCar;

#line default
#line hidden
#line 2 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\_ViewImports.cshtml"
using RentCar.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"062b936fedd6e37a9518b90055c1361ad59178cb", @"/Views/Inspecciones/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"612a37676d153cccf3f3542ae2284021dc345f54", @"/Views/_ViewImports.cshtml")]
    public class Views_Inspecciones_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RentCar.Models.RentCarModels.Inspeccion>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info navbar-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(104, 36, true);
            WriteLiteral("\r\n<h2>Inspecciones</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(140, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab59c92527ce4a9f8e728bd672683e68", async() => {
                BeginContext(195, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(209, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
            BeginContext(217, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff1a1e68bff141c0a71f420417c7f100", async() => {
                BeginContext(236, 118, true);
                WriteLiteral("\r\n    <input type=\"text\" id=\"Criterio\" name=\"Criterio\" />\r\n    <input type=\"submit\" id=\"cmdBuscar\" value=\"Buscar\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(361, 128, true);
            WriteLiteral("\r\n<table class=\"table table-hover table-striped table-condensed\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(490, 45, false);
#line 20 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ralladura));

#line default
#line hidden
            EndContext();
            BeginContext(535, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(591, 48, false);
#line 23 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GomaRepuesta));

#line default
#line hidden
            EndContext();
            BeginContext(639, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(695, 40, false);
#line 26 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gato));

#line default
#line hidden
            EndContext();
            BeginContext(735, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(791, 49, false);
#line 29 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RoturaCristal));

#line default
#line hidden
            EndContext();
            BeginContext(840, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(896, 47, false);
#line 32 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrimeraGoma));

#line default
#line hidden
            EndContext();
            BeginContext(943, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(999, 47, false);
#line 35 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SegundaGoma));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1102, 47, false);
#line 38 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TerceraGoma));

#line default
#line hidden
            EndContext();
            BeginContext(1149, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1205, 46, false);
#line 41 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CuartaGoma));

#line default
#line hidden
            EndContext();
            BeginContext(1251, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1307, 55, false);
#line 44 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CantidadCombustible));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1418, 41, false);
#line 47 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(1459, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1515, 42, false);
#line 50 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1613, 44, false);
#line 53 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Vehiculo));

#line default
#line hidden
            EndContext();
            BeginContext(1657, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1713, 43, false);
#line 56 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
            EndContext();
            BeginContext(1756, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1812, 44, false);
#line 59 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Empleado));

#line default
#line hidden
            EndContext();
            BeginContext(1856, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 65 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1974, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2023, 44, false);
#line 68 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ralladura));

#line default
#line hidden
            EndContext();
            BeginContext(2067, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2123, 47, false);
#line 71 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GomaRepuesta));

#line default
#line hidden
            EndContext();
            BeginContext(2170, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2226, 39, false);
#line 74 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gato));

#line default
#line hidden
            EndContext();
            BeginContext(2265, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2321, 48, false);
#line 77 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RoturaCristal));

#line default
#line hidden
            EndContext();
            BeginContext(2369, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2425, 46, false);
#line 80 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrimeraGoma));

#line default
#line hidden
            EndContext();
            BeginContext(2471, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2527, 46, false);
#line 83 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SegundaGoma));

#line default
#line hidden
            EndContext();
            BeginContext(2573, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2629, 46, false);
#line 86 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TerceraGoma));

#line default
#line hidden
            EndContext();
            BeginContext(2675, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2731, 45, false);
#line 89 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CuartaGoma));

#line default
#line hidden
            EndContext();
            BeginContext(2776, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2832, 54, false);
#line 92 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CantidadCombustible));

#line default
#line hidden
            EndContext();
            BeginContext(2886, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2942, 40, false);
#line 95 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(2982, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3038, 41, false);
#line 98 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(3079, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3135, 55, false);
#line 101 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Vehiculo.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(3190, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3246, 49, false);
#line 104 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cliente.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(3295, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3351, 50, false);
#line 107 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Empleado.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(3401, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3456, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cbcbcbf9e7045c893aacf548add5ff8", async() => {
                BeginContext(3512, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 110 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
                                       WriteLiteral(item.IdTransaccion);

#line default
#line hidden
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
            EndContext();
            BeginContext(3520, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3540, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92f80aa9ff6a4f099e720ac6e6f4bb49", async() => {
                BeginContext(3599, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 111 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
                                          WriteLiteral(item.IdTransaccion);

#line default
#line hidden
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
            EndContext();
            BeginContext(3610, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3630, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5233648fd7a4c24a0e7ba81f0f64330", async() => {
                BeginContext(3688, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 112 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
                                         WriteLiteral(item.IdTransaccion);

#line default
#line hidden
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
            EndContext();
            BeginContext(3698, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 115 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Inspecciones\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3737, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RentCar.Models.RentCarModels.Inspeccion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
