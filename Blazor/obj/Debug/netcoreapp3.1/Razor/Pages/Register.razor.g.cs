#pragma checksum "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b17d47560f727a3044579b130dc7309c4eabf7"
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
#nullable restore
#line 3 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\Pages\Register.razor"
using Twitch_Tools.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Shared.PreLogin.PreLoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col rounded bg-info py-5");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\Pages\Register.razor"
                      newUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\Pages\Register.razor"
                                               InsertUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.AddMarkupContent(15, "<label for=\"email\">Email</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "id", "emailAddress");
                __builder2.AddAttribute(18, "type", "email");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "palceholder", "Email Address");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\Pages\Register.razor"
                                                                                                                    newUser.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newUser.EmailAddress = __value, newUser.EmailAddress))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newUser.EmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.AddMarkupContent(29, "<label for=\"password\">Password</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "id", "password");
                __builder2.AddAttribute(32, "type", "password");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\Pages\Register.razor"
                                                                                       newUser.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newUser.Password = __value, newUser.Password))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newUser.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n\r\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.AddMarkupContent(42, "<label for=\"password\">Confirm Password</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                __builder2.AddAttribute(44, "id", "confirmPassword");
                __builder2.AddAttribute(45, "type", "password");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\Pages\Register.razor"
                                                                                              newUser.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newUser.ConfirmPassword = __value, newUser.ConfirmPassword))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newUser.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n        ");
                __builder2.AddMarkupContent(52, "<div class=\"text-right\">\r\n            <button type=\"submit\" class=\"btn btn-primary col-4\">Register</button>\r\n        </div>\r\n\r\n        ");
                __builder2.AddMarkupContent(53, "<div class=\"mt-3\">\r\n            <p>Already have an account <a href=\"Login\" type=\"button\">Login</a></p>\r\n        </div>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.AddMarkupContent(56, "<div class=\"col-5\">\r\n    Sign In\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\divid\Documents\C Development\Twitch Tools\Blazor\Pages\Register.razor"
      
    private UserModel newUser = new UserModel();

    private async Task InsertUser()
    {

        UserModel newU = new UserModel()
        {
            EmailAddress = newUser.EmailAddress,
            Password = newUser.Password,
            ConfirmPassword = newUser.ConfirmPassword
        };

        await _db.InsertUser(newU);

        newUser = new UserModel();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleData _db { get; set; }
    }
}
#pragma warning restore 1591
