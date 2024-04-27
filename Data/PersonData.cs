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
    public class PersonData
    {
        public List<Person> GetPeople()
        {
            string server = "LAB1504-13\\SQLEXPRESS";
            string database = "FacturaDB";
            string user = "brayandelgadillo";
            string password = "123456";
            string connectionString = $"Data Source={server};Initial Catalog={database};User ID={user};Password={password};";

            List<Person> people = new List<Person>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("USP_GetPeople", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int PersonID = reader.GetInt32("PersonID");
                            string FirstName = reader.GetString("FirstName");
                            string LastName = reader.GetString("LastName");
                            int Age = reader.GetInt32("Age");

                            people.Add(new Person(PersonID, FirstName, LastName, Age));
                        }
                    }
                }
            }

            return people;

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
