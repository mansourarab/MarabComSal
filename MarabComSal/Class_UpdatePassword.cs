using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MarabComSal
{
    class Class_UpdatePassword
    {
        SqlConnection channel;
        SqlCommand que;


        public Class_UpdatePassword()
        {
            channel = new SqlConnection(@"data source=COMMANDERMN9\SQLEXPRESS;initial catalog=Marab Company;integrated security=true;");
            que = new SqlCommand();
        }

        public int UpdatePassword(string oldpassword, string newpassword, int? accountid)
        {
            channel.Open();

            que.CommandText = "SP_UpdatePassword";// proc Name
            que.CommandType = CommandType.StoredProcedure;
            que.Connection = channel;
            que.Parameters.AddWithValue("@oldpassword", oldpassword);
            que.Parameters.AddWithValue("@newpassword", newpassword);
            que.Parameters.AddWithValue("@accountid", accountid);
            que.Parameters.Add("@returned", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            int returned = (int)que.Parameters["@returned"].Value;
            return returned;

            channel.Close();

        }
    }
}
