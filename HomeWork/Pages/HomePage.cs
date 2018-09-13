using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HomeWork.Pages
{
    class HomePage
    {
        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }
        public IWebElement SearchField => _driver.FindElement(By.Id("multisearch"));

        public IWebElement TVSection => _driver.FindElement(By.CssSelector(".bottom-nav a[title='TV']"));

        public IWebElement LGTV => _driver.FindElement(By.CssSelector("a[title='LG']"));




    }
}
