#pragma checksum "/Users/tayyabjaved/Documents/blazorprojects/002/BlazorApp/Pages/Paths.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3a7f5b8be8d510117c5f877b777ec72fedbdc1f"
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
#line 1 "/Users/tayyabjaved/Documents/blazorprojects/002/BlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/tayyabjaved/Documents/blazorprojects/002/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/tayyabjaved/Documents/blazorprojects/002/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/tayyabjaved/Documents/blazorprojects/002/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/tayyabjaved/Documents/blazorprojects/002/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/tayyabjaved/Documents/blazorprojects/002/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/tayyabjaved/Documents/blazorprojects/002/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/tayyabjaved/Documents/blazorprojects/002/BlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/tayyabjaved/Documents/blazorprojects/002/BlazorApp/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/tayyabjaved/Documents/blazorprojects/002/BlazorApp/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/paths")]
    public partial class Paths : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Paths</h1>\n\n\n");
            __builder.OpenElement(1, "li");
            __builder.AddContent(2, 
#nullable restore
#line 12 "/Users/tayyabjaved/Documents/blazorprojects/002/BlazorApp/Pages/Paths.razor"
 course1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenElement(4, "p");
            __builder.AddAttribute(5, "style", "border:2px solid black;padding:30px;");
            __builder.AddContent(6, "Current count: ");
            __builder.AddContent(7, 
#nullable restore
#line 15 "/Users/tayyabjaved/Documents/blazorprojects/002/BlazorApp/Pages/Paths.razor"
                                                                currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n\n");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn btn-primary");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "/Users/tayyabjaved/Documents/blazorprojects/002/BlazorApp/Pages/Paths.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "/Users/tayyabjaved/Documents/blazorprojects/002/BlazorApp/Pages/Paths.razor"
      
    private String course1="one";

 

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/tayyabjaved/Documents/blazorprojects/002/BlazorApp/Pages/Paths.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
