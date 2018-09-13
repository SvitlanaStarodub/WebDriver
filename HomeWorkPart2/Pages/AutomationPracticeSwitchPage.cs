using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HomeWorkPart2.Pages
{
    class AutomationPracticeSwitchPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        public AutomationPracticeSwitchPage(IWebDriver driver)
        {
            _driver = driver;
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
        }

        public void WaitUntilElementDisplayed(IWebElement element)
        {
            _wait.Until(_driver => element.Displayed);
        }

        public IWebElement ItemDropDown => _driver.FindElement(By.XPath(".//span[text()='Automation Practice Switch Windows']"));

        public IWebElement BrowserWindowButton => _driver.FindElement(By.CssSelector("#button1"));

        public IWebElement TimingAlertButton => _driver.FindElement(By.CssSelector("#timingAlert"));

    }
}
