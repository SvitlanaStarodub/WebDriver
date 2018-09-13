using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace HomeWorkPart2.Pages
{
    class HomePage
    {
        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement NavigationBar => _driver.FindElement(By.XPath(".//span[text()='DEMO SITES']"));
    }
}
