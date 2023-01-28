using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelJop.DB
{
    public class DiscountDataService: IDiscountDataService
    {
        private readonly SqlConnectionConfiguration _configuration;
        public DiscountDataService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }



        public async Task<bool> CreateDataDiscount(DiscountData Discountdat)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"insert into dbo.Discount (empname,discountreason,discountval,discountdate) values (@empname,@discountreason,@discountval,@discountdate)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { Discountdat.empname, Discountdat.discountreason, Discountdat.discountval, Discountdat.discountdate }, commandType: CommandType.Text);
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

        public async Task<bool> DeleteDataDiscount(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"delete from dbo.Discount where Id=@Id";
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

        public async Task<bool> EditDataDiscount(int id, DiscountData Discountdat)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"update dbo.Discount set empname = @empname, discountreason = @discountreason, discountval = @discountval, discountdate = @discountdate where Id=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { Discountdat.empname, Discountdat.discountreason, Discountdat.discountval, Discountdat.discountdate, id }, commandType: CommandType.Text);
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

        public async Task<IEnumerable<DiscountData>> GetDataDiscount()
        {
            IEnumerable<DiscountData> Discountdatt;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.Discount";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    Discountdatt = await conn.QueryAsync<DiscountData>(query);

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
            return Discountdatt;
        }

        public async Task<DiscountData> SingleDataDiscount(int id)
        {
            DiscountData GetDataDiscount = new DiscountData();

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.Discount where Id =@Id";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    GetDataDiscount = await conn.QueryFirstOrDefaultAsync<DiscountData>(query, new { id }, commandType: CommandType.Text);
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
            return GetDataDiscount;
        }


    }
}
