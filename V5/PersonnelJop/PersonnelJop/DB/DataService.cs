using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace PersonnelJop.DB
{
    public class DataService : IDataService
    {

            private readonly SqlConnectionConfiguration _configuration;
            public DataService(SqlConnectionConfiguration configuration)
            {
                _configuration = configuration;
            }



            public async Task<bool> CreateData(Data dat)
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    const string query = @"insert into dbo.Data (empname,empphone,empphone2,empaddress,empid,shiftfrom,shiftto,empjoptype,empsalary,empholiday,empshift) values (@empname,@empphone,@empphone2,@empaddress,@empid,@shiftfrom,@shiftto,@empjoptype,@empsalary,@empholiday,@empshift)";
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    try
                    {
                        await conn.ExecuteAsync(query, new { dat.empname, dat.empphone, dat.empphone2, dat.empaddress, dat.empid, dat.shiftfrom, dat.shiftto, dat.empjoptype, dat.empsalary, dat.empholiday,dat.empshift }, commandType: CommandType.Text);
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
                    const string query = @"delete from dbo.Data where Id=@Id";
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

            public async Task<bool> EditData(int id, Data dat)
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    const string query = @"update dbo.Data set empname = @empname, empphone = @empphone, empphone2 = @emppone2, empaddress = @empaddress, empid = @empid, shiftfrom = @shiftfrom, shiftto=@shiftto, empjoptype = @empjoptype, empsalary = @empsalary, empholiday = @empholiday, empshift = @empshift where Id=@Id";
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    try
                    {
                        await conn.ExecuteAsync(query, new { dat.empname, dat.empphone, dat.empphone2, dat.empaddress, dat.empid, dat.shiftfrom, dat.shiftto, dat.empjoptype, dat.empsalary, dat.empholiday,dat.empshift, id }, commandType: CommandType.Text);
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

            public async Task<IEnumerable<Data>> GetData()
            {
                IEnumerable<Data> datas;
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    const string query = @"select * from dbo.Data";

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    try
                    {
                        datas = await conn.QueryAsync<Data>(query);

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
                return datas;
            }

            public async Task<Data> SingleData(int id)
            {
                Data dataa = new Data();

                using (var conn = new SqlConnection(_configuration.Value))
                {
                    const string query = @"select * from dbo.Data where Id =@Id";

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    try
                    {
                        dataa = await conn.QueryFirstOrDefaultAsync<Data>(query, new { id }, commandType: CommandType.Text);
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
                return dataa;
            }
    }
}
