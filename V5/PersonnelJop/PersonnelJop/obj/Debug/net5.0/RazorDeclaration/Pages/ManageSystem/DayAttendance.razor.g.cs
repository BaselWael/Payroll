// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PersonnelJop.Pages.ManageSystem
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
#line 2 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\DayAttendance.razor"
using DB;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dayattend")]
    public partial class DayAttendance : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\DayAttendance.razor"
       
    private string name { get; set; }
    private DateTime date { get; set; }
    private string attends { get; set; }
    private string leave { get; set; }
    private string SelectName { get; set; }
    IEnumerable<Data> datas;
    IEnumerable<AttendingData> Attendingdatas;
    IEnumerable<LeavingData> Leavingdatas;
    private List<string> atnd = new List<string>();
    private List<string> lvs = new List<string>();

    protected override async Task OnInitializedAsync()
    {
        datas = await DataService.GetData();
        Attendingdatas = await AttendingDataServices.GetAttendingData();
        Leavingdatas = await LeavingDataService.GetLeavingData();
    }
    private async void  GetDates()
    {
        foreach(var (attend,lev) in Attendingdatas.Zip(Leavingdatas))
        {
            
            if (attend.empname == lev.empname && attend.empname == SelectName && lev.empname == SelectName)
            {
                if (date.Month.ToString() == attend.AttendsDate.Month.ToString() && date.Month.ToString() == lev.LeavesDate.Month.ToString() && date.Year.ToString()
                    == attend.AttendsDate.Year.ToString() && date.Year.ToString() == lev.LeavesDate.Year.ToString())
                {
                    name = attend.empname;
                    atnd.Add(attend.AttendsDate.ToString());
                    lvs.Add(lev.LeavesDate.ToString());
                    

                }
            }


        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILeavingDataService LeavingDataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAttendingDataService AttendingDataServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataService DataService { get; set; }
    }
}
#pragma warning restore 1591
