#pragma checksum "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "366bf37879f33f9a479a63441564d3226e37ff62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehiculos_Details), @"mvc.1.0.view", @"/Views/Vehiculos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehiculos/Details.cshtml", typeof(AspNetCore.Views_Vehiculos_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"366bf37879f33f9a479a63441564d3226e37ff62", @"/Views/Vehiculos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"612a37676d153cccf3f3542ae2284021dc345f54", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehiculos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RentCar.Models.RentCarModels.Vehiculo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(91, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Vehiculo</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(214, 47, false);
#line 14 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(261, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(305, 43, false);
#line 17 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(348, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(392, 45, false);
#line 20 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumChasis));

#line default
#line hidden
            EndContext();
            BeginContext(437, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(481, 41, false);
#line 23 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumChasis));

#line default
#line hidden
            EndContext();
            BeginContext(522, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(566, 44, false);
#line 26 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumPlaca));

#line default
#line hidden
            EndContext();
            BeginContext(610, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(654, 40, false);
#line 29 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumPlaca));

#line default
#line hidden
            EndContext();
            BeginContext(694, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(738, 42, false);
#line 32 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(780, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(824, 38, false);
#line 35 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(862, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(906, 48, false);
#line 38 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoVehiculo));

#line default
#line hidden
            EndContext();
            BeginContext(954, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(998, 56, false);
#line 41 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipoVehiculo.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1098, 51, false);
#line 44 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoCombustible));

#line default
#line hidden
            EndContext();
            BeginContext(1149, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1193, 59, false);
#line 47 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipoCombustible.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1296, 41, false);
#line 50 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Marca));

#line default
#line hidden
            EndContext();
            BeginContext(1337, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1381, 49, false);
#line 53 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Marca.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1430, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1474, 42, false);
#line 56 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(1516, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1560, 50, false);
#line 59 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Modelo.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1610, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1657, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba122f75c87e4c19be319f66f6a63fbf", async() => {
                BeginContext(1711, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Mayo-Agosto 2020\Propietaria\RentCar\RentCar\Views\Vehiculos\Details.cshtml"
                           WriteLiteral(Model.IdVehiculo);

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
            BeginContext(1719, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1727, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bb70f551dcf4a7bba0d9194a0bb26fa", async() => {
                BeginContext(1749, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1765, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RentCar.Models.RentCarModels.Vehiculo> Html { get; private set; }
    }
}
#pragma warning restore 1591
