using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace PersonnelJop.DB
{
    public class JopDataService : IJopDataService
    {
        private readonly SqlConnectionConfiguration _configuration;
        public JopDataService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool>  CreateDataJop(JopData Jopdat)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"insert into dbo.JopData (jop) values (@jop)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { Jopdat.jop }, commandType: CommandType.Text);
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

        public async Task<bool> DeleteDataJop(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"delete from dbo.JopData where Id=@Id";
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

        public async Task<bool> EditDataJop(int id, JopData Jopdat)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"update dbo.JopData set jop = @jop where Id=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { Jopdat.jop, id }, commandType: CommandType.Text);
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

        public async Task<IEnumerable<JopData>> GetDataJop()
        {
            IEnumerable<JopData> Jopdat;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.JopData";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    Jopdat = await conn.QueryAsync<JopData>(query);

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
            return Jopdat;
        }

        public async Task<JopData> SingleDataJop(int id)
        {
            JopData Jopdat = new JopData();

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.JopData where Id =@Id";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    Jopdat = await conn.QueryFirstOrDefaultAsync<JopData>(query, new { id }, commandType: CommandType.Text);
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
            return Jopdat;
        }
    }
}
