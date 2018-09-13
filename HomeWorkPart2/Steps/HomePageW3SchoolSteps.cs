using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkPart2.Pages;
using OpenQA.Selenium;

namespace HomeWorkPart2.Steps
{
    class HomePageW3SchoolSteps
    {
        private readonly HomePageW3SchoolPage _homePageW3SchoolPage;

        public HomePageW3SchoolSteps(IWebDriver driver)
        {
            _homePageW3SchoolPage = new HomePageW3SchoolPage(driver);

        }

        public void NavigarionW3School()
        {
          _homePageW3SchoolPage.NextButton.Click();
        }

        public string GetIFrameTitle()
        {
            return _homePageW3SchoolPage.iFrameTitle.Text;
        }
    }
}
