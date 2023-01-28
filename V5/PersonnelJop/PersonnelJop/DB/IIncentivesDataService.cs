using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelJop.DB
{
    interface IIncentivesDataService
    {
        Task<IEnumerable<IncentivesData>> GetDataIncentive();
        Task<bool> CreateDataIncentive(IncentivesData Incentivedat);
        Task<bool> EditDataIncentive(int id, IncentivesData Incentivedat);
        Task<IncentivesData> SingleDataIncentive(int id);
        Task<bool> DeleteDataIncentive(int id);
    }
}
