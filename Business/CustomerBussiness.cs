using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CustomerBussiness
    {
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            CustomerData customerData = new CustomerData();
            customers = customerData.GetCustomers();
            return customers;
        }
    }
}
