using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelJop.DB
{
    public class AllEmpSalaryService : IAllEmpSalary
    {
        private readonly SqlConnectionConfiguration _configuration;
        public AllEmpSalaryService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> CreateData(allempsalary empsalary)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"insert into dbo.allempsalary (empname,salary1,salary2,date) values (@empname,@salary1,@salary2,@date)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { empsalary.empname, empsalary.salary1,empsalary.salary2,empsalary.date }, commandType: CommandType.Text);
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

        public async Task<bool> DeleteData(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"delete from dbo.allempsalary where Id=@Id";
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

        public async Task<bool> EditData(int id, allempsalary empsalary)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"update dbo.allempsalary set empname = @empname, salary1=@salary1 , salary2 = @salary2 , date=@date where Id=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { empsalary.empname, empsalary.salary1,empsalary.salary2,empsalary.date, id }, commandType: CommandType.Text);
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

        public async Task<IEnumerable<allempsalary>> GetData()
        {
            IEnumerable<allempsalary> Getempsalary;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.allempsalary";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    Getempsalary = await conn.QueryAsync<allempsalary>(query);

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
            return Getempsalary;
        }

        public async Task<allempsalary> SingleData(int id)
        {
            allempsalary empsalary = new allempsalary();

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.allempsalary where Id =@Id";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    empsalary = await conn.QueryFirstOrDefaultAsync<allempsalary>(query, new { id }, commandType: CommandType.Text);
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
            return empsalary;
        }
    }
}
