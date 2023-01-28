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
#line 3 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
using DB;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Empsalaryy")]
    public partial class Salary : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
       
    private string msg { get; set; }
    private DateTime date = DateTime.Now;

    private int DayCount { get; set; }
    private DateTime Attend { get; set; }
    private DateTime Leave { get; set; }
    private double   duration { get; set; }
    private double SalaryVal { get; set; }
    private double SalaryValMonthly { get; set; }
    private int Disc { get; set; }
    private int IncentiveVal { get; set; }
    private int LoanVal { get; set; }
    private double val { get; set; }
    private double valsal { get; set; }

    private string Nameselected { get; set; }
    private double DayCalc { get; set; }
    public List<DateListCalc> DateList = new List<DateListCalc>();
    public List<DateListLeaveCalc> DateListLeave = new List<DateListLeaveCalc>();
    public allempsalary empsalary = new allempsalary();
    IEnumerable<allempsalary> Getempsalary;
    IEnumerable<Data> datas;
    IEnumerable<LoansData> Loansdatas;
    IEnumerable<IncentivesData> Incentivedat;
    IEnumerable<DiscountData> Discountdatt;
    IEnumerable<AttendingData> Attendingdatas;
    IEnumerable<LeavingData> Leavingdatas;

    protected override void OnInitialized()
    {

    }

    protected override async Task OnInitializedAsync()
    {

        Loansdatas = await LoansDataService.GetDataLoan();

        Discountdatt = await DiscountDataService.GetDataDiscount();
        Incentivedat = await IncentiveDataService.GetDataIncentive();
        datas = await DataService.GetData();
        Attendingdatas = await AttendingDataService.GetAttendingData();
        Leavingdatas = await LeavingDataService.GetLeavingData();
    }
    protected void calc()
    {
        msg = " ";
        DateList.Clear();
        DateListLeave.Clear();

        duration = 0;
        SalaryVal = 0;
        Disc = 0;
        IncentiveVal = 0;
        LoanVal = 0;
        val = 0;
        valsal = 0;
        foreach (var item in datas)
        {
            if(item.empname == Nameselected)
            {
                SalaryVal = int.Parse(item.empsalary);
            }
        }
        foreach(var item in Loansdatas)
        {
            if(item.empname == Nameselected)
            {
                LoanVal += int.Parse(item.loansval);

            }

        }
        foreach(var item in Incentivedat)
        {
            if(Nameselected == item.empname)
            {
                IncentiveVal += int.Parse(item.incentivesval);
            }

        }
        foreach(var item in Discountdatt)
        {

            if(item.empname == Nameselected)
            {
                Disc +=  int.Parse(item.discountval);
            }

        }
        foreach (var item in Attendingdatas)
        {
            if (item.empname == Nameselected)
            {
                if (item.AttendsDate.Month.ToString() == DateTime.Now.Month.ToString()) //If we are in the same month to calculate Day
                {
                    foreach(var lev in Leavingdatas)
                    {
                        if(lev.empname == Nameselected)
                        {
                            if (item.AttendsDate.Day.ToString() == lev.LeavesDate.Day.ToString())
                            {
                                DateList.Add(new DateListCalc
                                {
                                    date = item.AttendsDate
                                });
                            }
                        }
                    }



                }


            }
        }
        foreach(var item in Leavingdatas)
        {
            if(item.empname == Nameselected)
            {
                if(item.LeavesDate.Month.ToString() == DateTime.Now.Month.ToString()) //If we are in the same month to calculate Day
                {
                    foreach(var atend in Attendingdatas)
                    {
                        if(atend.empname == Nameselected)
                        {
                            if(item.LeavesDate.Day.ToString() == atend.AttendsDate.Day.ToString()) //Check if the day is the same day for attend and leaving in the same month to calculate
                            {
                                DateListLeave.Add(new DateListLeaveCalc
                                {
                                    date = item.LeavesDate
                                });
                            }
                        }
                    }

                }

            }
        }
        DayCount = DateList.Count();
        foreach(var (atend,leave) in DateListLeave.Zip(DateList) ) //looping all days together (attend,leave) to calculate salary
        {


            duration += atend.date.Subtract(leave.date).TotalMinutes;


        }




        DayCalc = SalaryVal / 26 / 8 / 60 * duration;


        val = DayCalc;
        valsal = DayCalc + IncentiveVal - Disc - LoanVal;

        //val = SalaryVal + IncentiveVal - LoanVal - Disc;



    }

    private void save()
    {

        int datyear = date.Year;
        int datmonth = date.Month;
        var firstDayOfMonth = new DateTime(datyear, datmonth, 1);
        var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

        if (DateTime.Now.Day.ToString() == lastDayOfMonth.ToString().Split("/")[1]) //To Save the salary in table for every month
        {
            DateList.Clear();
            DateListLeave.Clear();

            duration = 0;
            Disc = 0;
            IncentiveVal = 0;
            LoanVal = 0;
            val = 0;
            valsal = 0;
            foreach (var item in datas)
            {

                foreach (var itemLoan in Loansdatas)
                {
                    if (item.empname == itemLoan.empname)
                    {
                        LoanVal += int.Parse(itemLoan.loansval);

                    }

                }
                foreach (var itemIncen in Incentivedat)
                {
                    if (item.empname == itemIncen.empname)
                    {
                        IncentiveVal += int.Parse(itemIncen.incentivesval);
                    }

                }
                foreach (var itemDisc in Discountdatt)
                {

                    if (item.empname == itemDisc.empname)
                    {
                        Disc += int.Parse(itemDisc.discountval);
                    }

                }
                foreach (var itemAttend in Attendingdatas)
                {
                    if (item.empname == itemAttend.empname)
                    {
                        if (itemAttend.AttendsDate.Month.ToString() == DateTime.Now.Month.ToString()) //If we are in the same month to calculate Day
                        {
                            foreach (var lev in Leavingdatas)
                            {
                                if (lev.empname == item.empname)
                                {
                                    if (itemAttend.AttendsDate.Day.ToString() == lev.LeavesDate.Day.ToString())
                                    {
                                        DateList.Add(new DateListCalc
                                        {
                                            date = itemAttend.AttendsDate
                                        });
                                    }
                                }
                            }

                        }


                    }
                }
                foreach (var itemLeave in Leavingdatas)
                {
                    if (item.empname == itemLeave.empname)
                    {
                        if (itemLeave.LeavesDate.Month.ToString() == DateTime.Now.Month.ToString()) //If we are in the same month to calculate Day
                        {
                            foreach (var atend in Attendingdatas)
                            {
                                if (atend.empname == item.empname)
                                {
                                    if (itemLeave.LeavesDate.Day.ToString() == atend.AttendsDate.Day.ToString()) //Check if the day is the same day for attend and leaving in the same month to calculate
                                    {
                                        DateListLeave.Add(new DateListLeaveCalc
                                        {
                                            date = itemLeave.LeavesDate
                                        });
                                    }
                                }
                            }

                        }

                    }
                }

                DayCount = DateList.Count();
                foreach (var (atend, leave) in DateListLeave.Zip(DateList)) //looping all days together (attend,leave) to calculate salary
                {


                    duration += atend.date.Subtract(leave.date).TotalMinutes;


                }
                DayCount = DateList.Count();
                foreach (var (atend, leave) in DateListLeave.Zip(DateList)) //looping all days together (attend,leave) to calculate salary
                {


                    duration += atend.date.Subtract(leave.date).TotalMinutes;


                }




                DayCalc = double.Parse(item.empsalary) / 26.0 / 8.0 / 60.0 * (duration/2.0);


                val = DayCalc;
                double n = 10000 / 26 / 8 / 60;
                valsal = DayCalc + IncentiveVal - Disc - LoanVal;

                //val = SalaryVal + IncentiveVal - LoanVal - Disc;
                empsalary.empname = item.empname;
                empsalary.salary1 = val.ToString();
                empsalary.salary2 = valsal.ToString();
                empsalary.date = date.ToShortDateString();
                AllEmpSalaryService.CreateData(empsalary);


            }


        }
        else
        {

            msg = "wait for last day in the month";
        }
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAllEmpSalary AllEmpSalaryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILeavingDataService LeavingDataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAttendingDataService AttendingDataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IIncentivesDataService IncentiveDataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDiscountDataService DiscountDataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataService DataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoansDataService LoansDataService { get; set; }
    }
}
#pragma warning restore 1591
