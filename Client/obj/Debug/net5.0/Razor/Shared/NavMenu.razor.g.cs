#pragma checksum "F:\Home2Med\Home2Med-Code-1\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd658d9479abd8a79ac0a495d802e872a43e6a38"
// <auto-generated/>
#pragma warning disable 1591
namespace Home2Med.Client.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-bbn4wlm9jg");
            __builder.AddMarkupContent(3, "<img src=\"/Images/Icono/icno-40x40px.png\" alt b-bbn4wlm9jg>\r\n    ");
            __builder.AddMarkupContent(4, "<a class=\"navbar-brand\" href=\"#\" b-bbn4wlm9jg>Home2Med</a>\r\n    ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "navbar-toggler");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "F:\Home2Med\Home2Med-Code-1\Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "b-bbn4wlm9jg");
            __builder.AddMarkupContent(9, "<span class=\"navbar-toggler-icon\" b-bbn4wlm9jg></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", 
#nullable restore
#line 9 "F:\Home2Med\Home2Med-Code-1\Client\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "F:\Home2Med\Home2Med-Code-1\Client\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "b-bbn4wlm9jg");
            __builder.OpenElement(15, "ul");
            __builder.AddAttribute(16, "class", "nav flex-column");
            __builder.AddAttribute(17, "b-bbn4wlm9jg");
            __builder.OpenElement(18, "li");
            __builder.AddAttribute(19, "class", "nav-item px-3");
            __builder.AddAttribute(20, "b-bbn4wlm9jg");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "nav-link");
            __builder.AddAttribute(23, "href", "");
            __builder.AddAttribute(24, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 12 "F:\Home2Med\Home2Med-Code-1\Client\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "<h4 style=\"color:  #045df9  \" ; b-bbn4wlm9jg><span class=\"oi oi-home\" aria-hidden=\"true\" b-bbn4wlm9jg></span> Inicio</h4>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "nav-item px-3");
            __builder.AddAttribute(30, "b-bbn4wlm9jg");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "patient");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "<h4 style=\"color:  #045df9  \" ; b-bbn4wlm9jg><span class=\"oi oi-plus\" aria-hidden=\"true\" b-bbn4wlm9jg></span> Paciente</h4>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "li");
            __builder.AddAttribute(38, "class", "nav-item px-3");
            __builder.AddAttribute(39, "b-bbn4wlm9jg");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(40);
            __builder.AddAttribute(41, "class", "nav-link");
            __builder.AddAttribute(42, "href", "doctor");
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(44, "<h4 style=\"color:  #045df9  \" ; b-bbn4wlm9jg><span class=\"oi oi-loop\" aria-hidden=\"true\" b-bbn4wlm9jg></span> Médico</h4>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class", "nav-item px-3");
            __builder.AddAttribute(48, "b-bbn4wlm9jg");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(49);
            __builder.AddAttribute(50, "class", "nav-link");
            __builder.AddAttribute(51, "href", "nurse");
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(53, "<h4 style=\"color:  #045df9  \" ; b-bbn4wlm9jg><span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-bbn4wlm9jg></span> Enfermera</h4>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "li");
            __builder.AddAttribute(56, "class", "nav-item px-3");
            __builder.AddAttribute(57, "b-bbn4wlm9jg");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(58);
            __builder.AddAttribute(59, "class", "nav-link");
            __builder.AddAttribute(60, "href", "eps");
            __builder.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(62, "<h4 style=\"color:  #045df9  \" ; b-bbn4wlm9jg><span class=\"oi oi-list\" aria-hidden=\"true\" b-bbn4wlm9jg></span> E P S</h4>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "li");
            __builder.AddAttribute(65, "class", "nav-item px-3");
            __builder.AddAttribute(66, "b-bbn4wlm9jg");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(67);
            __builder.AddAttribute(68, "class", "nav-link");
            __builder.AddAttribute(69, "href", "salir");
            __builder.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(71, "<h4 style=\"color:  #045df9  \" ; b-bbn4wlm9jg><span class=\"oi oi-loop\" aria-hidden=\"true\" b-bbn4wlm9jg></span> Salir</h4>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "F:\Home2Med\Home2Med-Code-1\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
