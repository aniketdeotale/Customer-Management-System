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

            string expected = "Deotale , Aniket";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }
    }
}
