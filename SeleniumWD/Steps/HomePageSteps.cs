using OpenQA.Selenium;
using SeleniumWD.Pages;

namespace SeleniumWD.Steps
{
    public class HomePageSteps
    {
        private readonly IWebDriver _driver;
        private readonly HomePage _homePage;

        public HomePageSteps(IWebDriver driver)
        {
            _driver = driver;
            _homePage = new HomePage(_driver);
        }

        public void Search(string searchText)
        {
            _homePage.SearchField.SendKeys(searchText);
            _homePage.SearchField.Submit();
        }

    }
}
