#pragma checksum "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\CreateRelative.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3675b0108e87bc17a02a52048ce23366efd44fdf"
// <auto-generated/>
#pragma warning disable 1591
namespace Home2Med.Client.Pages.PageEps
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
#nullable restore
#line 2 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\CreateRelative.razor"
using Home2Med.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eps/createrelative")]
    public partial class CreateRelative : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Home2Med.Client.Pages.Components.FormRelative>(0);
            __builder.AddAttribute(1, "Relative", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Home2Med.Shared.Entity.Relative>(
#nullable restore
#line 4 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\CreateRelative.razor"
                          Relative

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 4 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\CreateRelative.razor"
                                                   Create

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\CreateRelative.razor"
       
   private Relative Relative = new Relative();
   void Create()
   {
      Console.WriteLine($"Nombre {Relative.RelativeName}");
      Console.WriteLine($"Tipo de Documento {Relative.RelativeDocumentType}");
      Console.WriteLine($"Documento {Relative.RelativeDocument}");
      Console.WriteLine($"Genero {Relative.RelativeGender}");
      Console.WriteLine($"Telefono {Relative.RelativePhone}");
      Console.WriteLine($"Relación con el paciente {Relative.RelativeRelationship}");
      Console.WriteLine($"Correo Electrónico {Relative.RelativeEmail}");
      Console.WriteLine($"Documento del Paciente a cargo {Relative.RelativePatientDoc}");
      Console.WriteLine($"Estado {Relative.RelativeStatus}");

   }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
