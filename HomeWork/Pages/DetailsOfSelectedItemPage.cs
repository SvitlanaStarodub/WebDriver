using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace HomeWork.Pages
{
    class DetailsOfSelectedItemPage
    {
        private readonly IWebDriver _driver;

        public DetailsOfSelectedItemPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement ItemName => _driver.FindElement(By.CssSelector("h1.cart-main-title"));

        public IWebElement ItemPrice => _driver.FindElement(By.CssSelector("a.buy-general span.price-number"));

    }
}
