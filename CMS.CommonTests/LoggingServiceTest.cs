using CMS.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ACM.BL;

namespace CMS.CommonTests
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTEst()
        {
            var changedItems = new List<iLoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "aniket.deotale@gmail.com",
                FirstName = "Aniket",
                LastName = "Deotale",
                AddressList= null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Sunflower",
                ProductDescription = "Assorted Size set of 4 Bright Sunflowers",
                CurrentPrice = 40
            };
            changedItems.Add(product);

            LoggingService.WriteToFile(changedItems);
        }
    }
}
