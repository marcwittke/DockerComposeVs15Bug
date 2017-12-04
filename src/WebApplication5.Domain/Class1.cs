using System;
using System.Data.SqlClient;

namespace WebApplication5.Domain
{
    using System.Collections.Generic;
    using System.Data;

    public class Class1
    {
        public string[] GetDatabases(string masterConnectionString)
        {
            List<string> databases = new List<string>();
            
            using (SqlConnection connection = new SqlConnection(masterConnectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT Name FROM sys.Databases";
                    var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                    while (reader.Read())
                    {
                        databases.Add(reader.GetString(0));
                    }
                }
            }
            return databases.ToArray();
        } 
    }
}
