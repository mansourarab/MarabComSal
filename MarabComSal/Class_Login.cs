using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MarabComSal
{
    class Class_Login
    {
        SqlConnection channel;
        SqlCommand que;

        public Class_Login()
        {
            channel = new SqlConnection(@"data source=COMMANDERMN9\SQLEXPRESS;initial catalog=Marab Company;integrated security=true;");
            que = new SqlCommand();
        }

        public static int? AccountId { get; set; }

        public int CheckUser(string username, string password, out int? AccountId)
        {
            channel.Open();

            que.CommandText = "SP_CheckUser";
            que.CommandType = CommandType.StoredProcedure;
            que.Connection = channel;
            que.Parameters.AddWithValue("@userName", username);
            que.Parameters.AddWithValue("@password", password);
            que.Parameters.Add("@returned", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            que.Parameters.Add("@accountid", SqlDbType.Int).Direction = ParameterDirection.Output;
            que.ExecuteNonQuery();//
            int returned = (int)que.Parameters["@returned"].Value;
            if (que.Parameters["@accountid"].Value is DBNull)
            {
                AccountId = null;
            }
            else
            {
                AccountId = (int)que.Parameters["@accountid"].Value;
            }

            channel.Close();
            return returned;
        }
    }
}
