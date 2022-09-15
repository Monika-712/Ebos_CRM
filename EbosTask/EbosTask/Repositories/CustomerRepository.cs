using EbosTask.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using EbosTask.Common;

namespace EbosTask.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        public int CreateCustomer(CustomersModel cust)
        {

            SqlConnection con = SqlHelper.GetConnection();

            SqlCommand com = new SqlCommand("Sp_Insertcustomer", con); //SqlHelper.GetConnection() //calling sql connecting string
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@customerno", cust.CustomerNo);
            com.Parameters.AddWithValue("@customername", cust.CustomerName);
            com.Parameters.AddWithValue("@customersurname", cust.Customersurname);
            com.Parameters.AddWithValue("@address", cust.Address);
            com.Parameters.AddWithValue("@country", cust.Country);
            com.Parameters.AddWithValue("@dateofbirth", cust.DateofBirth);
            com.Parameters.AddWithValue("@postcode", cust.PostCode);
            con.Open();
            int res = com.ExecuteNonQuery();
            con.Close();
            return res;


        }

        public List<CustomersModel> getCustomer()
        {
            List<CustomersModel> lst = new List<CustomersModel>();

            SqlConnection con = SqlHelper.GetConnection();
            {
                SqlCommand cmd = new SqlCommand("Sp_GetCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                con.Open();
                da.Fill(dt);
                con.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    CustomersModel cst = new CustomersModel();

                    cst.CustomerId =Guid.Parse(dr["customerId"].ToString());
                    cst.CustomerNo = Convert.ToInt64(dr["customerno"]);
                    cst.CustomerName = dr["customername"].ToString();
                    cst.Customersurname = dr["customersurname"].ToString();
                    cst.Address = dr["address"].ToString();
                    cst.PostCode = dr["postcode"].ToString();
                    cst.Country = dr["country"].ToString();
                    cst.DateofBirth = dr["DateofBirth"].ToString();
                    lst.Add(cst);

                }
            }


            return lst;
        }
        public bool DeleteCustomer(Guid id)
        {

            SqlConnection con = SqlHelper.GetConnection();
            SqlCommand cmd = new SqlCommand("SP_DeleteCust", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerId", id);
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
        public bool UpdateCustomer(CustomersModel cust)
        {

            SqlConnection con = SqlHelper.GetConnection();
            SqlCommand cmd = new SqlCommand("SP_UpdateCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerId", cust.CustomerId);
            cmd.Parameters.AddWithValue("@customerno", cust.CustomerNo);
            cmd.Parameters.AddWithValue("@customername", cust.CustomerName);
            cmd.Parameters.AddWithValue("@customersurname", cust.Customersurname);
            cmd.Parameters.AddWithValue("@address", cust.Address);
            cmd.Parameters.AddWithValue("@country", cust.Country);
            cmd.Parameters.AddWithValue("@dateofbirth", cust.DateofBirth);
            cmd.Parameters.AddWithValue("@postcode", cust.PostCode);

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
