using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelJop.DB
{
    public class ShiftDataService : IShiftData
    {

        private readonly SqlConnectionConfiguration _configuration;
        public ShiftDataService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> CreateDataShift(ShiftData Shiftdat)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"insert into dbo.ShiftData (timefrom,timeto) values (@timefrom,@timeto)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { Shiftdat.timefrom, Shiftdat.timeto}, commandType: CommandType.Text);
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

        public async Task<bool> DeleteDataShift(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"delete from dbo.ShiftData where Id=@Id";
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

        public async Task<bool> EditDataShift(int id, ShiftData Shiftdat)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"update dbo.ShiftData set timefrom = @timefrom, timeto=@timeto where Id=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { Shiftdat.timefrom, Shiftdat.timeto, id }, commandType: CommandType.Text);
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



        public async Task<IEnumerable<ShiftData>> GetShift()
        {
            IEnumerable<ShiftData> Shiftdat;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.ShiftData";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    Shiftdat = await conn.QueryAsync<ShiftData>(query);

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
            return Shiftdat;
        }

        public async Task<ShiftData> SingleDataShift(int id)
        {
            ShiftData Shiftdat = new ShiftData();

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.incentives where Id =@Id";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    Shiftdat = await conn.QueryFirstOrDefaultAsync<ShiftData>(query, new { id }, commandType: CommandType.Text);
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
            return Shiftdat;
        }
    }
}
