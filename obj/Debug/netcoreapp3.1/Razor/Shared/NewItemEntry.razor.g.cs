#pragma checksum "C:\Users\divid\Documents\C Development\Twitch Tools\Shared\NewItemEntry.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d31cf49525a4fd96dff789cdc4aac7afae9c10c"
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
#line 1 "C:\Users\divid\Documents\C Development\Twitch Tools\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\divid\Documents\C Development\Twitch Tools\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\divid\Documents\C Development\Twitch Tools\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\divid\Documents\C Development\Twitch Tools\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\divid\Documents\C Development\Twitch Tools\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\divid\Documents\C Development\Twitch Tools\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\divid\Documents\C Development\Twitch Tools\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\divid\Documents\C Development\Twitch Tools\_Imports.razor"
using Twitch_Tools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\divid\Documents\C Development\Twitch Tools\_Imports.razor"
using Twitch_Tools.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\divid\Documents\C Development\Twitch Tools\_Imports.razor"
using Twitch_Tools.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\divid\Documents\C Development\Twitch Tools\_Imports.razor"
using Twitch_Tools.Sql;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\divid\Documents\C Development\Twitch Tools\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\divid\Documents\C Development\Twitch Tools\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\divid\Documents\C Development\Twitch Tools\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class NewItemEntry : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "input=group input-group-lg");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"input-grou-prepend\">\r\n        <span class=\"input-group-text\">New Todo List</span>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "placeholder", "Enter your text here");
            __builder.AddAttribute(8, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\divid\Documents\C Development\Twitch Tools\Shared\NewItemEntry.razor"
                                                                                                                                           keyPressed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\divid\Documents\C Development\Twitch Tools\Shared\NewItemEntry.razor"
                                                                                            text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => text = __value, text));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "input-group-append");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn" + " btn-secondary" + " " + (
#nullable restore
#line 8 "C:\Users\divid\Documents\C Development\Twitch Tools\Shared\NewItemEntry.razor"
                                              buttonDisabled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\divid\Documents\C Development\Twitch Tools\Shared\NewItemEntry.razor"
                                                                        newItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Add (Enter)");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\divid\Documents\C Development\Twitch Tools\Shared\NewItemEntry.razor"
 
    string text { get; set; }
    string buttonDisabled => text != null && text.Length > 0 ? null : "disabled";

    [Parameter]
    public Action<string> onNewItem { get; set; }

    void newItem()
    {
        if (onNewItem != null)
        {
            onNewItem(text);
            text = "";
        }
    }

    void keyPressed(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            newItem();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591