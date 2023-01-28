using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelJop.DB.Loans
{
    public class LoansDataService : ILoansDataService
    {
        private readonly SqlConnectionConfiguration _configuration;
        public LoansDataService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }



        public async Task<bool> CreateDataLoan(LoansData Loansdat)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"insert into dbo.Loans (empname,loansreason,loansval,loansdate) values (@empname,@loansreason,@loansval,@loansdate)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { Loansdat.empname, Loansdat.loansreason, Loansdat.loansval, Loansdat.loansdate }, commandType: CommandType.Text);
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

        public async Task<bool> DeleteDataLoan(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"delete from dbo.Loans where Id=@Id";
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

        public async Task<bool> EditDataLoan(int id, LoansData Loansdat)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"update dbo.Loans set empname = @empname, loansreason = @loansreason, loansval = @loansval, loansdate = @loansdate where Id=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { Loansdat.empname, Loansdat.loansreason, Loansdat.loansval, Loansdat.loansdate, id }, commandType: CommandType.Text);
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

        public async Task<IEnumerable<LoansData>> GetDataLoan()
        {
            IEnumerable<LoansData> Loansdatas;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.Loans";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    Loansdatas = await conn.QueryAsync<LoansData>(query);

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
            return Loansdatas;
        }

        public async Task<LoansData> SingleDataLoan(int id)
        {
            LoansData Loansdataa = new LoansData();

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.Loans where Id =@Id";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    Loansdataa = await conn.QueryFirstOrDefaultAsync<LoansData>(query, new { id }, commandType: CommandType.Text);
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
            return Loansdataa;
        }
    }
}
