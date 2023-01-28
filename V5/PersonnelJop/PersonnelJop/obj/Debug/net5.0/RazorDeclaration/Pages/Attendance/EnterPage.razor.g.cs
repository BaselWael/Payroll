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
#line 3 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Attendance\EnterPage.razor"
using DB;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/enterr")]
    public partial class EnterPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Attendance\EnterPage.razor"
       


    private string errormessage { get; set; }
    private string SelectName { get; set; }
    private bool test { get; set; } = true;
    IEnumerable<AttendingData> Attendingdatas;
    AttendingData Attendingdat = new AttendingData();
    private DateTime date = DateTime.Now;
    private List<AttendListCalc> attendcalc = new List<AttendListCalc>();
    protected override void OnInitialized()
    {
        Attendingdat.empname = SelectName;
        Attendingdat.AttendsDate = date;
    }




    private void CreateDataAttending()
    {

        foreach (var item in Attendingdatas) //add all names and dates in list
        {
            if (item.empname == SelectName)
            {
                attendcalc.Add(new AttendListCalc
                {
                    attendnames = item.empname,
                    date = item.AttendsDate.ToShortDateString().ToString()
                });

            }
        }
        foreach(var item in attendcalc)
        {
            if(item.date == date.ToShortDateString())
            {
                test = false;
            }
        }
        if(test == false)
        {
            errormessage = "Ur Already signed in";
        }
        else
        {

            Attendingdat.empname = SelectName;
            AttendingDataService.CreateDataAttending(Attendingdat);
            errormessage = $"Done u signed in {DateTime.Now}";

        }
        //if(DateTime.Now.Day.ToString() == "1")
        //    {
        //        AttendingDataService.DeleteAllRows();
        //    }




    }


    IEnumerable<Data> datas;
    protected override async Task OnInitializedAsync()
    {
        datas = await DataService.GetData();
        Attendingdatas = await AttendingDataService.GetAttendingData();
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAttendingDataService AttendingDataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataService DataService { get; set; }
    }
}
#pragma warning restore 1591
