#pragma checksum "F:\DESARROLLO\Repos\calculator\src\Calculator\Shared\NumbersGrid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15b0b867a7234c33626b51c85a0fd8e07db37450"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class NumbersGrid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "F:\DESARROLLO\Repos\calculator\src\Calculator\Shared\NumbersGrid.razor"
       
    [Parameter]
    public List<Number> Numbers { get; set; }

    [Parameter]
    public EventCallback<Number> OnNumberClicked { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
