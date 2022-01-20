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
        public void ExecuteCommend(string querycommend)
        {
           using SqlConnection connection = new SqlConnection(_connectionString);
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = querycommend;
            if(connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            command.ExecuteNonQuery();
                
        }
    }
}
