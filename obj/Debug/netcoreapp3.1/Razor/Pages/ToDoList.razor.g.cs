#pragma checksum "C:\Users\divid\Documents\C Development\Twitch Tools\Pages\ToDoList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9463d22b3cf8bdfe8507510effbee31e5b2a9ac3"
// <auto-generated/>
#pragma warning disable 1591
namespace Twitch_Tools.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ToDoList")]
    public partial class ToDoList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>ToDoList:</h1>\r\n");
            __builder.OpenComponent<Twitch_Tools.Shared.TodoList>(1);
            __builder.AddAttribute(2, "todos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IList<Twitch_Tools.Model.Todo>>(
#nullable restore
#line 4 "C:\Users\divid\Documents\C Development\Twitch Tools\Pages\ToDoList.razor"
                  todos

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\divid\Documents\C Development\Twitch Tools\Pages\ToDoList.razor"
 
    IList<Todo> todos = new List<Todo>
    {
    new Todo {text = "component 1"},
    new Todo {text = "component 2"}
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
