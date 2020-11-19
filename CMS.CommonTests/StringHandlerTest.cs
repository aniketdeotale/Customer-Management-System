using CMS.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CMS.CommonTests
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
          


            var actual = StringHandler.InsertSpaces(source);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
           


            var actual =source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }
    }
}
