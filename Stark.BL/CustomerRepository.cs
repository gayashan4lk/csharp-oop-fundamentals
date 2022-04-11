using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stark.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(1);

            if(customerId == 1)
            {
                customer.Email = "pepperpotts@stark.com";
                customer.FirstName = "Pepper";
                customer.LastName = "Potts";
            }
            return customer;
        }

        public bool Save()
        {
            return true;
        }
    }
}
