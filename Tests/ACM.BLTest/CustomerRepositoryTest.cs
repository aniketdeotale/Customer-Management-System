using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetriveValid()
        {
            //--- Arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                
                EmailAddress = "aniket.deotale@gmail.com",
                FirstName = "Aniket",
                LastName = "Deotale"
            };
            // -- Act
            var actual = customerRepository.Retrive(1);

            // --- Assert
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

        }


        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //--- Arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {

                EmailAddress = "aniket.deotale@gmail.com",
                FirstName = "Aniket",
                LastName = "Deotale",
                AddressList = new List<Address>()
                {
                    new Address()
                    {

                              AddressType = 1,
                              StreetLine1 = "New Yeshwant Nagar",
                              StreetLine2 = "Gomaji",
                              City = "Hinganghat",
                              State = "Maharashtra",
                              Country = "India",
                              PostalCode = "144"
                    },
                    new Address()
                     {
                              AddressType = 2,
                              StreetLine1 = "Chubhas chowk",
                              StreetLine2 = "Vivekanand garden",
                              City = "Hinganghat",
                              State = "Maharashtra",
                              Country = "India",
                              PostalCode = "442301"

                    }

                }
            };


            // -- Act
            var actual = customerRepository.Retrive(1);

            // --- Assert
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for(int i = 0; i <1; i ++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
            }
        }



    }
}
