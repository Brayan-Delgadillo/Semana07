using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CustomerData
    {
        public List<Customer> GetCustomers()
        {
            string server = "LAB1504-13\\SQLEXPRESS";
            string database = "FacturaDB";
            string user = "brayandelgadillo";
            string password = "123456";
            string connectionString = $"Data Source={server};Initial Catalog={database};User ID={user};Password={password};";

            List<Customer> customers = new List<Customer>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("USP_GetCustomers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int CustomerID = reader.GetInt32("customer_id");
                            string Name = reader.GetString("name");
                            string Address = reader.GetString("address");
                            string Phone = reader.GetString("phone");
                            bool Active = reader.GetBoolean("active");

                            customers.Add(new Customer(CustomerID, Name, Address, Phone, Active));
                        }
                    }
                }
            }

            return customers;

        }
        public void Insert()
        {

        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
    }
}
