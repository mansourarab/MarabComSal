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

        
        public static string Fullname { get; set; }
        public static string Email { get; set; }
        public static string Gender { get; set; }
        public static string Phone { get; set; }
        public static string Usertype { get; set; }
        public static string Address { get; set; }
        public static string Department { get; set; }
        public static string Comemail { get; set; }

        public void RequestInfo(int? AccountId, out string Fullname, out string Email, out string Gender, out string Phone, out string Usertype, out string Address, out string Department, out string Comemail)
        {
            channel.Open();

            que.CommandText = "SP_ViewInfo";// proc Name
            que.CommandType = CommandType.StoredProcedure;
            que.Connection = channel;
            que.Parameters.AddWithValue("@accountid", AccountId);
            que.Parameters.Add("@fullname", SqlDbType.VarChar).Direction = ParameterDirection.Output;
            que.Parameters.Add("@email", SqlDbType.VarChar).Direction = ParameterDirection.Output;
            que.Parameters.Add("@gender", SqlDbType.VarChar).Direction = ParameterDirection.Output;
            que.Parameters.Add("@phone", SqlDbType.VarChar).Direction = ParameterDirection.Output;
            que.Parameters.Add("@usertype", SqlDbType.VarChar).Direction = ParameterDirection.Output;
            que.Parameters.Add("@address", SqlDbType.VarChar).Direction = ParameterDirection.Output;
            que.Parameters.Add("@department", SqlDbType.VarChar).Direction = ParameterDirection.Output;
            que.Parameters.Add("@comemail", SqlDbType.VarChar).Direction = ParameterDirection.Output;
            que.ExecuteNonQuery();
            Fullname = Convert.ToString(que.Parameters["@fullname"].Value);
            Email = Convert.ToString(que.Parameters["@email"].Value);
            Gender = Convert.ToString(que.Parameters["@gender"].Value);
            Phone = Convert.ToString(que.Parameters["@phone"].Value);
            Usertype = Convert.ToString(que.Parameters["@usertype"].Value);
            Address = Convert.ToString(que.Parameters["@address"].Value);
            Department = Convert.ToString(que.Parameters["@department"].Value);
            Comemail = Convert.ToString(que.Parameters["@comemail"].Value);

            channel.Close();

        }
    }
}
