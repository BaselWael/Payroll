using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelJop.DB
{
    interface ILoansDataService
    {
        Task<IEnumerable<LoansData>> GetDataLoan();
        Task<bool> CreateDataLoan(LoansData Loansdat);
        Task<bool> EditDataLoan(int id, LoansData Loansdat);
        Task<LoansData> SingleDataLoan(int id);
        Task<bool> DeleteDataLoan(int id);
    }
}
