using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HotelApp
{
    class dbclient
    {
        public string querystring = "SELECT * FROM DemoHotel";
        public string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void Read()
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(querystring, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount-2; i++)
                    {
                        Console.Write(reader.GetValue(i) + " \t");
                        Console.Write(reader.GetValue(i+1) + " \t");
                        Console.WriteLine(reader.GetValue(i+2));

                    }
                }
            }
        }

        public void Create()
        {
            //TODO: Implement the above
        }
        public void Update()
        {
            //TODO: Implement the above
        }
        public void Delete()
        {
            //TODO: Implement the above
        }
    }
}
