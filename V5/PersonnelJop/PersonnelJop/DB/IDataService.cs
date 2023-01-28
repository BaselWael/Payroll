using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelJop.DB
{
    interface IDataService
    {
        Task<IEnumerable<Data>> GetData();
        Task<bool> CreateData(Data dat);
        Task<bool> EditData(int id, Data dat);
        Task<Data> SingleData(int id);
        Task<bool> DeleteData(int id);
    }
}
