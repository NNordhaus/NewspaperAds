using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewspaperAds;
using NewspaperAds.Models;
namespace NewspaperAds.Tests.Models
{
    [TestClass]
    public class AdTests
    {
        [TestMethod]
        public void Size_Should_Accept_Valid_Sizes()
        {
            var sut = new Ad() { Size = 12 };
            sut = new Ad() { Size = 8 };
            sut = new Ad() { Size = 6 };
            sut = new Ad() { Size = 4 };
            sut = new Ad() { Size = 3 };

            Assert.IsNotNull(sut);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Size_Should_Not_Accept_Invalid_Sizes()
        {
            var sut = new Ad() { Size = 7 };
        }
    }
}
