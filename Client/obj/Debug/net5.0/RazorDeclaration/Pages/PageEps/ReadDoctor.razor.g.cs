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
#line 1 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Home2Med.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Home2Med.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Home2Med.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Home2Med.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Home2Med\Home2Med-Code-1\Client\Pages\PageEps\ReadDoctor.razor"
using Home2Med.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eps/readdoctor")]
    public partial class ReadDoctor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "F:\Home2Med\Home2Med-Code-1\Client\Pages\PageEps\ReadDoctor.razor"
       
   private List<Doctor> Doctors;
   string doctor_name = "";

   protected override void OnInitialized()
   {
      Doctors = doctor.GetDoctors();
   }

   private void ShowDoctors()
   {
      Doctors = doctor.GetDoctors().Where(x => x.Name.ToLower().Contains(doctor_name.ToLower())).ToList();
      Console.WriteLine($"El médico es: {doctor_name}");
   }

   

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "F:\Home2Med\Home2Med-Code-1\Client\Pages\PageEps\ReadDoctor.razor"
         

   private void DoctorSearch(KeyboardEventArgs e)
   {
      if (e.Key == "Enter")
      {
         ShowDoctors();
      }
   }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceDoctor doctor { get; set; }
    }
}
#pragma warning restore 1591
