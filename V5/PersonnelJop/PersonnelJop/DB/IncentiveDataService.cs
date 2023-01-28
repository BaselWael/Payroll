using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelJop.DB
{
    public class IncentiveDataService : IIncentivesDataService
    {
        private readonly SqlConnectionConfiguration _configuration;
        public IncentiveDataService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }



        public async Task<bool> CreateDataIncentive(IncentivesData Incentivedat)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"insert into dbo.incentives (empname,empreason,incentivesval,incentivesdate) values (@empname,@empreason,@incentivesval,@incentivesdate)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { Incentivedat.empname, Incentivedat.empreason, Incentivedat.incentivesval, Incentivedat.incentivesdate }, commandType: CommandType.Text);
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

        public async Task<bool> DeleteDataIncentive(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"delete from dbo.incentives where Id=@Id";
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

        public async Task<bool> EditDataIncentive(int id, IncentivesData Incentivedat)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"update dbo.incentives set empname = @empname, empreason = @empreason, incentivesval = @incentivesval, incentivesdate = @incentivesdate where Id=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { Incentivedat.empname, Incentivedat.empreason, Incentivedat.incentivesval, Incentivedat.incentivesdate, id }, commandType: CommandType.Text);
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

        public async Task<IEnumerable<IncentivesData>> GetDataIncentive()
        {
            IEnumerable<IncentivesData> Incentivedatt;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.incentives";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    Incentivedatt = await conn.QueryAsync<IncentivesData>(query);

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
            return Incentivedatt;
        }

        public async Task<IncentivesData> SingleDataIncentive(int id)
        {
            IncentivesData Incentivedat = new IncentivesData();

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.incentives where Id =@Id";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    Incentivedat = await conn.QueryFirstOrDefaultAsync<IncentivesData>(query, new { id }, commandType: CommandType.Text);
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
            return Incentivedat;
        }
    }
}
