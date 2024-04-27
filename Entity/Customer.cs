using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string  Address{ get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }

        public Customer(int CustomerID, string Name, string Address, string Phone, bool Active)
        {
            this.CustomerID = CustomerID;
            this.Name = Name;
            this.Address = Address;
            this.Phone = Phone;
            this.Active = Active;
        }
    }
}
