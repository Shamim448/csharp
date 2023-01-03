using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
    internal class DataUtility
    {
        private readonly string _connectionString;
        public DataUtility(string connectionString) 
            { 
                _connectionString = connectionString; 
            }
        public void ExecuteQuery(string querys, IList<(string key, object value)> parameters)
        {
            using SqlConnection connection = new(_connectionString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = querys; //Write query here
            if(parameters != null && parameters.Count > 0)
            {
                foreach(var item in parameters)
                {
                    command.Parameters.Add(new SqlParameter(item.key, item.value));
                }
            }
            if(connection.State!= System.Data.ConnectionState.Open)
            {
                connection.Open();
                command.ExecuteNonQuery();
            }

        }
        // Read Data From database
        public List<Dictionary<string, Object>> ReadData(string query)
        {
            using SqlConnection connection = new(_connectionString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            if(connection.State != System.Data.ConnectionState.Open)
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Dictionary<string, Object>> rows = new List<Dictionary<string, Object>>();
                while(reader.Read())
                {
                    Dictionary<string, Object> columns = new Dictionary<string, Object>();
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
