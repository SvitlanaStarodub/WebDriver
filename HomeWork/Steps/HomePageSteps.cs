using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HomeWork.Pages;
using OpenQA.Selenium;

namespace HomeWork.Steps
{
    class HomePageSteps
    {
        private readonly HomePage _homePage;

        public HomePageSteps(IWebDriver driver)
        {
            _homePage =new HomePage(driver);
        }

        public void Search(string searchText)
        {
            _homePage.SearchField.SendKeys(searchText);
            _homePage.SearchField.Submit();
        }

        public void SelectTelevisionSection()
        {
            _homePage.TVSection.Click();
        }

        public void SelectLGProducts()
        {
            _homePage.LGTV.Click();
        }
    }
}
