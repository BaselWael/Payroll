using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelJop.DB
{
    interface ILeavingDataService
    {
        Task<IEnumerable<LeavingData>> GetLeavingData();
        Task<bool> CreateDataLeaving(LeavingData Leavingdat);
        Task<bool> EditDataLeaving(int id, LeavingData Leavingdat);
        Task<LeavingData> SingleDataLeaving(int id);
        Task<bool> DeleteDataLeaving(int id);
        
    }
}
