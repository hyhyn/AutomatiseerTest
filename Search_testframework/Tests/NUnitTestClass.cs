using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Search_testframework.Framework;
using System;
namespace Search_testframework.Tests
{
    [TestFixture()]
    public class NUnitTestClass
    {
        private TopNavigation nav;

        [SetUp]
        public void Init()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.kodision.nl";
            nav = new TopNavigation(driver);
        }

        [Test()]
        public void TestCaseSearchEmptyInput()
        {
            nav.Search("");
            Assert.IsTrue(nav.IsEmpty(), "Results found");
        }

        [Test()]
        public void TestCaseSearchIsNotEmpty()
        {
            nav.Search("kodision");
            Assert.IsFalse(nav.IsEmpty(), "No results found");
        }

        [Test()]
        public void TestCaseSearchIsEmpty()
        {
            nav.Search("afnjsidsanfadksn");
            Assert.IsTrue(nav.IsEmpty(), "Results found");
        }
    }
}
