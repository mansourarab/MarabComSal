using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MarabComSal
{
    class Class_CustomerCheckAvailability
    {
        SqlConnection channel;
        SqlCommand que;


        public Class_CustomerCheckAvailability()
        {
            channel = new SqlConnection(@"data source=COMMANDERMN9\SQLEXPRESS;initial catalog=Marab Company;integrated security=true;");
            que = new SqlCommand();
        }


        public int? CheckUsernameandEmailAvalability(string username, string email, out int? status)
        {
            
            channel.Open();

            que.CommandText = "SP_CheckUsernameandEmailAvalability";
            que.CommandType = CommandType.StoredProcedure;
            que.Connection = channel;
            que.Parameters.Clear();
            que.Parameters.AddWithValue("@username", username);
            que.Parameters.AddWithValue("@email", username);
            que.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;
            status = Convert.ToInt32(que.Parameters["@result"].Value);


            channel.Close();
            return status;
        }
    }
}
