using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelJop.DB
{
    interface IDiscountDataService
    {
        Task<IEnumerable<DiscountData>> GetDataDiscount();
        Task<bool> CreateDataDiscount(DiscountData Discountdat);
        Task<bool> EditDataDiscount(int id, DiscountData Discountdat);
        Task<DiscountData> SingleDataDiscount(int id);
        Task<bool> DeleteDataDiscount(int id);
    }
}
