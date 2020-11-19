using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId==1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "New Yeshwant Nagar";
                address.StreetLine2 = "Gomaji";
                address.City = "Hinganghat";
                address.State = "Maharashtra";
                address.Country = "India";
                address.PostalCode = "144";

            }
            return address;
        }

        public IEnumerable<Address> RetrieveCustomerId(int c)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "New Yeshwant Nagar",
                StreetLine2 = "Gomaji",
                City = "Hinganghat",
                State = "Maharashtra",
                Country = "India",
                PostalCode = "442301"

            };
            addressList.Add(address);

           address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Chubhas chowk",
                StreetLine2 = "Vivekanand garden",
                City = "Hinganghat",
                State = "Maharashtra",
                Country = "India",
                PostalCode = "442301"

            };
            addressList.Add(address);

            return addressList;
        }
        public bool Save(Address address)
        {
            return true;
        }
    }
}
