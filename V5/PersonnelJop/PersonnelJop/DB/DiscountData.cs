using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelJop.DB
{
    public class DiscountData
    {
        public string empname { get; set; }
        public string discountreason { get; set; }
        public string discountval { get; set; } = "0";
        public DateTime discountdate { get; set; }
    }
}
