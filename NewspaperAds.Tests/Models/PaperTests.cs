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
    public class PaperTests
    {
        [TestMethod]
        public void Paper_Should_Reflect_Name()
        {
            var sut = new Paper("Free Press");

            Assert.AreEqual(sut.Name, "Free Press");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Newspaper_Should_Not_Allow_Empty_Name()
        {
            var sut = new Paper("");
        }
    }
}