using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace HomeWorkPart2.Pages
{
    class HomePageW3SchoolPage
    {
        private readonly IWebDriver _driver;
        public HomePageW3SchoolPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement NextButton => _driver.FindElement(By.XPath("(.//h1[span[contains(text(), 'Tutorial')]]/following-sibling::div//a[contains(text(), 'Next')])[1]"));

        public IWebElement iFrameTitle => _driver.FindElement(By.TagName("h1"));
    }
}
