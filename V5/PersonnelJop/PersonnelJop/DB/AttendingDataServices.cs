using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelJop.DB
{
    public class AttendingDataServices : IAttendingDataService
    {
        private readonly SqlConnectionConfiguration _configuration;
        public AttendingDataServices(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> CreateDataAttending(AttendingData Attendingdat)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"insert into dbo.AttendingData (empname,AttendsDate) values (@empname,@AttendsDate)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { Attendingdat.empname, Attendingdat.AttendsDate }, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return true;
        }

        public async Task<bool> DeleteDataAttending(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"delete from dbo.AttendingData where Id=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { id }, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return true;
        }
        //public async Task<bool> DeleteAllRows()
        //{
        //    using(var conn = new SqlConnection(_configuration.Value))
        //    {
        //        const string query = @"truncate table AttendingData";
        //        if (conn.State == ConnectionState.Closed)
        //            conn.Open();
        //        try
        //        {
        //            await conn.ExecuteAsync(query, commandType: CommandType.Text);
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //        finally
        //        {
        //            if (conn.State == ConnectionState.Open)
        //                conn.Close();
        //        }
        //    }
        //    return true;
        
        //}

        public async Task<bool> EditDataAttending(int id, AttendingData Attendingdat)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"update dbo.AttendingData set empname = @empname, AttendsDate=@AttendsDate where Id=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { Attendingdat.empname, Attendingdat.AttendsDate, id }, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return true;
        }

        public async Task<IEnumerable<AttendingData>> GetAttendingData()
        {
            IEnumerable<AttendingData> Attendingdatas;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.AttendingData";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    Attendingdatas = await conn.QueryAsync<AttendingData>(query);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }

            }
            return Attendingdatas;
        }

        public async Task<AttendingData> SingleDataAttending(int id)
        {
            AttendingData Attendingdat = new AttendingData();

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.AttendingData where Id =@Id";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    Attendingdat = await conn.QueryFirstOrDefaultAsync<AttendingData>(query, new { id }, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return Attendingdat;
        }
        
    }
}
