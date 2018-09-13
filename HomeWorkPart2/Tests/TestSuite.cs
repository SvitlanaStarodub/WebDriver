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
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace HomeWorkPart2.Tests
{
    [TestFixture]
    public class TestSuite
    {
        private IWebDriver _driver;

        public const string Url = "http://toolsqa.com/";


        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = SeleniumDriver.Driver;
            _driver.Manage().Window.Maximize();

            Wait.InitializeWaiter(_driver, TimeSpan.FromSeconds(5));

        }

        [Test]

        public void OpenPageInNewTab()
        {
            //arrange
            _driver.Url = Url;
            var homePageSteps = new HomePageSteps(_driver);
            var automationPracticeSwitchSteps = new AutomationPracticeSwitchSteps(_driver);
            var expectedResult = "QA Automation Tools Tutorial";
            var currentWindow = _driver.CurrentWindowHandle;
            

            //act
            homePageSteps.SelectSubMenu();
            automationPracticeSwitchSteps.NavigationToAutoPracticeSwitch();
            automationPracticeSwitchSteps.NavigateToBrowserWindow();
            var switchWindow = _driver.WindowHandles.First(h => h != currentWindow);
            _driver.SwitchTo().Window(switchWindow);
            var actualResult = _driver.Title;

            //assert
            Assert.AreEqual(expectedResult, actualResult, "Page Title is not matched");

        }

        [Test]

        public void GenerateTimingAlert()
        {

            //arrange
            _driver.Url = Url;
            var homePageSteps = new HomePageSteps(_driver);
            var automationPracticeSwitchSteps = new AutomationPracticeSwitchSteps(_driver);
            var alertExpected =
                "Knowledge increases by sharing but not by saving. Please share this website with your friends and in your organization.";

            //act
            homePageSteps.SelectSubMenu();
            automationPracticeSwitchSteps.NavigationToAutoPracticeSwitch();
            automationPracticeSwitchSteps.GenerateTimingAlert();

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.AlertIsPresent());
            var alertText = _driver.SwitchTo().Alert().Text;
            
            //assert
            Assert.AreEqual(alertExpected, alertText, $"'{alertExpected}' alert should be displayed");
        }

     


        [OneTimeTearDown]

        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
