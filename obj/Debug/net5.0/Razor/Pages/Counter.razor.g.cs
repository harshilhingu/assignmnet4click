#pragma checksum "C:\Users\HARSHIL\blazor\BlazorApp\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61d4659869a5c4d9a6a7e936a6b197bf2ed1f545"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HARSHIL\blazor\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HARSHIL\blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HARSHIL\blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HARSHIL\blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HARSHIL\blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HARSHIL\blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HARSHIL\blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HARSHIL\blazor\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HARSHIL\blazor\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HARSHIL\blazor\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
#nullable restore
#line 5 "C:\Users\HARSHIL\blazor\BlazorApp\Pages\Counter.razor"
__builder.AddContent(3, currentCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\HARSHIL\blazor\BlazorApp\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "disabled", 
#nullable restore
#line 7 "C:\Users\HARSHIL\blazor\BlazorApp\Pages\Counter.razor"
                                                                      currentCount>19

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-primary");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\HARSHIL\blazor\BlazorApp\Pages\Counter.razor"
                                          ResetCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Reset");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn btn-primary");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\HARSHIL\blazor\BlazorApp\Pages\Counter.razor"
                                          DecrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "disabled", 
#nullable restore
#line 11 "C:\Users\HARSHIL\blazor\BlazorApp\Pages\Counter.razor"
                                                                      currentCount<1

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, "Click here");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\HARSHIL\blazor\BlazorApp\Pages\Counter.razor"
       
    private int currentCount = 1;

    private void IncrementCount()
    {
        currentCount++;
    }

    private void ResetCount()
    {
        currentCount = 0;
    }

    private void DecrementCount()
    {
        currentCount--;
    }
    public class Name
    {
        public string harshil { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
