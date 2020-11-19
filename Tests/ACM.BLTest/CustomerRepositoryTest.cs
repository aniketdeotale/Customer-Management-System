using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
    }
}
