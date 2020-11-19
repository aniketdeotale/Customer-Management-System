using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }


        public Customer Retrive(int customerID)
        {
            Customer customer = new Customer(customerID);
            
            if (customerID ==1)
            {
                customer.EmailAddress = "aniket.deotale@gmail.com";
                customer.FirstName = "Aniket";
                customer.LastName = "Deotale";
                customer.AddressList = addressRepository.RetrieveCustomerId(customerID).ToList();
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
