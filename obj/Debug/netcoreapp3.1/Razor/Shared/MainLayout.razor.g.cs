#pragma checksum "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b03fb7b4b9da2967f7b9440b78e854426fa7e5a"
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
#line 11 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Twitch_Tools.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Twitch_Tools.Sql;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazored.Modal.BlazoredModal>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "header");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<Twitch_Tools.Shared.Topmenu>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "main");
            __builder.AddAttribute(8, "role", "main");
            __builder.AddAttribute(9, "class", "container h-100");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.AddContent(11, 
#nullable restore
#line 10 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "footer");
            __builder.AddAttribute(15, "class", "footer");
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenComponent<Twitch_Tools.Shared.Footer>(17);
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
