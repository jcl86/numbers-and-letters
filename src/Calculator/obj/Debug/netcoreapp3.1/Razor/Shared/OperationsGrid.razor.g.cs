#pragma checksum "F:\DESARROLLO\Repos\calculator\src\Calculator\Shared\OperationsGrid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c615ec5984160234d3412f0f962bf84babc82be9"
// <auto-generated/>
#pragma warning disable 1591
namespace Calculator.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\DESARROLLO\Repos\calculator\src\Calculator\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\DESARROLLO\Repos\calculator\src\Calculator\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\DESARROLLO\Repos\calculator\src\Calculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\DESARROLLO\Repos\calculator\src\Calculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\DESARROLLO\Repos\calculator\src\Calculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\DESARROLLO\Repos\calculator\src\Calculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\DESARROLLO\Repos\calculator\src\Calculator\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\DESARROLLO\Repos\calculator\src\Calculator\_Imports.razor"
using Calculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\DESARROLLO\Repos\calculator\src\Calculator\_Imports.razor"
using Calculator.Shared;

#line default
#line hidden
#nullable disable
    public partial class OperationsGrid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-3");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "F:\DESARROLLO\Repos\calculator\src\Calculator\Shared\OperationsGrid.razor"
                          () => OperationSelected.InvokeAsync(Operator.Add)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "class", "btn btn-secondary px-4 py-2 text-white mr-4");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<span class=\"display-4\"><i class=\"fas fa-plus\"></i></span>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-3");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "F:\DESARROLLO\Repos\calculator\src\Calculator\Shared\OperationsGrid.razor"
                          () => OperationSelected.InvokeAsync(Operator.Substract)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "class", "btn btn-secondary px-4 py-2 text-white mr-4");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.AddMarkupContent(20, "<span class=\"display-4\"><i class=\"fas fa-minus\"></i></span>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-3");
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "F:\DESARROLLO\Repos\calculator\src\Calculator\Shared\OperationsGrid.razor"
                          () => OperationSelected.InvokeAsync(Operator.Multiply)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "class", "btn btn-secondary px-4 py-2 text-white mr-4");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.AddMarkupContent(30, "<span class=\"display-4\"><i class=\"fas fa-times\"></i></span>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-3");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "F:\DESARROLLO\Repos\calculator\src\Calculator\Shared\OperationsGrid.razor"
                          () => OperationSelected.InvokeAsync(Operator.Divide)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "class", "btn btn-secondary px-4 py-2 text-white");
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.AddMarkupContent(40, "<span class=\"display-4\"><i class=\"fas fa-divide\"></i></span>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "F:\DESARROLLO\Repos\calculator\src\Calculator\Shared\OperationsGrid.razor"
       

    [Parameter]
    public EventCallback<Operator> OperationSelected { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591