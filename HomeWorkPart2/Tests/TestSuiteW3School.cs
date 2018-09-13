using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkPart2.Core;
using HomeWorkPart2.Helpers;
using HomeWorkPart2.Pages;
using HomeWorkPart2.Steps;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;

namespace HomeWorkPart2.Tests
{
    [TestFixture]
    class TestSuiteW3School
    {
        private IWebDriver _driver;

        public const string Url = "https://www.w3schools.com/hTml/html_iframe.asp";

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = SeleniumDriver.Driver;
            _driver.Manage().Window.Maximize();

           
        }

        [Test]

        public void NavigationToW3School()
        {
            //arrange
            _driver.Url = Url;
            var homePageW3SchoolSteps = new HomePageW3SchoolSteps(_driver);
            var expectedFrameTitle = "HTML Introduction";
            var expectedWebTabTitle = "HTML Iframes";

            //act
            var iFrame = _driver.FindElement(By.CssSelector("iframe[src='default.asp']"));
            _driver.SwitchTo().Frame(iFrame);
            homePageW3SchoolSteps.NavigarionW3School();
           var actualResult = homePageW3SchoolSteps.GetIFrameTitle();

            //assert
            Assert.AreEqual(expectedFrameTitle, actualResult, $"{expectedFrameTitle} should be as frame title");
            Assert.AreEqual(expectedWebTabTitle, _driver.Title, $"{expectedWebTabTitle} should be web title");
        }

        
        [OneTimeTearDown]

        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
