#pragma checksum "C:\Users\user\Documents\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganaderos\list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce2296b75b82876288cf080d653d54572d6a731d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ganaderia.App.Presentacion.Pages.Ganaderos.Pages_Ganaderos_list), @"mvc.1.0.razor-page", @"/Pages/Ganaderos/list.cshtml")]
namespace Ganaderia.App.Presentacion.Pages.Ganaderos
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
#line 1 "C:\Users\user\Documents\Ganaderia.App\Ganaderia.App.Presentacion\Pages\_ViewImports.cshtml"
using Ganaderia.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce2296b75b82876288cf080d653d54572d6a731d", @"/Pages/Ganaderos/list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1717c2eb7bb98504efa8c0608ed0b9689cdbfa7f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Ganaderos_list : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\Documents\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganaderos\list.cshtml"
  
  Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2 align=""center""> Listado de ganaderos</h2>

<table  class=""table table-striped"">
 
    <tr class=""table-success"">
    <th>Nombres</th>
    <th>Apellidos</th>
    <th>NumeroTelefono</th>
    <th>Correo</th>
    <th>Contrasena</th>
    <th>Latitud</th>
    <th>Longitud</th>
  </tr>
  
");
#nullable restore
#line 20 "C:\Users\user\Documents\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganaderos\list.cshtml"
   foreach (var ganadero in Model.Ganaderos)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr class=\"bg-warning\">\r\n    <td>");
#nullable restore
#line 23 "C:\Users\user\Documents\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganaderos\list.cshtml"
   Write(ganadero.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\user\Documents\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganaderos\list.cshtml"
   Write(ganadero.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\user\Documents\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganaderos\list.cshtml"
   Write(ganadero.NumeroTelefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\user\Documents\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganaderos\list.cshtml"
   Write(ganadero.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 27 "C:\Users\user\Documents\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganaderos\list.cshtml"
   Write(ganadero.Contrasena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\user\Documents\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganaderos\list.cshtml"
   Write(ganadero.Latitud);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 29 "C:\Users\user\Documents\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganaderos\list.cshtml"
   Write(ganadero.Longitud);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>  \r\n");
#nullable restore
#line 31 "C:\Users\user\Documents\Ganaderia.App\Ganaderia.App.Presentacion\Pages\Ganaderos\list.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ganaderia.App.Presentacion.Pages.listModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ganaderia.App.Presentacion.Pages.listModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ganaderia.App.Presentacion.Pages.listModel>)PageContext?.ViewData;
        public Ganaderia.App.Presentacion.Pages.listModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
