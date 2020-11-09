using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
{
    class DatabaseOperations : DbContext
    {
        public DatabaseOperations() : base("DBConnection")
        {

        }

        //public DbSet<ProfileDb> Profiles { get; set; }
        //static protected string ConnectionOptions { get; private set; } = "Data Source=localhost; database=Barcodes; Integrated Security=true";
        //static private SqlConnection sqlConnection;

        /*
        static public List<object> PushQuery(SqlConnection connection, string query)
        {
            connection.Open();
            var command = new SqlCommand(query, connection);
            var reader = command.ExecuteReader();
            List<object> data = null;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        data.Add(new
                        {
                            Value = reader.GetValue(i)
                        }); 
                    }
                }
            }
            reader.Close();
            connection.Close();
            return data;
        }

        static public SqlConnection SingleConnection()
        {
            if (sqlConnection == null) sqlConnection = new SqlConnection(ConnectionOptions);
            return sqlConnection;
        }
        */
    }
}
