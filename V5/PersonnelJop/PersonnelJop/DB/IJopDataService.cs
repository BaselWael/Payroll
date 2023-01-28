using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelJop.DB
{
    interface IJopDataService
    {
        Task<IEnumerable<JopData>> GetDataJop();
        Task<bool> CreateDataJop(JopData Jopdat);
        Task<bool> EditDataJop(int id, JopData Jopdat);
        Task<JopData> SingleDataJop(int id);
        Task<bool> DeleteDataJop(int id);
    }
}
