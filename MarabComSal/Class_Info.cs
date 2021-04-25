using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MarabComSal
{
    class Class_Info
    {
        SqlConnection channel;
        SqlCommand que;


        public Class_Info()
        {
            channel = new SqlConnection(@"data source=COMMANDERMN9\SQLEXPRESS;initial catalog=Marab Company;integrated security=true;");
            que = new SqlCommand();
        }



        public DataTable ViewInfo(int? AccountId)
        {
            channel.Open();

            que.CommandText = "SP_ViewInfo";// proc Name
            que.CommandType = CommandType.StoredProcedure;
            que.Connection = channel;
            que.Parameters.AddWithValue("@accountid", AccountId);
            DataTable dt = new DataTable();
            SqlDataReader dr = que.ExecuteReader();
            dt.Load(dr);
            


            channel.Close();
            return dt;
        }


        public int UpdateContactinfo(string phone, string address, int? accountid)
        {
            channel.Open();

            que.CommandText = "SP_UpdateContactInfo";// proc Name
            que.CommandType = CommandType.StoredProcedure;
            que.Connection = channel;
            que.Parameters.AddWithValue("@phone", phone);
            que.Parameters.AddWithValue("@address", address);
            que.Parameters.AddWithValue("@accountid", accountid);
            que.Parameters.Add("@returned", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            que.ExecuteNonQuery();
            int returned = (int)que.Parameters["@returned"].Value;

            channel.Close();
            return returned;

        }

    }
}
