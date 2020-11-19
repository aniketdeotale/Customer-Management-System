using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Common;

namespace ACM.BL
{

    
    public class Customer :EntityBase, iLoggable
    {

        public Customer(): this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerID = customerId;
            AddressList = new List<Address>();
        }
        public int CustomerType { get; set; }
        public List<Address> AddressList { get; set; }
        public int CustomerID { get; private set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public override string ToString()
        {
            return FullName;
        }
        public static int InstanceCount{ get; set; }
        public string FirstName { get; set; }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

      

        public string Log()
        {
            var logString = CustomerID + ": " + FullName + " " +
                "Email: " + EmailAddress + " " +
                "Status: " + EntityState.ToString();
            return logString;

        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        
        }
    }
}
