using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelJop.DB
{
    interface IShiftData
    {
        Task<IEnumerable<ShiftData>> GetShift();
        Task<bool> CreateDataShift(ShiftData Shiftdat);
        Task<bool> EditDataShift(int id, ShiftData Shiftdat);
        Task<ShiftData> SingleDataShift(int id);
        Task<bool> DeleteDataShift(int id);
    }
}
