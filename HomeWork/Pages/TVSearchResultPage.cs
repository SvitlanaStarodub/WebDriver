using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace HomeWork.Pages
{
    class TvSearchResultPage
    {
        private readonly IWebDriver _driver;

        public TvSearchResultPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public List<IWebElement> ItemNameList => _driver.FindElements(By.CssSelector(".title-itm h5")).ToList();

        public List<IWebElement> ItemPriceList => _driver.FindElements(By.CssSelector(".base-price .price-number")).ToList();

        public List<IWebElement> FilterItems => _driver.FindElements(By.CssSelector(".filter-itm h3")).ToList();


    }
}
