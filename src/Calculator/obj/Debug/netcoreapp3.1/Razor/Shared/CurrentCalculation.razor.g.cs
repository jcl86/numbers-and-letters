#pragma checksum "F:\DESARROLLO\Repos\calculator\src\Calculator\Shared\CurrentCalculation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "933a979a4fd5a32578478470df443654c48114af"
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
    public partial class CurrentCalculation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex align-items-center flex-column mt-2");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 2 "F:\DESARROLLO\Repos\calculator\src\Calculator\Shared\CurrentCalculation.razor"
     if (!Calculation.IsEmpty)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.AddMarkupContent(4, "<span>Current calculation</span>\r\n        ");
            __builder.OpenElement(5, "span");
            __builder.AddAttribute(6, "class", "display-4 px-4 py-2 bg-ligth text-info d-flex align-items-center justify-content-between bg-light");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.AddContent(8, 
#nullable restore
#line 6 "F:\DESARROLLO\Repos\calculator\src\Calculator\Shared\CurrentCalculation.razor"
             Calculation.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "F:\DESARROLLO\Repos\calculator\src\Calculator\Shared\CurrentCalculation.razor"
                              () => Calculation.Restart()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "class", "btn btn-lg bt-light text-danger ml-4");
            __builder.AddMarkupContent(13, "\r\n                <i class=\"fas fa-trash-alt\"></i>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 12 "F:\DESARROLLO\Repos\calculator\src\Calculator\Shared\CurrentCalculation.razor"
         if (Calculation.IsFilled && !Calculation.CanBeOperated())
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "alert alert-danger p-2");
            __builder.AddAttribute(19, "role", "alert");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.AddContent(21, 
#nullable restore
#line 15 "F:\DESARROLLO\Repos\calculator\src\Calculator\Shared\CurrentCalculation.razor"
                 Calculation.ErrorText

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 17 "F:\DESARROLLO\Repos\calculator\src\Calculator\Shared\CurrentCalculation.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "F:\DESARROLLO\Repos\calculator\src\Calculator\Shared\CurrentCalculation.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "F:\DESARROLLO\Repos\calculator\src\Calculator\Shared\CurrentCalculation.razor"
       
    [Parameter]
    public Calculation Calculation { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
