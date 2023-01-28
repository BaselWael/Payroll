using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelJop.DB
{
    public class LeavingDataService : ILeavingDataService
    {
        private readonly SqlConnectionConfiguration _configuration;
        public LeavingDataService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> CreateDataLeaving(LeavingData Leavingdat)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"insert into dbo.LeavingData (empname,LeavesDate) values (@empname,@LeavesDate)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { Leavingdat.empname, Leavingdat.LeavesDate }, commandType: CommandType.Text);
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

        public async Task<bool> DeleteDataLeaving(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"delete from dbo.LeavingData where Id=@Id";
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
        //    using (var conn = new SqlConnection(_configuration.Value))
        //    {
        //        const string query = @"truncate table LeavingData";
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

        public async Task<bool> EditDataLeaving(int id, LeavingData Leavingdat)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"update dbo.LeavingData set empname = @empname, LeavesDate=@LeavesDate where Id=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { Leavingdat.empname, Leavingdat.LeavesDate, id }, commandType: CommandType.Text);
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

        public async Task<IEnumerable<LeavingData>> GetLeavingData()
        {
            IEnumerable<LeavingData> Leavingdatas;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.LeavingData";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    Leavingdatas = await conn.QueryAsync<LeavingData>(query);

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
            return Leavingdatas;
        }

        public async Task<LeavingData> SingleDataLeaving(int id)
        {
            LeavingData Leavingdat = new LeavingData();

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.LeavingData where Id =@Id";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    Leavingdat = await conn.QueryFirstOrDefaultAsync<LeavingData>(query, new { id }, commandType: CommandType.Text);
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
            return Leavingdat;
        }
    }
}
