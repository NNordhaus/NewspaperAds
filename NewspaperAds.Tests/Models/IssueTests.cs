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
    public class IssueTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Deadline_Should_Not_Be_In_The_Past()
        {
            var sut = new Issue(DateTime.Now.AddDays(-1));
        }

        [TestMethod]
        public void Deadline_Should_Be_In_The_Future()
        {
            var sut = new Issue(DateTime.Now.AddDays(1));

            Assert.IsNotNull(sut);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AdPages_Should_Be_Positive()
        {
            var sut = new Issue() { AdPages = -1 };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Ads_Should_Not_Allow_More_Than_Will_Fit_Available_Pages()
        {
            var sut = new Issue() { AdPages = 2 };

            var Ad1 = new Ad() { Size = 12 };
            var Ad2 = new Ad() { Size = 8 };
            var Ad3 = new Ad() { Size = 6 };
            
            sut.AddAd(Ad1);
            sut.AddAd(Ad2);
            sut.AddAd(Ad3);

        }
    }
}
