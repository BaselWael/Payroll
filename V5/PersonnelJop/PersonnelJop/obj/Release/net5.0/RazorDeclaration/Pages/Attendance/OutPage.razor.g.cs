// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PersonnelJop.Pages.Attendance
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\jop\mine\V3\PersonnelJop\PersonnelJop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\jop\mine\V3\PersonnelJop\PersonnelJop\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\jop\mine\V3\PersonnelJop\PersonnelJop\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\jop\mine\V3\PersonnelJop\PersonnelJop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\jop\mine\V3\PersonnelJop\PersonnelJop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\jop\mine\V3\PersonnelJop\PersonnelJop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\jop\mine\V3\PersonnelJop\PersonnelJop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\jop\mine\V3\PersonnelJop\PersonnelJop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\jop\mine\V3\PersonnelJop\PersonnelJop\_Imports.razor"
using PersonnelJop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\jop\mine\V3\PersonnelJop\PersonnelJop\_Imports.razor"
using PersonnelJop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\jop\mine\V3\PersonnelJop\PersonnelJop\Pages\Attendance\OutPage.razor"
using DB;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/out")]
    public partial class OutPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "F:\jop\mine\V3\PersonnelJop\PersonnelJop\Pages\Attendance\OutPage.razor"
       
    private string SelectName { get; set; }

    LeavingData Leavingdat = new LeavingData();
    private DateTime date = DateTime.Now;
    protected override void OnInitialized()
    {

        Leavingdat.LeavesDate = date;
    }
    protected async Task CreateDataAttending()
    {
        Leavingdat.empname = SelectName;
        await LeavingDataService.CreateDataLeaving(Leavingdat);

    }



    IEnumerable<Data> datas;
    protected override async Task OnInitializedAsync()
    {
        datas = await DataService.GetData();
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILeavingDataService LeavingDataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataService DataService { get; set; }
    }
}
#pragma warning restore 1591
