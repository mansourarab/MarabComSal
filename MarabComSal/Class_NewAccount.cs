﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MarabComSal
{
    class Class_NewAccount
    {
        SqlConnection channel;
        SqlCommand que;

        public Class_NewAccount()
        {
            channel = new SqlConnection(@"data source=COMMANDERMN9\SQLEXPRESS;initial catalog=Marab Company;integrated security=true;");
            que = new SqlCommand();
        }



        public int CustomerNewAccount(string customername, bool gender, string phone, string address, string username, string password, string email)
        {
            channel.Open();

            que.CommandText = "SP_CustomerNewAccount";
            que.CommandType = CommandType.StoredProcedure;
            que.Connection = channel;
            que.Parameters.Clear();
            que.Parameters.AddWithValue("@customername", customername);
            que.Parameters.AddWithValue("@address", address);
            que.Parameters.AddWithValue("@gender_bool", gender);
            que.Parameters.AddWithValue("@username", username);
            que.Parameters.AddWithValue("@password", password);
            que.Parameters.AddWithValue("@phone", phone);
            que.Parameters.AddWithValue("@usertype", "Customer");
            que.Parameters.AddWithValue("@email", email);

            int returned = que.ExecuteNonQuery();


            channel.Close();
            return returned;

        }

        public int EmployeeNewAccount(string employeename, bool gender, string phone, string address, string username, string password, string email, string department)
        {
            channel.Open();

            que.CommandText = "SP_EmployeeNewAccount";
            que.CommandType = CommandType.StoredProcedure;
            que.Connection = channel;
            que.Parameters.Clear();
            que.Parameters.AddWithValue("@empname", employeename);
            que.Parameters.AddWithValue("@addr", address);
            que.Parameters.AddWithValue("@gender_bool", gender);
            que.Parameters.AddWithValue("@username", username);
            que.Parameters.AddWithValue("@password", password);
            que.Parameters.AddWithValue("@phone", phone);
            que.Parameters.AddWithValue("@usertype", "Employee");
            que.Parameters.AddWithValue("@email", email);
            que.Parameters.AddWithValue("@dep", department);

            int returned = que.ExecuteNonQuery();


            channel.Close();
            return returned;
        }
    }
}