#pragma checksum "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Setting\AllEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aadd9fbe33585b6a06ba3c3021ac2ee9dbc464a7"
// <auto-generated/>
#pragma warning disable 1591
namespace PersonnelJop.Pages.Setting
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\_Imports.razor"
using PersonnelJop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\_Imports.razor"
using PersonnelJop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Setting\AllEmployee.razor"
using DB;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/allempp")]
    public partial class AllEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Setting\AllEmployee.razor"
 if (datas == null)
{



#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 15 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Setting\AllEmployee.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddAttribute(3, "align", "center");
            __builder.AddAttribute(4, "style", "color: wheat;");
            __builder.AddMarkupContent(5, "<div class=\"row\"><div class=\"col\"><div class=\"mb-3\"><button class=\"btn btn-success\">اظهار</button>\r\n                    <button class=\"btn btn-info\">طباعه</button></div></div></div>\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddMarkupContent(12, @"<thead><tr><th scope=""col"">ID</th>
                            <th scope=""col"">name</th>
                            <th scope=""col"">phone</th>
                            <th scope=""col"">phone2</th>
                            <th scope=""col"">address</th>
                            <th scope=""col"">id</th>
                            <th scope=""col"">jop</th>
                            <th scope=""col"">salary</th>
                            <th scope=""col"">holiday</th></tr></thead>
                    ");
            __builder.OpenElement(13, "tbody");
#nullable restore
#line 46 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Setting\AllEmployee.razor"
                         foreach (var item in datas)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "tr");
            __builder.OpenElement(15, "th");
            __builder.AddAttribute(16, "scope", "row");
            __builder.AddContent(17, 
#nullable restore
#line 49 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Setting\AllEmployee.razor"
                                                 item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 50 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Setting\AllEmployee.razor"
                                     item.empname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 51 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Setting\AllEmployee.razor"
                                     item.empphone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 52 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Setting\AllEmployee.razor"
                                     item.empphone2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 53 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Setting\AllEmployee.razor"
                                     item.empaddress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 54 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Setting\AllEmployee.razor"
                                     item.empid

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 55 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Setting\AllEmployee.razor"
                                     item.empjoptype

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 56 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Setting\AllEmployee.razor"
                                     item.empsalary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                                ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 57 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Setting\AllEmployee.razor"
                                     item.empholiday

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Setting\AllEmployee.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Setting\AllEmployee.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Setting\AllEmployee.razor"
       
    IEnumerable<Data> datas;

    protected override async Task OnInitializedAsync()
    {
        datas = await DataService.GetData();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataService DataService { get; set; }
    }
}
#pragma warning restore 1591
