using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer
            {
                FirstName = "Aniket",
                LastName = "Deotale"
            };

            string expected = "Deotale, Aniket";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            Customer customer = new Customer
            {
               
                LastName = "Deotale"
            };

            string expected = "Deotale";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer
            {

                FirstName = "Aniket"
            };

            string expected = "Aniket";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Aniket";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c1.FirstName = "Anuj";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c1.FirstName = "Ashwin";
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
           var customer = new Customer
            {
                LastName = "Aniket",
                EmailAddress = "Aniket.deotale@gmail.com"

            };
            var expected = true;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            var customer = new Customer
            {
                
                EmailAddress = "Aniket.deotale@gmail.com"

            };
            var expected = false;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
