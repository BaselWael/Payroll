#pragma checksum "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31db3a48825f2a9a6f2d11dc7744ac9877b20bf2"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 15 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
 if (datas == null)
{



#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 20 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
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
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "mb-3");
            __builder.AddMarkupContent(12, "<label>اسم الموظف</label>\r\n                    ");
            __builder.OpenElement(13, "select");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
                                    Nameselected

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Nameselected = __value, Nameselected));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "selected");
            __builder.AddAttribute(18, "disabled");
            __builder.AddContent(19, "ChooseEmployee");
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
                         foreach (var item in datas)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "option");
            __builder.AddContent(21, 
#nullable restore
#line 34 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
                                     item.empname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "mb-3");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-success");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
                                                              calc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "بحث");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-info");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
                                                          save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "تسجيل");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "mb-3");
            __builder.OpenElement(37, "span");
            __builder.AddContent(38, 
#nullable restore
#line 45 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
                           msg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "container");
            __builder.AddAttribute(41, "dir", "rtl");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "row");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "mb-3");
            __builder.AddMarkupContent(48, "<label>المرتب</label>\r\n                            ");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "number");
            __builder.AddAttribute(51, "disabled");
            __builder.AddAttribute(52, "value", 
#nullable restore
#line 60 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
                                                                  SalaryVal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n                        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "mb-3");
            __builder.AddMarkupContent(56, "<label>صافي الايام</label>\r\n                            ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "text");
            __builder.AddAttribute(59, "disabled");
            __builder.AddAttribute(60, "value", 
#nullable restore
#line 65 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
                                                                val

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "mb-3");
            __builder.AddMarkupContent(64, "<label>صافي المرتب</label>\r\n                            ");
            __builder.OpenElement(65, "input");
            __builder.AddAttribute(66, "type", "text");
            __builder.AddAttribute(67, "disabled");
            __builder.AddAttribute(68, "value", 
#nullable restore
#line 70 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
                                                                valsal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "mb-3");
            __builder.AddAttribute(72, "dir", "rtl");
            __builder.OpenElement(73, "label");
            __builder.AddMarkupContent(74, "عدد ايام الحضور : ");
            __builder.AddContent(75, 
#nullable restore
#line 74 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
                                                      DayCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n                    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "col");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "mb-3");
            __builder.AddMarkupContent(81, "<label>مكافأات</label>\r\n                                    ");
            __builder.OpenElement(82, "input");
            __builder.AddAttribute(83, "type", "number");
            __builder.AddAttribute(84, "disabled");
            __builder.AddAttribute(85, "value", 
#nullable restore
#line 83 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
                                                                          IncentiveVal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                          \r\n                       \r\n                                ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "mb-3");
            __builder.AddMarkupContent(89, "<label>خصومات</label>\r\n                                    ");
            __builder.OpenElement(90, "input");
            __builder.AddAttribute(91, "type", "number");
            __builder.AddAttribute(92, "disabled");
            __builder.AddAttribute(93, "value", 
#nullable restore
#line 89 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
                                                                           Disc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n\r\n\r\n                       \r\n                        \r\n                                ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "mb-3");
            __builder.AddMarkupContent(97, "<label>سلف</label>\r\n                                    ");
            __builder.OpenElement(98, "input");
            __builder.AddAttribute(99, "type", "number");
            __builder.AddAttribute(100, "disabled");
            __builder.AddAttribute(101, "value", 
#nullable restore
#line 97 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
                                                                          LoanVal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 426 "C:\Users\bslwa\Desktop\V6 Desgin\V5\PersonnelJop\PersonnelJop\Pages\ManageSystem\Salary.razor"
     




}

#line default
#line hidden
#nullable disable
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
