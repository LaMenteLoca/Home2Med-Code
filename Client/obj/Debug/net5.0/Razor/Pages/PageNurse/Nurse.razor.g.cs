#pragma checksum "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageNurse\Nurse.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "331633182d5cefec40b521c898b84e4aaa1c9a9d"
// <auto-generated/>
#pragma warning disable 1591
namespace Home2Med.Client.Pages.PageNurse
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Home2Med-Clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/nurse")]
    public partial class Nurse : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<nav class=""navbar navbar-expand-sm navbar-h2m bg-prima""><div class=""container""><a class=""navbar-brand"" href=""#"">ENFERMERA</a>
      <ul class=""navbar-nav""><li class=""nav-item""><a href=""nurse/nursepersonaldata"" class=""nav-link""> Datos Personales</a></li>
         <li class=""nav-item dropdown""><a href=""#"" class=""nav-link dropdown-toggle"" data-toggle=""dropdown""> Historia Clínica</a>
            <div class=""dropdown-menu bg-h2m""><a href=""nurse/createhistoryclinic"" class=""dropdown-item"">Crear</a>
               <a href=""nurse/readhistoryclinic"" class=""dropdown-item"">Buscar</a>
               <a href=""nurse/updatehistoryclinic"" class=""dropdown-item"">Editar</a>
               <a href=""nurse/deletehistoryclinic"" class=""dropdown-item"">Borrar</a></div></li>
         <li class=""nav-item""><a href=""/nurse/nursevitalsings"" class=""nav-link""> Signos Vitales</a></li>
         <li class=""nav-item""><a class=""nav-link"" href=""#"">Home</a></li></ul></div></nav>
<hr>

");
            __builder.AddMarkupContent(1, "<div class=\"jumbotron\"><div><img src=\"/Images/foto05.png\" class=\"d-block w-100\" alt=\"...\"></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
