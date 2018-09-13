using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkPart2.Pages;
using OpenQA.Selenium;

namespace HomeWorkPart2.Steps
{
    class HomePageSteps
    {
        private readonly HomePage _homePage;

        public HomePageSteps (IWebDriver driver)
        {
            _homePage = new HomePage(driver);
        }

        public void SelectSubMenu()
        {
            _homePage.NavigationBar.Click();
        }
    }
}
