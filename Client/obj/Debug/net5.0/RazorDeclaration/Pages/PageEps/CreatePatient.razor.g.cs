// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\CreatePatient.razor"
using Home2Med.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eps/createpatient")]
    public partial class CreatePatient : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\CreatePatient.razor"
       
   private Patient Patient = new Patient();
private async Task Create()
   {
      var httpResponse = await patient_i.Post("api/patients", Patient);
      if (httpResponse.Error)
      {
         var body = await httpResponse.HttpResponseMessage.Content.ReadAsStringAsync();
         Console.WriteLine(body);
      }
      else
      {
         navigationManager.NavigateTo("/eps/createpatient");
      }
      Console.WriteLine($"Nombre {Patient.PatientName}");
      Console.WriteLine($"Tipo de Documento {Patient.PatientDocumentType}");
      Console.WriteLine($"Documento {Patient.PatientDocument}");
      Console.WriteLine($"Genero {Patient.PatientGender}");
      Console.WriteLine($"Telefono {Patient.PatientPhone}");
      Console.WriteLine($"Dirección de Residencia {Patient.PatientAddress}");
      Console.WriteLine($"Georeferenciación {Patient.PatientGeorreferentiation}");
      Console.WriteLine($"Diagnóstico {Patient.PatientDiagnosis}");
      Console.WriteLine($"Médico Tratante {Patient.PatientDoctor}");
      Console.WriteLine($"EPS {Patient.PatientEPS}");
      Console.WriteLine($"Estado {Patient.PatientStatus}");

   }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicePatient patient_i { get; set; }
    }
}
#pragma warning restore 1591
