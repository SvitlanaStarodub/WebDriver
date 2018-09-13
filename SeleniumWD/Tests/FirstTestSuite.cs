using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumWD.Core;
using SeleniumWD.Steps;

namespace SeleniumWD.Tests
{ 
    [TestFixture]
    public class FirstTestSuite
    {
        private IWebDriver _driver;
        private const string Url = "https://f.ua/";

        [OneTimeSetUp]
        public void Setup()
        {
            _driver = SeleniumDriver.Driver;
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test()
        {
            _driver.Url = Url;

            var homePage = new HomePageSteps(_driver);
            var resultPage = new SearchResultPageSteps(_driver);

            homePage.Search("Ноутбук");

            resultPage.SelectFilterItem("Класс", "игровой");

            //need to add verification
        }

        [Test]
        public void VerifyItemsInResultTest()
        {
            _driver.Url = Url;

            var homePage = new HomePageSteps(_driver);
            var resultPage = new SearchResultPageSteps(_driver);

            homePage.Search("Ноутбук");

            var resultList = resultPage.GetResultItemTitle();
            Assert.IsTrue(resultList.All(i => i.Contains("Ноутбук") || i.Equals(string.Empty)));
        }

        [Test]
        public void OpenItemTest()
        {
            _driver.Url = Url;

            var homePage = new HomePageSteps(_driver);
            var resultPage = new SearchResultPageSteps(_driver);
            var productPage = new ProductPageSteps(_driver);

            homePage.Search("Ноутбук");

            resultPage.OpenItem("Ноутбук LENOVO ThinkPad T470p");

            var productTitle = productPage.GetTitle();
            Assert.IsTrue(productTitle.Contains("Ноутбук Lenovo ThinkPad T470p"));
            Assert.IsTrue(resultPage.GetTitle().Contains("Lenovo ThinkPad T470p"));
        }

        [Test]
        public void PageTitleTest()
        {
            _driver.Url = Url;

            var homePage = new HomePageSteps(_driver);

            homePage.Search("Телефоны");

            Assert.IsTrue(_driver.Title.Contains("Телефоны".ToUpper()));
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
