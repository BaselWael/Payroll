using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelJop.DB
{
    interface IAttendingDataService
    {
        Task<IEnumerable<AttendingData>> GetAttendingData();
        Task<bool> CreateDataAttending(AttendingData Attendingdat);
        Task<bool> EditDataAttending(int id, AttendingData Attendingdat);
        Task<AttendingData> SingleDataAttending(int id);
        Task<bool> DeleteDataAttending(int id);
        //Task<bool> DeleteAllRows();
    }
}
