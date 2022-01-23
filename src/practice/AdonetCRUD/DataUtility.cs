using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdonetCRUD
{
    internal class DataUtility
    {
        private readonly string _connectionString;
        public DataUtility(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void ExecuteCommend(string crudQuery, IList<(string key, object value)> parameters)
        {
            //"using" used for idisposal code would destroy after out of function
           using SqlConnection connection = new SqlConnection(_connectionString);
           using SqlCommand commend = connection.CreateCommand();
            commend.CommandText = crudQuery;
            if(parameters != null && parameters.Count > 0)
            {
                foreach (var item in parameters)
                {
                    commend.Parameters.Add(new SqlParameter (item.key, item.value));
                }
            }
            //check connection open or not
            if(connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            commend.ExecuteNonQuery();
        }
<<<<<<< HEAD
        //Read data
        public IList<Dictionary<string, object>> DataReader(string query, IList<(string key, object value)> parameters)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand commend = connection.CreateCommand();
            commend.CommandText = query;
            if(connection.State != System.Data.ConnectionState.Open)
            connection.Open();
            SqlDataReader reader = commend.ExecuteReader();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            while (reader.Read())
            {
                Dictionary<string , object> columns = new Dictionary<string, object>();
                foreach(var column in reader.GetColumnSchema()) 
                {
                    columns.Add(column.ColumnName, reader[column.ColumnName]);
                }
                rows.Add(columns);
            }
=======

        //data read
        public IList<Dictionary<string, object>> ReadData(string query,
            IList<(string key, object value)> parameters)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            using SqlCommand commend = connection.CreateCommand();
            commend.CommandText = query;
            if (parameters != null && parameters.Count > 0)
            {
                foreach (var item in parameters)
                {
                    commend.Parameters.Add(new SqlParameter(item.key, item.value));
                }
            }
            //check connection open or not
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            SqlDataReader reader = commend.ExecuteReader();

            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();

            while (reader.Read())
            {
                Dictionary<string, object> columns = new Dictionary<string, object>();

                foreach (var column in reader.GetColumnSchema())
                {
                    columns.Add(column.ColumnName, reader[column.ColumnName]);
                }

                rows.Add(columns);
            }

>>>>>>> 0a3f69dcc28d1db54f9f29e0cbbc859f50868da8
            return rows;
        }
    }
}
