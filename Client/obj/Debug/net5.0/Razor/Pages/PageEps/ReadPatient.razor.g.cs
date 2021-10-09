#pragma checksum "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\ReadPatient.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d20dfa98da98e40ebda0f9994a1c3b3de0f085ef"
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
#line 2 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\ReadPatient.razor"
using Home2Med.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eps/readpatient")]
    public partial class ReadPatient : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<nav class=\"navbar navbar-expand-sm navbar-h2m bg-prima mb-3\"><div class=\"container\"><a class=\"navbar-brand\" href=\"#\"><strong>E P S - Buscar Paciente</strong></a></div></nav>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center align-items-center");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "jumbotron1 col-9");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group ml-4 mb-2 col-8");
            __builder.AddMarkupContent(7, "<p class=\"mb-0\"><strong>Nombres y Apellidos</strong></p>\r\n         ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 18 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\ReadPatient.razor"
                           (KeyboardEventArgs e)=>PatientSearch(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "class", "form-control col-11");
            __builder.AddAttribute(12, "id", "patient_name");
            __builder.AddAttribute(13, "placeholder", "Buscar Paciente");
            __builder.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\ReadPatient.razor"
                                         patient_name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patient_name = __value, patient_name));
            __builder.SetUpdatesAttributeName("Value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n      ");
            __builder.OpenElement(17, "div");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "btn btn-success mb-1 ml-5");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\ReadPatient.razor"
                                                                           ShowPatients

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Buscar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n   ");
            __builder.OpenComponent<Home2Med.Client.Pages.Components.ServicePatients>(24);
            __builder.AddAttribute(25, "Patients", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Home2Med.Shared.Entity.Patient>>(
#nullable restore
#line 25 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\ReadPatient.razor"
                              Patients

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\ReadPatient.razor"
       
   private List<Patient> Patients;
   string patient_name = "";

   protected override void OnInitialized()
   {
      Patients = patient.GetPatients();
   }

   private void ShowPatients()
   {
      Patients = patient.GetPatients().Where(x => x.PatientName.ToLower().Contains(patient_name.ToLower())).ToList();
      Console.WriteLine($"El paciente es: {patient_name}");
   }

   

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Home2Med-Clone\Home2Med-Code\Client\Pages\PageEps\ReadPatient.razor"
         

   private void PatientSearch(KeyboardEventArgs e)
   {
      if (e.Key == "Enter")
      {
         ShowPatients();
      }
   }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicePatient patient { get; set; }
    }
}
#pragma warning restore 1591
