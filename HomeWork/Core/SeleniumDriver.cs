using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomeWork.Core
{
    public static class SeleniumDriver
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    _driver = new ChromeDriver();
                }
                return _driver;
            }

            set { _driver = value; }
        }
    }
}
