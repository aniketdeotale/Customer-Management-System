using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrive(int customerID)
        {
            Customer customer = new Customer(customerID);
            
            if (customerID ==1)
            {
                customer.EmailAddress = "Aniket.deoatle@gmail.com";
                customer.FirstName = " Aniket";
                customer.LastName = "Deotale";
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
