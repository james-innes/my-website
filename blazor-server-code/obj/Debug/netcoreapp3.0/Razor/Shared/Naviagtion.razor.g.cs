#pragma checksum "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\Shared\Naviagtion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fedba5e208be7cf50db94f7f98cb2cbc0867c53e"
// <auto-generated/>
#pragma warning disable 1591
namespace Website.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\_Imports.razor"
using Website.Shared;

#line default
#line hidden
#nullable disable
    public partial class Naviagtion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddMarkupContent(1, "\r\n      ");
            __builder.OpenElement(2, "nav");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "ul");
            __builder.AddMarkupContent(5, "\r\n          ");
            __builder.OpenElement(6, "li");
            __builder.AddMarkupContent(7, "\r\n              ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(8);
            __builder.AddAttribute(9, "href", "elements");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, "Elements");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n          ");
            __builder.OpenElement(14, "li");
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(16);
            __builder.AddAttribute(17, "href", "rws");
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(19, "Waldorf Education");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n\r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\James.INnes\source\repos\my-website\blazor-server-code\Shared\Naviagtion.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
