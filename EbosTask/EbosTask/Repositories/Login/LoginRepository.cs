using EbosTask.Common;
using EbosTask.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EbosTask.Repositories.Login
{
    public class LoginRepository : ILoginRepository
    {
        public int LoginCheck(LoginModel user)
        {
            using (SqlConnection con = SqlHelper.GetConnection())
            {
                using (SqlCommand com = new SqlCommand("Sp_login", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@username", user.username);
                    com.Parameters.AddWithValue("@password", user.password);
                    com.Parameters.AddWithValue("@RoleId", Guid.Parse(user.RoleID));

                    SqlParameter oblogin = new SqlParameter();
                    oblogin.ParameterName = "@Isvalid";
                    oblogin.SqlDbType = SqlDbType.Bit;
                    oblogin.Direction = ParameterDirection.Output;
                    com.Parameters.Add(oblogin);

                    con.Open();
                    com.ExecuteNonQuery();
                    int res = Convert.ToInt32(oblogin.Value);
                    con.Close();


                    return res;
                }
            }
        }

        public List<Roles> GetRoles()
        {
            List<Roles> lstRoles = new List<Roles>();
            try
            {
                SqlConnection con = SqlHelper.GetConnection();
                {
                    SqlCommand cmd = new SqlCommand("SP_GetRoles", con);
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
                            Roles role = new Roles();
                            role.RoleID = dr["RoleID"].ToString();
                            role.RoleType = dr["RoleType"].ToString();
                            lstRoles.Add(role);

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstRoles;
        }
    }
}
