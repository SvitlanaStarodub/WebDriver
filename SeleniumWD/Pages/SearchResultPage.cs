using System.Linq;
using OpenQA.Selenium;

namespace SeleniumWD.Pages
{
    public class SearchResultPage
    {
        private readonly IWebDriver _driver;

        public SearchResultPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement[] ItemTitles => _driver.FindElements(By.CssSelector(".catalog_item .title a")).ToArray();

        public IWebElement[] Properties => _driver.FindElements(By.ClassName("properties_block")).ToArray();
    }
}
