using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelJop.DB
{
    interface IAllEmpSalary
    {
        Task<IEnumerable<allempsalary>> GetData();
        Task<bool> CreateData(allempsalary empsalary);
        Task<bool> EditData(int id, allempsalary empsalary);
        Task<allempsalary> SingleData(int id);
        Task<bool> DeleteData(int id);
    }
}
