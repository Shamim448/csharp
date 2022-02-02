﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdonetPractice
{
    public class DataUtility
    {
        private readonly string _connectionString;

        public DataUtility(string connectionstring)
        {
            _connectionString = connectionstring;
        }

       public void ExecuteQuery(string query, IList<(string key, object value)> paramiter)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            if(paramiter != null && paramiter.Count > 0)
            {
                foreach(var item in paramiter)
                {
                    command.Parameters.Add(new SqlParameter(item.key, item.value));
                }
                
            }
            if(connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            command.ExecuteNonQuery();
        }

        public IList<Dictionary<string, object>> 
            ReadData(string query, IList<(string key, object value)> paramiter)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            if (paramiter != null && paramiter.Count > 0)
            {
                foreach (var item in paramiter)
                {
                    command.Parameters.Add(new SqlParameter(item.key, item.value));
                }

            }
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            while (reader.Read())
            {
                Dictionary<string, object> columns = new Dictionary<string, object>();
                foreach(var item in reader.GetColumnSchema())
                {
                    columns.Add(item.ColumnName, reader[item.ColumnName]);
                }
                rows.Add(columns);
            }
            return rows;
        }
    }
}
