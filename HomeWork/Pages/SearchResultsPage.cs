using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace HomeWork.Pages
{
    class SearchResultsPage
    {
        private readonly IWebDriver _driver;

        public SearchResultsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IReadOnlyCollection<IWebElement> SearchResults => _driver.FindElements(By.CssSelector("div.catalog-card-container h5"));
    }
}
