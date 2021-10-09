#pragma checksum "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PagePatient\Patient.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb1b02c4706a916f134cb42c9bc73930d0646b00"
// <auto-generated/>
#pragma warning disable 1591
namespace Home2Med.Client.Pages.PagePatient
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/patient")]
    public partial class Patient : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<nav class=""navbar navbar-expand-sm navbar-h2m bg-prima""><div class=""container""><a class=""navbar-brand"" href=""#"">PACIENTE</a>
      <ul class=""navbar-nav""><li class=""nav-item""><a href=""patient/patientpersonaldata"" class=""nav-link""> Datos Personales</a></li>
         <li class=""nav-item""><a href=""patient/patientfamilydata"" class=""nav-link""> Datos Familiar</a></li>
         <li class=""nav-item""><a href=""patient/patienthistoryclinic"" class=""nav-link""> Historia Clínica</a></li>
         <li class=""nav-item dropdown""><a href=""#"" class=""nav-link dropdown-toggle"" data-toggle=""dropdown""> Signos Vitales</a>
            <div class=""dropdown-menu bg-h2m""><a href=""patient/createvitalsing"" class=""dropdown-item"">Crear</a>
               <a href=""patient/readvitalsing"" class=""dropdown-item"">Buscar</a>
               <a href=""patient/updatevitalsing"" class=""dropdown-item"">Editar</a>
               <a href=""patient/deletevitalsing"" class=""dropdown-item"">Borrar</a></div></li>
         <li class=""nav-item""><a class=""nav-link"" href=""#"">Home</a></li></ul></div></nav>
<hr>

");
            __builder.AddMarkupContent(1, @"<div class=""jumbotron""><div class=""container""><div id=""carousel1"" class=""carousel slide"" data-ride=""carousel""><ol class=""carousel-indicators""><li data-target=""#carousel1"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#carousel1"" data-slide-to=""1""></li>
            <li data-target=""#carousel1"" data-slide-to=""2""></li></ol>
         
         <div class=""carousel-inner""><div class=""carousel-item active""><img class=""d-block w-100"" src=""Images/xpruebas/slide01.png"" alt height=""450"" width=""10""></div>
            <div class=""carousel-item""><img class=""d-block w-100"" src=""Images/xpruebas/slide03.png"" alt height=""450"" width=""10""></div>
            <div class=""carousel-item""><img class=""d-block w-100"" src=""Images/xpruebas/slide02.png"" alt height=""450"" width=""10""></div></div>
         
         <a class=""carousel-control-prev"" href=""#"" data-slide=""prev""><span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span></a>
         <a class=""carousel-control-next"" href=""#"" data-slide=""next""><span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span></a></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
