#pragma checksum "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\Shared\Topmenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e07040736a9d526c2d16028aabda3cbb8438f5b"
// <auto-generated/>
#pragma warning disable 1591
namespace Twitch_Tools.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Twitch_Tools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Twitch_Tools.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Twitch_Tools.Shared.PreLogin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Twitch_Tools.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Twitch_Tools.Sql;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class Topmenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-md navbar-dark fixed-top bg-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href=\"#\">Insp</a>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "collapse navbar-collapse");
            __builder.AddAttribute(6, "id", "navbarCollapse");
            __builder.AddMarkupContent(7, "\r\n\t\t");
            __builder.AddMarkupContent(8, @"<ul class=""navbar-nav mr-auto"">
			<li class=""nav-item active"">
				<a class=""nav-link"" href=""#"">Home <span class=""sr-only"">(current)</span></a>
			</li>
			<li class=""nav-item"">
				<a class=""nav-link"" href=""#"">Link</a>
			</li>
			<li class=""nav-item"">
				<a class=""nav-link disabled"" href=""#"">Disabled</a>
			</li>
		</ul>
		");
            __builder.OpenElement(9, "form");
            __builder.AddAttribute(10, "class", "form-inline mt-2 mt-md-0");
            __builder.AddMarkupContent(11, "\r\n\t\t\t<input class=\"form-control mr-sm-2\" type=\"text\" placeholder=\"Search\" aria-label=\"Search\">\r\n\t\t\t");
            __builder.AddMarkupContent(12, "<button class=\"btn btn-outline-success my-2 my-sm-0\" type=\"submit\">Search</button>\r\n\t\t\t");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\Shared\Topmenu.razor"
                                          RegisterModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Register");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\t\t\t");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-primary");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\Shared\Topmenu.razor"
                                                      LoginModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\Shared\Topmenu.razor"
      
	void RegisterModal() => Modal.Show<RegisterModal>("Register");
       void LoginModal() => Modal.Show<LoginModal>("Login");

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
    }
}
#pragma warning restore 1591
