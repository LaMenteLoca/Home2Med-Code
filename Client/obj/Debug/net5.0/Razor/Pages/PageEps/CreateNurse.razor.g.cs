#pragma checksum "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\CreateNurse.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7d9210da53f9d64021d321a959ddb8b84cc5c58"
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
#line 1 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\CreateNurse.razor"
using Home2Med.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eps/createnurse")]
    public partial class CreateNurse : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<nav class=\"navbar navbar-expand-sm navbar-h2m bg-prima mb-3\"><div class=\"container\"><a class=\"navbar-brand\" href=\"#\"><strong>E P S - Creación Enfermera</strong></a></div></nav>\r\n\r\n");
            __builder.OpenComponent<Home2Med.Client.Pages.Components.FormNurse>(1);
            __builder.AddAttribute(2, "Nurse", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Home2Med.Shared.Entity.Nurse>(
#nullable restore
#line 12 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\CreateNurse.razor"
                  Nurse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 12 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\CreateNurse.razor"
                                        Create

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\CreateNurse.razor"
       
   private Nurse Nurse = new Nurse();
   private async Task Create()
   {
      var httpResponse = await nurse_i.Post("api/nurses", Nurse);
      if (httpResponse.Error)
      {
         var body = await httpResponse.HttpResponseMessage.Content.ReadAsStringAsync();
         Console.WriteLine(body);
      }
      else
      {
         navigationManager.NavigateTo("/eps/createnurse");
      }
      Console.WriteLine($"Nombre {Nurse.NurseName}");
      Console.WriteLine($"Tipo de Documento {Nurse.NurseDocumentType}");
      Console.WriteLine($"Documento {Nurse.NurseDocument}");
      Console.WriteLine($"Genero {Nurse.NurseGender}");
      Console.WriteLine($"Telefono {Nurse.NursePhone}");
      Console.WriteLine($"Especialidad {Nurse.NurseSpeciality}");
      Console.WriteLine($"Estado {Nurse.NurseStatus}");

   }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceNurse nurse_i { get; set; }
    }
}
#pragma warning restore 1591
