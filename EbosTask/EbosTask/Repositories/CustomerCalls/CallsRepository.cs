using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using EbosTask.Common;
using EbosTask.Models;

namespace EbosTask.Repositories
{
    public class CallsRepository : ICallsRepository
    {
        public List<CallsModel> GetCalls()
        {
            List<CallsModel> lstCalls = new List<CallsModel>();

            using (SqlConnection con = SqlHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("Sp_GetCalls", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    if (dt.Columns.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            CallsModel cst = new CallsModel();

                            cst.Callid = Convert.ToInt32(dr["CallId"]);
                            cst.Customerno = Convert.ToInt64(dr["customerno"]);
                            cst.CustomerId = Guid.Parse(dr["customerId"].ToString());
                            cst.DateofCall = dr["dateofcall"].ToString();
                            cst.TimeofCall = dr["timeofcall"].ToString();
                            cst.Subject = dr["subject"].ToString();
                            cst.Description = dr["description"].ToString();
                            lstCalls.Add(cst);

                        }
                    }
                }
            }
            
            return lstCalls;

        }
        public int AddCall(CallsModel cust)
        {
            SqlConnection con = SqlHelper.GetConnection();

            SqlCommand com = new SqlCommand("SP_AddCall", con); 
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@customerId", cust.CustomerId);
            com.Parameters.AddWithValue("@dateofcall", Convert.ToDateTime( cust.DateofCall));
            com.Parameters.AddWithValue("@timeofcall", cust.TimeofCall);
            com.Parameters.AddWithValue("@subject", cust.Subject);
            com.Parameters.AddWithValue("@description", cust.Description);

            con.Open();
            int res = com.ExecuteNonQuery();
            con.Close();

            return res;

        }
        public bool UpdateCalls(CallsModel calls)
        {
            using (SqlConnection con = SqlHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SP_UpdateCall", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@callid", calls.Callid);
                    cmd.Parameters.AddWithValue("@customerid",  calls.CustomerId);
                    cmd.Parameters.AddWithValue("@dateofcall", Convert.ToDateTime(calls.DateofCall));
                    cmd.Parameters.AddWithValue("@timeofcall", calls.TimeofCall);
                    cmd.Parameters.AddWithValue("@subject", calls.Subject);
                    cmd.Parameters.AddWithValue("@description", calls.Description);

                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    con.Close();

                    if (i >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

        }
        public bool DeleteCall(int id)
        {

            using (SqlConnection con = SqlHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SP_DeleteCall", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@callsid", id);

                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    con.Close();

                    if (res >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

        }

        public  List<CustNumbers> GetCustNumbers()
        {
            List<CustNumbers> lstNumbers = new List<CustNumbers>();
            try
            {
                SqlConnection con = SqlHelper.GetConnection();
                {
                    SqlCommand cmd = new SqlCommand("SP_GetCustomerNumbers", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    foreach (DataRow dr in dt.Rows)
                    {
                        CustNumbers number = new CustNumbers();
                        number.CustId = dr["CustomerID"].ToString();
                        number.Customerno = dr["customerno"].ToString();
                        lstNumbers.Add(number);

                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstNumbers;
        }
    }
}
