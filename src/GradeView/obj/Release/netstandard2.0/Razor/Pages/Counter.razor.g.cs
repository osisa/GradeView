#pragma checksum "C:\Git\Gradeview\src\GradeView\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cb13ecdab24bf3ea8479b8c2d07c9e70a17817e"
// <auto-generated/>
#pragma warning disable 1591
namespace GradeView.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Git\Gradeview\src\GradeView\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Git\Gradeview\src\GradeView\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Git\Gradeview\src\GradeView\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Git\Gradeview\src\GradeView\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 5 "C:\Git\Gradeview\src\GradeView\_Imports.razor"
using GradeView;

#line default
#line hidden
#line 6 "C:\Git\Gradeview\src\GradeView\_Imports.razor"
using GradeView.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            builder.OpenElement(1, "p");
            builder.AddContent(2, "Current count: ");
            builder.AddContent(3, 
#line 5 "C:\Git\Gradeview\src\GradeView\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(4, "\r\n\r\n");
            builder.OpenElement(5, "button");
            builder.AddAttribute(6, "class", "btn btn-primary");
            builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 7 "C:\Git\Gradeview\src\GradeView\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
            ));
            builder.AddContent(8, "Click me");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 9 "C:\Git\Gradeview\src\GradeView\Pages\Counter.razor"
       
    int currentCount = 0;

    void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
