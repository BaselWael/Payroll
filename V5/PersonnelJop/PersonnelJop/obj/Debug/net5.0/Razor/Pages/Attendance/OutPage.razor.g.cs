#pragma checksum "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Attendance\OutPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91eb2622d7ac2fef0ca3d897e1bcfbbbbc4f9fc3"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Attendance\OutPage.razor"
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
#nullable restore
#line 8 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Attendance\OutPage.razor"
 if (datas == null)
{



#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Attendance\OutPage.razor"
                           }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddAttribute(3, "align", "center");
            __builder.AddAttribute(4, "dir", "rtl");
            __builder.AddAttribute(5, "style", "color: wheat;");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col");
            __builder.OpenElement(10, "select");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Attendance\OutPage.razor"
                            SelectName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectName = __value, SelectName));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "selected");
            __builder.AddAttribute(15, "disabled");
            __builder.AddContent(16, "Choose Emplyee");
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Attendance\OutPage.razor"
                 foreach (var item in datas)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "option");
            __builder.AddContent(18, 
#nullable restore
#line 22 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Attendance\OutPage.razor"
         item.empname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Attendance\OutPage.razor"
                              }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "disabled");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Attendance\OutPage.razor"
                                    date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => date = __value, date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n    <hr>\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "row");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-success");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Attendance\OutPage.razor"
                                                      CreateDataLeaving

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "????????????");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n            ");
            __builder.OpenElement(38, "label");
            __builder.AddContent(39, 
#nullable restore
#line 37 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Attendance\OutPage.razor"
                    errormessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 132 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Attendance\OutPage.razor"
       
  }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\Attendance\OutPage.razor"
       
    private string errormessage { get; set; }
    private string SelectName { get; set; }
    private bool test { get; set; } = true;
    int num = 0;
    public List<LeaveCalc> leavecheck = new List<LeaveCalc>();
    LeavingData Leavingdat = new LeavingData();
    private DateTime date = DateTime.Now;
    private string er { get; set; }
    IEnumerable<LeavingData> Leavingdatas;
    protected override void OnInitialized()
    {

        Leavingdat.LeavesDate = date;
        Leavingdat.empname = SelectName;

    }
    private void CreateDataLeaving()
    {
        foreach (var item in Leavingdatas)
        {
            if (item.empname == SelectName)
            {
                leavecheck.Add(new LeaveCalc
                {
                    leavesname = item.empname,
                    date = item.LeavesDate.ToShortDateString().ToString()
                }) ;
            }
        }
        foreach(var item in leavecheck)
        {
            if(item.date == date.ToShortDateString())
            {
                test = false;
            }
        }
        if(test == false)
        {
            errormessage = "Ur Already Signed out";
        }

        else
        {
            foreach(var item in Attendingdatas)
            {
                if(SelectName == item.empname)
                {
                    er = $"day1 : {item.AttendsDate.Day} +day2: {date.Day} +month1: {item.AttendsDate.Month} +month2: {date.Month}";
                    if (item.AttendsDate.Day == date.Day && item.AttendsDate.Month == date.Month)
                    {
                        Leavingdat.empname = SelectName;
                        LeavingDataService.CreateDataLeaving(Leavingdat);
                        errormessage = $"Done u signed in {DateTime.Now}";
                        break;
                    }
                    else
                    {
                        errormessage = "you r not in to out";
                    }
                }




            }

        }

    }



    IEnumerable<Data> datas;
    IEnumerable<AttendingData> Attendingdatas;
    protected override async Task OnInitializedAsync()
    {
        datas = await DataService.GetData();
        Attendingdatas = await AttendingDataService.GetAttendingData();
        Leavingdatas = await LeavingDataService.GetLeavingData();

    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAttendingDataService AttendingDataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILeavingDataService LeavingDataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataService DataService { get; set; }
    }
}
#pragma warning restore 1591
