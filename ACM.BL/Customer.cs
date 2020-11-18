using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{

    
    public class Customer
    {

        public int CustomerID { get; private set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                return LastName + " , " + FirstName;
            }
        }

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
    }
}
