using System;
using System.Collections.Generic;
using System.Text;

namespace OopConptsDemo
{
    class Romance
    {
        //Create
        public string ConnectionString { get; private set; }

        public EmployeeRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        // Create
        public void Insert(employee Employee)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);

            using (conn)
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "INSERT INTO products (Name, Price) " +
                                  "VALUES (@name, @price);";
                cmd.Parameters.AddWithValue("name", product.Name);
                cmd.Parameters.AddWithValue("price", product.Price);

                cmd.ExecuteNonQuery();

            }
}
