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
    }
}
