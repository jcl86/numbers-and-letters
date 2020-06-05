#pragma checksum "F:\DESARROLLO\Repos\calculator\src\Calculator\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da8dec607e0d5f9d93862cafe0a9cf632602f478"
// <auto-generated/>
#pragma warning disable 1591
namespace Calculator.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "d-flex align-items-end justify-content-between");
            __builder.AddMarkupContent(5, "\r\n\r\n        ");
            __builder.OpenComponent<Calculator.Shared.ObjetivePanel>(6);
            __builder.AddAttribute(7, "Objective", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "F:\DESARROLLO\Repos\calculator\src\Calculator\Pages\Index.razor"
                                  game.Objetive

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n\r\n\r\n");
#nullable restore
#line 11 "F:\DESARROLLO\Repos\calculator\src\Calculator\Pages\Index.razor"
         if (game.IsStarted)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "bg-light d-flex justify-content-start");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "F:\DESARROLLO\Repos\calculator\src\Calculator\Pages\Index.razor"
                                  () => game.RestartGame()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "class", "btn btn-outline-secondary");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, "<span class=\"mr-2\"><i class=\"fas fa-redo-alt\"></i></span>Begin again\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 18 "F:\DESARROLLO\Repos\calculator\src\Calculator\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenComponent<Calculator.Shared.CurrentCalculation>(21);
            __builder.AddAttribute(22, "Calculation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Calculator.Calculation>(
#nullable restore
#line 20 "F:\DESARROLLO\Repos\calculator\src\Calculator\Pages\Index.razor"
                                         game.CurrentCalculation

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n    <br>\r\n\r\n    ");
            __builder.OpenComponent<Calculator.Shared.NumbersGrid>(25);
            __builder.AddAttribute(26, "Numbers", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Calculator.Number>>(
#nullable restore
#line 26 "F:\DESARROLLO\Repos\calculator\src\Calculator\Pages\Index.razor"
                          game.Numbers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "OnNumberClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Calculator.Number>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Calculator.Number>(this, 
#nullable restore
#line 26 "F:\DESARROLLO\Repos\calculator\src\Calculator\Pages\Index.razor"
                                                         NumberClicked

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n\r\n    <br>\r\n\r\n    ");
            __builder.OpenComponent<Calculator.Shared.OperationsGrid>(29);
            __builder.AddAttribute(30, "OperationSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Calculator.Operator>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Calculator.Operator>(this, 
#nullable restore
#line 30 "F:\DESARROLLO\Repos\calculator\src\Calculator\Pages\Index.razor"
                                       OnOperationClicked

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n\r\n    ");
            __builder.OpenComponent<Calculator.Shared.ResultsGrid>(32);
            __builder.AddAttribute(33, "OnNumberClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Calculator.CalculatedNumber>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Calculator.CalculatedNumber>(this, 
#nullable restore
#line 32 "F:\DESARROLLO\Repos\calculator\src\Calculator\Pages\Index.razor"
                                  CalculatedNumberClicked

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(34, "Numbers", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Calculator.CalculatedNumber>>(
#nullable restore
#line 32 "F:\DESARROLLO\Repos\calculator\src\Calculator\Pages\Index.razor"
                                                                    game.CalculatedNumbers

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n\r\n    ");
            __builder.OpenComponent<Calculator.Shared.AchievementMessage>(36);
            __builder.AddAttribute(37, "Message", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Calculator.Message>(
#nullable restore
#line 34 "F:\DESARROLLO\Repos\calculator\src\Calculator\Pages\Index.razor"
                                 game.Message

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n\r\n    ");
            __builder.OpenComponent<Calculator.Shared.CalculationList>(39);
            __builder.AddAttribute(40, "List", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Calculator.Calculation>>(
#nullable restore
#line 36 "F:\DESARROLLO\Repos\calculator\src\Calculator\Pages\Index.razor"
                           game.CalculationList

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "F:\DESARROLLO\Repos\calculator\src\Calculator\Pages\Index.razor"
 
    private Game game;

    protected override void OnInitialized()
    {
        game = new Game(gamePreparer);
    }

    private void OnOperationClicked(Operator @operator)
    {
        if (!game.CurrentCalculation.IsFilled)
        {
            game.CurrentCalculation.SetOperator(@operator);
            game.Resolve();
        }
    }

    private void NumberClicked(Number number)
    {
        if (!game.CurrentCalculation.IsFilled)
        {
            game.CurrentCalculation.SetNumber(number);
            game.Resolve();
        }
    }

    private void CalculatedNumberClicked(Calculator.CalculatedNumber number)
    {
        if (!game.CurrentCalculation.IsFilled)
        {
            game.CurrentCalculation.SetNumber(number);
            game.Resolve();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGamePreparer gamePreparer { get; set; }
    }
}
#pragma warning restore 1591
